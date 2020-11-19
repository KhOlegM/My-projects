using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXAppDataLayoutControl
{
    /// <summary>
    /// https://docs.devexpress.com/WindowsForms/4922/controls-and-libraries/form-layout-managers/layout-and-data-layout-controls/getting-started/tutorial-creating-a-simple-data-layout
    /// </summary>
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }
    }
}
