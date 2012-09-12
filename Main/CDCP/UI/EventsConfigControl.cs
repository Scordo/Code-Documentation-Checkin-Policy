using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class EventsConfigControl : UserControl, IPolicyConfigControl
    {
        public EventsConfigControl()
        {
            InitializeComponent();
        }

        void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
        {
            EventConfig controlConfig = config.EventConfig;
            Visibilities.Bind(controlConfig.VisibilitiesToCheck);

            OverridesOptionCheckBox.Checked = controlConfig.DocumentOverrides;
            ExplicitOptionCheckBox.Checked = controlConfig.ExplicitInterfaceEventDocumentationRequired;
            InterfaceOptionCheckBox.Checked = controlConfig.InterfaceDeclarationDocumentationRequired;
            SummaryDocumentationTagCheckBox.Checked = controlConfig.SummaryDocumentationRequired; 
        }

        void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
        {
            EventConfig controlConfig = config.EventConfig;
            controlConfig.VisibilitiesToCheck = Visibilities.GetVisibilites();

            controlConfig.DocumentOverrides = OverridesOptionCheckBox.Checked;
            controlConfig.ExplicitInterfaceEventDocumentationRequired = ExplicitOptionCheckBox.Checked;
            controlConfig.InterfaceDeclarationDocumentationRequired = InterfaceOptionCheckBox.Checked;
            controlConfig.SummaryDocumentationRequired = SummaryDocumentationTagCheckBox.Checked;
        }
    }
}