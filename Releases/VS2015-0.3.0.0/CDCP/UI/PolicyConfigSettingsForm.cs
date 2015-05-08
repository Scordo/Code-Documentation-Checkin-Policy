using System.Collections.Generic;
using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class PolicyConfigSettingsForm : Form, IPolicyConfigControl
    {
        private readonly List<IPolicyConfigControl> _configControls;

        public PolicyConfigSettingsForm()
        {
            InitializeComponent();
            _configControls = new List<IPolicyConfigControl>{ClassesConfigControlInstance, StructsConfigControlInstance, InterfacesConfigControlInstance, EnumsConfigControlInstance, EventsConfigControlInstance, DelegatesConfigControlInstance, FieldsConfigControlInstance, PropertiesConfigControlInstance, MethodsConfigControlInstance, GeneralConfigControlInstance};
        }

        void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
        {
            _configControls.ForEach(c => c.ReadFromConfig(config));
        }

        void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
        {
            _configControls.ForEach(c => c.WriteToConfig(config));
        }

        private void ResetToDefaultsButton_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Do you really want to reset the settings to the policy defaults?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                ((IPolicyConfigControl) this).ReadFromConfig(PolicyConfig.GetDefault());
        }
    }
}