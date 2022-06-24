using YamlDotNet.Serialization;

namespace TwitchIntegration
{
    public class IntegrationConfig : IConfig
    {
        [YamlMember(Description = "Debug mode which shows more information in console.")]
        public bool Debug { get; set; } = false;
        [YamlMember(Description = "Twitch OAuth token used for connecting to your twitch channel.")]
        public string TwitchOAuth { get; set; } = "twitch-oauth";
        [YamlMember(Description = "Streamlabs donations.")]
        public StreamLabsApp StreamLabs { get; set; } = new StreamLabsApp();
        [YamlMember(Description = "Twitch events.")]
        public TwitchEvents Events { get; set; } = new TwitchEvents();
    }
}
