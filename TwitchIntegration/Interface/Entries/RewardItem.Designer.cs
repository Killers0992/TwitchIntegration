namespace TwitchIntegration.Interface
{
    partial class RewarddItem
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
            this.delete = new ReaLTaiizor.Controls.PoisonButton();
            this.edit = new ReaLTaiizor.Controls.PoisonButton();
            this.rewardName = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.Location = new System.Drawing.Point(602, 10);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(35, 26);
            this.delete.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.delete.TabIndex = 13;
            this.delete.Text = "❌";
            this.delete.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.delete.UseCustomForeColor = true;
            this.delete.UseSelectable = true;
            this.delete.Click += new System.EventHandler(this.removeReward_Click);
            // 
            // edit
            // 
            this.edit.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.edit.ForeColor = System.Drawing.Color.Lime;
            this.edit.Location = new System.Drawing.Point(561, 10);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(35, 26);
            this.edit.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.edit.TabIndex = 14;
            this.edit.Text = "✎";
            this.edit.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.edit.UseCustomForeColor = true;
            this.edit.UseSelectable = true;
            this.edit.Click += new System.EventHandler(this.poisonButton1_Click);
            // 
            // rewardName
            // 
            this.rewardName.AutoSize = true;
            this.rewardName.Location = new System.Drawing.Point(12, 16);
            this.rewardName.Name = "rewardName";
            this.rewardName.Size = new System.Drawing.Size(53, 19);
            this.rewardName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.rewardName.TabIndex = 15;
            this.rewardName.Text = "Reward";
            this.rewardName.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // RewarddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rewardName);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Name = "RewarddItem";
            this.Size = new System.Drawing.Size(649, 48);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PoisonButton delete;
        private PoisonButton edit;
        private PoisonLabel rewardName;
    }
}
