using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface.Dialogs
{
    public partial class CreateRewardDialog : PoisonUserControl
    {
        private MainPanel _mainPanel;

        public static bool IsWaiting = true;
        public static RewardInfo LastReward;

        public CreateRewardDialog(MainPanel panel)
        {
            _mainPanel = panel;
            LastReward = null;
            IsWaiting = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void actionCheck_Tick(object sender, EventArgs e)
        {
            if (LastReward == null || !IsWaiting) return;

            IsWaiting = false;
            waitingLabel.Visible = false;
            waitingSpinner.Visible = false;

            rewardInfo.Visible = true;
            rewardInfo.Text = $"Do you want to add reward \"{LastReward.Title}\" ?";

            confirmButton.Cursor = Cursors.Default;
            confirmButton.Enabled = true;
        }
    }
}
