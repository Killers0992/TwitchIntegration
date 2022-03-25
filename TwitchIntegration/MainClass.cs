using Microsoft.Extensions.DependencyInjection;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration
{
    public class MainClass : VrcIntegration<IntegrationConfig>
    {
        public MainClass()
        {
            Instance = this;
            MainPanel = new MainPanel();
        }

        public override string Name { get; } = "Twitch Integration";
        public override string Author { get; } = "Killers0992";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override PoisonUserControl MainPanel { get; }

        public static MainClass Instance;

        public override void OnRegister(ref IServiceCollection services)
        {
            services.AddHostedService<TwitchBot>();
            services.AddHostedService<Streamlabs>();
            base.OnRegister(ref services);
        }

        public override IConfig OnCreateDefaultConfig()
        {
            return new IntegrationConfig()
            {
                Events = new TwitchEvents()
                {
                    OnCommand = new Dictionary<string, TwitchCommand>() { { "test", new TwitchCommand() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } } } },
                    OnBeingHosted = new List<TwitchHost>() { new TwitchHost() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } } },
                    OnNewSubscriber = new List<TwitchNewSub>() { new TwitchNewSub() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } }, SubPlans = new List<SubscriptionPlan>() { SubscriptionPlan.NotSet, SubscriptionPlan.Prime, SubscriptionPlan.Tier1, SubscriptionPlan.Tier2 } } },
                    OnReceiveBits = new List<TwitchBits>() { new TwitchBits() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } } },
                    OnReSubscriber = new List<TwitchReSub>() { new TwitchReSub() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } }, SubPlans = new List<SubscriptionPlan>() { SubscriptionPlan.NotSet, SubscriptionPlan.Prime, SubscriptionPlan.Tier1, SubscriptionPlan.Tier2 } } },
                    OnReward = new Dictionary<string, TwitchReward>() { { "<REWARD ID>", new TwitchReward() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } } } },
                    OnUserBanned = new TwitchBan() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } },
                    OnUserTimedout = new TwitchTimedout() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } },
                    OnFollow = new TwitchFollow() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } }
                }
            };
        }
    }
}
