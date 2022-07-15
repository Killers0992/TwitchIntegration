namespace TwitchIntegration.Interface.Dialogs
{
    public partial class CreateSubscriptionDialog : PoisonUserControl
    {
        private MainPanel _mainPanel;

        public CreateSubscriptionDialog(MainPanel panel)
        {
            _mainPanel = panel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!metroSwitch1.Switched)
                _mainPanel.AddReSubscription(0, true);
            else
                _mainPanel.AddSubscription(0, true);

            ParentForm.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
