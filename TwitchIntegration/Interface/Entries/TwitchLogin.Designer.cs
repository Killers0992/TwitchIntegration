namespace TwitchIntegration.Interface
{
    partial class TwitchLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tokenFIeld = new ReaLTaiizor.Controls.PoisonTextBox();
            this.loginButton = new ReaLTaiizor.Controls.PoisonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TwitchIntegration.Properties.Resources.Twitch_UnextrudedWordmarkPurple;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(267, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(235, 93);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(357, 19);
            this.poisonLabel1.TabIndex = 1;
            this.poisonLabel1.Text = "You need to login thru twitch account and paste token there";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // tokenFIeld
            // 
            // 
            // 
            // 
            this.tokenFIeld.CustomButton.Image = null;
            this.tokenFIeld.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.tokenFIeld.CustomButton.Name = "";
            this.tokenFIeld.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tokenFIeld.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tokenFIeld.CustomButton.TabIndex = 1;
            this.tokenFIeld.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tokenFIeld.CustomButton.UseSelectable = true;
            this.tokenFIeld.CustomButton.Visible = false;
            this.tokenFIeld.Lines = new string[0];
            this.tokenFIeld.Location = new System.Drawing.Point(267, 146);
            this.tokenFIeld.MaxLength = 32767;
            this.tokenFIeld.Name = "tokenFIeld";
            this.tokenFIeld.PasswordChar = '*';
            this.tokenFIeld.PromptText = "Twitch OAuth token....";
            this.tokenFIeld.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tokenFIeld.SelectedText = "";
            this.tokenFIeld.SelectionLength = 0;
            this.tokenFIeld.SelectionStart = 0;
            this.tokenFIeld.ShortcutsEnabled = true;
            this.tokenFIeld.Size = new System.Drawing.Size(296, 23);
            this.tokenFIeld.TabIndex = 2;
            this.tokenFIeld.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.tokenFIeld.UseSelectable = true;
            this.tokenFIeld.WaterMark = "Twitch OAuth token....";
            this.tokenFIeld.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tokenFIeld.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(378, 187);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 32);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // TwitchLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.tokenFIeld);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TwitchLogin";
            this.Size = new System.Drawing.Size(854, 258);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PoisonLabel poisonLabel1;
        private PoisonButton loginButton;
        public PoisonTextBox tokenFIeld;
    }
}
