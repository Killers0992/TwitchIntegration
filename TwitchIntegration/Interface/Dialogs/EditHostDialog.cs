using ReaLTaiizor.Enum.Poison;
using TwitchIntegration.Interfaces;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface.Dialogs
{
    public partial class EditHostDialog : PoisonUserControl, IActionRemovable
    {
        private bool _isUpdating;
        private HostItem _mainPanel;
        private PoisonTaskWindow _currentAddOscWindow;

        public EditHostDialog(HostItem panel)
        {
            _mainPanel = panel;
            InitializeComponent();

            minimumBits.ValueChanged += OnMinimumViewersChanged;
            maxiumumBits.ValueChanged += OnMaximumViewersChanged;

            randomAction.SwitchedChanged += OnRandomChanged;

            globalH.ValueChanged += OnGlobalChanged;
            globalM.ValueChanged += OnGlobalChanged;
            globalS.ValueChanged += OnGlobalChanged;

            ID = _mainPanel.ItemIndex;
            Init();
        }

        private void OnGlobalChanged(object sender, EventArgs e)
        {
            MainClass.Instance.Config.Events.OnBeingHosted[ID].GlobalDelay = new TimeSpan((int)globalH.Value, (int)globalM.Value, (int)globalS.Value);
        }

        public int ID { get; set; }

        public void Init()
        {
            _isUpdating = true;
            MinimumViewers = MainClass.Instance.Config.Events.OnBeingHosted[ID].MinViewers;
            MaximumViewers = MainClass.Instance.Config.Events.OnBeingHosted[ID].MaxViewers;

            RandomExecution = MainClass.Instance.Config.Events.OnBeingHosted[ID].ExecuteRandomAction;

            globalH.Value = MainClass.Instance.Config.Events.OnBeingHosted[ID].GlobalDelay.Hours;
            globalM.Value = MainClass.Instance.Config.Events.OnBeingHosted[ID].GlobalDelay.Minutes;
            globalS.Value = MainClass.Instance.Config.Events.OnBeingHosted[ID].GlobalDelay.Seconds;

            LoadActions();
            _isUpdating = false;
        }

        public void LoadActions()
        {
            OscActions = new List<OscOutAction>();
            OscActions = MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions;
        }

        public void RemoveAction(Control control)
        {
            oscActions.Controls.Remove(control);
        }

        public void AddNewAction(int id, string actionName, double duration, string value, string defaultValue, bool scroll = false)
        {
            if (id == -1)
            {
                MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions.Add(new OscOutAction()
                {
                    ActionName = actionName,
                    ExecutionDuration = duration,
                    Value = value.ConvertStringToObject(),
                    DefaultValue = defaultValue.ConvertStringToObject(),
                });
                id = MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions.Count - 1;
                MainClass.Instance.SaveConfig();
            }

            var item = new OscItem(this);
            item.ID = id;

            item.actionName.LostFocus += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions[item.ID].ActionName = item.actionName.Text;
                MainClass.Instance.SaveConfig();
            };
            item.executionDuration.ValueChanged += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions[item.ID].ExecutionDuration = Convert.ToDouble(item.executionDuration.Value); ;
                MainClass.Instance.SaveConfig();
            };
            item.oscValue.TextChanged += (o, e) =>
            {
                var parsed = item.oscValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions[item.ID].Value;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions[item.ID].Value = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.defaultValue.TextChanged += (o, e) =>
            {
                var parsed = item.defaultValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions[item.ID].DefaultValue;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions[item.ID].DefaultValue = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.removeAction.Click += (o, e) =>
            {
                if (MessageBox.Show($"Do you want to remove action {item.ActionName}?", "Remove action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    return;

                MainClass.Instance.Config.Events.OnBeingHosted[ID].OscOutActions.RemoveAt(item.ID);
                MainClass.Instance.SaveConfig();
                item.ParentPanel.RemoveAction(item);
            };

            item.ActionName = actionName;
            item.ExecutionDuration = Convert.ToDecimal(duration);
            item.Value = value;
            item.DefaultValue = defaultValue;
            oscActions.Controls.Add(item);

            if (scroll)
                oscActions.ScrollControlIntoView(item);
        }

        int _minimumViewers;
        public int MinimumViewers
        {
            get
            {
                return _minimumViewers;
            }
            set
            {
                _minimumViewers = value;
                minimumBits.Value = _minimumViewers;
            }
        }

        private void OnMinimumViewersChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnBeingHosted[ID].MinViewers = (int)minimumBits.Value;
            MainClass.Instance.SaveConfig();

            _mainPanel.UpdateItem(true);
        }

        int _maximumViewers;
        public int MaximumViewers
        {
            get
            {
                return _maximumViewers;
            }
            set
            {
                _maximumViewers = value;
                maxiumumBits.Value = _maximumViewers;
            }
        }

        private void OnMaximumViewersChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnBeingHosted[ID].MaxViewers = (int)maxiumumBits.Value;
            MainClass.Instance.SaveConfig();

            _mainPanel.UpdateItem(true);
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
            MainClass.Instance.Config.Events.OnBeingHosted[ID].ExecuteRandomAction = randomAction.Switched;
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
                AddNewAction(-1, control.actionName.Text, control.executionDuration.Value, control.value.Text, control.defaultValue.Text, true);
                control.ParentForm.Close();
            };

            _currentAddOscWindow = new PoisonTaskWindow(0, control)
            {
                Text = "Add OSC Action",

                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,

                Movable = true,

                StartPosition = FormStartPosition.CenterScreen,

                CustomSize = true,
                Size = new Size(325, 282),

                Theme = ThemeStyle.Dark,
                Style = ColorStyle.Magenta,
            };
            _currentAddOscWindow.Show();
        }
    }
}
