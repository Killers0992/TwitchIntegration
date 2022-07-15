using VrcOscIntegrations.Services;

namespace TwitchIntegration.Models.Twitch
{
    public class TwitchHost
    {
        [YamlMember(Description = "Minimum amount of viewers from host required to execute this event.")]
        public int MinViewers { get; set; } = 0;
        [YamlMember(Description = "Maximum amount of viewers from host required to execute this event.")]
        public int MaxViewers { get; set; } = 1000;

        [YamlMember(Description = "Global delay between next usage of this event.")]
        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;

        [JsonIgnore]
        [YamlIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        [YamlMember(Description = "If enabled random action is pick from \"OscOutActions\".")]
        public bool ExecuteRandomAction { get; set; }
        [YamlMember(Description = "List of OSC actions executed while this event.")]
        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(BeingHostedNotification host)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Info($"TwitchHost", $"User {host.HostedByChannel} hosted your channel but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
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

            Logger.Info($"TwitchHost", $"User {host.HostedByChannel} hosted your channel and OSC actions added to queue!", Color.Magenta, Color.White);
            return true;
        }
    }
}
