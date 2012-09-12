using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class MethodsConfigControl : UserControl, IPolicyConfigControl
    {
        public MethodsConfigControl()
        {
            InitializeComponent();
        }

        void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
        {
            MethodConfig controlConfig = config.MethodConfig;
            Visibilities.Bind(controlConfig.VisibilitiesToCheck);

            GenericParametersOptionCheckBox.Checked = controlConfig.GenericParameterDocumentationRequired;
            ParametersOptionCheckBox.Checked = controlConfig.ParameterDocumentationRequired;
            OverridesOptionCheckBox.Checked = controlConfig.DocumentOverrides;
            ExplicitOptionCheckBox.Checked = controlConfig.ExplicitInterfaceMethodDocumentationRequired;
            InterfaceOptionCheckBox.Checked = controlConfig.InterfaceDeclarationDocumentationRequired;
            ReturnsDocumentationTagCheckBox.Checked = controlConfig.ResultDocumentationRequired;
            SampleDocumentationTagCheckBox.Checked = controlConfig.SampleDocumentationRequired;
            SummaryDocumentationTagCheckBox.Checked = controlConfig.SummaryDocumentationRequired; 
        }

        void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
        {
            MethodConfig controlConfig = config.MethodConfig;
            controlConfig.VisibilitiesToCheck = Visibilities.GetVisibilites();

            controlConfig.GenericParameterDocumentationRequired = GenericParametersOptionCheckBox.Checked;
            controlConfig.ParameterDocumentationRequired = ParametersOptionCheckBox.Checked;
            controlConfig.DocumentOverrides = OverridesOptionCheckBox.Checked;
            controlConfig.ExplicitInterfaceMethodDocumentationRequired = ExplicitOptionCheckBox.Checked;
            controlConfig.InterfaceDeclarationDocumentationRequired = InterfaceOptionCheckBox.Checked;
            controlConfig.ResultDocumentationRequired = ReturnsDocumentationTagCheckBox.Checked;
            controlConfig.SampleDocumentationRequired = SampleDocumentationTagCheckBox.Checked;
            controlConfig.SummaryDocumentationRequired = SummaryDocumentationTagCheckBox.Checked;
        }
    }
}