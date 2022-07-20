using TwitchIntegration.Interfaces;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface.Dialogs
{
    public partial class EditReSubscriptionDialog : PoisonUserControl, IActionRemovable
    {
        private bool _isUpdating;
        private SubItem _mainPanel;
        private PoisonTaskWindow _currentAddOscWindow;

        public EditReSubscriptionDialog(SubItem panel)
        {
            _mainPanel = panel;
            InitializeComponent();

            tier1.SwitchedChanged += UpdatePlans;
            tier2.SwitchedChanged += UpdatePlans;
            tier3.SwitchedChanged += UpdatePlans;
            prime.SwitchedChanged += UpdatePlans;

            minimumMonths.ValueChanged += OnMinimumMonthsChanged;
            maxiumumMonths.ValueChanged += OnMaximumMonthsChanged;

            randomAction.SwitchedChanged += OnRandomChanged;

            globalH.ValueChanged += OnGlobalChanged;
            globalM.ValueChanged += OnGlobalChanged;
            globalS.ValueChanged += OnGlobalChanged;

            ID = _mainPanel.ItemIndex;
            Init();
        }

        private void OnGlobalChanged(object sender, EventArgs e)
        {
            MainClass.Instance.Config.Events.OnReSubscriber[ID].GlobalDelay = new TimeSpan((int)globalH.Value, (int)globalM.Value, (int)globalS.Value);
        }

        public int ID { get; set; }

        public void Init()
        {
            _isUpdating = true;
            Tier1 = MainClass.Instance.Config.Events.OnReSubscriber[ID].SubPlans.Contains(SubscriptionPlan.Tier1);
            Tier2 = MainClass.Instance.Config.Events.OnReSubscriber[ID].SubPlans.Contains(SubscriptionPlan.Tier2);
            Tier3 = MainClass.Instance.Config.Events.OnReSubscriber[ID].SubPlans.Contains(SubscriptionPlan.Tier3);
            Prime = MainClass.Instance.Config.Events.OnReSubscriber[ID].SubPlans.Contains(SubscriptionPlan.Prime);

            MinimumMonths = MainClass.Instance.Config.Events.OnReSubscriber[ID].MinMonths;
            MaximumMonths = MainClass.Instance.Config.Events.OnReSubscriber[ID].MaxMonths;

            RandomExecution = MainClass.Instance.Config.Events.OnReSubscriber[ID].ExecuteRandomAction;

            globalH.Value = MainClass.Instance.Config.Events.OnReSubscriber[ID].GlobalDelay.Hours;
            globalM.Value = MainClass.Instance.Config.Events.OnReSubscriber[ID].GlobalDelay.Minutes;
            globalS.Value = MainClass.Instance.Config.Events.OnReSubscriber[ID].GlobalDelay.Seconds;

            LoadActions();
            _isUpdating = false;
        }

        public void LoadActions()
        {
            OscActions = new List<OscOutAction>();
            OscActions = MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions;
        }

        public void RemoveAction(Control control)
        {
            oscActions.Controls.Remove(control);
        }

        public void AddNewAction(int id, string actionName, double duration, string value, string defaultValue, bool scroll = false)
        {
            if (id == -1)
            {
                MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions.Add(new OscOutAction()
                {
                    ActionName = actionName,
                    ExecutionDuration = duration,
                    Value = value.ConvertStringToObject(),
                    DefaultValue = defaultValue.ConvertStringToObject(),
                });
                id = MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions.Count - 1;
                MainClass.Instance.SaveConfig();
            }

            var item = new OscItem(this);
            item.ID = id;

            item.actionName.LostFocus += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions[item.ID].ActionName = item.actionName.Text;
                MainClass.Instance.SaveConfig();
            };
            item.executionDuration.TextChanged += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions[item.ID].ExecutionDuration = (int)item.executionDuration.Value;
                MainClass.Instance.SaveConfig();
            };
            item.oscValue.TextChanged += (o, e) =>
            {
                var parsed = item.oscValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions[item.ID].Value;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions[item.ID].Value = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.defaultValue.TextChanged += (o, e) =>
            {
                var parsed = item.defaultValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions[item.ID].DefaultValue;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions[item.ID].DefaultValue = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.removeAction.Click += (o, e) =>
            {
                if (MessageBox.Show($"Do you want to remove action {item.ActionName}?", "Remove action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    return;

                MainClass.Instance.Config.Events.OnReSubscriber[ID].OscOutActions.RemoveAt(item.ID);
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

        public void UpdatePlans(object sender)
        {
            if (_isUpdating) return;

            var newPlans = new List<SubscriptionPlan>();
            if (tier1.Switched)
                newPlans.Add(SubscriptionPlan.Tier1);
            if (tier2.Switched)
                newPlans.Add(SubscriptionPlan.Tier2);
            if (tier3.Switched)
                newPlans.Add(SubscriptionPlan.Tier3);
            if (prime.Switched)
                newPlans.Add(SubscriptionPlan.Prime);

            MainClass.Instance.Config.Events.OnReSubscriber[ID].SubPlans = newPlans;
            MainClass.Instance.SaveConfig();

            _mainPanel.UpdateItem(true);
        }

        //
        bool _tier1;
        [Category("Tier1 Info")]
        public bool Tier1
        {
            get
            {
                return _tier1;
            }
            set
            {
                _tier1 = value;
                tier1.Switched = value;
            }
        }

        bool _tier2;
        [Category("Tier2 Info")]
        public bool Tier2
        {
            get
            {
                return _tier2;
            }
            set
            {
                _tier2 = value;
                tier2.Switched = value;
            }
        }
        //
        bool _tier3;
        [Category("Tier3 Info")]
        public bool Tier3
        {
            get
            {
                return _tier3;
            }
            set
            {
                _tier3 = value;
                tier3.Switched = value;
            }
        }

        bool _prime;
        [Category("Prime Info")]
        public bool Prime
        {
            get
            {
                return _prime;
            }
            set
            {
                _prime = value;
                prime.Switched = value;
            }
        }

        int _minimumMonths;
        public int MinimumMonths
        {
            get
            {
                return _minimumMonths;
            }
            set
            {
                _minimumMonths = value;
                minimumMonths.Value = _minimumMonths;
            }
        }

        private void OnMinimumMonthsChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnReSubscriber[ID].MinMonths = (int)minimumMonths.Value;
            MainClass.Instance.SaveConfig();

            _mainPanel.UpdateItem(true);
        }

        int _maximumMonths;
        public int MaximumMonths
        {
            get
            {
                return _maximumMonths;
            }
            set
            {
                _maximumMonths = value;
                maxiumumMonths.Value = _maximumMonths;
            }
        }

        private void OnMaximumMonthsChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            MainClass.Instance.Config.Events.OnReSubscriber[ID].MaxMonths = (int)maxiumumMonths.Value;
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
            MainClass.Instance.Config.Events.OnReSubscriber[ID].ExecuteRandomAction = randomAction.Switched;
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
