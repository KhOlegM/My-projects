using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView1.QueryControl += tabbedView1_QueryControl;
        }

        // Assigning a required content for each auto generated Document
        void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == userControl1Document)
                e.Control = new WindowsFormsApp2.UserControl1();
            if (e.Document == userControl2Document)
                e.Control = new WindowsFormsApp2.UserControl2();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        private void panelContainer2_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel10_Click(object sender, EventArgs e)
        {

        }
    }
}
