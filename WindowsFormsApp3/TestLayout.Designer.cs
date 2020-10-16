namespace WindowsFormsApp3
{
    partial class TestLayout
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
            this.dtLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dataSetCUB = new WindowsFormsApp3.DataSetCUB();
            this.dataSetCUBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.suffixUPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suffixUPNTableAdapter = new WindowsFormsApp3.DataSetCUBTableAdapters.SuffixUPNTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new WindowsFormsApp3.DataSetCUBTableAdapters.PeopleTableAdapter();
            this.colINN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colfirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisBusinessPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtLayoutControl)).BeginInit();
            this.dtLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suffixUPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLayoutControl
            // 
            this.dtLayoutControl.Controls.Add(this.checkBox1);
            this.dtLayoutControl.Controls.Add(this.gridControl1);
            this.dtLayoutControl.Controls.Add(this.lookUpEdit1);
            this.dtLayoutControl.DataSource = this.dataSetCUBBindingSource;
            this.dtLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.dtLayoutControl.Name = "dtLayoutControl";
            this.dtLayoutControl.Root = this.Root;
            this.dtLayoutControl.Size = new System.Drawing.Size(696, 463);
            this.dtLayoutControl.TabIndex = 0;
            this.dtLayoutControl.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(696, 463);
            this.Root.TextVisible = false;
            // 
            // dataSetCUB
            // 
            this.dataSetCUB.DataSetName = "DataSetCUB";
            this.dataSetCUB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetCUBBindingSource
            // 
            this.dataSetCUBBindingSource.DataSource = this.dataSetCUB;
            this.dataSetCUBBindingSource.Position = 0;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 420);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(676, 23);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(447, 12);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.suffixUPNBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "suffixName";
            this.lookUpEdit1.Properties.ValueMember = "suffixId";
            this.lookUpEdit1.Size = new System.Drawing.Size(237, 20);
            this.lookUpEdit1.StyleController = this.dtLayoutControl;
            this.lookUpEdit1.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(338, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(338, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // suffixUPNBindingSource
            // 
            this.suffixUPNBindingSource.DataMember = "SuffixUPN";
            this.suffixUPNBindingSource.DataSource = this.dataSetCUBBindingSource;
            // 
            // suffixUPNTableAdapter
            // 
            this.suffixUPNTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.peopleBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(672, 392);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colINN,
            this.colfirstName,
            this.collastName,
            this.colisBusinessPartner});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(676, 396);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.dataSetCUBBindingSource;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // colINN
            // 
            this.colINN.FieldName = "INN";
            this.colINN.Name = "colINN";
            this.colINN.Visible = true;
            this.colINN.VisibleIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.peopleBindingSource, "isBusinessPartner", true));
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(334, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(338, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colfirstName
            // 
            this.colfirstName.FieldName = "firstName";
            this.colfirstName.Name = "colfirstName";
            this.colfirstName.Visible = true;
            this.colfirstName.VisibleIndex = 0;
            // 
            // collastName
            // 
            this.collastName.FieldName = "lastName";
            this.collastName.Name = "collastName";
            this.collastName.Visible = true;
            this.collastName.VisibleIndex = 1;
            // 
            // colisBusinessPartner
            // 
            this.colisBusinessPartner.FieldName = "isBusinessPartner";
            this.colisBusinessPartner.Name = "colisBusinessPartner";
            this.colisBusinessPartner.Visible = true;
            this.colisBusinessPartner.VisibleIndex = 2;
            // 
            // TestLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 463);
            this.Controls.Add(this.dtLayoutControl);
            this.Name = "TestLayout";
            this.Text = "TestLayout";
            this.Load += new System.EventHandler(this.TestLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLayoutControl)).EndInit();
            this.dtLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCUBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suffixUPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dtLayoutControl;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource dataSetCUBBindingSource;
        private DataSetCUB dataSetCUB;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource suffixUPNBindingSource;
        private DataSetCUBTableAdapters.SuffixUPNTableAdapter suffixUPNTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private DataSetCUBTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colINN;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colfirstName;
        private DevExpress.XtraGrid.Columns.GridColumn collastName;
        private DevExpress.XtraGrid.Columns.GridColumn colisBusinessPartner;
    }
}