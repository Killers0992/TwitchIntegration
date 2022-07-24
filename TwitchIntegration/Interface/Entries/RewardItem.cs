using ReaLTaiizor.Enum.Poison;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface
{
    public partial class RewarddItem : PoisonUserControl
    {
        private MainPanel _mainPanel;
        private PoisonTaskWindow _currentEditWindow;

        public RewarddItem(MainPanel panel)
        {
            _mainPanel = panel;
            InitializeComponent();
        }

        private void OnCommandNameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActiveControl = null;
        }

        public string RewardID { get; set; }

        string _rewardName;
        [Category("Reward Info")]
        public string RewardName
        {
            get
            {
                return _rewardName;
            }
            set
            {
                _rewardName = value;
                if (rewardName.Text != _rewardName)
                    rewardName.Text = value;
            }
        }

        private void removeReward_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to remove reward {RewardName}?", "Remove reward", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            MainClass.Instance.Config.Events.OnReward.Remove(RewardID);
            MainClass.Instance.SaveConfig();
            ClsoeWindowIfNeeded();
            _mainPanel.RemoveReward(this);
        }

        private void ClsoeWindowIfNeeded()
        {
            if (_currentEditWindow != null)
            {
                _currentEditWindow.Close();
                _currentEditWindow.Dispose();
                _currentEditWindow = null;
            }
        }

        private void poisonButton1_Click(object sender, EventArgs e)
        {
            ClsoeWindowIfNeeded();

            _currentEditWindow = new PoisonTaskWindow(0, new EditRewardDialog(this))
            {
                Text = $"Edit reward \"{RewardName}\"",

                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,

                Movable = true,

                StartPosition = FormStartPosition.CenterScreen,

                CustomSize = true,
                Size = new Size(606, 357),

                Theme = ThemeStyle.Dark,
                Style = ColorStyle.Magenta,
            };
            _currentEditWindow.Show();
        }
    }
}
