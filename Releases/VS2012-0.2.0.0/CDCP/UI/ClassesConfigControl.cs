using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class ClassesConfigControl : UserControl, IPolicyConfigControl
    {
        public ClassesConfigControl()
        {
            InitializeComponent();
        }

        protected virtual ClassConfig GetConfig(PolicyConfig config)
        {
            return config.ClassConfig;
        }

        void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
        {
            ClassConfig controlConfig = GetConfig(config);
            Visibilities.Bind(controlConfig.VisibilitiesToCheck);
            GenericParametersOptionCheckBox.Checked = controlConfig.GenericParameterDocumentationRequired;
            SampleDocumentationTagCheckBox.Checked = controlConfig.SampleDocumentationRequired;
            SummaryDocumentationTagCheckBox.Checked = controlConfig.SummaryDocumentationRequired;
        }

        void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
        {
            ClassConfig controlConfig = GetConfig(config);
            controlConfig.VisibilitiesToCheck = Visibilities.GetVisibilites();
            controlConfig.GenericParameterDocumentationRequired = GenericParametersOptionCheckBox.Checked;
            controlConfig.SampleDocumentationRequired = SampleDocumentationTagCheckBox.Checked;
            controlConfig.SummaryDocumentationRequired = SummaryDocumentationTagCheckBox.Checked;
        }
    }
}