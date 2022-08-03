namespace TwitchIntegration.Interface.Dialogs
{
    partial class EditReSubscriptionDialog
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tier1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tier2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.prime = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tier3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.minimumMonths = new ReaLTaiizor.Controls.CrownNumeric();
            this.poisonLabel6 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel9 = new ReaLTaiizor.Controls.PoisonLabel();
            this.globalH = new ReaLTaiizor.Controls.CrownNumeric();
            this.poisonLabel10 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel11 = new ReaLTaiizor.Controls.PoisonLabel();
            this.globalM = new ReaLTaiizor.Controls.CrownNumeric();
            this.poisonLabel12 = new ReaLTaiizor.Controls.PoisonLabel();
            this.globalS = new ReaLTaiizor.Controls.CrownNumeric();
            this.oscActions = new System.Windows.Forms.FlowLayoutPanel();
            this.newOscAction = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel17 = new ReaLTaiizor.Controls.PoisonLabel();
            this.randomAction = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel7 = new ReaLTaiizor.Controls.PoisonLabel();
            this.maxiumumMonths = new ReaLTaiizor.Controls.CrownNumeric();
            this.poisonLabel18 = new ReaLTaiizor.Controls.PoisonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.minimumMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumumMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // tier1
            // 
            this.tier1.BackColor = System.Drawing.Color.Transparent;
            this.tier1.BackgroundColor = System.Drawing.Color.Empty;
            this.tier1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.tier1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tier1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.tier1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.tier1.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tier1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.tier1.IsDerivedStyle = true;
            this.tier1.Location = new System.Drawing.Point(22, 42);
            this.tier1.Name = "tier1";
            this.tier1.Size = new System.Drawing.Size(58, 22);
            this.tier1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.tier1.StyleManager = null;
            this.tier1.Switched = false;
            this.tier1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.tier1.TabIndex = 2;
            this.tier1.Text = "metroSwitch1";
            this.tier1.ThemeAuthor = "Taiizor";
            this.tier1.ThemeName = "MetroLight";
            this.tier1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(15, 13);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(233, 19);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 3;
            this.poisonLabel1.Text = "Which subscription tier will excute this?";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel2.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel2.Location = new System.Drawing.Point(85, 46);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(36, 15);
            this.poisonLabel2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel2.TabIndex = 4;
            this.poisonLabel2.Text = "Tier1";
            this.poisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel3.Location = new System.Drawing.Point(85, 74);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(36, 15);
            this.poisonLabel3.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel3.TabIndex = 6;
            this.poisonLabel3.Text = "Tier2";
            this.poisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // tier2
            // 
            this.tier2.BackColor = System.Drawing.Color.Transparent;
            this.tier2.BackgroundColor = System.Drawing.Color.Empty;
            this.tier2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.tier2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tier2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.tier2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.tier2.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tier2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.tier2.IsDerivedStyle = true;
            this.tier2.Location = new System.Drawing.Point(22, 70);
            this.tier2.Name = "tier2";
            this.tier2.Size = new System.Drawing.Size(58, 22);
            this.tier2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.tier2.StyleManager = null;
            this.tier2.Switched = false;
            this.tier2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.tier2.TabIndex = 5;
            this.tier2.Text = "metroSwitch2";
            this.tier2.ThemeAuthor = "Taiizor";
            this.tier2.ThemeName = "MetroLight";
            this.tier2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel4.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel4.Location = new System.Drawing.Point(85, 130);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(40, 15);
            this.poisonLabel4.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel4.TabIndex = 8;
            this.poisonLabel4.Text = "Prime";
            this.poisonLabel4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // prime
            // 
            this.prime.BackColor = System.Drawing.Color.Transparent;
            this.prime.BackgroundColor = System.Drawing.Color.Empty;
            this.prime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.prime.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.prime.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.prime.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.prime.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.prime.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.prime.IsDerivedStyle = true;
            this.prime.Location = new System.Drawing.Point(22, 126);
            this.prime.Name = "prime";
            this.prime.Size = new System.Drawing.Size(58, 22);
            this.prime.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.prime.StyleManager = null;
            this.prime.Switched = false;
            this.prime.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.prime.TabIndex = 7;
            this.prime.Text = "metroSwitch3";
            this.prime.ThemeAuthor = "Taiizor";
            this.prime.ThemeName = "MetroDark";
            this.prime.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // poisonLabel5
            // 
            this.poisonLabel5.AutoSize = true;
            this.poisonLabel5.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel5.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel5.Location = new System.Drawing.Point(85, 102);
            this.poisonLabel5.Name = "poisonLabel5";
            this.poisonLabel5.Size = new System.Drawing.Size(36, 15);
            this.poisonLabel5.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel5.TabIndex = 10;
            this.poisonLabel5.Text = "Tier3";
            this.poisonLabel5.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // tier3
            // 
            this.tier3.BackColor = System.Drawing.Color.Transparent;
            this.tier3.BackgroundColor = System.Drawing.Color.Empty;
            this.tier3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.tier3.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tier3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.tier3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.tier3.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tier3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.tier3.IsDerivedStyle = true;
            this.tier3.Location = new System.Drawing.Point(22, 98);
            this.tier3.Name = "tier3";
            this.tier3.Size = new System.Drawing.Size(58, 22);
            this.tier3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.tier3.StyleManager = null;
            this.tier3.Switched = false;
            this.tier3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.tier3.TabIndex = 9;
            this.tier3.Text = "metroSwitch4";
            this.tier3.ThemeAuthor = "Taiizor";
            this.tier3.ThemeName = "MetroLight";
            this.tier3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // minimumMonths
            // 
            this.minimumMonths.Location = new System.Drawing.Point(86, 197);
            this.minimumMonths.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.minimumMonths.Name = "minimumMonths";
            this.minimumMonths.Size = new System.Drawing.Size(48, 23);
            this.minimumMonths.TabIndex = 12;
            // 
            // poisonLabel6
            // 
            this.poisonLabel6.AutoSize = true;
            this.poisonLabel6.Location = new System.Drawing.Point(18, 199);
            this.poisonLabel6.Name = "poisonLabel6";
            this.poisonLabel6.Size = new System.Drawing.Size(65, 19);
            this.poisonLabel6.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel6.TabIndex = 13;
            this.poisonLabel6.Text = "Minimum";
            this.poisonLabel6.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel8
            // 
            this.poisonLabel8.AutoSize = true;
            this.poisonLabel8.Location = new System.Drawing.Point(15, 225);
            this.poisonLabel8.Name = "poisonLabel8";
            this.poisonLabel8.Size = new System.Drawing.Size(260, 19);
            this.poisonLabel8.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel8.TabIndex = 16;
            this.poisonLabel8.Text = "How often the command can be executed?";
            this.poisonLabel8.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel9
            // 
            this.poisonLabel9.AutoSize = true;
            this.poisonLabel9.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel9.Location = new System.Drawing.Point(20, 252);
            this.poisonLabel9.Name = "poisonLabel9";
            this.poisonLabel9.Size = new System.Drawing.Size(53, 19);
            this.poisonLabel9.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel9.TabIndex = 17;
            this.poisonLabel9.Text = "Global";
            this.poisonLabel9.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // globalH
            // 
            this.globalH.Location = new System.Drawing.Point(86, 251);
            this.globalH.Name = "globalH";
            this.globalH.Size = new System.Drawing.Size(40, 23);
            this.globalH.TabIndex = 18;
            // 
            // poisonLabel10
            // 
            this.poisonLabel10.AutoSize = true;
            this.poisonLabel10.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel10.Location = new System.Drawing.Point(126, 252);
            this.poisonLabel10.Name = "poisonLabel10";
            this.poisonLabel10.Size = new System.Drawing.Size(17, 19);
            this.poisonLabel10.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel10.TabIndex = 19;
            this.poisonLabel10.Text = "h";
            this.poisonLabel10.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel11
            // 
            this.poisonLabel11.AutoSize = true;
            this.poisonLabel11.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel11.Location = new System.Drawing.Point(183, 252);
            this.poisonLabel11.Name = "poisonLabel11";
            this.poisonLabel11.Size = new System.Drawing.Size(22, 19);
            this.poisonLabel11.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel11.TabIndex = 21;
            this.poisonLabel11.Text = "m";
            this.poisonLabel11.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // globalM
            // 
            this.globalM.Location = new System.Drawing.Point(144, 251);
            this.globalM.Name = "globalM";
            this.globalM.Size = new System.Drawing.Size(40, 23);
            this.globalM.TabIndex = 20;
            // 
            // poisonLabel12
            // 
            this.poisonLabel12.AutoSize = true;
            this.poisonLabel12.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel12.Location = new System.Drawing.Point(246, 253);
            this.poisonLabel12.Name = "poisonLabel12";
            this.poisonLabel12.Size = new System.Drawing.Size(15, 19);
            this.poisonLabel12.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel12.TabIndex = 23;
            this.poisonLabel12.Text = "s";
            this.poisonLabel12.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // globalS
            // 
            this.globalS.Location = new System.Drawing.Point(206, 252);
            this.globalS.Name = "globalS";
            this.globalS.Size = new System.Drawing.Size(40, 23);
            this.globalS.TabIndex = 22;
            // 
            // oscActions
            // 
            this.oscActions.AutoScroll = true;
            this.oscActions.BackColor = System.Drawing.Color.Transparent;
            this.oscActions.Location = new System.Drawing.Point(276, 13);
            this.oscActions.Name = "oscActions";
            this.oscActions.Size = new System.Drawing.Size(288, 180);
            this.oscActions.TabIndex = 31;
            // 
            // newOscAction
            // 
            this.newOscAction.Location = new System.Drawing.Point(276, 199);
            this.newOscAction.Name = "newOscAction";
            this.newOscAction.Size = new System.Drawing.Size(133, 23);
            this.newOscAction.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.newOscAction.TabIndex = 32;
            this.newOscAction.Text = "✙ Add new OSC Action";
            this.newOscAction.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.newOscAction.UseSelectable = true;
            this.newOscAction.Click += new System.EventHandler(this.newOscAction_Click);
            // 
            // poisonLabel17
            // 
            this.poisonLabel17.AutoSize = true;
            this.poisonLabel17.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel17.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel17.Location = new System.Drawing.Point(478, 203);
            this.poisonLabel17.Name = "poisonLabel17";
            this.poisonLabel17.Size = new System.Drawing.Size(90, 15);
            this.poisonLabel17.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel17.TabIndex = 34;
            this.poisonLabel17.Text = "Random action";
            this.poisonLabel17.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // randomAction
            // 
            this.randomAction.BackColor = System.Drawing.Color.Transparent;
            this.randomAction.BackgroundColor = System.Drawing.Color.Empty;
            this.randomAction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.randomAction.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.randomAction.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.randomAction.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.randomAction.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.randomAction.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.randomAction.IsDerivedStyle = true;
            this.randomAction.Location = new System.Drawing.Point(415, 199);
            this.randomAction.Name = "randomAction";
            this.randomAction.Size = new System.Drawing.Size(58, 22);
            this.randomAction.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.randomAction.StyleManager = null;
            this.randomAction.Switched = false;
            this.randomAction.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.randomAction.TabIndex = 33;
            this.randomAction.Text = "metroSwitch6";
            this.randomAction.ThemeAuthor = "Taiizor";
            this.randomAction.ThemeName = "MetroLight";
            this.randomAction.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // poisonLabel7
            // 
            this.poisonLabel7.AutoSize = true;
            this.poisonLabel7.Location = new System.Drawing.Point(140, 198);
            this.poisonLabel7.Name = "poisonLabel7";
            this.poisonLabel7.Size = new System.Drawing.Size(68, 19);
            this.poisonLabel7.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel7.TabIndex = 36;
            this.poisonLabel7.Text = "Maximum";
            this.poisonLabel7.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // maxiumumMonths
            // 
            this.maxiumumMonths.Location = new System.Drawing.Point(213, 196);
            this.maxiumumMonths.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxiumumMonths.Name = "maxiumumMonths";
            this.maxiumumMonths.Size = new System.Drawing.Size(48, 23);
            this.maxiumumMonths.TabIndex = 35;
            // 
            // poisonLabel18
            // 
            this.poisonLabel18.Location = new System.Drawing.Point(20, 151);
            this.poisonLabel18.Name = "poisonLabel18";
            this.poisonLabel18.Size = new System.Drawing.Size(241, 42);
            this.poisonLabel18.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel18.TabIndex = 37;
            this.poisonLabel18.Text = "Required range of months when\r\nthis will be executed.\r\n";
            this.poisonLabel18.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // EditReSubscriptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.poisonLabel18);
            this.Controls.Add(this.poisonLabel7);
            this.Controls.Add(this.maxiumumMonths);
            this.Controls.Add(this.poisonLabel17);
            this.Controls.Add(this.randomAction);
            this.Controls.Add(this.newOscAction);
            this.Controls.Add(this.oscActions);
            this.Controls.Add(this.poisonLabel12);
            this.Controls.Add(this.globalS);
            this.Controls.Add(this.poisonLabel11);
            this.Controls.Add(this.globalM);
            this.Controls.Add(this.poisonLabel10);
            this.Controls.Add(this.globalH);
            this.Controls.Add(this.poisonLabel9);
            this.Controls.Add(this.poisonLabel8);
            this.Controls.Add(this.poisonLabel6);
            this.Controls.Add(this.minimumMonths);
            this.Controls.Add(this.poisonLabel5);
            this.Controls.Add(this.tier3);
            this.Controls.Add(this.poisonLabel4);
            this.Controls.Add(this.prime);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.tier2);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.tier1);
            this.Name = "EditReSubscriptionDialog";
            this.Size = new System.Drawing.Size(586, 287);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.minimumMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxiumumMonths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSwitch tier1;
        private PoisonLabel poisonLabel1;
        private PoisonLabel poisonLabel2;
        private PoisonLabel poisonLabel3;
        private MetroSwitch tier2;
        private PoisonLabel poisonLabel4;
        private MetroSwitch prime;
        private PoisonLabel poisonLabel5;
        private MetroSwitch tier3;
        private CrownNumeric minimumMonths;
        private PoisonLabel poisonLabel6;
        private PoisonLabel poisonLabel8;
        private PoisonLabel poisonLabel9;
        private CrownNumeric globalH;
        private PoisonLabel poisonLabel10;
        private PoisonLabel poisonLabel11;
        private CrownNumeric globalM;
        private PoisonLabel poisonLabel12;
        private CrownNumeric globalS;
        private FlowLayoutPanel oscActions;
        private PoisonButton newOscAction;
        private PoisonLabel poisonLabel17;
        private MetroSwitch randomAction;
        private PoisonLabel poisonLabel7;
        private CrownNumeric maxiumumMonths;
        private PoisonLabel poisonLabel18;
    }
}
