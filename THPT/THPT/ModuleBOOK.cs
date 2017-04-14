using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace THUVIEN
{
    public partial class ModuleBOOK : UserControl
    {
        private static ModuleBOOK _instance;
        public static ModuleBOOK Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ModuleBOOK();
                return _instance;
            }
        }
        public ModuleBOOK()
        {
            InitializeComponent();
            btnUPDATE.Visible = false;
            btnDELETE.Visible = false;
        }

        DataTable dt;
        KetnoiCSDL kn = new KetnoiCSDL();
        
        private void ModuleBOOK_Load(object sender, EventArgs e)
        {
            loadForm();
            loadTextbox();
        }

        private void loadForm()
        {
            kn.loadSACH(this.dGVLISTBOOK);
        }

        private void loadTextbox()
        {
            txtNAMEBOOK.DataBindings.Clear();
            txtNAMEBOOK.DataBindings.Add("Text",dGVLISTBOOK.DataSource,"namebook");
            txtAUTHOR.DataBindings.Clear();
            txtAUTHOR.DataBindings.Add("Text",dGVLISTBOOK.DataSource,"author");
            txtTYPE.DataBindings.Clear();
            txtTYPE.DataBindings.Add("Text",dGVLISTBOOK.DataSource,"type");
            dTPDAYIN.DataBindings.Clear();
            dTPDAYIN.DataBindings.Add("Text",dGVLISTBOOK.DataSource,"dayin");
            txtNUMBER.DataBindings.Clear();
            txtNUMBER.DataBindings.Add("Text",dGVLISTBOOK.DataSource,"number");
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string namebook = txtNAMEBOOK.Text.Trim();
            string author = txtAUTHOR.Text.Trim();
            string type = txtTYPE.Text.Trim();
            DateTime dayin = DateTime.Parse(dTPDAYIN.Value.ToString());
            int number = int.Parse(txtNUMBER.Text.ToString());

            if(txtNAMEBOOK.Text.Trim()!= "")
            {
                kn.themSACH(namebook,author,type,dayin,number);
                MessageBox.Show("Đã thêm thành công", "THÔNG BÁO");
                loadForm();
                loadTextbox();
            }
        }

        private void dGVLISTBOOK_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dGVLISTBOOK.RowCount; i++)
            {
                dGVLISTBOOK[0, i].Value = i + 1;
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            string namebook = txtNAMEBOOK.Text.Trim();
            if(namebook == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin trước khi tìm kiếm!!","THÔNG BÁO");
            }
            else
            {
                dt = new DataTable();
                dt = kn.timkiemSACH(namebook);
                if(dt.Rows.Count>0)
                {
                    btnUPDATE.Visible = true;
                    btnDELETE.Visible = true;
                    dGVLISTBOOK.DataSource = dt;
                    loadTextbox();
                }
                else 
                {
                    MessageBox.Show("Truyện "+namebook+" không có trong danh sách!!","THÔNG BÁO");
                    loadForm();
                    loadTextbox();
                }
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            string namebook = txtNAMEBOOK.Text.Trim();
            string author = txtAUTHOR.Text.Trim();
            string type = txtTYPE.Text.Trim();
            DateTime dayin = DateTime.Parse(dTPDAYIN.Value.ToString());
            int number = int.Parse(txtNUMBER.Text.ToString());

            if (txtNAMEBOOK.Text.Trim() != "")
            {
                kn.suaSACH(namebook, author, type, dayin, number);
                MessageBox.Show("Đã sửa thành công", "THÔNG BÁO");
                loadForm();
                loadTextbox();
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string namebook = txtNAMEBOOK.Text.Trim();

            if (txtNAMEBOOK.Text.Trim() != "")
            {
                kn.xoaSACH(namebook);
                MessageBox.Show("Đã xóa thành công", "THÔNG BÁO");
                loadForm();
                loadTextbox();
            }
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            loadTextbox();
            loadForm();
        }

    }
}
