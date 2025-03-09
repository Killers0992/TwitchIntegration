using TwitchIntegration.Models.Twitch;
using YamlDotNet.Serialization;

namespace TwitchIntegration.Models
{
    public class Config
    {
        public static bool Import(string file)
        {
            if (!File.Exists(file)) return false;

            var fileExtension = Path.GetExtension(file);

            switch (fileExtension)
            {
                case ".json":
                    var jsonConfig = JsonConvert.DeserializeObject<IntegrationConfig>(File.ReadAllText(file));

                    MainClass.Instance.Config.CopyProperties(jsonConfig);
                    MainClass.Instance.SaveConfig();
                    break;
            }

            return true;
        }
    }

    public class StreamLabsApp
    {
        [YamlMember(Description = "If you are using streamlabs for donations enable this.")]
        public bool IsEnabled { get; set; }
        [YamlMember(Description = "Socket API key required for connecting to streamlabs sockets.")]
        public string SocketApiKey { get; set; } = "SOCKET-API-KEY";
        [YamlMember(Description = "Streamlabs events.")]
        public StreamLabsEvents Events { get; set; } = new StreamLabsEvents();
    }

    public class StreamLabsEvents
    {
        [YamlMember(Description = "Event executed while receiving new donation.")]
        public List<object> OnDonation { get; set; } = new List<object>();
    }

    public class TwitchEvents
    {
        public bool ShowedPrompt { get; set; } = false;

        [YamlMember(Description = "Prefix for commands used in twitch chat.")]
        public string CommandPrefix { get; set; } = "!";
        [YamlMember(Description = "Twitch commands.")]
        public Dictionary<string, TwitchCommand> OnCommand { get; set; } = new Dictionary<string, TwitchCommand>();
        [YamlMember(Description = "Twitch event executed while user redeeming reward.")]
        public Dictionary<string, TwitchReward> OnReward { get; set; } = new Dictionary<string, TwitchReward>();
        [YamlMember(Description = "Twitch event executed while user sends bits.")]
        public List<TwitchBits> OnReceiveBits { get; set; } = new List<TwitchBits>();
        [YamlMember(Description = "Twitch event executed after user becoming new subscriber.")]
        public List<TwitchNewSub> OnNewSubscriber { get; set; } = new List<TwitchNewSub>();
        [YamlMember(Description = "Twitch event executed after user re subscribing.")]
        public List<TwitchReSub> OnReSubscriber { get; set; } = new List<TwitchReSub>();
        [YamlMember(Description = "Twitch event executed after other channel hosting you.")]
        public List<TwitchHost> OnBeingHosted { get; set; } = new List<TwitchHost>();
        [YamlMember(Description = "Twitch event executed after user gets banned.")]
        public TwitchBan OnUserBanned { get; set; }
        [YamlMember(Description = "Twitch event executed after user gets timedout.")]
        public TwitchTimedout OnUserTimedout { get; set; }
        [YamlMember(Description = "Twitch event executed after user follows your channel.")]
        public TwitchFollow OnFollow { get; set; }
    }
}
