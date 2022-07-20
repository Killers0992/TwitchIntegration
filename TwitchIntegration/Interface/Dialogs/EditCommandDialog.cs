using TwitchIntegration.Interfaces;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface.Dialogs
{
    public partial class EditCommandDialog : PoisonUserControl, IActionRemovable
    {
        private bool _isUpdating;
        private CommandItem _mainPanel;
        private PoisonTaskWindow _currentAddOscWindow;

        public EditCommandDialog(CommandItem panel)
        {
            _mainPanel = panel;
            InitializeComponent();

            normalUser.SwitchedChanged += OnNormalUserChanged;
            subscriber.SwitchedChanged += OnSubscriberChanged;
            minimumMonths.ValueChanged += OnMinimumMonthsChanged;
            moderator.SwitchedChanged += OnModeratorChanged;
            streamer.SwitchedChanged += OnStreamerChanged;
            vip.SwitchedChanged += OnVipChanged;
            randomAction.SwitchedChanged += OnRandomChanged;

            globalH.ValueChanged += OnGlobalChanged;
            globalM.ValueChanged += OnGlobalChanged;
            globalS.ValueChanged += OnGlobalChanged;

            userH.ValueChanged += OnUserChanged;
            userM.ValueChanged += OnUserChanged;
            userS.ValueChanged += OnUserChanged;

            CommandName = _mainPanel.CommandName;
            Init();
        }

        private void OnGlobalChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].GlobalDelay = new TimeSpan((int)globalH.Value, (int)globalM.Value, (int)globalS.Value);
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].DelayPerUser = new TimeSpan((int)userH.Value, (int)userM.Value, (int)userS.Value);
        }

        public string CommandName { get; set; }

        public void Init()
        {
            _isUpdating = true;
            NormalUser = MainClass.Instance.Config.Events.OnCommand[CommandName].NormalAccess;
            Subscriber = MainClass.Instance.Config.Events.OnCommand[CommandName].SubAccess;
            SubscriberMonths = MainClass.Instance.Config.Events.OnCommand[CommandName].SubMonths;
            Moderator = MainClass.Instance.Config.Events.OnCommand[CommandName].ModAccess;
            Streamer = MainClass.Instance.Config.Events.OnCommand[CommandName].BroadcasterAccess;
            Vip = MainClass.Instance.Config.Events.OnCommand[CommandName].VipAccess;
            RandomExecution = MainClass.Instance.Config.Events.OnCommand[CommandName].ExecuteRandomAction;

            globalH.Value = MainClass.Instance.Config.Events.OnCommand[CommandName].GlobalDelay.Hours;
            globalM.Value = MainClass.Instance.Config.Events.OnCommand[CommandName].GlobalDelay.Minutes;
            globalS.Value = MainClass.Instance.Config.Events.OnCommand[CommandName].GlobalDelay.Seconds;

            userH.Value = MainClass.Instance.Config.Events.OnCommand[CommandName].DelayPerUser.Hours;
            userM.Value = MainClass.Instance.Config.Events.OnCommand[CommandName].DelayPerUser.Minutes;
            userS.Value = MainClass.Instance.Config.Events.OnCommand[CommandName].DelayPerUser.Seconds;

            LoadActions();
            _isUpdating = false;
        }

        public void LoadActions()
        {
            OscActions = new List<OscOutAction>();
            OscActions = MainClass.Instance.Config.Events.OnCommand[CommandName].OscOutActions;
        }

        public void RemoveAction(Control control)
        {
            oscActions.Controls.Remove(control);
        }

        public void AddNewAction(int id, string actionName, double duration, string value, string defaultValue, bool scroll = false)
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
            item.actionName.LostFocus += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnCommand[CommandName].OscOutActions[item.ID].ActionName = item.actionName.Text;
                MainClass.Instance.SaveConfig();
            };
            item.executionDuration.TextChanged += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnCommand[CommandName].OscOutActions[item.ID].ExecutionDuration = Convert.ToDouble(item.executionDuration.Value);
                MainClass.Instance.SaveConfig();
            };
            item.oscValue.TextChanged += (o, e) =>
            {
                var parsed = item.oscValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnCommand[CommandName].OscOutActions[item.ID].Value;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnCommand[CommandName].OscOutActions[item.ID].Value = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.defaultValue.TextChanged += (o, e) =>
            {
                var parsed = item.defaultValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnCommand[CommandName].OscOutActions[item.ID].DefaultValue;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnCommand[CommandName].OscOutActions[item.ID].DefaultValue = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.removeAction.Click += (o, e) =>
            {
                if (MessageBox.Show($"Do you want to remove action {item.ActionName}?", "Remove action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    return;

                MainClass.Instance.Config.Events.OnCommand[CommandName].OscOutActions.RemoveAt(item.ID);
                MainClass.Instance.SaveConfig();
                item.ParentPanel.RemoveAction(item);
            };

            item.ID = id;
            item.ActionName = actionName;
            item.ExecutionDuration = Convert.ToDecimal(duration);
            item.Value = value;
            item.DefaultValue = defaultValue;
            oscActions.Controls.Add(item);

            if (scroll)
                oscActions.ScrollControlIntoView(item);
        }

        //
        bool _normalUser;
        [Category("Command Info")]
        public bool NormalUser
        {
            get
            {
                return _normalUser;
            }
            set
            {
                _normalUser = value;
                normalUser.Switched = value;
            }
        }

        private void OnNormalUserChanged(object sender)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].NormalAccess = normalUser.Switched;
            MainClass.Instance.SaveConfig();
        }
        //
        bool _subscriber;
        [Category("Command Info")]
        public bool Subscriber
        {
            get
            {
                return _subscriber;
            }
            set
            {
                _subscriber = value;
                subscriber.Switched = value;
            }
        }

        private void OnSubscriberChanged(object sender)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].SubAccess = subscriber.Switched;
            MainClass.Instance.SaveConfig();
        }
        //

        int _months;
        public int SubscriberMonths
        {
            get
            {
                return _months;
            }
            set
            {
                _months = value;
                minimumMonths.Value = _months;
            }
        }

        private void OnMinimumMonthsChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].SubMonths = (int)minimumMonths.Value;
            MainClass.Instance.SaveConfig();
        }
        //
        bool _moderator;
        [Category("Command Info")]
        public bool Moderator
        {
            get
            {
                return _moderator;
            }
            set
            {
                _moderator = value;
                moderator.Switched = value;
            }
        }

        private void OnModeratorChanged(object sender)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].ModAccess = moderator.Switched;
            MainClass.Instance.SaveConfig();
        }
        //
        bool _streamer;
        [Category("Command Info")]
        public bool Streamer
        {
            get
            {
                return _streamer;
            }
            set
            {
                _streamer = value;
                streamer.Switched = value;
            }
        }


        private void OnStreamerChanged(object sender)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].BroadcasterAccess = moderator.Switched;
            MainClass.Instance.SaveConfig();
        }
        //
        bool _vip;
        [Category("Command Info")]
        public bool Vip
        {
            get
            {
                return _vip;
            }
            set
            {
                _vip = value;
                vip.Switched = value;
            }
        }

        private void OnVipChanged(object sender)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].VipAccess = vip.Switched;
            MainClass.Instance.SaveConfig();
        }
        //

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
                randomAction.Switched = value;
            }
        }

        private void OnRandomChanged(object sender)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnCommand[CommandName].ExecuteRandomAction = randomAction.Switched;
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

                if (_oscActions.Count == 0 && oscActions.Controls.Count != 0)
                {
                    oscActions.Controls.Clear();
                    return;
                }

                for (int x = 0; x < _oscActions.Count; x++)
                {
                    AddNewAction(x, _oscActions[x].ActionName, _oscActions[x].ExecutionDuration, _oscActions[x].Value != null ? _oscActions[x].Value.ToString() : string.Empty, _oscActions[x].DefaultValue != null ? _oscActions[x].DefaultValue.ToString() : string.Empty);
                }
            }
        }

        private void newOscAction_Click(object sender, EventArgs e)
        {
            if (_currentAddOscWindow != null)
            {
                _currentAddOscWindow.Close();
                _currentAddOscWindow.Dispose();
                _currentAddOscWindow = null;
            }

            var control = new CreateOscActionDialog();
            control.confirmButton.Click += (o, e) =>
            {
                AddNewAction(-1, control.actionName.Text, (int)control.executionDuration.Value, control.value.Text, control.defaultValue.Text, true);
                control.ParentForm.Close();
            };

            _currentAddOscWindow = new PoisonTaskWindow(0, control)
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
    }
}
