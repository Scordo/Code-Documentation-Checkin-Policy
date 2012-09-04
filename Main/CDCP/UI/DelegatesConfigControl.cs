using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class DelegateConfigControl : UserControl, IPolicyConfigControl
    {
        public DelegateConfigControl()
        {
            InitializeComponent();
        }

        void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
        {
            DelegateConfig controlConfig = config.DelegateConfig;
            Visibilities.Bind(controlConfig.VisibilitiesToCheck);

            GenericParametersOptionCheckBox.Checked = controlConfig.GenericParameterDocumentationRequired;
            ParametersOptionCheckBox.Checked = controlConfig.ParameterDocumentationRequired;
            ReturnsDocumentationTagCheckBox.Checked = controlConfig.ResultDocumentationRequired;
            SampleDocumentationTagCheckBox.Checked = controlConfig.SampleDocumentationRequired;
            SummaryDocumentationTagCheckBox.Checked = controlConfig.SummaryDocumentationRequired; 
        }

        void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
        {
            DelegateConfig controlConfig = config.DelegateConfig;
            controlConfig.VisibilitiesToCheck = Visibilities.GetVisibilites();

            controlConfig.GenericParameterDocumentationRequired = GenericParametersOptionCheckBox.Checked;
            controlConfig.ParameterDocumentationRequired = ParametersOptionCheckBox.Checked;
            controlConfig.ResultDocumentationRequired = ReturnsDocumentationTagCheckBox.Checked;
            controlConfig.SampleDocumentationRequired = SampleDocumentationTagCheckBox.Checked;
            controlConfig.SummaryDocumentationRequired = SummaryDocumentationTagCheckBox.Checked;
        }
    }
}