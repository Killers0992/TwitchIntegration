namespace TwitchIntegration.Interface.Dialogs
{
    partial class CreateSubscriptionDialog
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
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.confirmButton = new ReaLTaiizor.Controls.Button();
            this.cancelButton = new ReaLTaiizor.Controls.Button();
            this.metroSwitch1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.SuspendLayout();
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(48, 19);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(127, 19);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 1;
            this.poisonLabel1.Text = "Its new subscription?";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.Image = null;
            this.confirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmButton.InactiveColor = System.Drawing.Color.Lime;
            this.confirmButton.Location = new System.Drawing.Point(163, 66);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.confirmButton.Size = new System.Drawing.Size(120, 25);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Image = null;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.Location = new System.Drawing.Point(23, 67);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.cancelButton.Size = new System.Drawing.Size(120, 24);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // metroSwitch1
            // 
            this.metroSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.metroSwitch1.BackgroundColor = System.Drawing.Color.Empty;
            this.metroSwitch1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.metroSwitch1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSwitch1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.metroSwitch1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSwitch1.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSwitch1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSwitch1.IsDerivedStyle = true;
            this.metroSwitch1.Location = new System.Drawing.Point(186, 18);
            this.metroSwitch1.Name = "metroSwitch1";
            this.metroSwitch1.Size = new System.Drawing.Size(58, 22);
            this.metroSwitch1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroSwitch1.StyleManager = null;
            this.metroSwitch1.Switched = false;
            this.metroSwitch1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.metroSwitch1.TabIndex = 11;
            this.metroSwitch1.Text = "metroSwitch1";
            this.metroSwitch1.ThemeAuthor = "Taiizor";
            this.metroSwitch1.ThemeName = "MetroLight";
            this.metroSwitch1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CreateSubscriptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroSwitch1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.poisonLabel1);
            this.Name = "CreateSubscriptionDialog";
            this.Size = new System.Drawing.Size(305, 109);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.Button confirmButton;
        private ReaLTaiizor.Controls.Button cancelButton;
        private MetroSwitch metroSwitch1;
    }
}
