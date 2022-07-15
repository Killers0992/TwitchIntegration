using VrcOscIntegrations.Services;

namespace TwitchIntegration.Models.Twitch
{
    public class TwitchReward
    {
        [JsonIgnore]
        [YamlIgnore]
        DateTime CurrentGlobalDelay = DateTime.Now;
        [JsonIgnore]
        [YamlIgnore]
        Dictionary<string, DateTime> CurrentUserDelays = new Dictionary<string, DateTime>();


        [YamlMember(Description = "Name of reward used only for display name.")]
        public string RewardName { get; set; } = "UNKNOWN";

        [YamlMember(Description = "Global delay between next usage of this event.")]
        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;
        [YamlMember(Description = "Delay per user usage of this event.")]
        public TimeSpan DelayPerUser { get; set; } = TimeSpan.Zero;
        [YamlMember(Description = "If enabled random action is pick from \"OscOutActions\".")]
        public bool ExecuteRandomAction { get; set; }
        [YamlMember(Description = "List of OSC actions executed while this event.")]
        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(Redemption message)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Info($"TwitchReward", $"User {message.User.DisplayName} redeemed reward {message.Reward.Id} but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
                    return false;
                }
            }

            if (DelayPerUser.TotalSeconds > 0 && !string.IsNullOrEmpty(message.User.Id))
            {
                if (CurrentUserDelays.TryGetValue(message.User.Id, out DateTime delay))
                {
                    if (delay < DateTime.Now)
                    {
                        CurrentUserDelays.Remove(message.User.Id);
                    }
                    else
                    {
                        Logger.Info($"TwitchReward", $"User {message.User.DisplayName} redeemed reward {message.Reward.Id} but action is on cooldown! ( Cooldown ends in {(int)(delay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
                        return false;
                    }
                }
                CurrentUserDelays.Add(message.User.Id, DateTime.Now.Add(DelayPerUser));
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

            Logger.Info($"TwitchReward", $"User {message.User.DisplayName} redeemed reward {message.Reward.Id} and OSC actions added to queue!", Color.Magenta, Color.White);
            return true;
        }
    }
}
