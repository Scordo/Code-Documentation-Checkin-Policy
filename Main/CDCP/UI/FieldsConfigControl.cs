using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class FieldsConfigControl : UserControl, IPolicyConfigControl
    {
        public FieldsConfigControl()
        {
            InitializeComponent();
        }

        void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
        {
            FieldConfig controlConfig = config.FieldConfig;
            Visibilities.Bind(controlConfig.VisibilitiesToCheck);

            SummaryDocumentationTagCheckBox.Checked = controlConfig.SummaryDocumentationRequired; 
        }

        void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
        {
            FieldConfig controlConfig = config.FieldConfig;
            controlConfig.VisibilitiesToCheck = Visibilities.GetVisibilites();

            controlConfig.SummaryDocumentationRequired = SummaryDocumentationTagCheckBox.Checked;
        }
    }
}