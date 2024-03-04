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
    public partial class NhanVien : Form
    {
        KetNoiSQL data = new KetNoiSQL();
        bool isthoat = true;
        public NhanVien()
        {
            InitializeComponent();
        }
        private void loadNV()
        {
            string str = "select * from Nhanvien ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNV.DataSource = dt;

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadNV();
            DataGridView x = dgvNV;
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

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txtTEnNV.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            txtchucvu.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
            DTNS.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            txtSEX.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
            txtdiachi.Text = dgvNV.CurrentRow.Cells[6].Value.ToString();
            txtsdt.Text = dgvNV.CurrentRow.Cells[7].Value.ToString();
            txtgmail.Text = dgvNV.CurrentRow.Cells[8].Value.ToString();


        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTEnNV.Clear();
            txtchucvu.Clear();
            txtsdt.Clear();
            txtSEX.Clear();
            txtgmail.Clear();
            txtdiachi.Clear();
            txtMaNV.Focus();
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
                    string manv = txtMaNV.Text; 
                    string tennv = txtTEnNV.Text;
                    string ngaysinh = DTNS.Text;
                    string diachi = txtdiachi.Text;
                    string sdt = txtsdt.Text;
                    string gmail = txtgmail.Text;
                    string chucvu = txtchucvu.Text;
                    string sex = txtSEX.Text;
                    data.ExecuteNonQuery("delete from NHANVIEN where MaNV='" + manv + "'");
                    MessageBox.Show("Xoá Sản phẩm " + tennv + " thành công !!", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNV();
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
                string manv = txtMaNV.Text;
                string tennv = txtTEnNV.Text;
                string ngaysinh = DTNS.Text;
                string diachi = txtdiachi.Text;
                string sdt = txtsdt.Text;
                string gmail = txtgmail.Text;
                string chucvu = txtchucvu.Text;
                string sex = txtSEX.Text;
                data.ExecuteNonQuery("update Nhanvien set MaNV='" + manv + "',MaCV=N'" + chucvu +
            "',HotenNV=N'" + tennv + "',diachi =N'" + diachi + "',Ngaysinh =N'" + ngaysinh + "',Gioitinh=N'" + sex + "',Gmail =N'" + gmail + "', SĐT='" + sdt + "'where MaNV='" + manv + "'");
                MessageBox.Show("Sửa thành công");
                loadNV();
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
                string manv = txtMaNV.Text;
                string tennv = txtTEnNV.Text;
                string ngaysinh = DTNS.Text;
                string diachi = txtdiachi.Text;
                string sdt = txtsdt.Text;
                string gmail = txtgmail.Text;
                string chucvu = txtchucvu.Text;
                string sex = txtSEX.Text;

                data.ExecuteNonQuery("insert into NHANVIEN(MaNV, MaCV, Ngaysinh, Gioitinh, diachi, SĐT, Gmail,HotenNV) values ('" + manv + "',N'" + chucvu + "',N'" + ngaysinh + "','" + sex + "','" + diachi + "','" + sdt + "','" + gmail + "',N'" + tennv+ "')");
                MessageBox.Show("Thêm thành công");
                loadNV();
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

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "select * from Nhanvien Where MaNV = '" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNV.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "select * from Nhanvien ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNV.DataSource = dt;

        }
    }
}
