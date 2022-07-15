namespace TwitchIntegration.Interface
{
    partial class CommandItem
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
            this.commandName = new ReaLTaiizor.Controls.PoisonTextBox();
            this.delete = new ReaLTaiizor.Controls.PoisonButton();
            this.edit = new ReaLTaiizor.Controls.PoisonButton();
            this.SuspendLayout();
            // 
            // commandName
            // 
            // 
            // 
            // 
            this.commandName.CustomButton.Image = null;
            this.commandName.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.commandName.CustomButton.Name = "";
            this.commandName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.commandName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.commandName.CustomButton.TabIndex = 1;
            this.commandName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.commandName.CustomButton.UseSelectable = true;
            this.commandName.CustomButton.Visible = false;
            this.commandName.Lines = new string[0];
            this.commandName.Location = new System.Drawing.Point(15, 13);
            this.commandName.MaxLength = 32767;
            this.commandName.Name = "commandName";
            this.commandName.PasswordChar = '\0';
            this.commandName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.commandName.SelectedText = "";
            this.commandName.SelectionLength = 0;
            this.commandName.SelectionStart = 0;
            this.commandName.ShortcutsEnabled = true;
            this.commandName.Size = new System.Drawing.Size(212, 23);
            this.commandName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.commandName.TabIndex = 0;
            this.commandName.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.commandName.UseSelectable = true;
            this.commandName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.commandName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.delete.Click += new System.EventHandler(this.removeCommand_Click);
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
            // CommandItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.commandName);
            this.Name = "CommandItem";
            this.Size = new System.Drawing.Size(829, 48);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTextBox commandName;
        private PoisonButton delete;
        private PoisonButton edit;
    }
}
