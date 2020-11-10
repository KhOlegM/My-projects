﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class SuffixUPNEditForm : DevExpress.XtraEditors.XtraForm
    {
        public SuffixUPNEditForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            suffixUPNTableAdapter1.Fill(dataSetCUB1.SuffixUPN);
        }

        private void SuffixUPNEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCUB.SuffixUPN' table. You can move, or remove it, as needed.
            this.suffixUPNTableAdapter.Fill(this.dataSetCUB.SuffixUPN);

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "isActive", true);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //this.dataSetCUB.SuffixUPN.AcceptChanges();
            //this.suffixUPNTableAdapter.Update( (this.dataSetCUB.SuffixUPN);
            this.suffixUPNTableAdapter.Update(((System.Data.DataRowView)e.Row).Row);
        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            //this.suffixUPNTableAdapter.Delete(((DataRowView)e.Row).Row.ItemArray[0], ((DataRowView)e.Row).Row.ItemArray[0], ((DataRowView)e.Row).Row.ItemArray[0], ((DataRowView)e.Row).Row.ItemArray[0]);
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            var row = ((DataRowView)e.Row).Row.ItemArray;
            this.suffixUPNTableAdapter.Delete((int)row[0], row[1].ToString(), (bool)row[2], row[3].ToString()=="" ? null : row[3].ToString());
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}