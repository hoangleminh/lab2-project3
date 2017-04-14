using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THUVIEN
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R3VALK2\HOANGSV;Initial Catalog=THUVIEN;Integrated Security=True");
        private DataTable checkDANGNHAP(string username, string password)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "dangnhap_Check";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("username", SqlDbType.NVarChar)).Value = username;
            com.Parameters.Add(new SqlParameter("password", SqlDbType.NVarChar)).Value = password;
            SqlDataAdapter da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            con.Open();
            string user = txtUSERNAME.Text.Trim();
            string pass = txtUSERNAME.Text.Trim();
            dt = new DataTable();
            dt = checkDANGNHAP(user,pass);
            if (dt.Rows.Count>0)
            {
                MAINMENU frm1 = new MAINMENU();
                frm1.Show();
                this.Hide();
                MessageBox.Show("Đăng nhập thành công!!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu. Vui lòng nhập lại!!","THÔNG BÁO");
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
