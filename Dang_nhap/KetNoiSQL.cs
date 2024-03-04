using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dang_nhap
{
    internal class KetNoiSQL
    {
        private string connectString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
        public SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();
            return conn;
        }
        public DataTable ThongtinKH()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from  KhachHang", getConnect());
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinTaikhoan()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from  taikhoan", getConnect());
            adapter.Fill(data);
            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection ketnoi = new SqlConnection(connectString))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                data = thucthi.ExecuteNonQuery();
            }
            return data;
        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ketnoi = new SqlConnection(connectString))
            {
                ketnoi.Open();
                SqlCommand thucthi = new SqlCommand(query, ketnoi);
                SqlDataAdapter laydulieu = new SqlDataAdapter(thucthi);
                laydulieu.Fill(dt);
                ketnoi.Close();
            }
            return dt;
        }

    }
}
