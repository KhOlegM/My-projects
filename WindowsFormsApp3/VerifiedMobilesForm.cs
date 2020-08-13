using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp3
{
    public partial class VerifiedMobilesForm : DevExpress.XtraEditors.XtraForm
    {
        public VerifiedMobilesForm()
        {
            InitializeComponent();
        }

        private void treeListDepart_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }
    }
}