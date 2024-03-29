﻿using TwitchIntegration.Interfaces;

namespace TwitchIntegration.Interface
{
    public partial class OscItem : PoisonUserControl
    {
        public IActionRemovable ParentPanel;

        public OscItem(IActionRemovable parentPanel)
        {
            ParentPanel = parentPanel;
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

        decimal _executionDuration;
        [Category("Osc Item")]
        public decimal ExecutionDuration
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
