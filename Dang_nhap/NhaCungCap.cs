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
    public partial class NhaCungCap : Form
    {
        KetNoiSQL data = new KetNoiSQL();
        public NhaCungCap()
        {
            InitializeComponent();
        }
        private void loadNCC()
        {
            string str = "select * FROM NhaCungCap ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNCC.DataSource = dt;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            loadNCC();
            DataGridView x = dgvNCC;
            {
                x.Columns[0].Width = 70;
                x.Columns[1].Width = 70;
                x.Columns[2].Width = 250;
                x.Columns[3].Width = 70;
                x.Columns[4].Width = 150;
            }

        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            txtgmail.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtNCC.Clear();
            txtTenNCC.Clear();
            txtDiachi.Clear();
            txtgmail.Clear();
            txtsdt.Clear();
            txtNCC.Focus();
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
                    string mancc = txtNCC.Text;
                    string tenncc = txtTenNCC.Text;
                    string diachi = txtDiachi.Text;
                    string gmail = txtgmail.Text;
                    string sđt = txtsdt.Text;
                    
                    data.ExecuteNonQuery("delete from NhaCungCap where MaNCC='" + mancc + "'");
                    MessageBox.Show("Xoá Sản phẩm " + tenncc + " thành công !!", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNCC();
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
                string mancc = txtNCC.Text;
                string tenncc = txtTenNCC.Text;
                string diachi = txtDiachi.Text;
                string gmail = txtgmail.Text;
                string sđt = txtsdt.Text;
                data.ExecuteNonQuery("update NhaCungCap set MaNCC ='" + mancc + "',TenNCC =N'" + tenncc +
            "',Diachi =N'" + diachi + "',sđt =N'" + sđt + "',Gmail =N'" + gmail + "'where MaNCC ='" + mancc + "'");
                MessageBox.Show("Sửa thành công");
                loadNCC();
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
                string mancc = txtNCC.Text;
                string tenncc = txtTenNCC.Text;
                string diachi = txtDiachi.Text;
                string gmail = txtgmail.Text;
                string sđt = txtsdt.Text;

                data.ExecuteNonQuery("insert into NhaCungCap  values ('" + mancc + "',N'" + tenncc + "',N'" + diachi + "',N'" + sđt + "','" + gmail + "')");
                MessageBox.Show("Thêm thành công");
                loadNCC();
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

        private void NhaCungCap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "select * from NhaCungCap where MaNCC = '"+ textBox1.Text+"' ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNCC.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "select * from NhaCungCap ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNCC.DataSource = dt;
        }
    }
}
