using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dang_nhap
{
    public partial class KhachHang : Form
    {
        KetNoiSQL data = new KetNoiSQL();
        bool isthoat = true;
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadKH();
            DataGridView x = dgvKH;
            {
                x.Columns[0].Width = 200;
                x.Columns[1].Width = 200;
                x.Columns[2].Width = 250;
                x.Columns[3].Width = 200;
                x.Columns[4].Width = 210;
                x.Columns[5].Width = 210;
            }
        }
        private void loadKH()
        {
            string str = "select makh, tenkh , Gioitinh, sđt, malkh, diemtl from khachhang ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKH.DataSource = dt;

        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
            txttenkh.Text = dgvKH.CurrentRow.Cells[1].Value.ToString();
            txtsex.Text = dgvKH.CurrentRow.Cells[2].Value.ToString();
            txtsđt.Text = dgvKH.CurrentRow.Cells[3].Value.ToString();
            txtlkh.Text = dgvKH.CurrentRow.Cells[4].Value.ToString();
            txtdiemtl.Text = dgvKH.CurrentRow.Cells[5].Value.ToString();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtsex.Clear();
            txtsđt.Clear();
            txtlkh.Clear();
            txtdiemtl.Clear();
            txtmakh.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn chắc chắn xoá???", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    string makh = txtmakh.Text;
                    string tenkh = txttenkh.Text;
                    string sex = txtsex.Text;
                    string sdt = txtsđt.Text;
                    string malkh = txtlkh.Text;
                    string diemtl = txtdiemtl.Text;
                    data.ExecuteNonQuery("delete from KHACHHANG where MaKH='" + makh + "'");
                    MessageBox.Show("Xoá Sản phẩm " + tenkh + " thành công !!", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadKH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá Sản phẩm !!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtmakh.Text;
                string tenkh = txttenkh.Text;
                string sex = txtsex.Text;
                string sdt = txtsđt.Text;
                string malkh = txtlkh.Text;
                string diemtl = txtdiemtl.Text;
                data.ExecuteNonQuery("update KHACHHANG set MaKH='" + makh + "',MaLKH=N'" + malkh +
            "',tenkh =N'" + tenkh + "',Gioitinh =N'" + sex + "',sđt =N'" + sdt + "',diemtl =N'" + diemtl + "'where MaKH='" + makh + "'");
                MessageBox.Show("Sửa thành công");
                loadKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtmakh.Text;
                string tenkh = txttenkh.Text;
                string sex = txtsex.Text;
                string sdt = txtsđt.Text;
                string malkh = txtlkh.Text;
                string diemtl = txtdiemtl.Text;

                data.ExecuteNonQuery("insert into Khachhang (makh, tenkh , Gioitinh, sđt, malkh, diemtl) values ('" + makh + "',N'" + tenkh + "',N'" + sex+ "',N'" + sdt + "','" + malkh + "','" + diemtl + "')");
                MessageBox.Show("Thêm thành công");
                loadKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn chắc chắn thoát???", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string str = "select makh, tenkh , Gioitinh, sđt, malkh, diemtl from khachhang ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKH.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "select makh, tenkh , Gioitinh, sđt, malkh, diemtl from khachhang Where MaKH = '" + txttimkiem.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKH.DataSource = dt;

        }
    }
}
