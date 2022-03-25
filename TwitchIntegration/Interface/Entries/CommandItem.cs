using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface
{
    public partial class CommandItem : PoisonUserControl
    {
        private MainPanel _mainPanel;
        private PoisonTaskWindow _currentAddOscWindow;

        public CommandItem(MainPanel panel)
        {
            _mainPanel = panel;
            InitializeComponent();

            commandName.LostFocus += OnCommandNameTypingEnded;
            commandName.KeyDown += OnCommandNameKeyDown;
            normalAccess.CheckedChanged += OnNormalAccessChanged;
            streamerAccess.CheckedChanged += OnStreamerAccessChanged;
            subAccess.CheckedChanged += OnSubAccessChanged;
            vipAccess.CheckedChanged += OnVipAccessChanged;
            random.SwitchedChanged += OnRandomChanged;
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

        bool _normalAccess;
        [Category("Command Info")]
        public bool NormalAccess
        {
            get
            {
                return _normalAccess;
            }
            set
            {
                _normalAccess = value;
                normalAccess.Checked = value;
            }
        }

        void OnNormalAccessChanged(object sender)
        {
            MainClass.Instance.Config.Events.OnCommand[CommandName].NormalAccess = normalAccess.Checked;
            MainClass.Instance.SaveConfig();
        }

        bool _streamerAccess;
        [Category("Command Info")]
        public bool StreamerAccess
        {
            get
            {
                return _streamerAccess;
            }
            set
            {
                _streamerAccess = value;
                streamerAccess.Checked = value;
            }
        }

        void OnStreamerAccessChanged(object sender)
        {
            MainClass.Instance.Config.Events.OnCommand[CommandName].BroadcasterAccess = streamerAccess.Checked;
            MainClass.Instance.SaveConfig();
        }

        bool _subAccess;
        [Category("Command Info")]
        public bool SubAccess
        {
            get
            {
                return _subAccess;
            }
            set
            {
                _subAccess = value;
                subAccess.Checked = value;
            }
        }


        void OnSubAccessChanged(object sender)
        {
            MainClass.Instance.Config.Events.OnCommand[CommandName].SubAccess = subAccess.Checked;
            MainClass.Instance.SaveConfig();
        }

        bool _vipAccess;
        [Category("Command Info")]
        public bool VipAccess
        {
            get
            {
                return _vipAccess;
            }
            set
            {
                _vipAccess = value;
                vipAccess.Checked = value;
            }
        }

        void OnVipAccessChanged(object sender)
        {
            MainClass.Instance.Config.Events.OnCommand[CommandName].VipAccess = vipAccess.Checked;
            MainClass.Instance.SaveConfig();
        }

        bool _randomExecution;
        public bool RandomExecution
        {
            get
            {
                return _randomExecution;
            }
            set
            {
                _randomExecution = value;
                random.Switched = value;
            }
        }

        void OnRandomChanged(object sender)
        {
            MainClass.Instance.Config.Events.OnCommand[CommandName].ExecuteRandomAction = random.Switched;
            MainClass.Instance.SaveConfig();
        }

        List<OscOutAction> _oscActions;
        public List<OscOutAction> OscActions
        {
            get
            {
                return _oscActions;
            }
            set
            {
                _oscActions = value;
                for(int x = 0; x < _oscActions.Count; x++)
                {
                    AddNewAction(x, _oscActions[x].ActionName, _oscActions[x].ExecutionDuration, _oscActions[x].Value != null ? _oscActions[x].Value.ToString() : string.Empty, _oscActions[x].DefaultValue != null ? _oscActions[x].DefaultValue.ToString() : string.Empty);
                }
            }
        }

        public void AddNewAction(int id, string actionName, int duration, string value, string defaultValue, bool scroll = false)
        {
            if (id == -1)
            {
                if (MainClass.Instance.Config.Events.OnCommand.TryGetValue(CommandName, out TwitchCommand cmd))
                {
                    cmd.OscOutActions.Add(new OscOutAction()
                    {
                        ActionName = actionName,
                        ExecutionDuration = duration,
                        Value = value.ConvertStringToObject(),
                        DefaultValue = defaultValue.ConvertStringToObject(),
                    });
                    id = cmd.OscOutActions.Count - 1;
                    MainClass.Instance.SaveConfig();
                }
            }

            var item = new OscItem(this);
            item.ID = id;
            item.ActionName = actionName;
            item.ExecutionDuration = duration;
            item.Value = value;
            item.DefaultValue = defaultValue;
            oscActions.Controls.Add(item);

            if (scroll)
                oscActions.ScrollControlIntoView(item);
        }

        private void newOscAction_Click(object sender, EventArgs e)
        {
            if (_currentAddOscWindow != null)
            {
                _currentAddOscWindow.Close();
                _currentAddOscWindow.Dispose();
                _currentAddOscWindow = null;
            }

            _currentAddOscWindow = new PoisonTaskWindow(0, new CreateOscActionDialog(this))
            {
                Text = "Add OSC Action",
                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,
                Movable = true,
                WindowState = FormWindowState.Normal,
            };
            _currentAddOscWindow.Controls[0].Parent = _currentAddOscWindow;

            _currentAddOscWindow.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            _currentAddOscWindow.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            _currentAddOscWindow.Show();
            _currentAddOscWindow.Size = new System.Drawing.Size(325, 282);
        }

        public void RemoveAction(Control control)
        {
            oscActions.Controls.Remove(control);
        }

        private void removeCommand_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to remove command {CommandName}?", "Remove command", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            MainClass.Instance.Config.Events.OnCommand.Remove(CommandName);
            MainClass.Instance.SaveConfig();
            _mainPanel.RemoveCommand(this);
        }
    }
}
