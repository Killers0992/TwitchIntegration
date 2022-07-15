namespace TwitchIntegration.Interface
{
    partial class MainPanel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            this.MainTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.twitchLogin = new TwitchIntegration.Interface.TwitchLogin();
            this.pubsubSpinner = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.chatSpinner = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.version = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel23 = new ReaLTaiizor.Controls.PoisonLabel();
            this.twitchPusSubStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.twitchChatStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel9 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.CommandsTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.addNewCommand = new ReaLTaiizor.Controls.PoisonButton();
            this.commands = new System.Windows.Forms.FlowLayoutPanel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.RewardsTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.addReward = new ReaLTaiizor.Controls.PoisonButton();
            this.rewards = new System.Windows.Forms.FlowLayoutPanel();
            this.SubscriptionsTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.addSub = new ReaLTaiizor.Controls.PoisonButton();
            this.subscriptions = new System.Windows.Forms.FlowLayoutPanel();
            this.BitsTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.addBits = new ReaLTaiizor.Controls.PoisonButton();
            this.bits = new System.Windows.Forms.FlowLayoutPanel();
            this.HostTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.addhost = new ReaLTaiizor.Controls.PoisonButton();
            this.hosts = new System.Windows.Forms.FlowLayoutPanel();
            this.followTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.BanTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.TimedoutTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.SettingsTab = new ReaLTaiizor.Controls.PoisonTabPage();
            this.debugSwitch = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel15 = new ReaLTaiizor.Controls.PoisonLabel();
            this.twitchOAuth = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.poisonToolTip = new ReaLTaiizor.Controls.PoisonToolTip();
            this.poisonStyleExtender = new ReaLTaiizor.Controls.PoisonStyleExtender(this.components);
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.poisonTabControl1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.CommandsTab.SuspendLayout();
            this.commands.SuspendLayout();
            this.RewardsTab.SuspendLayout();
            this.SubscriptionsTab.SuspendLayout();
            this.BitsTab.SuspendLayout();
            this.HostTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonTabControl1
            // 
            this.poisonTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonTabControl1.Controls.Add(this.MainTab);
            this.poisonTabControl1.Controls.Add(this.CommandsTab);
            this.poisonTabControl1.Controls.Add(this.RewardsTab);
            this.poisonTabControl1.Controls.Add(this.SubscriptionsTab);
            this.poisonTabControl1.Controls.Add(this.BitsTab);
            this.poisonTabControl1.Controls.Add(this.HostTab);
            this.poisonTabControl1.Controls.Add(this.followTab);
            this.poisonTabControl1.Controls.Add(this.BanTab);
            this.poisonTabControl1.Controls.Add(this.TimedoutTab);
            this.poisonTabControl1.Controls.Add(this.SettingsTab);
            this.poisonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.poisonTabControl1.Name = "poisonTabControl1";
            this.poisonTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.poisonTabControl1.SelectedIndex = 0;
            this.poisonTabControl1.Size = new System.Drawing.Size(865, 303);
            this.poisonTabControl1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonTabControl1.TabIndex = 0;
            this.poisonTabControl1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonTabControl1.UseSelectable = true;
            // 
            // MainTab
            // 
            this.MainTab.AutoScroll = true;
            this.MainTab.Controls.Add(this.twitchLogin);
            this.MainTab.Controls.Add(this.pubsubSpinner);
            this.MainTab.Controls.Add(this.chatSpinner);
            this.MainTab.Controls.Add(this.version);
            this.MainTab.Controls.Add(this.poisonLabel23);
            this.MainTab.Controls.Add(this.twitchPusSubStatus);
            this.MainTab.Controls.Add(this.twitchChatStatus);
            this.MainTab.Controls.Add(this.poisonLabel8);
            this.MainTab.Controls.Add(this.poisonLabel9);
            this.MainTab.Controls.Add(this.poisonLabel1);
            this.MainTab.HorizontalScrollbar = true;
            this.MainTab.HorizontalScrollbarBarColor = true;
            this.MainTab.HorizontalScrollbarHighlightOnWheel = false;
            this.MainTab.HorizontalScrollbarSize = 10;
            this.MainTab.Location = new System.Drawing.Point(4, 38);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(25);
            this.MainTab.Size = new System.Drawing.Size(857, 261);
            this.MainTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main Controls";
            this.MainTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.MainTab.VerticalScrollbar = true;
            this.MainTab.VerticalScrollbarBarColor = true;
            this.MainTab.VerticalScrollbarHighlightOnWheel = false;
            this.MainTab.VerticalScrollbarSize = 10;
            // 
            // twitchLogin
            // 
            this.twitchLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.twitchLogin.Location = new System.Drawing.Point(0, 3);
            this.twitchLogin.Name = "twitchLogin";
            this.twitchLogin.Size = new System.Drawing.Size(854, 255);
            this.twitchLogin.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.twitchLogin.TabIndex = 16;
            this.twitchLogin.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.twitchLogin.UseSelectable = true;
            // 
            // pubsubSpinner
            // 
            this.pubsubSpinner.Location = new System.Drawing.Point(134, 103);
            this.pubsubSpinner.Maximum = 100;
            this.pubsubSpinner.Name = "pubsubSpinner";
            this.pubsubSpinner.Size = new System.Drawing.Size(20, 20);
            this.pubsubSpinner.Speed = 2F;
            this.pubsubSpinner.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.pubsubSpinner.TabIndex = 15;
            this.pubsubSpinner.Text = "poisonProgressSpinner5";
            this.pubsubSpinner.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.pubsubSpinner.UseSelectable = true;
            this.pubsubSpinner.Value = 90;
            // 
            // chatSpinner
            // 
            this.chatSpinner.Location = new System.Drawing.Point(134, 65);
            this.chatSpinner.Maximum = 100;
            this.chatSpinner.Name = "chatSpinner";
            this.chatSpinner.Size = new System.Drawing.Size(20, 20);
            this.chatSpinner.Speed = 2F;
            this.chatSpinner.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.chatSpinner.TabIndex = 14;
            this.chatSpinner.Text = "chatSpinner";
            this.chatSpinner.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.chatSpinner.UseSelectable = true;
            this.chatSpinner.Value = 90;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.version.Location = new System.Drawing.Point(115, 148);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(47, 25);
            this.version.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.version.TabIndex = 13;
            this.version.Text = "0.0.0";
            this.version.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel23
            // 
            this.poisonLabel23.AutoSize = true;
            this.poisonLabel23.Location = new System.Drawing.Point(28, 103);
            this.poisonLabel23.Name = "poisonLabel23";
            this.poisonLabel23.Size = new System.Drawing.Size(93, 19);
            this.poisonLabel23.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel23.TabIndex = 11;
            this.poisonLabel23.Text = "Twitch PubSub";
            this.poisonLabel23.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // twitchPusSubStatus
            // 
            this.twitchPusSubStatus.AutoSize = true;
            this.twitchPusSubStatus.BackColor = System.Drawing.Color.Chocolate;
            this.twitchPusSubStatus.ForeColor = System.Drawing.Color.Red;
            this.twitchPusSubStatus.Location = new System.Drawing.Point(134, 103);
            this.twitchPusSubStatus.Name = "twitchPusSubStatus";
            this.twitchPusSubStatus.Size = new System.Drawing.Size(28, 19);
            this.twitchPusSubStatus.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.twitchPusSubStatus.TabIndex = 11;
            this.twitchPusSubStatus.Text = "❌";
            this.twitchPusSubStatus.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.twitchPusSubStatus.UseCustomForeColor = true;
            // 
            // twitchChatStatus
            // 
            this.twitchChatStatus.AutoSize = true;
            this.twitchChatStatus.BackColor = System.Drawing.Color.Chocolate;
            this.twitchChatStatus.ForeColor = System.Drawing.Color.Red;
            this.twitchChatStatus.Location = new System.Drawing.Point(134, 65);
            this.twitchChatStatus.Name = "twitchChatStatus";
            this.twitchChatStatus.Size = new System.Drawing.Size(28, 19);
            this.twitchChatStatus.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.twitchChatStatus.TabIndex = 11;
            this.twitchChatStatus.Text = "❌";
            this.twitchChatStatus.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.twitchChatStatus.UseCustomForeColor = true;
            // 
            // poisonLabel8
            // 
            this.poisonLabel8.AutoSize = true;
            this.poisonLabel8.Location = new System.Drawing.Point(28, 65);
            this.poisonLabel8.Name = "poisonLabel8";
            this.poisonLabel8.Size = new System.Drawing.Size(75, 19);
            this.poisonLabel8.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel8.TabIndex = 11;
            this.poisonLabel8.Text = "Twitch Chat";
            this.poisonLabel8.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel9
            // 
            this.poisonLabel9.AutoSize = true;
            this.poisonLabel9.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel9.Location = new System.Drawing.Point(28, 148);
            this.poisonLabel9.Name = "poisonLabel9";
            this.poisonLabel9.Size = new System.Drawing.Size(67, 25);
            this.poisonLabel9.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel9.TabIndex = 8;
            this.poisonLabel9.Text = "Version";
            this.poisonLabel9.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.Location = new System.Drawing.Point(28, 28);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(149, 25);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 8;
            this.poisonLabel1.Text = "Connection Status";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // CommandsTab
            // 
            this.CommandsTab.Controls.Add(this.addNewCommand);
            this.CommandsTab.Controls.Add(this.commands);
            this.CommandsTab.HorizontalScrollbarBarColor = true;
            this.CommandsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CommandsTab.HorizontalScrollbarSize = 10;
            this.CommandsTab.Location = new System.Drawing.Point(4, 38);
            this.CommandsTab.Name = "CommandsTab";
            this.CommandsTab.Padding = new System.Windows.Forms.Padding(25);
            this.CommandsTab.Size = new System.Drawing.Size(857, 261);
            this.CommandsTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.CommandsTab.TabIndex = 1;
            this.CommandsTab.Text = "Commands";
            this.CommandsTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.CommandsTab.VerticalScrollbarBarColor = true;
            this.CommandsTab.VerticalScrollbarHighlightOnWheel = false;
            this.CommandsTab.VerticalScrollbarSize = 10;
            this.CommandsTab.Visible = false;
            // 
            // addNewCommand
            // 
            this.addNewCommand.Location = new System.Drawing.Point(3, 237);
            this.addNewCommand.Name = "addNewCommand";
            this.addNewCommand.Size = new System.Drawing.Size(137, 23);
            this.addNewCommand.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.addNewCommand.TabIndex = 3;
            this.addNewCommand.Text = "✙ Add New Command";
            this.addNewCommand.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.addNewCommand.UseSelectable = true;
            this.addNewCommand.Click += new System.EventHandler(this.addNewCommand_Click);
            // 
            // commands
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.commands, true);
            this.commands.AutoScroll = true;
            this.commands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.commands.Controls.Add(this.poisonLabel3);
            this.commands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.commands.Location = new System.Drawing.Point(3, 3);
            this.commands.Name = "commands";
            this.commands.Size = new System.Drawing.Size(855, 232);
            this.commands.TabIndex = 2;
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.Location = new System.Drawing.Point(3, 0);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(86, 19);
            this.poisonLabel3.TabIndex = 0;
            this.poisonLabel3.Text = "poisonLabel3";
            this.poisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // RewardsTab
            // 
            this.RewardsTab.Controls.Add(this.addReward);
            this.RewardsTab.Controls.Add(this.rewards);
            this.RewardsTab.HorizontalScrollbar = true;
            this.RewardsTab.HorizontalScrollbarBarColor = true;
            this.RewardsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.RewardsTab.HorizontalScrollbarSize = 10;
            this.RewardsTab.Location = new System.Drawing.Point(4, 35);
            this.RewardsTab.Name = "RewardsTab";
            this.RewardsTab.Padding = new System.Windows.Forms.Padding(25);
            this.RewardsTab.Size = new System.Drawing.Size(857, 264);
            this.RewardsTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.RewardsTab.TabIndex = 2;
            this.RewardsTab.Text = "Rewards";
            this.RewardsTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.RewardsTab.VerticalScrollbar = true;
            this.RewardsTab.VerticalScrollbarBarColor = true;
            this.RewardsTab.VerticalScrollbarHighlightOnWheel = false;
            this.RewardsTab.VerticalScrollbarSize = 10;
            this.RewardsTab.Visible = false;
            // 
            // addReward
            // 
            this.addReward.Location = new System.Drawing.Point(3, 237);
            this.addReward.Name = "addReward";
            this.addReward.Size = new System.Drawing.Size(121, 23);
            this.addReward.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.addReward.TabIndex = 5;
            this.addReward.Text = "✙ Add New Reward";
            this.addReward.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.addReward.UseSelectable = true;
            this.addReward.Click += new System.EventHandler(this.addReward_Click);
            // 
            // rewards
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.rewards, true);
            this.rewards.AutoScroll = true;
            this.rewards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rewards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rewards.Location = new System.Drawing.Point(3, 3);
            this.rewards.Name = "rewards";
            this.rewards.Size = new System.Drawing.Size(854, 232);
            this.rewards.TabIndex = 4;
            // 
            // SubscriptionsTab
            // 
            this.SubscriptionsTab.BackColor = System.Drawing.Color.Transparent;
            this.SubscriptionsTab.Controls.Add(this.addSub);
            this.SubscriptionsTab.Controls.Add(this.subscriptions);
            this.SubscriptionsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubscriptionsTab.HorizontalScrollbarBarColor = true;
            this.SubscriptionsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.SubscriptionsTab.HorizontalScrollbarSize = 10;
            this.SubscriptionsTab.Location = new System.Drawing.Point(4, 35);
            this.SubscriptionsTab.Name = "SubscriptionsTab";
            this.SubscriptionsTab.Size = new System.Drawing.Size(857, 264);
            this.SubscriptionsTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.SubscriptionsTab.TabIndex = 3;
            this.SubscriptionsTab.Text = "Subscriptions";
            this.SubscriptionsTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.SubscriptionsTab.UseCustomBackColor = true;
            this.SubscriptionsTab.UseCustomForeColor = true;
            this.SubscriptionsTab.VerticalScrollbarBarColor = true;
            this.SubscriptionsTab.VerticalScrollbarHighlightOnWheel = false;
            this.SubscriptionsTab.VerticalScrollbarSize = 10;
            // 
            // addSub
            // 
            this.addSub.Location = new System.Drawing.Point(3, 237);
            this.addSub.Name = "addSub";
            this.addSub.Size = new System.Drawing.Size(144, 23);
            this.addSub.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.addSub.TabIndex = 7;
            this.addSub.Text = "✙ Add New Subscription";
            this.addSub.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.addSub.UseSelectable = true;
            this.addSub.Click += new System.EventHandler(this.addSub_Click);
            // 
            // subscriptions
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.subscriptions, true);
            this.subscriptions.AutoScroll = true;
            this.subscriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.subscriptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.subscriptions.Location = new System.Drawing.Point(3, 3);
            this.subscriptions.Name = "subscriptions";
            this.subscriptions.Size = new System.Drawing.Size(854, 232);
            this.subscriptions.TabIndex = 6;
            // 
            // BitsTab
            // 
            this.BitsTab.Controls.Add(this.addBits);
            this.BitsTab.Controls.Add(this.bits);
            this.BitsTab.HorizontalScrollbarBarColor = true;
            this.BitsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.BitsTab.HorizontalScrollbarSize = 10;
            this.BitsTab.Location = new System.Drawing.Point(4, 35);
            this.BitsTab.Name = "BitsTab";
            this.BitsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BitsTab.Size = new System.Drawing.Size(857, 264);
            this.BitsTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.BitsTab.TabIndex = 4;
            this.BitsTab.Text = "Bits";
            this.BitsTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.BitsTab.UseVisualStyleBackColor = true;
            this.BitsTab.VerticalScrollbarBarColor = true;
            this.BitsTab.VerticalScrollbarHighlightOnWheel = false;
            this.BitsTab.VerticalScrollbarSize = 10;
            // 
            // addBits
            // 
            this.addBits.Location = new System.Drawing.Point(3, 237);
            this.addBits.Name = "addBits";
            this.addBits.Size = new System.Drawing.Size(98, 23);
            this.addBits.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.addBits.TabIndex = 9;
            this.addBits.Text = "✙ Add New Bits";
            this.addBits.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.addBits.UseSelectable = true;
            this.addBits.Click += new System.EventHandler(this.addBits_Click);
            // 
            // bits
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.bits, true);
            this.bits.AutoScroll = true;
            this.bits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.bits.Location = new System.Drawing.Point(3, 6);
            this.bits.Name = "bits";
            this.bits.Size = new System.Drawing.Size(854, 229);
            this.bits.TabIndex = 8;
            // 
            // HostTab
            // 
            this.HostTab.Controls.Add(this.addhost);
            this.HostTab.Controls.Add(this.hosts);
            this.HostTab.HorizontalScrollbarBarColor = true;
            this.HostTab.HorizontalScrollbarHighlightOnWheel = false;
            this.HostTab.HorizontalScrollbarSize = 10;
            this.HostTab.Location = new System.Drawing.Point(4, 35);
            this.HostTab.Name = "HostTab";
            this.HostTab.Padding = new System.Windows.Forms.Padding(3);
            this.HostTab.Size = new System.Drawing.Size(857, 264);
            this.HostTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.HostTab.TabIndex = 6;
            this.HostTab.Text = "Host";
            this.HostTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.HostTab.UseVisualStyleBackColor = true;
            this.HostTab.VerticalScrollbarBarColor = true;
            this.HostTab.VerticalScrollbarHighlightOnWheel = false;
            this.HostTab.VerticalScrollbarSize = 10;
            // 
            // addhost
            // 
            this.addhost.Location = new System.Drawing.Point(3, 237);
            this.addhost.Name = "addhost";
            this.addhost.Size = new System.Drawing.Size(104, 23);
            this.addhost.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.addhost.TabIndex = 9;
            this.addhost.Text = "✙ Add New Host";
            this.addhost.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.addhost.UseSelectable = true;
            this.addhost.Click += new System.EventHandler(this.addhost_Click);
            // 
            // hosts
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.hosts, true);
            this.hosts.AutoScroll = true;
            this.hosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.hosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.hosts.Location = new System.Drawing.Point(3, 6);
            this.hosts.Name = "hosts";
            this.hosts.Size = new System.Drawing.Size(854, 229);
            this.hosts.TabIndex = 8;
            // 
            // followTab
            // 
            this.followTab.HorizontalScrollbarBarColor = true;
            this.followTab.HorizontalScrollbarHighlightOnWheel = false;
            this.followTab.HorizontalScrollbarSize = 10;
            this.followTab.Location = new System.Drawing.Point(4, 35);
            this.followTab.Name = "followTab";
            this.followTab.Padding = new System.Windows.Forms.Padding(3);
            this.followTab.Size = new System.Drawing.Size(857, 264);
            this.followTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.followTab.TabIndex = 5;
            this.followTab.Text = "Follow";
            this.followTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.followTab.UseVisualStyleBackColor = true;
            this.followTab.VerticalScrollbarBarColor = true;
            this.followTab.VerticalScrollbarHighlightOnWheel = false;
            this.followTab.VerticalScrollbarSize = 10;
            // 
            // BanTab
            // 
            this.BanTab.HorizontalScrollbarBarColor = true;
            this.BanTab.HorizontalScrollbarHighlightOnWheel = false;
            this.BanTab.HorizontalScrollbarSize = 10;
            this.BanTab.Location = new System.Drawing.Point(4, 35);
            this.BanTab.Name = "BanTab";
            this.BanTab.Padding = new System.Windows.Forms.Padding(3);
            this.BanTab.Size = new System.Drawing.Size(857, 264);
            this.BanTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.BanTab.TabIndex = 7;
            this.BanTab.Text = "Ban";
            this.BanTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.BanTab.UseVisualStyleBackColor = true;
            this.BanTab.VerticalScrollbarBarColor = true;
            this.BanTab.VerticalScrollbarHighlightOnWheel = false;
            this.BanTab.VerticalScrollbarSize = 10;
            // 
            // TimedoutTab
            // 
            this.TimedoutTab.HorizontalScrollbarBarColor = true;
            this.TimedoutTab.HorizontalScrollbarHighlightOnWheel = false;
            this.TimedoutTab.HorizontalScrollbarSize = 10;
            this.TimedoutTab.Location = new System.Drawing.Point(4, 35);
            this.TimedoutTab.Name = "TimedoutTab";
            this.TimedoutTab.Padding = new System.Windows.Forms.Padding(3);
            this.TimedoutTab.Size = new System.Drawing.Size(857, 264);
            this.TimedoutTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.TimedoutTab.TabIndex = 8;
            this.TimedoutTab.Text = "Timedout";
            this.TimedoutTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.TimedoutTab.UseVisualStyleBackColor = true;
            this.TimedoutTab.VerticalScrollbarBarColor = true;
            this.TimedoutTab.VerticalScrollbarHighlightOnWheel = false;
            this.TimedoutTab.VerticalScrollbarSize = 10;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.debugSwitch);
            this.SettingsTab.Controls.Add(this.poisonLabel2);
            this.SettingsTab.Controls.Add(this.poisonLabel15);
            this.SettingsTab.Controls.Add(this.twitchOAuth);
            this.SettingsTab.HorizontalScrollbarBarColor = true;
            this.SettingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.SettingsTab.HorizontalScrollbarSize = 10;
            this.SettingsTab.Location = new System.Drawing.Point(4, 35);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(25);
            this.SettingsTab.Size = new System.Drawing.Size(857, 264);
            this.SettingsTab.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.SettingsTab.TabIndex = 3;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.SettingsTab.VerticalScrollbarBarColor = true;
            this.SettingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.SettingsTab.VerticalScrollbarSize = 10;
            this.SettingsTab.Visible = false;
            // 
            // debugSwitch
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.debugSwitch, true);
            this.debugSwitch.BackColor = System.Drawing.Color.Transparent;
            this.debugSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.debugSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.debugSwitch.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.debugSwitch.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.debugSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.debugSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.debugSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.debugSwitch.IsDerivedStyle = true;
            this.debugSwitch.Location = new System.Drawing.Point(30, 115);
            this.debugSwitch.Name = "debugSwitch";
            this.debugSwitch.Size = new System.Drawing.Size(58, 22);
            this.debugSwitch.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.debugSwitch.StyleManager = null;
            this.debugSwitch.Switched = false;
            this.debugSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.debugSwitch.TabIndex = 13;
            this.debugSwitch.ThemeAuthor = "Them3";
            this.debugSwitch.ThemeName = "MetroDark5";
            this.debugSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(28, 89);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(87, 19);
            this.poisonLabel2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel2.TabIndex = 12;
            this.poisonLabel2.Text = "Debug mode";
            this.poisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel15
            // 
            this.poisonLabel15.AutoSize = true;
            this.poisonLabel15.Location = new System.Drawing.Point(28, 23);
            this.poisonLabel15.Margin = new System.Windows.Forms.Padding(3);
            this.poisonLabel15.Name = "poisonLabel15";
            this.poisonLabel15.Size = new System.Drawing.Size(123, 19);
            this.poisonLabel15.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel15.TabIndex = 10;
            this.poisonLabel15.Text = "Twitch OAuth Token";
            this.poisonLabel15.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // twitchOAuth
            // 
            this.twitchOAuth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.twitchOAuth.CustomButton.Image = null;
            this.twitchOAuth.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.twitchOAuth.CustomButton.Name = "";
            this.twitchOAuth.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.twitchOAuth.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.twitchOAuth.CustomButton.TabIndex = 1;
            this.twitchOAuth.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.twitchOAuth.CustomButton.UseSelectable = true;
            this.twitchOAuth.CustomButton.Visible = false;
            this.twitchOAuth.Lines = new string[0];
            this.twitchOAuth.Location = new System.Drawing.Point(28, 48);
            this.twitchOAuth.MaxLength = 32767;
            this.twitchOAuth.Name = "twitchOAuth";
            this.twitchOAuth.PasswordChar = '*';
            this.twitchOAuth.PromptText = "Token";
            this.twitchOAuth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.twitchOAuth.SelectedText = "";
            this.twitchOAuth.SelectionLength = 0;
            this.twitchOAuth.SelectionStart = 0;
            this.twitchOAuth.ShortcutsEnabled = true;
            this.twitchOAuth.Size = new System.Drawing.Size(171, 22);
            this.twitchOAuth.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.twitchOAuth.TabIndex = 3;
            this.twitchOAuth.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonToolTip.SetToolTip(this.twitchOAuth, "Textbox Tooltip");
            this.twitchOAuth.UseSelectable = true;
            this.twitchOAuth.WaterMark = "Token";
            this.twitchOAuth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.twitchOAuth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonStyleManager
            // 
            this.poisonStyleManager.Owner = this;
            this.poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonToolTip
            // 
            this.poisonToolTip.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip.StyleManager = null;
            this.poisonToolTip.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonStyleExtender
            // 
            this.poisonStyleExtender.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(10, 10);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "Log";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(10, 10);
            this.materialCheckBox2.TabIndex = 0;
            this.materialCheckBox2.Text = "Log1";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.poisonTabControl1);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(868, 309);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.poisonTabControl1.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.CommandsTab.ResumeLayout(false);
            this.commands.ResumeLayout(false);
            this.commands.PerformLayout();
            this.RewardsTab.ResumeLayout(false);
            this.SubscriptionsTab.ResumeLayout(false);
            this.BitsTab.ResumeLayout(false);
            this.HostTab.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PoisonTabControl poisonTabControl1;
        private PoisonStyleManager poisonStyleManager;
        private PoisonTabPage MainTab;
        private PoisonToolTip poisonToolTip;
        private PoisonLabel poisonLabel1;
        private PoisonTabPage RewardsTab;
        private PoisonTabPage SettingsTab;
        private PoisonTabPage SubscriptionsTab;
        private PoisonLabel poisonLabel8;
        private PoisonTextBox twitchOAuth;
        private PoisonLabel poisonLabel15;
        private PoisonStyleExtender poisonStyleExtender;
        private PoisonLabel twitchChatStatus;
        private PoisonLabel twitchPusSubStatus;
        private MaterialCheckBox materialCheckBox1;
        private PoisonLabel poisonLabel9;
        private MaterialCheckBox materialCheckBox2;
        private PoisonLabel poisonLabel23;
        private PoisonLabel version;
        private PoisonTabPage CommandsTab;
        private PoisonProgressSpinner chatSpinner;
        private PoisonProgressSpinner pubsubSpinner;
        private PoisonLabel poisonLabel2;
        private MetroSwitch debugSwitch;
        private FlowLayoutPanel commands;
        private PoisonButton addNewCommand;
        private PoisonButton addReward;
        private FlowLayoutPanel rewards;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PoisonButton addSub;
        private FlowLayoutPanel subscriptions;
        private PoisonTabPage BitsTab;
        private PoisonTabPage followTab;
        private PoisonTabPage HostTab;
        private PoisonTabPage TimedoutTab;
        private PoisonButton addBits;
        private FlowLayoutPanel bits;
        private PoisonButton addhost;
        private FlowLayoutPanel hosts;
        private TwitchLogin twitchLogin;
        private PoisonTabPage BanTab;
        private PoisonLabel poisonLabel3;
    }
}
