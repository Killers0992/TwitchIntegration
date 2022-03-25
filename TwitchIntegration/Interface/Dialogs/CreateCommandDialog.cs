namespace TwitchIntegration.Interface.Dialogs
{
    public partial class CreateCommandDialog : PoisonUserControl
    {
        private MainPanel _mainPanel;

        public CreateCommandDialog(MainPanel panel)
        {
            _mainPanel = panel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainPanel.AddCommand(actionName.Text);
            ParentForm.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
