﻿using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Bot
{
    public class TwitchEventHandlers
    {
        private TwitchBot bot;

        public TwitchEventHandlers(TwitchBot bot)
        {
            this.bot = bot;
        }

        public void OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Bits > 0)
            {
                var bitsEvent = MainClass.Instance.Config.Events.OnReceiveBits.FirstOrDefault(p => e.ChatMessage.Bits >= p.MinBits && e.ChatMessage.Bits <= p.MaxBits) ?? MainClass.Instance.Config.Events.OnReceiveBits.OrderByDescending(p => p.MaxBits).FirstOrDefault();
                if (bitsEvent != null)
                {
                    bitsEvent.TryExecuteCommand(e.ChatMessage);
                }
            }

            if (!e.ChatMessage.Message.StartsWith(MainClass.Instance.Config.Events.CommandPrefix))
                return;

            string cmdName = e.ChatMessage.Message.Remove(0, 1);

            if (MainClass.Instance.Config.Events.OnCommand.TryGetValue(cmdName.ToLower(), out TwitchCommand cmd))
            {
                if (!cmd.TryExecuteCommand(e.ChatMessage))
                    Logger.Info("TwitchCommand", $"User {e.ChatMessage.Username} failed to execute command {cmdName}", Color.Magenta, Color.White);
            }
        }

        public void OnRewardRedeem(object sender, TwitchLib.PubSub.Events.OnChannelPointsRewardRedeemedArgs e)
        {
            if (!MainClass.Instance.Config.Events.OnReward.TryGetValue(e.RewardRedeemed.Redemption.Reward.Id, out TwitchReward rew))
            {
                Logger.Info("TwitchReward", $"User {e.RewardRedeemed.Redemption.User.DisplayName} used reward {e.RewardRedeemed.Redemption.Reward.Id} but that reward id is not added in config!", Color.Magenta, Color.White);
                return;
            }

            if (rew.TryExecuteCommand(e.RewardRedeemed.Redemption))
                Logger.Info("TwitchReward", $"User {e.RewardRedeemed.Redemption.User.DisplayName} executed reward {e.RewardRedeemed.Redemption.Reward.Id}", Color.Magenta, Color.White);
            else
                Logger.Info("TwitchReward", $"User {e.RewardRedeemed.Redemption.User.DisplayName} failed to execute redeem {e.RewardRedeemed.Redemption.Reward.Id}", Color.Magenta, Color.White);
        }

        public void OnListenResponse(object sender, TwitchLib.PubSub.Events.OnListenResponseArgs e)
        {
            Logger.Debug("TwitchPubSub", $"Response from channel {e.ChannelId}, topic: {e.Topic}, isSuccess: {e.Successful}!", Color.DarkMagenta, Color.White);
        }

        public void OnConnected(object sender, OnConnectedArgs e)
        {
            TwitchBot.IsConnectedToTwitchChat = true;
            MainPanel.OnStatusChanged(new StatusChangeArgs(false, true));
            Logger.Info("TwitchBot", $"Connected!", Color.Magenta, Color.White);
        }

        public void OnPubSubServiceClosed(object sender, EventArgs e)
        {
            TwitchBot.IsConnectedToTwitchPubSub = false;
            MainPanel.OnStatusChanged(new StatusChangeArgs(true, false));
            Logger.Info("TwitchPubSub", "Service disconnected!", Color.DarkMagenta, Color.White);
        }

        public void OnPubSubServiceError(object sender, TwitchLib.PubSub.Events.OnPubSubServiceErrorArgs e)
        {
            Logger.Error("TwitchPubSub", e.Exception.Message, Color.DarkMagenta, Color.White);
        }

        public void OnClientLog(object sender, TwitchLib.Client.Events.OnLogArgs e)
        {
            Logger.Debug("TwitchBot", e.Data, Color.Magenta, Color.White);
        }

        public void OnDisconnected(object sender, OnDisconnectedEventArgs e)
        {
            TwitchBot.IsConnectedToTwitchChat = false;
            MainPanel.OnStatusChanged(new StatusChangeArgs(false, false));
            Logger.Info("TwitchBot", $"Disconnected!", Color.Magenta, Color.White);
        }

        public void OnPubSubServiceConnected(object sender, EventArgs e)
        {
            TwitchBot.IsConnectedToTwitchPubSub = true;
            MainPanel.OnStatusChanged(new StatusChangeArgs(true, true));
            Logger.Info("TwitchPubSub", $"Connected!", Color.DarkMagenta, Color.White);
            bot.tPubSub.SendTopics(MainClass.Instance.Config.TwitchOAuth);
        }

        public void OnChannelSubscription(object sender, OnChannelSubscriptionArgs e)
        {
            var cumulativeMonths = e.Subscription.CumulativeMonths ?? 0;
            if (cumulativeMonths != 0)
            {
                var targetSubCommand = MainClass.Instance.Config.Events.OnReSubscriber.FirstOrDefault(p => p.SubPlans.Contains(e.Subscription.SubscriptionPlan) && cumulativeMonths >= p.MinMonths && cumulativeMonths <= p.MaxMonths) ?? MainClass.Instance.Config.Events.OnReSubscriber.Where(p => p.SubPlans.Contains(e.Subscription.SubscriptionPlan)).OrderByDescending(p => p.MaxMonths).FirstOrDefault();

                if (targetSubCommand == null)
                {
                    Logger.Info($"TwitchReSub", $"User {e.Subscription.DisplayName} subbed for {cumulativeMonths} months but sub plan {e.Subscription.SubscriptionPlan} is not configured in config!", Color.Magenta, Color.White);
                    return;
                }

                targetSubCommand.TryExecuteCommand(cumulativeMonths, e.Subscription);
            }
            else
            {
                var targetSubCommand = MainClass.Instance.Config.Events.OnNewSubscriber.FirstOrDefault(p => p.SubPlans.Contains(e.Subscription.SubscriptionPlan));

                if (targetSubCommand == null)
                {
                    Logger.Info($"TwitchNewSub", $"User {e.Subscription.DisplayName} subbed but sub plan {e.Subscription.SubscriptionPlan} is not configured in config!", Color.Magenta, Color.White);
                    return;
                }

                targetSubCommand.TryExecuteCommand(e.Subscription);
            }
        }

        public void OnFollow(object sender, OnFollowArgs e)
        {
            if (MainClass.Instance.Config.Events.OnFollow == null)
            {
                Logger.Info($"TwitchFollow", $"User {e.Username} followed channel but event OnFollow is not configured!", Color.Magenta, Color.White);
                return;
            }

            MainClass.Instance.Config.Events.OnFollow.TryExecuteCommand(e.DisplayName);
        }

        public void OnBeingHosted(object sender, OnBeingHostedArgs e)
        {
            var targetCommand = MainClass.Instance.Config.Events.OnBeingHosted.FirstOrDefault(p => e.BeingHostedNotification.Viewers >= p.MinViewers && e.BeingHostedNotification.Viewers <= p.MaxViewers) ?? MainClass.Instance.Config.Events.OnBeingHosted.OrderByDescending(p => p.MaxViewers).FirstOrDefault();

            if (targetCommand == null)
            {
                Logger.Info($"TwitchHost", $"User {e.BeingHostedNotification.HostedByChannel} is hosting your channel with {e.BeingHostedNotification.Viewers} viewers but any OscActions were made!", Color.Magenta, Color.White);
                return;
            }

            targetCommand.TryExecuteCommand(e.BeingHostedNotification);
        }

        public void OnUserTimedout(object sender, OnUserTimedoutArgs e)
        {
            if (MainClass.Instance.Config.Events.OnUserTimedout == null) return;

            MainClass.Instance.Config.Events.OnUserTimedout.TryExecuteCommand(e.UserTimeout.Username);
        }


        public void OnUserBanned(object sender, OnUserBannedArgs e)
        {
            if (MainClass.Instance.Config.Events.OnUserBanned == null) return;

            MainClass.Instance.Config.Events.OnUserBanned.TryExecuteCommand(e.UserBan.Username);
        }
    }
}
