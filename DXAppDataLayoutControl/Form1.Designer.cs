
namespace DXAppDataLayoutControl
{
    partial class Form1
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.northwindDataSet = new DXAppDataLayoutControl.NorthwindDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new DXAppDataLayoutControl.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CustomerIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCustomerID = new DevExpress.XtraLayout.LayoutControlItem();
            this.CompanyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCompanyName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ContactNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForContactName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ContactTitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForContactTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.CityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.RegionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForRegion = new DevExpress.XtraLayout.LayoutControlItem();
            this.PostalCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPostalCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.CountryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.FaxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForFax = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.AddressMemoExEdit = new DevExpress.XtraEditors.MemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressMemoExEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.dataNavigator1);
            this.dataLayoutControl1.Controls.Add(this.CustomerIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CompanyNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactTitleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RegionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FaxTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressMemoExEdit);
            this.dataLayoutControl1.DataSource = this.customersBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(600, 339);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(600, 339);
            this.Root.TextVisible = false;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCustomerID,
            this.ItemForCompanyName,
            this.ItemForContactName,
            this.ItemForContactTitle,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(580, 319);
            // 
            // CustomerIDTextEdit
            // 
            this.CustomerIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "CustomerID", true));
            this.CustomerIDTextEdit.Location = new System.Drawing.Point(91, 12);
            this.CustomerIDTextEdit.Name = "CustomerIDTextEdit";
            this.CustomerIDTextEdit.Size = new System.Drawing.Size(497, 20);
            this.CustomerIDTextEdit.StyleController = this.dataLayoutControl1;
            this.CustomerIDTextEdit.TabIndex = 4;
            // 
            // ItemForCustomerID
            // 
            this.ItemForCustomerID.Control = this.CustomerIDTextEdit;
            this.ItemForCustomerID.Location = new System.Drawing.Point(0, 0);
            this.ItemForCustomerID.Name = "ItemForCustomerID";
            this.ItemForCustomerID.Size = new System.Drawing.Size(580, 24);
            this.ItemForCustomerID.Text = "Customer ID";
            this.ItemForCustomerID.TextSize = new System.Drawing.Size(75, 13);
            // 
            // CompanyNameTextEdit
            // 
            this.CompanyNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "CompanyName", true));
            this.CompanyNameTextEdit.Location = new System.Drawing.Point(305, 36);
            this.CompanyNameTextEdit.Name = "CompanyNameTextEdit";
            this.CompanyNameTextEdit.Size = new System.Drawing.Size(99, 20);
            this.CompanyNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CompanyNameTextEdit.TabIndex = 5;
            // 
            // ItemForCompanyName
            // 
            this.ItemForCompanyName.Control = this.CompanyNameTextEdit;
            this.ItemForCompanyName.Location = new System.Drawing.Point(214, 24);
            this.ItemForCompanyName.Name = "ItemForCompanyName";
            this.ItemForCompanyName.Size = new System.Drawing.Size(182, 24);
            this.ItemForCompanyName.Text = "Company Name";
            this.ItemForCompanyName.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ContactNameTextEdit
            // 
            this.ContactNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "ContactName", true));
            this.ContactNameTextEdit.Location = new System.Drawing.Point(91, 36);
            this.ContactNameTextEdit.Name = "ContactNameTextEdit";
            this.ContactNameTextEdit.Size = new System.Drawing.Size(131, 20);
            this.ContactNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactNameTextEdit.TabIndex = 6;
            // 
            // ItemForContactName
            // 
            this.ItemForContactName.Control = this.ContactNameTextEdit;
            this.ItemForContactName.Location = new System.Drawing.Point(0, 24);
            this.ItemForContactName.Name = "ItemForContactName";
            this.ItemForContactName.Size = new System.Drawing.Size(214, 24);
            this.ItemForContactName.Text = "Contact Name";
            this.ItemForContactName.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ContactTitleTextEdit
            // 
            this.ContactTitleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "ContactTitle", true));
            this.ContactTitleTextEdit.Location = new System.Drawing.Point(487, 36);
            this.ContactTitleTextEdit.Name = "ContactTitleTextEdit";
            this.ContactTitleTextEdit.Size = new System.Drawing.Size(101, 20);
            this.ContactTitleTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactTitleTextEdit.TabIndex = 7;
            // 
            // ItemForContactTitle
            // 
            this.ItemForContactTitle.Control = this.ContactTitleTextEdit;
            this.ItemForContactTitle.Location = new System.Drawing.Point(396, 24);
            this.ItemForContactTitle.Name = "ItemForContactTitle";
            this.ItemForContactTitle.Size = new System.Drawing.Size(184, 24);
            this.ItemForContactTitle.Text = "Contact Title";
            this.ItemForContactTitle.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.AddressMemoExEdit;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 48);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(556, 24);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(75, 13);
            // 
            // CityTextEdit
            // 
            this.CityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "City", true));
            this.CityTextEdit.Location = new System.Drawing.Point(103, 180);
            this.CityTextEdit.Name = "CityTextEdit";
            this.CityTextEdit.Size = new System.Drawing.Size(195, 20);
            this.CityTextEdit.StyleController = this.dataLayoutControl1;
            this.CityTextEdit.TabIndex = 9;
            // 
            // ItemForCity
            // 
            this.ItemForCity.Control = this.CityTextEdit;
            this.ItemForCity.Location = new System.Drawing.Point(0, 0);
            this.ItemForCity.Name = "ItemForCity";
            this.ItemForCity.Size = new System.Drawing.Size(278, 24);
            this.ItemForCity.Text = "City";
            this.ItemForCity.TextSize = new System.Drawing.Size(75, 13);
            // 
            // RegionTextEdit
            // 
            this.RegionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Region", true));
            this.RegionTextEdit.Location = new System.Drawing.Point(381, 180);
            this.RegionTextEdit.Name = "RegionTextEdit";
            this.RegionTextEdit.Size = new System.Drawing.Size(195, 20);
            this.RegionTextEdit.StyleController = this.dataLayoutControl1;
            this.RegionTextEdit.TabIndex = 10;
            // 
            // ItemForRegion
            // 
            this.ItemForRegion.Control = this.RegionTextEdit;
            this.ItemForRegion.Location = new System.Drawing.Point(278, 0);
            this.ItemForRegion.Name = "ItemForRegion";
            this.ItemForRegion.Size = new System.Drawing.Size(278, 24);
            this.ItemForRegion.Text = "Region";
            this.ItemForRegion.TextSize = new System.Drawing.Size(75, 13);
            // 
            // PostalCodeTextEdit
            // 
            this.PostalCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "PostalCode", true));
            this.PostalCodeTextEdit.Location = new System.Drawing.Point(381, 204);
            this.PostalCodeTextEdit.Name = "PostalCodeTextEdit";
            this.PostalCodeTextEdit.Size = new System.Drawing.Size(195, 20);
            this.PostalCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalCodeTextEdit.TabIndex = 11;
            // 
            // ItemForPostalCode
            // 
            this.ItemForPostalCode.Control = this.PostalCodeTextEdit;
            this.ItemForPostalCode.Location = new System.Drawing.Point(278, 24);
            this.ItemForPostalCode.Name = "ItemForPostalCode";
            this.ItemForPostalCode.Size = new System.Drawing.Size(278, 24);
            this.ItemForPostalCode.Text = "Postal Code";
            this.ItemForPostalCode.TextSize = new System.Drawing.Size(75, 13);
            // 
            // CountryTextEdit
            // 
            this.CountryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Country", true));
            this.CountryTextEdit.Location = new System.Drawing.Point(103, 204);
            this.CountryTextEdit.Name = "CountryTextEdit";
            this.CountryTextEdit.Size = new System.Drawing.Size(195, 20);
            this.CountryTextEdit.StyleController = this.dataLayoutControl1;
            this.CountryTextEdit.TabIndex = 12;
            // 
            // ItemForCountry
            // 
            this.ItemForCountry.Control = this.CountryTextEdit;
            this.ItemForCountry.Location = new System.Drawing.Point(0, 24);
            this.ItemForCountry.Name = "ItemForCountry";
            this.ItemForCountry.Size = new System.Drawing.Size(278, 24);
            this.ItemForCountry.Text = "Country";
            this.ItemForCountry.TextSize = new System.Drawing.Size(75, 13);
            // 
            // PhoneTextEdit
            // 
            this.PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Phone", true));
            this.PhoneTextEdit.Location = new System.Drawing.Point(103, 90);
            this.PhoneTextEdit.Name = "PhoneTextEdit";
            this.PhoneTextEdit.Size = new System.Drawing.Size(473, 20);
            this.PhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneTextEdit.TabIndex = 13;
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.Control = this.PhoneTextEdit;
            this.ItemForPhone.Location = new System.Drawing.Point(0, 0);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.Size = new System.Drawing.Size(556, 24);
            this.ItemForPhone.Text = "Phone";
            this.ItemForPhone.TextSize = new System.Drawing.Size(75, 13);
            // 
            // FaxTextEdit
            // 
            this.FaxTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Fax", true));
            this.FaxTextEdit.Location = new System.Drawing.Point(103, 114);
            this.FaxTextEdit.Name = "FaxTextEdit";
            this.FaxTextEdit.Size = new System.Drawing.Size(473, 20);
            this.FaxTextEdit.StyleController = this.dataLayoutControl1;
            this.FaxTextEdit.TabIndex = 14;
            // 
            // ItemForFax
            // 
            this.ItemForFax.Control = this.FaxTextEdit;
            this.ItemForFax.Location = new System.Drawing.Point(0, 24);
            this.ItemForFax.Name = "ItemForFax";
            this.ItemForFax.Size = new System.Drawing.Size(556, 24);
            this.ItemForFax.Text = "Fax";
            this.ItemForFax.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCity,
            this.ItemForPostalCode,
            this.ItemForRegion,
            this.ItemForCountry,
            this.ItemForAddress});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 138);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(580, 114);
            this.layoutControlGroup2.Text = "Address";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPhone,
            this.ItemForFax});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(580, 90);
            this.layoutControlGroup3.Text = "Phones";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.customersBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(12, 308);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(228, 19);
            this.dataNavigator1.StyleController = this.dataLayoutControl1;
            this.dataNavigator1.TabIndex = 15;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataNavigator1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 296);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(580, 23);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 252);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(580, 44);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // AddressMemoExEdit
            // 
            this.AddressMemoExEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customersBindingSource, "Address", true));
            this.AddressMemoExEdit.Location = new System.Drawing.Point(103, 228);
            this.AddressMemoExEdit.Name = "AddressMemoExEdit";
            this.AddressMemoExEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AddressMemoExEdit.Size = new System.Drawing.Size(473, 20);
            this.AddressMemoExEdit.StyleController = this.dataLayoutControl1;
            this.AddressMemoExEdit.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 339);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressMemoExEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraEditors.TextEdit CustomerIDTextEdit;
        private DevExpress.XtraEditors.TextEdit CompanyNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ContactNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ContactTitleTextEdit;
        private DevExpress.XtraEditors.TextEdit CityTextEdit;
        private DevExpress.XtraEditors.TextEdit RegionTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit CountryTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit FaxTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactTitle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRegion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountry;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFax;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.MemoExEdit AddressMemoExEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}

