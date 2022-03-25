using ReaLTaiizor.Controls;
using TwitchIntegration.Models.Twitch;

namespace TwitchIntegration.Interface
{
    public partial class MainPanel : PoisonUserControl
    {
        public static event EventHandler<StatusChangeArgs> StatusChanged;

        public static bool Loaded;
        public static bool Initialized;


        private PoisonTaskWindow _currentCreateCommandWindow;

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
            PopulateCommands();
        }

        public void RemoveCommand(Control control)
        {
            commands.Controls.Remove(control);
        }

        public void AddCommand(string commandName, bool normalAccess = true, bool streamerAccess = false, bool subAccess = false, bool vipAccess = false, bool randomExecution = false, List<OscOutAction> actions = null)
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
            cmdItem.NormalAccess = normalAccess;
            cmdItem.StreamerAccess = streamerAccess;
            cmdItem.SubAccess = subAccess;
            cmdItem.VipAccess = vipAccess;
            cmdItem.RandomExecution = randomExecution;
            cmdItem.OscActions = actions ?? new List<OscOutAction>();

            commands.Controls.Add(cmdItem);
        }

        public void PopulateCommands()
        {
            foreach(var cmd in MainClass.Instance.Config.Events.OnCommand)
            {
                AddCommand(cmd.Key, 
                    cmd.Value.NormalAccess,
                    cmd.Value.BroadcasterAccess,
                    cmd.Value.SubAccess,
                    cmd.Value.VipAccess,
                    cmd.Value.ExecuteRandomAction,
                    cmd.Value.OscOutActions);
            }
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
                WindowState = FormWindowState.Normal,
            };
            _currentCreateCommandWindow.Controls[0].Parent = _currentCreateCommandWindow;

            _currentCreateCommandWindow.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            _currentCreateCommandWindow.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            _currentCreateCommandWindow.Show();
            _currentCreateCommandWindow.Size = new System.Drawing.Size(325, 200);
        }
    }
}