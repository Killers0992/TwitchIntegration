using VrcOscIntegrations.Services;

namespace TwitchIntegration.Models.Twitch
{
    public class TwitchCommand
    {
        [YamlMember(Description = "If enabled then anyone can execute this event.")]
        public bool NormalAccess { get; set; } = true;
        [YamlMember(Description = "If enabled then only users with active subscribtion can use this.")]
        public bool SubAccess { get; set; }
        [YamlMember(Description = "If enabled then only users with set amount of subscribed months can use this.")]
        public int SubMonths { get; set; }
        [YamlMember(Description = "If enabled then only users with moderation rank can use this.")]
        public bool ModAccess { get; set; }
        [YamlMember(Description = "If enabled then only users with VIP rank can use this.")]
        public bool VipAccess { get; set; }
        [YamlMember(Description = "If enabled then only streamer can use this.")]
        public bool BroadcasterAccess { get; set; }

        [YamlMember(Description = "Global delay between next usage of this event.")]
        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;

        [JsonIgnore]
        [YamlIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        [YamlMember(Description = "Delay per user usage of this event.")]
        public TimeSpan DelayPerUser { get; set; } = TimeSpan.Zero;

        [JsonIgnore]
        [YamlIgnore]
        public Dictionary<string, DateTime> CurrentUserDelays = new Dictionary<string, DateTime>();

        [YamlMember(Description = "If enabled random action is pick from \"OscOutActions\".")]
        public bool ExecuteRandomAction { get; set; }
        [YamlMember(Description = "List of OSC actions executed while this event.")]
        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(ChatMessage message)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Info($"TwitchCommand", $"User {message.DisplayName} tried to execute command {message.Message} but command is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )", Color.White, Color.White);
                    return false;
                }
            }

            if (DelayPerUser.TotalSeconds > 0 && !string.IsNullOrEmpty(message.UserId))
            {
                if (CurrentUserDelays.TryGetValue(message.UserId, out DateTime delay))
                {
                    if (delay < DateTime.Now)
                    {
                        CurrentUserDelays.Remove(message.UserId);
                    }
                    else
                    {
                        Logger.Info($"TwitchCommand", $"User {message.DisplayName} tried to execute command {message.Message} but command is on cooldown! ( Cooldown ends in {(int)(delay - DateTime.Now).TotalSeconds} seconds )", Color.White, Color.White);
                        return false;
                    }
                }
                CurrentUserDelays.Add(message.UserId, DateTime.Now.Add(DelayPerUser));
            }

            if (!NormalAccess)
            {
                if (message.SubscribedMonthCount < SubMonths) return false;
                if (SubAccess)
                {
                    if (!message.IsSubscriber) return false;
                }
                if (ModAccess && !message.IsModerator) return false;
                if (VipAccess && !message.IsVip) return false;
                if (BroadcasterAccess && !message.IsBroadcaster) return false;
            }

            if (ExecuteRandomAction && OscOutActions.Count > 1)
            {
                var action = OscOutActions[TwitchBot.rng.Next(0, OscOutActions.Count - 1)];
                OscActions.EnqueueAction(action);
            }
            else
            {
                foreach (var action in OscOutActions)
                    OscActions.EnqueueAction(action);
            }

            Logger.Info($"TwitchCommand", $"User {message.DisplayName} sended command {message.Message} and OSC actions added to queue!", Color.White, Color.White);
            return true;
        }
    }
}
