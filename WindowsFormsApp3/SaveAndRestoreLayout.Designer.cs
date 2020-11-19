
namespace WindowsFormsApp3
{
    partial class SaveAndRestoreLayout
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel5 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel5_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel6 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel6_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel4.SuspendLayout();
            this.dockPanel5.SuspendLayout();
            this.dockPanel6.SuspendLayout();
            this.dockPanel6_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel4,
            this.dockPanel5,
            this.dockPanel6});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            this.dockManager1.EndDocking += new DevExpress.XtraBars.Docking.EndDockingEventHandler(this.dockManager1_EndDocking);
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel4.ID = new System.Guid("2d1851c0-f807-4338-ad1f-44f91fd195d1");
            this.dockPanel4.Location = new System.Drawing.Point(0, 0);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel4.Size = new System.Drawing.Size(200, 494);
            this.dockPanel4.Text = "dockPanel4";
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(191, 467);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // dockPanel5
            // 
            this.dockPanel5.Controls.Add(this.dockPanel5_Container);
            this.dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel5.ID = new System.Guid("bcfc3e64-52f4-4a46-a476-922e453c2f65");
            this.dockPanel5.Location = new System.Drawing.Point(200, 0);
            this.dockPanel5.Name = "dockPanel5";
            this.dockPanel5.OriginalSize = new System.Drawing.Size(198, 200);
            this.dockPanel5.Size = new System.Drawing.Size(198, 494);
            this.dockPanel5.Text = "dockPanel5";
            // 
            // dockPanel5_Container
            // 
            this.dockPanel5_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel5_Container.Name = "dockPanel5_Container";
            this.dockPanel5_Container.Size = new System.Drawing.Size(189, 467);
            this.dockPanel5_Container.TabIndex = 0;
            // 
            // dockPanel6
            // 
            this.dockPanel6.Controls.Add(this.dockPanel6_Container);
            this.dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel6.DockVertical = DevExpress.Utils.DefaultBoolean.True;
            this.dockPanel6.FloatVertical = true;
            this.dockPanel6.ID = new System.Guid("1309179d-5773-490f-b712-e2bc0b423a84");
            this.dockPanel6.Location = new System.Drawing.Point(398, 0);
            this.dockPanel6.Name = "dockPanel6";
            this.dockPanel6.OriginalSize = new System.Drawing.Size(507, 494);
            this.dockPanel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dockPanel6.Size = new System.Drawing.Size(507, 494);
            this.dockPanel6.Text = "dockPanel6";
            this.dockPanel6.DragDrop += new System.Windows.Forms.DragEventHandler(this.dockPanel6_DragDrop);
            this.dockPanel6.Move += new System.EventHandler(this.dockPanel6_Move);
            // 
            // dockPanel6_Container
            // 
            this.dockPanel6_Container.Controls.Add(this.xtraTabControl1);
            this.dockPanel6_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel6_Container.Name = "dockPanel6_Container";
            this.dockPanel6_Container.Size = new System.Drawing.Size(499, 466);
            this.dockPanel6_Container.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(499, 466);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(493, 438);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(493, 438);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // SaveAndRestoreLayout
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 494);
            this.Controls.Add(this.dockPanel6);
            this.Controls.Add(this.dockPanel5);
            this.Controls.Add(this.dockPanel4);
            this.Name = "SaveAndRestoreLayout";
            this.Text = "SaveAndRestoreLayout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveAndRestoreLayout_FormClosing);
            this.Load += new System.EventHandler(this.SaveAndRestoreLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel4.ResumeLayout(false);
            this.dockPanel5.ResumeLayout(false);
            this.dockPanel6.ResumeLayout(false);
            this.dockPanel6_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel6;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel6_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel5;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel5_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
    }
}