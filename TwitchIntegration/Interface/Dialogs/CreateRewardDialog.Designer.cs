namespace TwitchIntegration.Interface.Dialogs
{
    partial class CreateRewardDialog
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
            this.components = new System.ComponentModel.Container();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.confirmButton = new ReaLTaiizor.Controls.Button();
            this.cancelButton = new ReaLTaiizor.Controls.Button();
            this.waitingLabel = new ReaLTaiizor.Controls.PoisonLabel();
            this.waitingSpinner = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.actionCheck = new System.Windows.Forms.Timer(this.components);
            this.rewardInfo = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(23, -3);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(307, 19);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 1;
            this.poisonLabel1.Text = "Use reward on your channel which you want to add";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.confirmButton.Enabled = false;
            this.confirmButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.Image = null;
            this.confirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmButton.InactiveColor = System.Drawing.Color.Lime;
            this.confirmButton.Location = new System.Drawing.Point(200, 66);
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
            // waitingLabel
            // 
            this.waitingLabel.AutoSize = true;
            this.waitingLabel.Location = new System.Drawing.Point(50, 28);
            this.waitingLabel.Name = "waitingLabel";
            this.waitingLabel.Size = new System.Drawing.Size(122, 19);
            this.waitingLabel.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.waitingLabel.TabIndex = 11;
            this.waitingLabel.Text = "Waiting for action...";
            this.waitingLabel.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // waitingSpinner
            // 
            this.waitingSpinner.Location = new System.Drawing.Point(31, 29);
            this.waitingSpinner.Maximum = 100;
            this.waitingSpinner.Name = "waitingSpinner";
            this.waitingSpinner.Size = new System.Drawing.Size(16, 16);
            this.waitingSpinner.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.waitingSpinner.TabIndex = 12;
            this.waitingSpinner.Text = "poisonProgressSpinner1";
            this.waitingSpinner.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.waitingSpinner.UseSelectable = true;
            // 
            // actionCheck
            // 
            this.actionCheck.Enabled = true;
            this.actionCheck.Interval = 2000;
            this.actionCheck.Tick += new System.EventHandler(this.actionCheck_Tick);
            // 
            // rewardInfo
            // 
            this.rewardInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rewardInfo.AutoSize = true;
            this.rewardInfo.Location = new System.Drawing.Point(115, 29);
            this.rewardInfo.Name = "rewardInfo";
            this.rewardInfo.Size = new System.Drawing.Size(98, 19);
            this.rewardInfo.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.rewardInfo.TabIndex = 13;
            this.rewardInfo.Text = "Reward: NONE";
            this.rewardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rewardInfo.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.rewardInfo.Visible = false;
            // 
            // CreateRewardDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rewardInfo);
            this.Controls.Add(this.waitingSpinner);
            this.Controls.Add(this.waitingLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.poisonLabel1);
            this.Name = "CreateRewardDialog";
            this.Size = new System.Drawing.Size(352, 109);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.Button confirmButton;
        private ReaLTaiizor.Controls.Button cancelButton;
        private PoisonLabel waitingLabel;
        private PoisonProgressSpinner waitingSpinner;
        private System.Windows.Forms.Timer actionCheck;
        private PoisonLabel rewardInfo;
    }
}
