namespace TwitchIntegration.Interface
{
    public partial class TwitchLogin : PoisonUserControl
    {

        public TwitchLogin()
        {
            InitializeComponent();
            tokenFIeld.Text = String.Empty;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MainClass.Instance.Config.TwitchOAuth = tokenFIeld.Text;
            MainClass.Instance.SaveConfig();

            TwitchBot.WaitingForAction = false;
        }
    }
}
