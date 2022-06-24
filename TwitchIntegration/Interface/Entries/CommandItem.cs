using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface
{
    public partial class CommandItem : PoisonUserControl
    {
        private MainPanel _mainPanel;
        private PoisonTaskWindow _currentEditWindow;

        public CommandItem(MainPanel panel)
        {
            _mainPanel = panel;
            InitializeComponent();

            commandName.LostFocus += OnCommandNameTypingEnded;
            commandName.KeyDown += OnCommandNameKeyDown;
        }

        private void OnCommandNameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActiveControl = null;
        }

        string _commandName;
        [Category("Command Info")]
        public string CommandName
        {
            get
            {
                return _commandName;
            }
            set
            {
                _commandName = value;
                if (commandName.Text != _commandName)
                    commandName.Text = value;
            }
        }

        void OnCommandNameTypingEnded(object sender, EventArgs e)
        {
            if (CommandName == commandName.Text) return;

            if (MainClass.Instance.Config.Events.OnCommand.ContainsKey(commandName.Text))
            {
                MessageBox.Show($"Command with name \"{commandName.Text}\" already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            var saved = MainClass.Instance.Config.Events.OnCommand[CommandName];

            MainClass.Instance.Config.Events.OnCommand.Remove(CommandName);
            CommandName = commandName.Text;
            MainClass.Instance.Config.Events.OnCommand.Add(CommandName, saved);
            MainClass.Instance.SaveConfig();
        }

        private void removeCommand_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to remove command {CommandName}?", "Remove command", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            MainClass.Instance.Config.Events.OnCommand.Remove(CommandName);
            MainClass.Instance.SaveConfig();
            ClsoeWindowIfNeeded();
            _mainPanel.RemoveCommand(this);
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

            _currentEditWindow = new PoisonTaskWindow(0, new EditCommandDialog(this))
            {
                Text = $"Edit command \"{CommandName}\"",
                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,
                Movable = true,
                WindowState = FormWindowState.Normal,
            };
            _currentEditWindow.Controls[0].Parent = _currentEditWindow;

            _currentEditWindow.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            _currentEditWindow.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            _currentEditWindow.Show();
            _currentEditWindow.Size = new System.Drawing.Size(606, 357);
        }
    }
}
