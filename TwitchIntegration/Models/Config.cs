using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Models
{
    public class StreamLabsApp
    {
        public bool IsEnabled { get; set; }
        public string SocketApiKey { get; set; } = "SOCKET-API-KEY";
        public StreamLabsEvents Events { get; set; } = new StreamLabsEvents();
    }

    public class StreamLabsEvents
    {
        public List<object> OnDonation { get; set; } = new List<object>();
    }

    public class TwitchEvents
    {
        public string CommandPrefix { get; set; } = "!";
        public Dictionary<string, TwitchCommand> OnCommand { get; set; } = new Dictionary<string, TwitchCommand>();
        public Dictionary<string, TwitchReward> OnReward { get; set; } = new Dictionary<string, TwitchReward>();
        public List<TwitchBits> OnReceiveBits { get; set; } = new List<TwitchBits>();
        public List<TwitchNewSub> OnNewSubscriber { get; set; } = new List<TwitchNewSub>();
        public List<TwitchReSub> OnReSubscriber { get; set; } = new List<TwitchReSub>();
        public List<TwitchHost> OnBeingHosted { get; set; } = new List<TwitchHost>();
        public TwitchBan OnUserBanned { get; set; }
        public TwitchTimedout OnUserTimedout { get; set; }
        public TwitchFollow OnFollow { get; set; }
    }
}
