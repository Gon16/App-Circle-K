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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dang_nhap
{
    public partial class hangton : Form
    {
        KetNoiSQL data = new KetNoiSQL();
        bool isthoat = true;
        public hangton()
        {
            InitializeComponent();
        }
        private void loadhangton()
        {
            string str = "select MaSP,MaLSP, TenSP, SoLuongTon, HSD, GiaNhap from SanPham ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvhangton.DataSource = dt;
        }
        private void hangton_Load(object sender, EventArgs e)
        {
            loadhangton();
            DataGridView x = dgvhangton;
            {
                x.Columns[0].Width = 70;
                x.Columns[1].Width = 70;
                x.Columns[2].Width = 150;
                x.Columns[3].Width = 70;
                x.Columns[4].Width = 110;
                x.Columns[5].Width = 110;

            }
        }

        private void dgvhangton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvhangton.CurrentRow.Cells[0].Value.ToString();
            txtMLSP.Text = dgvhangton.CurrentRow.Cells[1].Value.ToString();
            txtslt.Text = dgvhangton.CurrentRow.Cells[3].Value.ToString();
            txttensp.Text = dgvhangton.CurrentRow.Cells[2].Value.ToString();
            dthsd.Text = dgvhangton.CurrentRow.Cells[4].Value.ToString();
            txtdongia.Text = dgvhangton.CurrentRow.Cells[5].Value.ToString();
            

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtdongia.Clear();
            txtmasp.Clear();
            txtslt.Clear();
            txttensp.Clear();
            txtMLSP.Clear();
            txtmasp.Focus();
        }

        private void btLUU_Click(object sender, EventArgs e)
        {
            try
            {

                string masp = txtmasp.Text;
                string malsp = txtMLSP.Text;
                string slt = txtslt.Text;
                string tensp = txttensp.Text;
                string HSD = dthsd.Text;
                string dongia = txtdongia.Text;
                data.ExecuteNonQuery("insert into SanPham (MaSP, MaLSP, TenSP, Soluongton, HSD, Gianhap ) values ('" + masp + "',N'" + malsp + "',N'" + tensp + "','" + slt + "','" + HSD + "','" + dongia + "')");
                MessageBox.Show("Thêm thành công");
                loadhangton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

                    string masp = txtmasp.Text;
                    string malsp = txtMLSP.Text;
                    string slt = txtslt.Text;
                    string tensp = txttensp.Text;
                    string HSD = dthsd.Text;
                    string dongia = txtdongia.Text;
                    data.ExecuteNonQuery("delete from SANPHAM where MaSP='" + masp + "'");
                    MessageBox.Show("Xoá Sản phẩm " + tensp + " thành công !!", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadhangton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá Sản phẩm !!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtmasp.Text;
                string malsp = txtMLSP.Text;
                string slt = txtslt.Text;
                string tensp = txttensp.Text;
                string HSD = dthsd.Text;
                string dongia = txtdongia.Text;
                data.ExecuteNonQuery("update SANPHAM set MaSP='" + masp + "',MaLSP=N'" + malsp +
                "',TenSp=N'" + tensp + "',HSD =N'" + HSD + "',SOluongton='" + slt + "', GiaNhap='" + dongia + "'where MaSP='" + masp + "'");
                MessageBox.Show("Sửa thành công");
                loadhangton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void hangton_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
