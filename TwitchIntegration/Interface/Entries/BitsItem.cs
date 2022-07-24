using ReaLTaiizor.Enum.Poison;
using TwitchIntegration.Enums;

namespace TwitchIntegration.Interface
{
    public partial class BitsItem : PoisonUserControl
    {
        private MainPanel _mainPanel;
        private PoisonTaskWindow _currentEditWindow;

        public BitsItem(MainPanel panel, int itemId)
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

            var bitsItem = MainClass.Instance.Config.Events.OnReceiveBits[ItemIndex];

            MinBits = bitsItem.MinBits;
            MaxBits = bitsItem.MaxBits;
        }

        public int ItemIndex { get; set; }

        int _minBits;
        [Category("Minimum Bits Info")]
        public int MinBits
        {
            get
            {
                return _minBits;
            }
            set
            {
                _minBits = value;
                minMonths.Text = value.ToString();
            }
        }

        int _maxBits;
        [Category("Maximum Bits Info")]
        public int MaxBits
        {
            get
            {
                return _maxBits;
            }
            set
            {
                _maxBits = value;
                maxMonths.Text = value.ToString();
            }
        }

        private void removeReward_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to remove bits?", "Remove bits", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            MainClass.Instance.Config.Events.OnReceiveBits.RemoveAt(ItemIndex);
            MainClass.Instance.SaveConfig();
            CloseWindowIfNeeded();
            _mainPanel.RemoveBits(this);
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
            _currentEditWindow = new PoisonTaskWindow(0, new EditBitsDialog(this))
            {
                Text = $"Edit bits",

                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,

                Movable = true,

                StartPosition = FormStartPosition.CenterScreen,

                CustomSize = true,
                Size = new Size(686, 357),

                Theme = ThemeStyle.Dark,
                Style = ColorStyle.Magenta,
            };
            _currentEditWindow.Show();
        }
    }
}
