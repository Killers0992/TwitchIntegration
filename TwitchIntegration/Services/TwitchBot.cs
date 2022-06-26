using TwitchLib.Api.Helix.Models.ChannelPoints;
using TwitchLib.Api.Helix.Models.ChannelPoints.GetCustomReward;

namespace TwitchIntegration.Services
{
    public class TwitchBot : BackgroundService
    {
        public static Random rng = new Random();
        public static string ChannelID;

        public static string TwitchName;
        public static string ChannelName;
        public static string UserID;

        public static bool IsConnectedToTwitchChat;
        public static bool IsConnectedToTwitchPubSub;

        public static bool WaitingForAction;

        public TwitchAPI api;
        public TwitchClient client;
        public TwitchPubSub tPubSub;
        TwitchEventHandlers eventHandlers;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            api = new TwitchAPI();
            api.Settings.ClientId = AuthProviders.TwitchClientID;

            retry:

            while (WaitingForAction)
            {
                await Task.Delay(1000);
            }

            try
            {
                var user = await api.Helix.Users.GetUsersAsync(accessToken: MainClass.Instance.Config.TwitchOAuth);
                var firstUser = user.Users.FirstOrDefault();
                if (firstUser != null)
                {
                    ChannelID = firstUser.Id;
                    TwitchName = firstUser.DisplayName;
                    ChannelName = firstUser.Login;
                }
                else
                {
                    WaitingForAction = true;
                    goto retry;
                }
            }
            catch (Exception ex)
            {
                MainPanel.ShowLogin = true;
                var result = MessageBox.Show("OAuth token is invalid, do you want login via twitch?", "Twitch Integration", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    AuthProviders.CreateTwitchAuth("chat:read+channel:read:redemptions+channel:read:subscriptions");
                    MessageBox.Show("After login copy token from browser and paste in twitch integration.", "Twitch Integration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                WaitingForAction = true;
                goto retry;
            }

            ConnectionCredentials credentials = new ConnectionCredentials(TwitchName, MainClass.Instance.Config.TwitchOAuth);

            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };

            WebSocketClient customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);

            if (client == null)
            {
                Logger.Error($"TwitchBot", "Client is null!", Color.Magenta, Color.White);
                return;
            }

            Logger.Info("TwitchBot", "Starting...", Color.Magenta, Color.White);
            client.Initialize(credentials, ChannelName);

            eventHandlers = new TwitchEventHandlers(this);

            client.OnLog += eventHandlers.OnClientLog;
            client.OnMessageReceived += eventHandlers.OnMessageReceived;
            client.OnBeingHosted += eventHandlers.OnBeingHosted;
            client.OnUserTimedout += eventHandlers.OnUserTimedout;
            client.OnUserBanned += eventHandlers.OnUserBanned;
            client.OnConnected += eventHandlers.OnConnected;
            client.OnDisconnected += eventHandlers.OnDisconnected;

            client.Connect();

            tPubSub = new TwitchPubSub();

            tPubSub.OnChannelSubscription += eventHandlers.OnChannelSubscription;
            tPubSub.OnFollow += eventHandlers.OnFollow;
            tPubSub.OnChannelPointsRewardRedeemed += eventHandlers.OnRewardRedeem;

            tPubSub.OnListenResponse += eventHandlers.OnListenResponse;
            tPubSub.OnPubSubServiceClosed += eventHandlers.OnPubSubServiceClosed;
            tPubSub.OnPubSubServiceError += eventHandlers.OnPubSubServiceError;
            tPubSub.OnPubSubServiceConnected += eventHandlers.OnPubSubServiceConnected;

            tPubSub.ListenToSubscriptions(ChannelID);
            tPubSub.ListenToFollows(ChannelID);
            tPubSub.ListenToChannelPoints(ChannelID);

            tPubSub.Connect();

            await Task.Delay(-1);
        }
    }
}
