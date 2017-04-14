using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THUVIEN
{
    public partial class MAINMENU : Form
    {
        public MAINMENU()
        {
            InitializeComponent();
        }

        private void BOOK_Click(object sender, EventArgs e)
        {
            if (!panelTHAOTAC.Controls.Contains(ModuleBOOK.Instance))
            {
                panelTHAOTAC.Controls.Add(ModuleBOOK.Instance);
                ModuleBOOK.Instance.Dock = DockStyle.Fill;
                ModuleBOOK.Instance.BringToFront();
            }
            else
            {
                ModuleBOOK.Instance.BringToFront();
            }
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DANGNHAP frm2 = new DANGNHAP();
            frm2.Show();
            this.Close();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void READER_Click(object sender, EventArgs e)
        {
            if (!panelTHAOTAC.Controls.Contains(ModuleReader.Instance))
            {
                panelTHAOTAC.Controls.Add(ModuleReader.Instance);
                ModuleReader.Instance.Dock = DockStyle.Fill;
                ModuleReader.Instance.BringToFront();
            }
            else
            {
                ModuleReader.Instance.BringToFront();
            }
        }
    }
}
