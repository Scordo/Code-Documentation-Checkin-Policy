using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class EnumsConfigControl : UserControl, IPolicyConfigControl
    {
        public EnumsConfigControl()
        {
            InitializeComponent();
        }

        void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
        {
            EnumConfig controlConfig = config.EnumConfig;
            Visibilities.Bind(controlConfig.VisibilitiesToCheck);

            SummaryDocumentationTagCheckBox.Checked = controlConfig.SummaryDocumentationRequired; 
        }

        void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
        {
            EnumConfig controlConfig = config.EnumConfig;
            controlConfig.VisibilitiesToCheck = Visibilities.GetVisibilites();

            controlConfig.SummaryDocumentationRequired = SummaryDocumentationTagCheckBox.Checked;
        }
    }
}