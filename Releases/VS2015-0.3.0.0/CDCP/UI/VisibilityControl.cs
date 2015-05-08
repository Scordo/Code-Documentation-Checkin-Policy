using System.Collections.Generic;
using System.Windows.Forms;
using CDCP.Configuration;

namespace CDCP.UI
{
    public partial class VisibilityControl : UserControl
    {
        public VisibilityControl()
        {
            InitializeComponent();
        }

        public void Bind(HashSet<Visibility> visibilities)
        {
            visibilities = visibilities ?? new HashSet<Visibility>();
            PublicBox.Checked = visibilities.Contains(Visibility.Public);
            ProtectedBox.Checked = visibilities.Contains(Visibility.Protected);
            ProtectedInternalBox.Checked = visibilities.Contains(Visibility.ProtectedInternal);
            InternalBox.Checked = visibilities.Contains(Visibility.Internal);
            PrivateBox.Checked = visibilities.Contains(Visibility.Private);
        }

        public HashSet<Visibility> GetVisibilites()
        {

            HashSet<Visibility> visibilities = new HashSet<Visibility>();

            if (PublicBox.Checked) 
                visibilities.Add(Visibility.Public);

            if (ProtectedBox.Checked)
                visibilities.Add(Visibility.Protected);

            if (ProtectedInternalBox.Checked)
                visibilities.Add(Visibility.ProtectedInternal);

            if (InternalBox.Checked)
                visibilities.Add(Visibility.Internal);

            if (PrivateBox.Checked)
                visibilities.Add(Visibility.Private);

            return visibilities;
        }
    }
}