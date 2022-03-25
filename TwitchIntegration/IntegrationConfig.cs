namespace TwitchIntegration
{
    public class IntegrationConfig : IConfig
    {
        public bool Debug { get; set; } = false;
        public string TwitchOAuth { get; set; } = "twitch-oauth";
        public StreamLabsApp StreamLabs { get; set; } = new StreamLabsApp();
        public TwitchEvents Events { get; set; } = new TwitchEvents();
    }
}
