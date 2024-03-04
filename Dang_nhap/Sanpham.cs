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
    public partial class Sanpham : Form
    {
        KetNoiSQL data = new KetNoiSQL();
        bool isthoat = true;
        public Sanpham()
        {
            InitializeComponent();
        }
        private void loadsanpham()
        {
            string str = "select * from SanPham ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSP.DataSource = dt;
        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            loadsanpham();
            DataGridView x = dgvSP;
            {
                x.Columns[0].Width = 70;
                x.Columns[1].Width = 70;
                x.Columns[2].Width = 150;
                x.Columns[3].Width = 70;
                x.Columns[4].Width = 110;
                x.Columns[5].Width = 110;
                x.Columns[6].Width = 110;
                x.Columns[7].Width = 150;

            }
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvSP.CurrentRow.Cells[0].Value.ToString();
            txtmaloaisp.Text = dgvSP.CurrentRow.Cells[1].Value.ToString();
            txtslt.Text = dgvSP.CurrentRow.Cells[4].Value.ToString();
            txttensp.Text = dgvSP.CurrentRow.Cells[2].Value.ToString();
            DTHSD.Text = dgvSP.CurrentRow.Cells[5].Value.ToString();
            txtDVT.Text = dgvSP.CurrentRow.Cells[3].Value.ToString();
            txtgianhap.Text = dgvSP.CurrentRow.Cells[6].Value.ToString();
            txtgiaban.Text = dgvSP.CurrentRow.Cells[7].Value.ToString();

        }



        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {

                string masp = txtmasp.Text;
                string malsp = txtmaloaisp.Text;
                string slt = txtslt.Text;
                string tensp = txttensp.Text;
                string HSD = DTHSD.Text;
                string dVT = txtDVT.Text;
                string gianhap = txtgianhap.Text;
                string giaban = txtgiaban.Text;

                data.ExecuteNonQuery("insert into SanPham values ('" + masp + "',N'" + malsp + "',N'" + tensp + "','" + dVT + "','" + slt + "','" + HSD + "','" + gianhap + "','" + giaban + "')");
                MessageBox.Show("Thêm thành công");
                loadsanpham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtgianhap.Clear();
            txtgiaban.Clear();
            txtmasp.Clear();
            txtslt.Clear();
            txttensp.Clear();
            txtmaloaisp.Clear();
            txtDVT.Clear();
            txtmasp.Focus();
        }

        private void btXOA_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn chắc chắn xoá???", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {

                    string masp = txtmasp.Text;
                    string malsp = txtmaloaisp.Text;
                    string slt = txtslt.Text;
                    string tensp = txttensp.Text;
                    string HSD = DTHSD.Text;
                    string dVT = txtDVT.Text;
                    string gianhap = txtgianhap.Text;
                    string giaban = txtgiaban.Text;
                    data.ExecuteNonQuery("delete from SANPHAM where MaSP='" + masp + "'");
                    MessageBox.Show("Xoá Sản phẩm " + tensp + " thành công !!", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadsanpham();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá Sản phẩm !!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BTSUA_Click(object sender, EventArgs e)
        {
               try
                {
                    string masp = txtmasp.Text;
                    string malsp = txtmaloaisp.Text;
                    string slt = txtslt.Text;
                    string tensp = txttensp.Text;
                    string HSD = DTHSD.Text;
                    string dVT = txtDVT.Text;
                    string gianhap = txtgianhap.Text;
                    string giaban = txtgiaban.Text;
                    data.ExecuteNonQuery("update SANPHAM set MaSP='" + masp + "',MaLSP=N'" + malsp +
                "',TenSp=N'" + tensp + "',Donvitinh =N'" + dVT + "',HSD =N'" + HSD + "',SOluongton='" + slt + "',Giaban =N'" + giaban + "', GiaNhap='" + gianhap + "'where MaSP='" + masp + "'");
                    MessageBox.Show("Sửa thành công");
                    loadsanpham();
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

        private void Sanpham_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "select * from SanPham where MaSP = '" +textBox1.Text+ "' ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSP.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "select * from SanPham ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSP.DataSource = dt;

        }
    }
}
