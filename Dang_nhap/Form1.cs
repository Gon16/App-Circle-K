using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dang_nhap
{
    public partial class Form1 : Form
    {
        KetNoiSQL data = new KetNoiSQL();
        private BindingSource bdsource = new BindingSource();
        private DataTable DT = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            data.getConnect();
            SqlDataAdapter da = new SqlDataAdapter("select * from taikhoan where TaiKhoan='" + txttaikhoan.Text + "'and pass='" + txtpass.Text + "'", data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmain fr = new frmain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttaikhoan.ResetText();
                txtpass.ResetText();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pchide_Click(object sender, EventArgs e)
        {
            if(txtpass.PasswordChar == '*')
            {
                pcshow.BringToFront();
                txtpass.PasswordChar = '\0';
            }    
        }

        private void pcshow_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                pchide.BringToFront();
                txtpass.PasswordChar = '*';
            }
        }
    }
}
