namespace TwitchIntegration.Interface
{
    public partial class OscItem : PoisonUserControl
    {

        public OscItem()
        {
            InitializeComponent();
        }

        public int ID { get; set; }

        string _actionName;

        [Category("Osc Item")]
        public string ActionName
        {
            get
            {
                return _actionName;
            }
            set
            {
                _actionName = value;
                actionName.Text = value;
            }
        }

        int _executionDuration;
        [Category("Osc Item")]
        public int ExecutionDuration
        {
            get
            {
                return _executionDuration;
            }
            set
            {
                _executionDuration = value;
                executionDuration.Value = value;
            }
        }

        string _value;
        [Category("Osc Item")]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                this.oscValue.Text = value;
            }
        }

        string _defaultValue;
        [Category("Osc Item")]
        public string DefaultValue
        {
            get
            {
                return _defaultValue;
            }
            set
            {
                _defaultValue = value;
                this.defaultValue.Text = value;
            }
        }
    }
}
