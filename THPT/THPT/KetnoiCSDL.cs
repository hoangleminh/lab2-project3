using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace THUVIEN
{
    public class KetnoiCSDL
    {
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-R3VALK2\HOANGSV;Initial Catalog=THUVIEN;Integrated Security=True");
        DataTable dt2 = new DataTable();

        public void loadSACH(DataGridView dGVLISTBOOK)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql = "LISTBOOK_LOAD";
                SqlCommand com2 = new SqlCommand(sql, con2);
                com2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da2 = new SqlDataAdapter(com2);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dGVLISTBOOK.DataSource = dt2;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void loadREADER(DataGridView dGVReader)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql = "READER_LOAD";
                SqlCommand com2 = new SqlCommand(sql, con2);
                com2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da2 = new SqlDataAdapter(com2);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dGVReader.DataSource = dt2;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void themSACH(string namebook, string author, string type, DateTime dayin, int number)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "LISTBOOK_ADD";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("namebook", SqlDbType.NVarChar)).Value = namebook;
                com2.Parameters.Add(new SqlParameter("author", SqlDbType.NVarChar)).Value = author;
                com2.Parameters.Add(new SqlParameter("type", SqlDbType.NVarChar)).Value = type;
                com2.Parameters.Add(new SqlParameter("dayin", SqlDbType.Date)).Value = dayin;
                com2.Parameters.Add(new SqlParameter("number", SqlDbType.Int)).Value = number;
                
                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void themREADER(string name, DateTime ngaysinh, string socmnd, string quequan, int sosachmuon, string typereader)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "READER_ADD";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("name", SqlDbType.NVarChar)).Value = name;
                com2.Parameters.Add(new SqlParameter("ngaysinh", SqlDbType.DateTime)).Value = ngaysinh;
                com2.Parameters.Add(new SqlParameter("socmnd", SqlDbType.NVarChar)).Value = socmnd;
                com2.Parameters.Add(new SqlParameter("quequan", SqlDbType.NVarChar)).Value = quequan;
                com2.Parameters.Add(new SqlParameter("sosachmuon", SqlDbType.Int)).Value = sosachmuon;
                com2.Parameters.Add(new SqlParameter("typereader", SqlDbType.NVarChar)).Value = typereader;

                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void suaSACH(string namebook, string author, string type, DateTime dayin, int number)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "LISTBOOK_UPDATE";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("namebook", SqlDbType.NVarChar)).Value = namebook;
                com2.Parameters.Add(new SqlParameter("author", SqlDbType.NVarChar)).Value = author;
                com2.Parameters.Add(new SqlParameter("type", SqlDbType.NVarChar)).Value = type;
                com2.Parameters.Add(new SqlParameter("dayin", SqlDbType.Date)).Value = dayin;
                com2.Parameters.Add(new SqlParameter("number", SqlDbType.Int)).Value = number;

                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" +ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void suaREADER(string name, DateTime ngaysinh, string socmnd, string quequan, int sosachmuon, string typereader)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "READER_UPDATE";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("name", SqlDbType.NVarChar)).Value = name;
                com2.Parameters.Add(new SqlParameter("ngaysinh", SqlDbType.DateTime)).Value = ngaysinh;
                com2.Parameters.Add(new SqlParameter("socmnd", SqlDbType.NVarChar)).Value = socmnd;
                com2.Parameters.Add(new SqlParameter("quequan", SqlDbType.NVarChar)).Value = quequan;
                com2.Parameters.Add(new SqlParameter("sosachmuon", SqlDbType.Int)).Value = sosachmuon;
                com2.Parameters.Add(new SqlParameter("typereader", SqlDbType.NVarChar)).Value = typereader;

                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void xoaSACH(string namebook)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "LISTBOOK_DELETE";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("namebook", SqlDbType.NVarChar)).Value = namebook;

                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void xoaREADER(string name)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "LISTBOOK_DELETE";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("name", SqlDbType.NVarChar)).Value = name;

                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public DataTable timkiemSACH(string namebook)
        {
            if (con2.State == ConnectionState.Closed)
                con2.Open();
            string sql2 = "LISTBOOK_FIND";
            SqlCommand com2 = new SqlCommand(sql2, con2);
            com2.CommandType = CommandType.StoredProcedure;
            com2.Parameters.Add(new SqlParameter("namebook", SqlDbType.NVarChar)).Value = namebook;
            SqlDataAdapter da = new SqlDataAdapter(com2);
            dt2 = new DataTable();
            da.Fill(dt2);
            con2.Close();
            return dt2; 
        }

        public DataTable timkiemREADER(string name)
        {
            if (con2.State == ConnectionState.Closed)
                con2.Open();
            string sql2 = "READER_FIND";
            SqlCommand com2 = new SqlCommand(sql2, con2);
            com2.CommandType = CommandType.StoredProcedure;
            com2.Parameters.Add(new SqlParameter("name", SqlDbType.NVarChar)).Value = name;
            SqlDataAdapter da2 = new SqlDataAdapter(com2);
            dt2 = new DataTable();
            da2.Fill(dt2);
            con2.Close();
            return dt2; 
        }
    }
}
