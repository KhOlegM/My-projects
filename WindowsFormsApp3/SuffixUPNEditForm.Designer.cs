namespace WindowsFormsApp3
{
    partial class SuffixUPNEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.dataSetCUBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCUB = new WindowsFormsApp3.DataSetCUB();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsuffixName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.suffixUPNTableAdapter = new WindowsFormsApp3.DataSetCUBTableAdapters.SuffixUPNTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSetCUB1 = new WindowsFormsApp3.DataSetCUB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsuffixId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsuffixName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colisActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.suffixUPNTableAdapter1 = new WindowsFormsApp3.DataSetCUBTableAdapters.SuffixUPNTableAdapter();
            this.colhostLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(12, 12);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.dataSetCUBBindingSource;
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(499, 20);
            this.gridLookUpEdit1.TabIndex = 0;
            // 
            // dataSetCUBBindingSource
            // 
            this.dataSetCUBBindingSource.DataMember = "SuffixUPN";
            this.dataSetCUBBindingSource.DataSource = this.dataSetCUB;
            // 
            // dataSetCUB
            // 
            this.dataSetCUB.DataSetName = "DataSetCUB";
            this.dataSetCUB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsuffixName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colsuffixName
            // 
            this.colsuffixName.FieldName = "suffixName";
            this.colsuffixName.Name = "colsuffixName";
            this.colsuffixName.Visible = true;
            this.colsuffixName.VisibleIndex = 0;
            // 
            // suffixUPNTableAdapter
            // 
            this.suffixUPNTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "SuffixUPN";
            this.gridControl1.DataSource = this.dataSetCUB1;
            this.gridControl1.Location = new System.Drawing.Point(12, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(499, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSetCUB1
            // 
            this.dataSetCUB1.DataSetName = "DataSetCUB";
            this.dataSetCUB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsuffixId,
            this.colsuffixName1,
            this.colisActive,
            this.colhostLogin});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView1_RowDeleting);
            this.gridView1.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridView1_RowDeleted);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colsuffixId
            // 
            this.colsuffixId.FieldName = "suffixId";
            this.colsuffixId.Name = "colsuffixId";
            // 
            // colsuffixName1
            // 
            this.colsuffixName1.ColumnEdit = this.repositoryItemTextEdit1;
            this.colsuffixName1.FieldName = "suffixName";
            this.colsuffixName1.Name = "colsuffixName1";
            this.colsuffixName1.Visible = true;
            this.colsuffixName1.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colisActive
            // 
            this.colisActive.FieldName = "isActive";
            this.colisActive.Name = "colisActive";
            // 
            // suffixUPNTableAdapter1
            // 
            this.suffixUPNTableAdapter1.ClearBeforeFill = true;
            // 
            // colhostLogin
            // 
            this.colhostLogin.FieldName = "hostLogin";
            this.colhostLogin.Name = "colhostLogin";
            // 
            // SuffixUPNEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 314);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Name = "SuffixUPNEditForm";
            this.Text = "SuffixUPNEditForm";
            this.Load += new System.EventHandler(this.SuffixUPNEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource dataSetCUBBindingSource;
        private DataSetCUB dataSetCUB;
        private DataSetCUBTableAdapters.SuffixUPNTableAdapter suffixUPNTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colsuffixName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DataSetCUB dataSetCUB1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colsuffixId;
        private DevExpress.XtraGrid.Columns.GridColumn colsuffixName1;
        private DevExpress.XtraGrid.Columns.GridColumn colisActive;
        private DataSetCUBTableAdapters.SuffixUPNTableAdapter suffixUPNTableAdapter1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colhostLogin;
    }
}