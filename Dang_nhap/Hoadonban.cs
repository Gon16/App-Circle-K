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
    public partial class Hoadonban : Form
    {
        KetNoiSQL data = new KetNoiSQL();
        public Hoadonban()
        {
            InitializeComponent();
        }
        private void loadHD()
        {
            string str = "select HD.MAHD,HD.NGAYBAN, NV.MANV, NV.HOTENNV, KH.MAKH,KH.TENKH, KH.DIEMTL, KH.SĐT, HD.Thanhtien FROM HOADON HD JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH JOIN NHANVIEN NV ON NV.MANV = HD.MANV ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvhoadon.DataSource = dt;
        }






        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahd.Text = dgvhoadon.CurrentRow.Cells[0].Value.ToString();
            DTngayban.Text = dgvhoadon.CurrentRow.Cells[1].Value.ToString();
            txtmanv.Text = dgvhoadon.CurrentRow.Cells[2].Value.ToString();
            txttennv.Text = dgvhoadon.CurrentRow.Cells[3].Value.ToString();
            txtmakh.Text = dgvhoadon.CurrentRow.Cells[4].Value.ToString();
            txttenkh.Text = dgvhoadon.CurrentRow.Cells[5].Value.ToString();
            txtdiemtl.Text = dgvhoadon.CurrentRow.Cells[6].Value.ToString();
            txtsdt.Text = dgvhoadon.CurrentRow.Cells[7].Value.ToString();
            txttongtien.Text = dgvhoadon.CurrentRow.Cells[8].Value.ToString();

            string mahd = txtmahd.Text;
            string str = "select SP.MASP, SP.TENSP, SP.GIABAN, CT.SLBAN from Hoadon hd JOIN CTHOADON CT ON CT.MAHD = HD.MAHD JOIN SANPHAM  SP ON CT.MASP = SP.MASP where CT.MAHD = '" + mahd + "' ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcthoadon.DataSource = dt;


        }

        private void Hoadonban_Load(object sender, EventArgs e)
        {
            loadHD();
            DataGridView x = dgvhoadon;
            {
                x.Columns[0].Width = 70;
                x.Columns[1].Width = 100;
                x.Columns[2].Width = 70;
                x.Columns[3].Width = 200;
                x.Columns[4].Width = 150;
                x.Columns[5].Width = 150;
                x.Columns[6].Width = 150;
                x.Columns[7].Width = 150;
            }



        }

        private void dgvcthoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvcthoadon.CurrentRow.Cells[0].Value.ToString();
            txttensp.Text = dgvcthoadon.CurrentRow.Cells[1].Value.ToString();
            txtsl.Text = dgvcthoadon.CurrentRow.Cells[2].Value.ToString();
            txtdongia.Text = dgvcthoadon.CurrentRow.Cells[3].Value.ToString();

        }

        private void bttmkiem_Click(object sender, EventArgs e)
        {
            string str = "select HD.MAHD,HD.NGAYBAN, NV.MANV, NV.HOTENNV, KH.MAKH,KH.TENKH, KH.DIEMTL, KH.SĐT, HD.Thanhtien FROM HOADON HD JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH JOIN NHANVIEN NV ON NV.MANV = HD.MANV Where MaHD = '" + txttimkiem.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvhoadon.DataSource = dt;
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

        private void btin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RPHDB rp = new RPHDB();
            rp.ShowDialog();
            rp = null;
            this.Show();

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtdiemtl.Clear();
            txtmahd.Clear();
            txtdongia.Clear();
            txtmakh.Clear();
            txtmanv.Clear();
            txttennv.Clear();
            txtdiemtl.Clear();
            txtsdt.Clear();
            txttongtien.Clear();
            txttensp.Clear();
            txttenkh.Clear();
            txtmasp.Clear();
            txtsl.Clear();
            txtmahd.Focus();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtmahd.Text;
                string makh = txtmakh.Text;
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;
                string tenkh = txttenkh.Text;
                string diemtl = txtdiemtl.Text;
                string sđt = txtsdt.Text;
                string ngayban = DTngayban.Text;
                string masp = txtmasp.Text;
                string sl = txtsl.Text;
                string t = txttongtien.Text;
                string tensp = txttensp.Text;
                string gia = txtdongia.Text;
                data.ExecuteNonQuery("insert into Hoadon (MaHD, MaKH, MaNV,Ngayban, Thanhtien)  values ('" + mahd + "','" +makh+"','" +manv+"','"+ ngayban+"','" + t +"')" +
                    "insert into CTHoaDon values ('"+mahd+"', '"+masp+"','"+sl+"','"+gia+"')");
                MessageBox.Show("Thêm thành công");
                loadHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại bị trùng khóa !!", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Hoadonban_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();    
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string str = "select HD.MAHD,HD.NGAYBAN, NV.MANV, NV.HOTENNV, KH.MAKH,KH.TENKH, KH.DIEMTL, KH.SĐT, HD.Thanhtien FROM HOADON HD JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH JOIN NHANVIEN NV ON NV.MANV = HD.MANV ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvhoadon.DataSource = dt;  
        }
    }
}
