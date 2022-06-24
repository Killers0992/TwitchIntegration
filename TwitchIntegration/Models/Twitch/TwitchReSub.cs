using VrcOscIntegrations.Services;

namespace TwitchIntegration.Models.Twitch
{
    public class TwitchReSub
    {
        [YamlMember(Description = "Minimum amount of months subscribed required to execute this event.")]
        public int MinMonths { get; set; } = 0;
        [YamlMember(Description = "Maximum amount of months subscribed required to execute this event.")]
        public int MaxMonths { get; set; } = 365;

        [YamlMember(Description = "Which sub plans can execue this event. ( Prime, Tier1, Tier2, Tier3  )")]
        public List<SubscriptionPlan> SubPlans { get; set; } = new List<SubscriptionPlan>();

        [YamlMember(Description = "Global delay between next usage of this event.")]
        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;

        [YamlIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        [YamlMember(Description = "If enabled random action is pick from \"OscOutActions\".")]
        public bool ExecuteRandomAction { get; set; }
        [YamlMember(Description = "List of OSC actions executed while this event.")]
        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(int months, ChannelSubscription sub)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Info($"TwitchReSub", $"User {sub.DisplayName} subbed but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
                    return false;
                }
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

            Logger.Info($"TwitchReSub", $"User {sub.DisplayName} resubbed with plan {sub.SubscriptionPlan} for {months} and OSC actions added to queue!", Color.Magenta, Color.White);
            return true;
        }
    }
}
