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

        private void VerifiedMobilesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCUB.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.dataSetCUB.People);
            // TODO: This line of code loads data into the 'dataSetCUB.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.dataSetCUB.People);

        }
    }
}