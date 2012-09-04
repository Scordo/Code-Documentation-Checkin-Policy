using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class PropertiesConfigControl : UserControl, IPolicyConfigControl
    {
        public PropertiesConfigControl()
        {
            InitializeComponent();
        }

        void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
        {
            PropertyConfig controlConfig = config.PropertyConfig;
            Visibilities.Bind(controlConfig.VisibilitiesToCheck);

            OverridesOptionCheckBox.Checked = controlConfig.DocumentOverrides;
            ExplicitOptionCheckBox.Checked = controlConfig.ExplicitInterfacePropertyDocumentationRequired;
            InterfaceOptionCheckBox.Checked = controlConfig.InterfaceDeclarationDocumentationRequired;
            SummaryDocumentationTagCheckBox.Checked = controlConfig.SummaryDocumentationRequired;
            ReturnsDocumentationTagCheckBox.Checked = controlConfig.ResultDocumentationRequired;
        }

        void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
        {
            PropertyConfig controlConfig = config.PropertyConfig;
            controlConfig.VisibilitiesToCheck = Visibilities.GetVisibilites();

            controlConfig.DocumentOverrides = OverridesOptionCheckBox.Checked;
            controlConfig.ExplicitInterfacePropertyDocumentationRequired = InterfaceOptionCheckBox.Checked;
            controlConfig.InterfaceDeclarationDocumentationRequired = InterfaceOptionCheckBox.Checked;
            controlConfig.SummaryDocumentationRequired = SummaryDocumentationTagCheckBox.Checked;
            controlConfig.ResultDocumentationRequired = ReturnsDocumentationTagCheckBox.Checked;
        }
    }
}