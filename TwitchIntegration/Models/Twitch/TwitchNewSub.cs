using VrcOscIntegrations.Services;

namespace TwitchIntegration.Models.Twitch
{
    public class TwitchNewSub
    {
        public List<SubscriptionPlan> SubPlans { get; set; } = new List<SubscriptionPlan>();

        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;

        [YamlIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        public bool ExecuteRandomAction { get; set; }
        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(ChannelSubscription sub)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Info($"TwitchNewSub", $"User {sub.DisplayName} subbed but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
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

            Logger.Info($"TwitchNewSub", $"User {sub.DisplayName} subbed with plan {sub.SubscriptionPlan} and OSC actions added to queue!", Color.Magenta, Color.White);
            return true;
        }
    }
}
