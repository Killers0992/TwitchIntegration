using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using System.Reflection;
using TwitchIntegration.Interface.Tabs;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface
{
    public partial class MainPanel : PoisonUserControl
    {
        public static event EventHandler<StatusChangeArgs> StatusChanged;

        public static bool Loaded;
        public static bool Initialized;
        public static bool ShowLogin;

        private PoisonTaskWindow _currentCreateCommandWindow;
        private PoisonTaskWindow _currentCreateRewardWindow;
        private PoisonTaskWindow _currentCreateSubWindow;

        public static void OnStatusChanged(StatusChangeArgs e)
        {
            if (StatusChanged != null)
                StatusChanged(null, e);
        }

        public MainPanel()
        {
            InitializeComponent();
            StatusChanged += new EventHandler<StatusChangeArgs>(OnStatusChanged);
            version.Text = MainClass.Instance.Version.ToString(3);
            debugSwitch.Switched = MainClass.Instance.Config.Debug;
            twitchOAuth.Text = MainClass.Instance.Config.TwitchOAuth;
            Loaded = true;

            debugSwitch.SwitchedChanged += OnDebugChanged;
            twitchOAuth.LostFocus += OnOAuthChanged;
            twitchOAuth.KeyDown += OnOAuthKeyDown;

            followTab.Controls.Add(new FollowTab());
            BanTab.Controls.Add(new BanTab());
            TimedoutTab.Controls.Add(new TimedOutTab());

            openFileDialog1.InitialDirectory = AppContext.BaseDirectory;
        }

        void OnOAuthKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActiveControl = null;
        }

        void OnOAuthChanged(object sender, EventArgs e)
        {
            MainClass.Instance.Config.TwitchOAuth = twitchOAuth.Text;
            MainClass.Instance.SaveConfig();

            TwitchBot.WaitingForAction = false;
        }

        void OnDebugChanged(object sender)
        {
            MainClass.Instance.Config.Debug = debugSwitch.Switched;
            MainClass.Instance.SaveConfig();
        }

        void OnStatusChanged(object sender, StatusChangeArgs e)
        {
            if (!Initialized) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnStatusChanged(sender, e);
                });
                return;
            }

            SetStatus(e.IsPubSub, e.IsConnected);
        }

        public void SetStatus(bool isPubsub, bool isConnected)
        {
            if (isPubsub)
            {
                if (pubsubSpinner.EnsureVisible)
                    pubsubSpinner.Visible = false;

                twitchPusSubStatus.Text = isConnected ? "✔" : "❌";
                twitchPusSubStatus.ForeColor = isConnected ? Color.Green : Color.Red;
            }
            else
            {
                if (chatSpinner.EnsureVisible)
                    chatSpinner.Visible = false;

                twitchChatStatus.Text = isConnected ? "✔" : "❌";
                twitchChatStatus.ForeColor = isConnected ? Color.Green : Color.Red;
            }
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            Initialized = true;
            SetStatus(true, TwitchBot.IsConnectedToTwitchPubSub);
            SetStatus(false, TwitchBot.IsConnectedToTwitchChat);

            //Tabs setup
            PopulateCommands();
            PopulateRewards();
            PopulateSubscriptions();
            PopulateBits();
            PopulateHost();
        }

        #region Tabs
        #region Commands
        public void PopulateCommands()
        {
            foreach (var cmd in MainClass.Instance.Config.Events.OnCommand)
                AddCommand(cmd.Key);
        }

        public void AddCommand(string commandName)
        {
            if (!MainClass.Instance.Config.Events.OnCommand.ContainsKey(commandName))
            {
                MainClass.Instance.Config.Events.OnCommand.Add(commandName, new TwitchCommand()
                {
                    OscOutActions = new List<OscOutAction>(),
                });
                MainClass.Instance.SaveConfig();
            }

            var cmdItem = new CommandItem(this);
            cmdItem.Width = commands.Width - 25;

            cmdItem.CommandName = commandName;

            commands.Controls.Add(cmdItem);
        }

        public void RemoveCommand(Control control)
        {
            commands.Controls.Remove(control);
        }

        private void addNewCommand_Click(object sender, EventArgs e)
        {
            if (_currentCreateCommandWindow != null)
            {
                _currentCreateCommandWindow.Close();
                _currentCreateCommandWindow.Dispose();
                _currentCreateCommandWindow = null;
            }

            _currentCreateCommandWindow = new PoisonTaskWindow(0, new CreateCommandDialog(this))
            {
                Text = "Add Command",

                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,

                Movable = true,

                StartPosition = FormStartPosition.CenterScreen,

                CustomSize = true,
                Size = new Size(325, 200),

                Theme = ThemeStyle.Dark,
                Style = ColorStyle.Magenta,
            };
            _currentCreateCommandWindow.Show();
        }
        #endregion

        #region Subscriptions
        public void PopulateSubscriptions()
        {
            for (int x = 0; x < MainClass.Instance.Config.Events.OnReSubscriber.Count; x++)
                AddReSubscription(x);

            for (int x = 0; x < MainClass.Instance.Config.Events.OnNewSubscriber.Count; x++)
                AddSubscription(x);
        }

        public void AddReSubscription(int id, bool createIfNew = false)
        {
            if (createIfNew)
            {
                MainClass.Instance.Config.Events.OnReSubscriber.Add(new TwitchReSub()
                {
                    OscOutActions = new List<OscOutAction>(),
                    SubPlans = new List<SubscriptionPlan>() { SubscriptionPlan.Tier1 },
                });

                id = MainClass.Instance.Config.Events.OnReSubscriber.Count - 1;

                MainClass.Instance.SaveConfig();
            }

            var rewItem = new SubItem(this, id, Enums.SubscriptionType.ReSub);
            rewItem.Width = subscriptions.Width - 25;

            subscriptions.Controls.Add(rewItem);
        }

        public void AddSubscription(int id, bool createIfNew = false)
        {
            if (createIfNew)
            {
                MainClass.Instance.Config.Events.OnNewSubscriber.Add(new TwitchNewSub()
                {
                    OscOutActions = new List<OscOutAction>(),
                    SubPlans = new List<SubscriptionPlan>() { SubscriptionPlan.Tier1 },
                });

                id = MainClass.Instance.Config.Events.OnNewSubscriber.Count - 1;

                MainClass.Instance.SaveConfig();
            }

            var rewItem = new SubItem(this, id, Enums.SubscriptionType.NewSub);
            rewItem.Width = subscriptions.Width - 25;

            subscriptions.Controls.Add(rewItem);
        }

        public void RemoveSubscription(Control control)
        {
            subscriptions.Controls.Remove(control);
            RefreshSubscriptionIndexes();
        }

        public void RefreshSubscriptionIndexes()
        {
            int reSubsIndex = MainClass.Instance.Config.Events.OnReSubscriber.Count;
            int newSubsIndex = MainClass.Instance.Config.Events.OnNewSubscriber.Count;

            for(int x = 0; x < subscriptions.Controls.Count; x++)
            {
                if (subscriptions.Controls[x] is not SubItem item) return;

                if (reSubsIndex != 0)
                {
                    item.ItemIndex = reSubsIndex-1;
                    item.SubType = Enums.SubscriptionType.ReSub;
                }
                else if (newSubsIndex != 0)
                {
                    item.ItemIndex = newSubsIndex-1;
                    item.SubType = Enums.SubscriptionType.NewSub;
                }

                item.UpdateItem();
            }
        }

        private void addSub_Click(object sender, EventArgs e)
        {
            if (_currentCreateSubWindow != null)
            {
                _currentCreateSubWindow.Close();
                _currentCreateSubWindow.Dispose();
                _currentCreateSubWindow = null;
            }

            _currentCreateSubWindow = new PoisonTaskWindow(0, new CreateSubscriptionDialog(this))
            {
                Text = "Add Subscription",

                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,

                Movable = true,

                StartPosition = FormStartPosition.CenterScreen,

                CustomSize = true,
                Size = new Size(385, 180),

                Theme = ThemeStyle.Dark,
                Style = ColorStyle.Magenta,
            };
            _currentCreateSubWindow.Show();
        }
#endregion

        #region Rewards
        public void PopulateRewards()
        {
            foreach (var rew in MainClass.Instance.Config.Events.OnReward)
                AddReward(rew.Key, rew.Value.RewardName);
        }

        public void AddReward(string rewardID, string rewardName)
        {
            if (!MainClass.Instance.Config.Events.OnReward.ContainsKey(rewardID))
            {
                MainClass.Instance.Config.Events.OnReward.Add(rewardID, new TwitchReward()
                {
                    OscOutActions = new List<OscOutAction>(),
                    RewardName = rewardName
                });
                MainClass.Instance.SaveConfig();
            }

            var rewItem = new RewarddItem(this);
            rewItem.Width = rewards.Width - 25;

            rewItem.RewardID = rewardID;
            rewItem.RewardName = rewardName + $" ({rewardID})";

            rewards.Controls.Add(rewItem);
        }

        public void RemoveReward(Control control)
        {
            rewards.Controls.Remove(control);
        }

        private void addReward_Click(object sender, EventArgs e)
        {
            if (_currentCreateRewardWindow != null)
            {
                _currentCreateRewardWindow.Close();
                _currentCreateRewardWindow.Dispose();
                _currentCreateRewardWindow = null;
            }

            _currentCreateRewardWindow = new PoisonTaskWindow(0, new CreateRewardDialog(this))
            {
                Text = "Add Reward",

                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,

                Movable = true,

                StartPosition = FormStartPosition.CenterScreen,

                CustomSize = true,
                Size = new Size(385, 180),

                Theme = ThemeStyle.Dark,
                Style = ColorStyle.Magenta,
            };
            _currentCreateRewardWindow.Show();
        }
        #endregion

        #region Bits
        public void PopulateBits()
        {
            for (int x = 0; x < MainClass.Instance.Config.Events.OnReceiveBits.Count; x++)
                AddBits(x);
        }

        public void AddBits(int id, bool createIfNew = false)
        {
            if (createIfNew)
            {
                MainClass.Instance.Config.Events.OnReceiveBits.Add(new TwitchBits()
                {
                    OscOutActions = new List<OscOutAction>(),
                });

                id = MainClass.Instance.Config.Events.OnReceiveBits.Count - 1;

                MainClass.Instance.SaveConfig();
            }

            var rewItem = new BitsItem(this, id);
            rewItem.Width = subscriptions.Width - 27;

            bits.Controls.Add(rewItem);
        }

        public void RemoveBits(Control control)
        {
            bits.Controls.Remove(control);
            RefreshBitsIndexes();
        }

        public void RefreshBitsIndexes()
        {
            int bitsIndex = MainClass.Instance.Config.Events.OnReceiveBits.Count;

            for (int x = 0; x < bits.Controls.Count; x++)
            {
                if (bits.Controls[x] is not BitsItem item) return;

                if (bitsIndex != 0)
                {
                    item.ItemIndex = bitsIndex-1;
                }

                item.UpdateItem();
            }
        }

        private void addBits_Click(object sender, EventArgs e)
        {
            AddBits(0, true);
        }
        #endregion

        #region Host
        public void PopulateHost()
        {
            for (int x = 0; x < MainClass.Instance.Config.Events.OnBeingHosted.Count; x++)
                AddHost(x);
        }

        public void AddHost(int id, bool createIfNew = false)
        {
            if (createIfNew)
            {
                MainClass.Instance.Config.Events.OnBeingHosted.Add(new TwitchHost()
                {
                    OscOutActions = new List<OscOutAction>(),
                });

                id = MainClass.Instance.Config.Events.OnBeingHosted.Count - 1;

                MainClass.Instance.SaveConfig();
            }

            var rewItem = new HostItem(this, id);
            rewItem.Width = hosts.Width - 27;

            hosts.Controls.Add(rewItem);
        }

        public void RemoveHost(Control control)
        {
            hosts.Controls.Remove(control);
            RefreshHostsIndexes();
        }

        public void RefreshHostsIndexes()
        {
            int hostsIndex = MainClass.Instance.Config.Events.OnBeingHosted.Count;

            for (int x = 0; x < hosts.Controls.Count; x++)
            {
                if (hosts.Controls[x] is not HostItem item) return;

                if (hostsIndex != 0)
                {
                    item.ItemIndex = hostsIndex-1;
                }

                item.UpdateItem();
            }
        }


        private void addhost_Click(object sender, EventArgs e)
        {
            AddHost(0, true);
        }
        #endregion

        #region Follow

        #endregion
        #endregion

        #region Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ShowLogin && !twitchLogin.Visible)
            {
                ShowLogin = false;
                twitchLogin.Visible = true;
                return;
            }

            if (TwitchBot.IsConnectedToTwitchChat && twitchLogin.Visible)
            {
                twitchLogin.Visible = false;
            }
        }
        #endregion

        private void poisonButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Config.Import(openFileDialog1.FileName);
                MessageBox.Show("Config imported, restart application!");
            }
        }
    }
}