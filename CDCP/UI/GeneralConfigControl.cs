using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
  public partial class GeneralConfigControl : UserControl, IPolicyConfigControl
  {
    public GeneralConfigControl()
    {
      InitializeComponent();
    }

    void IPolicyConfigControl.ReadFromConfig(PolicyConfig config)
    {
      SkipMergesCheckBox.Checked = config.SkipMerges;
      SkipBranchesCheckBox.Checked = config.SkipBranches;
      SkipRollbacksCheckBox.Checked = config.SkipRollbacks;
      SkipUndeletesCheckBox.Checked = config.SkipUndeletes;
    }

    void IPolicyConfigControl.WriteToConfig(PolicyConfig config)
    {
      config.SkipMerges = SkipMergesCheckBox.Checked;
      config.SkipBranches = SkipBranchesCheckBox.Checked;
      config.SkipRollbacks = SkipRollbacksCheckBox.Checked;
      config.SkipUndeletes = SkipUndeletesCheckBox.Checked;
    }
  }
}