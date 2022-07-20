﻿using TwitchIntegration.Interfaces;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface.Dialogs
{
    public partial class EditRewardDialog : PoisonUserControl, IActionRemovable
    {
        private RewarddItem _mainPanel;
        private PoisonTaskWindow _currentAddOscWindow;
        private PoisonTaskWindow _currentRewardWindow;

        public EditRewardDialog(RewarddItem panel)
        {
            _mainPanel = panel;
            InitializeComponent();

            randomAction.SwitchedChanged += OnRandomChanged;

            globalH.ValueChanged += OnGlobalChanged;
            globalM.ValueChanged += OnGlobalChanged;
            globalS.ValueChanged += OnGlobalChanged;

            userH.ValueChanged += OnUserChanged;
            userM.ValueChanged += OnUserChanged;
            userS.ValueChanged += OnUserChanged;

            RewardID = _mainPanel.RewardID;
            Init();
        }

        private void OnGlobalChanged(object sender, EventArgs e)
        {
            MainClass.Instance.Config.Events.OnReward[RewardID].GlobalDelay = new TimeSpan((int)globalH.Value, (int)globalM.Value, (int)globalS.Value);
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            MainClass.Instance.Config.Events.OnReward[RewardID].DelayPerUser = new TimeSpan((int)userH.Value, (int)userM.Value, (int)userS.Value);
        }


        string _rewardId;
        public string RewardID
        {
            get
            {
                return _rewardId;
            }
            set
            {
                _rewardId = value;
                if (rewardId.Text != value)
                    rewardId.Text = value;
            }
        }

        public void Init()
        {
            RandomExecution = MainClass.Instance.Config.Events.OnReward[RewardID].ExecuteRandomAction;
            globalH.Value = MainClass.Instance.Config.Events.OnReward[RewardID].GlobalDelay.Hours;
            globalM.Value = MainClass.Instance.Config.Events.OnReward[RewardID].GlobalDelay.Minutes;
            globalS.Value = MainClass.Instance.Config.Events.OnReward[RewardID].GlobalDelay.Seconds;

            userH.Value = MainClass.Instance.Config.Events.OnReward[RewardID].DelayPerUser.Hours;
            userM.Value = MainClass.Instance.Config.Events.OnReward[RewardID].DelayPerUser.Minutes;
            userS.Value = MainClass.Instance.Config.Events.OnReward[RewardID].DelayPerUser.Seconds;

            LoadActions();
        }

        public void LoadActions()
        {
            OscActions = new List<OscOutAction>();
            OscActions = MainClass.Instance.Config.Events.OnReward[RewardID].OscOutActions;
        }

        public void RemoveAction(Control control)
        {
            oscActions.Controls.Remove(control);
        }

        public void AddNewAction(int id, string actionName, double duration, string value, string defaultValue, bool scroll = false)
        {
            if (id == -1)
            {
                if (MainClass.Instance.Config.Events.OnReward.TryGetValue(RewardID, out TwitchReward cmd))
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

            item.actionName.LostFocus += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnReward[RewardID].OscOutActions[item.ID].ActionName = item.actionName.Text;
                MainClass.Instance.SaveConfig();
            };
            item.executionDuration.TextChanged += (o, e) =>
            {
                MainClass.Instance.Config.Events.OnCommand[RewardID].OscOutActions[item.ID].ExecutionDuration = Convert.ToDouble(item.executionDuration.Value);
                MainClass.Instance.SaveConfig();
            };
            item.oscValue.TextChanged += (o, e) =>
            {
                var parsed = item.oscValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnReward[RewardID].OscOutActions[item.ID].Value;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnReward[RewardID].OscOutActions[item.ID].Value = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.defaultValue.TextChanged += (o, e) =>
            {
                var parsed = item.defaultValue.Text.ConvertStringToObject();
                var currentValue = MainClass.Instance.Config.Events.OnReward[RewardID].OscOutActions[item.ID].DefaultValue;

                if (currentValue == parsed)
                    return;

                MainClass.Instance.Config.Events.OnReward[RewardID].OscOutActions[item.ID].DefaultValue = parsed;
                MainClass.Instance.SaveConfig();
            };
            item.removeAction.Click += (o, e) =>
            {
                if (MessageBox.Show($"Do you want to remove action {item.ActionName}?", "Remove action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    return;

                MainClass.Instance.Config.Events.OnReward[RewardID].OscOutActions.RemoveAt(item.ID);
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
            MainClass.Instance.Config.Events.OnReward[RewardID].ExecuteRandomAction = randomAction.Switched;
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

        private void changeReward_Click(object sender, EventArgs e)
        {
            if (_currentRewardWindow != null)
            {
                _currentRewardWindow.Close();
                _currentRewardWindow.Dispose();
                _currentRewardWindow = null;
            }

            var control = new CreateRewardDialog(null, false);
            control.confirmButton.Click += (ev, o) =>
            {
                var save = MainClass.Instance.Config.Events.OnReward[RewardID];
                if (RewardID == CreateRewardDialog.LastReward.Id) return;
                MainClass.Instance.Config.Events.OnReward.Remove(RewardID);

                save.RewardName = CreateRewardDialog.LastReward.Title;
                MainClass.Instance.Config.Events.OnReward.Add(CreateRewardDialog.LastReward.Id, save);

                this.RewardID = CreateRewardDialog.LastReward.Id;

                _mainPanel.RewardID = RewardID;
                _mainPanel.RewardName = save.RewardName + $" ({RewardID})";
            };

            _currentRewardWindow = new PoisonTaskWindow(0, control)
            {
                Text = "Assign reward",
                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,
                Movable = true,
                WindowState = FormWindowState.Normal,
            };
            _currentRewardWindow.Controls[0].Parent = _currentRewardWindow;

            _currentRewardWindow.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            _currentRewardWindow.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            _currentRewardWindow.Show();
            _currentRewardWindow.Size = new System.Drawing.Size(385, 180);
        }
    }
}
