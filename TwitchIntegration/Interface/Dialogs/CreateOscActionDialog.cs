namespace TwitchIntegration.Interface.Dialogs
{
    public partial class CreateOscActionDialog : PoisonUserControl
    {
        public CreateOscActionDialog()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
