using TwitchIntegration.Interfaces;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface.Tabs
{
    public partial class BanTab : PoisonUserControl, IActionRemovable
    {
        private bool _isUpdating;
        private PoisonTaskWindow _currentAddOscWindow;

        public BanTab()
        {
            InitializeComponent();

            randomAction.SwitchedChanged += OnRandomChanged;

            globalH.ValueChanged += OnGlobalChanged;
            globalM.ValueChanged += OnGlobalChanged;
            globalS.ValueChanged += OnGlobalChanged;

            Load += (o, ev) =>
            {
                Init();
            };
        }

        private void OnGlobalChanged(object sender, EventArgs e)
        {
            MainClass.Instance.Config.Events.OnUserBanned.GlobalDelay = new TimeSpan((int)globalH.Value, (int)globalM.Value, (int)globalS.Value);
        }

        public void Init()
        {
            _isUpdating = true;
            RandomExecution = MainClass.Instance.Config.Events.OnUserBanned.ExecuteRandomAction;

            globalH.Value = MainClass.Instance.Config.Events.OnUserBanned.GlobalDelay.Hours;
            globalM.Value = MainClass.Instance.Config.Events.OnUserBanned.GlobalDelay.Minutes;
            globalS.Value = MainClass.Instance.Config.Events.OnUserBanned.GlobalDelay.Seconds;

            LoadActions();
            _isUpdating = false;
        }

        public void LoadActions()
        {
            OscActions = new List<OscOutAction>();
            OscActions = MainClass.Instance.Config.Events.OnUserBanned.OscOutActions;
        }

        public void RemoveAction(Control control)
        {
            oscActions.Controls.Remove(control);
        }

        public void AddNewAction(int id, string actionName, int duration, string value, string defaultValue, bool scroll = false)
        {
            if (id == -1)
            {
                MainClass.Instance.Config.Events.OnUserBanned.OscOutActions.Add(new OscOutAction()
                {
                    ActionName = actionName,
                    ExecutionDuration = duration,
                    Value = value.ConvertStringToObject(),
                    DefaultValue = defaultValue.ConvertStringToObject(),
                });
                id = MainClass.Instance.Config.Events.OnUserBanned.OscOutActions.Count - 1;
                MainClass.Instance.SaveConfig();
            }

            var item = new OscItem(this);
            item.ID = id;

            item.actionName.LostFocus += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnUserBanned.OscOutActions[item.ID].ActionName = item.actionName.Text;
                MainClass.Instance.SaveConfig();
            };
            item.executionDuration.TextChanged += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnUserBanned.OscOutActions[item.ID].ExecutionDuration = (int)item.executionDuration.Value;
                MainClass.Instance.SaveConfig();
            };
            item.oscValue.TextChanged += (o, e) =>
            {
                var parsed = item.oscValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnUserBanned.OscOutActions[item.ID].Value;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnUserBanned.OscOutActions[item.ID].Value = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.defaultValue.TextChanged += (o, e) =>
            {
                var parsed = item.defaultValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnUserBanned.OscOutActions[item.ID].DefaultValue;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnUserBanned.OscOutActions[item.ID].DefaultValue = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.removeAction.Click += (o, e) =>
            {
                if (MessageBox.Show($"Do you want to remove action {item.ActionName}?", "Remove action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    return;

                MainClass.Instance.Config.Events.OnUserBanned.OscOutActions.RemoveAt(item.ID);
                MainClass.Instance.SaveConfig();
                item.ParentPanel.RemoveAction(item);
            };

            item.ActionName = actionName;
            item.ExecutionDuration = duration;
            item.Value = value;
            item.DefaultValue = defaultValue;
            oscActions.Controls.Add(item);

            if (scroll)
                oscActions.ScrollControlIntoView(item);
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
                randomAction.Switched = value;
            }
        }

        private void OnRandomChanged(object sender)
        {
            MainClass.Instance.Config.Events.OnUserBanned.ExecuteRandomAction = randomAction.Switched;
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
