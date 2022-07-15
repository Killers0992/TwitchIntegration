namespace TwitchIntegration.Interface
{
    partial class BitsItem
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
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.minMonths = new ReaLTaiizor.Controls.PoisonLabel();
            this.maxMonths = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.Location = new System.Drawing.Point(785, 10);
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
            this.edit.Location = new System.Drawing.Point(744, 10);
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
            this.rewardName.Size = new System.Drawing.Size(29, 19);
            this.rewardName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.rewardName.TabIndex = 15;
            this.rewardName.Text = "Bits";
            this.rewardName.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.Location = new System.Drawing.Point(95, 16);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(68, 19);
            this.poisonLabel3.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel3.TabIndex = 18;
            this.poisonLabel3.Text = "Minimum:";
            this.poisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.Location = new System.Drawing.Point(215, 16);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(71, 19);
            this.poisonLabel4.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel4.TabIndex = 19;
            this.poisonLabel4.Text = "Maximum:";
            this.poisonLabel4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // minMonths
            // 
            this.minMonths.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.minMonths.Location = new System.Drawing.Point(160, 16);
            this.minMonths.Name = "minMonths";
            this.minMonths.Size = new System.Drawing.Size(51, 19);
            this.minMonths.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.minMonths.TabIndex = 20;
            this.minMonths.Text = "0";
            this.minMonths.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // maxMonths
            // 
            this.maxMonths.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.maxMonths.Location = new System.Drawing.Point(289, 16);
            this.maxMonths.Name = "maxMonths";
            this.maxMonths.Size = new System.Drawing.Size(61, 19);
            this.maxMonths.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.maxMonths.TabIndex = 21;
            this.maxMonths.Text = "0";
            this.maxMonths.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // BitsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.maxMonths);
            this.Controls.Add(this.minMonths);
            this.Controls.Add(this.poisonLabel4);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.rewardName);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Name = "BitsItem";
            this.Size = new System.Drawing.Size(829, 48);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PoisonButton delete;
        private PoisonButton edit;
        private PoisonLabel rewardName;
        private PoisonLabel poisonLabel3;
        private PoisonLabel poisonLabel4;
        private PoisonLabel minMonths;
        private PoisonLabel maxMonths;
    }
}
