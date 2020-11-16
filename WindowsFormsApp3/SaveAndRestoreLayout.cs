using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class SaveAndRestoreLayout : DevExpress.XtraEditors.XtraForm
    {
        private string xmlFile = "c:\\Tmp\\DockStates\\MainState.xml";

        public SaveAndRestoreLayout()
        {
            InitializeComponent();
        }

        private void SaveAndRestoreLayout_Load(object sender, EventArgs e)
        {
            dockManager1.RestoreLayoutFromXml(xmlFile);
        }

        private void SaveAndRestoreLayout_FormClosing(object sender, FormClosingEventArgs e)
        {
            dockManager1.SaveLayoutToXml(xmlFile);
        }

        private void dockPanel6_DragDrop(object sender, DragEventArgs e)
        {

        }

        
        private void dockPanel6_Move(object sender, EventArgs e)
        {

        }

        private void dockManager1_EndDocking(object sender, DevExpress.XtraBars.Docking.EndDockingEventArgs e)
        {

        }
    }
}