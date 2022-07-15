using ReaLTaiizor.Enum.Poison;
using TwitchIntegration.Enums;

namespace TwitchIntegration.Interface
{
    public partial class SubItem : PoisonUserControl
    {
        private MainPanel _mainPanel;
        private PoisonTaskWindow _currentEditWindow;

        public SubItem(MainPanel panel, int itemId, SubscriptionType type)
        {
            ItemIndex = itemId;
            SubType = type;
            _mainPanel = panel;
            InitializeComponent();
            UpdateItem();
        }

        public void UpdateItem(bool isUpdate = false)
        {
            if (!isUpdate)
                CloseWindowIfNeeded();

            if (SubType == SubscriptionType.ReSub)
            {
                var item = MainClass.Instance.Config.Events.OnReSubscriber[ItemIndex];

                rewardName.Text = "Re subscription";

                Plans = string.Join(", ", item.SubPlans.Select(x => x.ToString()));

                minMonths.Visible = true;
                maxMonths.Visible = true;

                poisonLabel3.Visible = true;
                poisonLabel4.Visible = true;

                MinMonths = item.MinMonths;
                MaxMonths = item.MaxMonths;
                return;
            }

            var subItem = MainClass.Instance.Config.Events.OnNewSubscriber[ItemIndex];

            rewardName.Text = "New subscription";

            Plans = string.Join(", ", subItem.SubPlans.Select(x => x.ToString()));

            poisonLabel3.Visible = false;
            poisonLabel4.Visible = false;

            minMonths.Visible = false;
            maxMonths.Visible = false;
        }

        public SubscriptionType SubType { get; set; }

        public int ItemIndex { get; set; }

        string _plans;
        [Category("Plans Info")]
        public string Plans
        {
            get
            {
                return _plans;
            }
            set
            {
                _plans = value;
                subPlans.Text = value;
            }
        }

        int _minMonths;
        [Category("Minimum Months Info")]
        public int MinMonths
        {
            get
            {
                return _minMonths;
            }
            set
            {
                _minMonths = value;
                minMonths.Text = value.ToString();
            }
        }

        int _maxMonths;
        [Category("Maximum Months Info")]
        public int MaxMonths
        {
            get
            {
                return _maxMonths;
            }
            set
            {
                _maxMonths = value;
                maxMonths.Text = value.ToString();
            }
        }

        private void removeReward_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to remove sub?", "Remove sub", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            if (SubType == SubscriptionType.ReSub)
                MainClass.Instance.Config.Events.OnReSubscriber.RemoveAt(ItemIndex);
            else
                MainClass.Instance.Config.Events.OnNewSubscriber.RemoveAt(ItemIndex);

            MainClass.Instance.SaveConfig();
            CloseWindowIfNeeded();
            _mainPanel.RemoveSubscription(this);
        }

        private void CloseWindowIfNeeded()
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
            CloseWindowIfNeeded();
            _currentEditWindow = new PoisonTaskWindow(0, SubType == SubscriptionType.NewSub ? new EditNewSubscriptionDialog(this) : new EditReSubscriptionDialog(this))
            {
                Text = $"Edit sub",
                Resizable = false,
                MaximizeBox = false,
                Movable = true,
    
                StartPosition = FormStartPosition.CenterScreen,

                Theme = ThemeStyle.Dark,
                Style = ColorStyle.Magenta,
            };

            _currentEditWindow.Show();
            _currentEditWindow.Size = new System.Drawing.Size(606, 357);
        }
    }
}
