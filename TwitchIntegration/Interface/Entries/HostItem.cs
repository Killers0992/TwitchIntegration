using ReaLTaiizor.Enum.Poison;
using TwitchIntegration.Enums;

namespace TwitchIntegration.Interface
{
    public partial class HostItem : PoisonUserControl
    {
        private MainPanel _mainPanel;
        private PoisonTaskWindow _currentEditWindow;

        public HostItem(MainPanel panel, int itemId)
        {
            ItemIndex = itemId;
            _mainPanel = panel;
            InitializeComponent();
            UpdateItem();
        }

        public void UpdateItem(bool isUpdate = false)
        {
            if (!isUpdate)
                CloseWindowIfNeeded();

            var hostItem = MainClass.Instance.Config.Events.OnBeingHosted[ItemIndex];

            MinViewers = hostItem.MinViewers;
            MaxViewers = hostItem.MaxViewers;
        }

        public int ItemIndex { get; set; }

        int _minViewers;
        [Category("Minimum Viers Info")]
        public int MinViewers
        {
            get
            {
                return _minViewers;
            }
            set
            {
                _minViewers = value;
                minViewers.Text = value.ToString();
            }
        }

        int _maxViewers;
        [Category("Maximum Viewers Info")]
        public int MaxViewers
        {
            get
            {
                return _maxViewers;
            }
            set
            {
                _maxViewers = value;
                maxViewers.Text = value.ToString();
            }
        }

        private void removeReward_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to remove host?", "Remove host", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            MainClass.Instance.Config.Events.OnBeingHosted.RemoveAt(ItemIndex);
            MainClass.Instance.SaveConfig();
            CloseWindowIfNeeded();
            _mainPanel.RemoveHost(this);
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
            _currentEditWindow = new PoisonTaskWindow(0, new EditHostDialog(this))
            {
                Text = $"Edit host",
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

        private void HostItem_Load(object sender, EventArgs e)
        {

        }
    }
}
