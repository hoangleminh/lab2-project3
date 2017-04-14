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
    public partial class ModuleReader : UserControl
    {
        private static ModuleReader _instance;
        public static ModuleReader Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ModuleReader();
                return _instance;
            }
        }
        public ModuleReader()
        {
            InitializeComponent();
            comNATIVE.Items.Add("An Giang");
            comNATIVE.Items.Add("Bà Rịa - Vũng Tàu");
            comNATIVE.Items.Add("Bắc Giang");
            comNATIVE.Items.Add("Bắc Cạn");
            comNATIVE.Items.Add("Bạc Liêu");
            comNATIVE.Items.Add("Bắc Ninh");
            comNATIVE.Items.Add("Bến Tre");
            comNATIVE.Items.Add("Bình Định");
            comNATIVE.Items.Add("Bình Dương");
            comNATIVE.Items.Add("Bình Phước");
            comNATIVE.Items.Add("Bình Thuận");
            comNATIVE.Items.Add("Cà Mau");
            comNATIVE.Items.Add("Cao Bằng");
            comNATIVE.Items.Add("Đăk Lăk");
            comNATIVE.Items.Add("Đăk Nông");
            comNATIVE.Items.Add("Điện Biên");
            comNATIVE.Items.Add("Đồng Nai");
            comNATIVE.Items.Add("Đồng Tháp");
            comNATIVE.Items.Add("Gia Lai");
            comNATIVE.Items.Add("Hà Giang");
            comNATIVE.Items.Add("Hà Nam");
            comNATIVE.Items.Add("Hà Tĩnh");
            comNATIVE.Items.Add("Hải Dương");
            comNATIVE.Items.Add("Hậu Giang");
            comNATIVE.Items.Add("Hòa Bình");
            comNATIVE.Items.Add("Hưng Yên");
            comNATIVE.Items.Add("Khánh Hòa");
            comNATIVE.Items.Add("Kiên Giang");
            comNATIVE.Items.Add("Kon Tum");
            comNATIVE.Items.Add("Lai Châu");
            comNATIVE.Items.Add("Lâm Đồng");
            comNATIVE.Items.Add("Lạng Sơn");
            comNATIVE.Items.Add("Lào Cai");
            comNATIVE.Items.Add("Long An");
            comNATIVE.Items.Add("Nam Định");
            comNATIVE.Items.Add("Nghệ An");
            comNATIVE.Items.Add("Ninh Bình");
            comNATIVE.Items.Add("Ninh Thuận");
            comNATIVE.Items.Add("Phú Thọ");
            comNATIVE.Items.Add("Quảng Bình");
            comNATIVE.Items.Add("Quảng Nam");
            comNATIVE.Items.Add("Quảng Ngãi");
            comNATIVE.Items.Add("Quảng Ninh");
            comNATIVE.Items.Add("Quảng Trị");
            comNATIVE.Items.Add("Sóc Trăng");
            comNATIVE.Items.Add("Sơn La");
            comNATIVE.Items.Add("Tây Ninh");
            comNATIVE.Items.Add("Thái Bình");
            comNATIVE.Items.Add("Thái Nguyên");
            comNATIVE.Items.Add("Thanh Hóa");
            comNATIVE.Items.Add("Thừa Thiên Huế");
            comNATIVE.Items.Add("Tiền Giang");
            comNATIVE.Items.Add("Trà Vinh");
            comNATIVE.Items.Add("Tuyên Quang");
            comNATIVE.Items.Add("Vĩnh Long");
            comNATIVE.Items.Add("Vĩnh Phúc");
            comNATIVE.Items.Add("Yên Bái");
            comNATIVE.Items.Add("Phú Yên");
            comNATIVE.Items.Add("Cần Thơ");
            comNATIVE.Items.Add("Đà Nẵng");
            comNATIVE.Items.Add("Hải Phòng");
            comNATIVE.Items.Add("Hà Nội");
            comNATIVE.Items.Add("TP HCM");
            comTypereader.Items.Add("Giáo viên");
            comTypereader.Items.Add("Sinh viên");
            btnDELETE.Visible = false;
            btnUPDATE.Visible = false;
            btnREFRESH.Visible = false;
        }

        DataTable dt;
        KetnoiCSDL kn = new KetnoiCSDL();

        private void loadForm2()
        {
            kn.loadREADER(this.dGVReader);
        }

        private void loadTextbox2()
        {
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dGVReader.DataSource, "name");
            dTPNgaysinh.DataBindings.Clear();
            dTPNgaysinh.DataBindings.Add("Text", dGVReader.DataSource, "ngaysinh");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dGVReader.DataSource, "socmnd");
            comNATIVE.DataBindings.Clear();
            comNATIVE.DataBindings.Add("Text", dGVReader.DataSource, "quequan");
            txtSosachmuon.DataBindings.Clear();
            txtSosachmuon.DataBindings.Add("Text", dGVReader.DataSource, "sosachmuon");
            comTypereader.DataBindings.Clear();
            comTypereader.DataBindings.Add("Text", dGVReader.DataSource, "typereader");
        }
        private void ModuleReader_Load(object sender, EventArgs e)
        {
            loadForm2();
            loadTextbox2();
        }
        private void dGVReader_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dGVReader.RowCount; i++)
            {
                dGVReader[0, i].Value = i + 1;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            DateTime ngaysinh = DateTime.Parse(dTPNgaysinh.Value.ToString());
            string socmnd = txtCMND.Text.Trim();
            string quequan = comNATIVE.Text.Trim();
            int sosachmuon = int.Parse(txtSosachmuon.Text.Trim());
            string typereader = comTypereader.Text.Trim();
           
            if(name !="")
            {
                kn.themREADER(name,ngaysinh,socmnd,quequan,sosachmuon,typereader);
                MessageBox.Show("Đã thêm thành công", "THÔNG BÁO");
                btnREFRESH.Visible = true;
                btnDELETE.Visible = true;
                btnUPDATE.Visible = true;
                dGVReader.DataSource = dt;
                loadForm2();
                loadTextbox2();
            }
        }

        private void btnFIND_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if(name == "")
            {
                MessageBox.Show("Vui lòng nhập tên người dùng trước khi tìm kiếm!!","THÔNG BÁO");
            }
            else
            {
                dt = new DataTable();
                dt = kn.timkiemREADER(name);
                if(dt.Rows.Count>0)
                {
                    btnREFRESH.Visible = true;
                    btnDELETE.Visible = true;
                    btnUPDATE.Visible = true;
                    dGVReader.DataSource = dt;
                    loadTextbox2();
                }
                else
                {
                    MessageBox.Show(name+ " không có trong danh sách!!","THÔNG BÁO");
                    loadForm2();
                    loadTextbox2();
                }
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if(name != "")
            {
                kn.xoaREADER(name);
                MessageBox.Show("Đã xóa "+name+" thành công!!","THÔNG BÁO");
                loadForm2();
                loadTextbox2();
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            DateTime ngaysinh = DateTime.Parse(dTPNgaysinh.Value.ToString());
            string socmnd = txtCMND.Text.Trim();
            string quequan = comNATIVE.Text.Trim();
            int sosachmuon = int.Parse(txtSosachmuon.Text.Trim());
            string typereader = comTypereader.Text.Trim();
            if (name == "")
            {
                kn.suaREADER(name, ngaysinh, socmnd, quequan, sosachmuon, typereader);
                MessageBox.Show(name + " đã sửa thành công", "THÔNG BÁO");
                loadForm2();
                loadTextbox2();
            }
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            loadTextbox2();
            loadForm2();
        }
    }
}
