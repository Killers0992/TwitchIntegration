namespace TwitchIntegration.Interface.Tabs
{
    partial class TimedOutTab
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
            this.poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel9 = new ReaLTaiizor.Controls.PoisonLabel();
            this.globalH = new ReaLTaiizor.Controls.CrownNumeric();
            this.poisonLabel10 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel11 = new ReaLTaiizor.Controls.PoisonLabel();
            this.globalM = new ReaLTaiizor.Controls.CrownNumeric();
            this.poisonLabel12 = new ReaLTaiizor.Controls.PoisonLabel();
            this.globalS = new ReaLTaiizor.Controls.CrownNumeric();
            this.newOscAction = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel17 = new ReaLTaiizor.Controls.PoisonLabel();
            this.randomAction = new ReaLTaiizor.Controls.MetroSwitch();
            this.oscActions = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.globalH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalS)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonLabel8
            // 
            this.poisonLabel8.AutoSize = true;
            this.poisonLabel8.Location = new System.Drawing.Point(15, 167);
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
            this.poisonLabel9.Location = new System.Drawing.Point(20, 194);
            this.poisonLabel9.Name = "poisonLabel9";
            this.poisonLabel9.Size = new System.Drawing.Size(53, 19);
            this.poisonLabel9.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel9.TabIndex = 17;
            this.poisonLabel9.Text = "Global";
            this.poisonLabel9.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // globalH
            // 
            this.globalH.Location = new System.Drawing.Point(86, 193);
            this.globalH.Name = "globalH";
            this.globalH.Size = new System.Drawing.Size(40, 23);
            this.globalH.TabIndex = 18;
            // 
            // poisonLabel10
            // 
            this.poisonLabel10.AutoSize = true;
            this.poisonLabel10.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.poisonLabel10.Location = new System.Drawing.Point(126, 194);
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
            this.poisonLabel11.Location = new System.Drawing.Point(183, 194);
            this.poisonLabel11.Name = "poisonLabel11";
            this.poisonLabel11.Size = new System.Drawing.Size(22, 19);
            this.poisonLabel11.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel11.TabIndex = 21;
            this.poisonLabel11.Text = "m";
            this.poisonLabel11.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // globalM
            // 
            this.globalM.Location = new System.Drawing.Point(144, 193);
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
            this.globalS.Location = new System.Drawing.Point(206, 194);
            this.globalS.Name = "globalS";
            this.globalS.Size = new System.Drawing.Size(40, 23);
            this.globalS.TabIndex = 22;
            // 
            // newOscAction
            // 
            this.newOscAction.Location = new System.Drawing.Point(289, 193);
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
            this.poisonLabel17.Location = new System.Drawing.Point(491, 197);
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
            this.randomAction.Location = new System.Drawing.Point(428, 193);
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
            // oscActions
            // 
            this.oscActions.BackColor = System.Drawing.Color.Transparent;
            this.oscActions.Location = new System.Drawing.Point(289, 7);
            this.oscActions.Name = "oscActions";
            this.oscActions.Size = new System.Drawing.Size(288, 180);
            this.oscActions.TabIndex = 31;
            // 
            // FollowTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FollowTab";
            this.Size = new System.Drawing.Size(857, 261);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.globalH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PoisonLabel poisonLabel8;
        private PoisonLabel poisonLabel9;
        private CrownNumeric globalH;
        private PoisonLabel poisonLabel10;
        private PoisonLabel poisonLabel11;
        private CrownNumeric globalM;
        private PoisonLabel poisonLabel12;
        private CrownNumeric globalS;
        private PoisonButton newOscAction;
        private PoisonLabel poisonLabel17;
        private MetroSwitch randomAction;
        private FlowLayoutPanel oscActions;
    }
}
