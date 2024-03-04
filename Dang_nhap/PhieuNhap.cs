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
    public partial class PhieuNhap : Form
    {
        KetNoiSQL data = new KetNoiSQL();
        bool isthoat = true;
        public PhieuNhap()
        {
            InitializeComponent();
        }
        private void loadPN()
        {
            string str = "select PN.MANHAP, PN.NGAYNHAP, NV.MANV, NV.HOTENNV, NCC.MANCC, NCC.TENNCC, NCC.DiaChi, NCC.SĐT, PN.Thanhtien FROM PhieuNhapSP PN JOIN NhaCungCap NCC ON PN.MaNCC = NCC.MaNCC JOIN NHANVIEN NV ON NV.MANV = PN.MANV ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPN.DataSource = dt;
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            loadPN();
            DataGridView x = dgvPN;
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

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmapn.Text = dgvPN.CurrentRow.Cells[0].Value.ToString();
            DTngaynhap.Text = dgvPN.CurrentRow.Cells[1].Value.ToString();
            txtmanv.Text = dgvPN.CurrentRow.Cells[2].Value.ToString();
            txttennv.Text = dgvPN.CurrentRow.Cells[3].Value.ToString();
            txtmancc.Text = dgvPN.CurrentRow.Cells[4].Value.ToString();
            txttenncc.Text = dgvPN.CurrentRow.Cells[5].Value.ToString();
            txtdiachi.Text = dgvPN.CurrentRow.Cells[6].Value.ToString();
            txtsdt.Text = dgvPN.CurrentRow.Cells[7].Value.ToString();
            txttongtien.Text = dgvPN.CurrentRow.Cells[8].Value.ToString();

            string mapn = txtmapn.Text;
            string str = "select SP.MASP, SP.TENSP, SP.GIANHAP, CT.SLNhap from PhieuNhapSP hd JOIN CTNhap CT ON CT.MANHAP = HD.MANHAP JOIN SANPHAM  SP ON CT.MASP = SP.MASP where CT.MANhap = '" + mapn + "' ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvctpn.DataSource = dt;
        }

        private void dgvctpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvctpn.CurrentRow.Cells[0].Value.ToString();
            txttensp.Text = dgvctpn.CurrentRow.Cells[1].Value.ToString();
            txtsl.Text = dgvctpn.CurrentRow.Cells[2].Value.ToString();
            txtdongia.Text = dgvctpn.CurrentRow.Cells[3].Value.ToString();
        }

        private void bttmkiem_Click(object sender, EventArgs e)
        {
            string str = "select PN.MANHAP, PN.NGAYNHAP, NV.MANV, NV.HOTENNV, NCC.MANCC, NCC.TENNCC, NCC.DiaChi, NCC.SĐT, PN.Thanhtien FROM PhieuNhapSP PN JOIN NhaCungCap NCC ON PN.MaNCC = NCC.MaNCC JOIN NHANVIEN NV ON NV.MANV = PN.MANV Where MaNhap = '" + txttimkiem.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPN.DataSource = dt;
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            string str = "select PN.MANHAP, PN.NGAYNHAP, NV.MANV, NV.HOTENNV, NCC.MANCC, NCC.TENNCC, NCC.DiaChi, NCC.SĐT, PN.Thanhtien FROM PhieuNhapSP PN JOIN NhaCungCap NCC ON PN.MaNCC = NCC.MaNCC JOIN NHANVIEN NV ON NV.MANV = PN.MANV ";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPN.DataSource = dt;
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
            MessageBox.Show("In hóa đơn thành công", "In hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtdiachi.Clear();
            txtmapn.Clear();
            txtdongia.Clear();
            txtmancc.Clear();
            txtmanv.Clear();
            txttennv.Clear();
            txtsdt.Clear();
            txttongtien.Clear();
            txttensp.Clear();
            txttenncc.Clear();
            txtmasp.Clear();
            txtsl.Clear();
            txtmapn.Focus();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                string mapn = txtmapn.Text;
                string mancc = txtmancc.Text;
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;
                string tenncc = txttenncc.Text;
                string diachi = txtdiachi.Text;
                string sđt = txtsdt.Text;
                string ngaynhap = DTngaynhap.Text;
                string masp = txtmasp.Text;
                string sl = txtsl.Text;
                string t = txttongtien.Text;
                string tensp = txttensp.Text;
                string gia = txtdongia.Text;
                data.ExecuteNonQuery("insert into PhieunhapSP (MaNhap, MaNCC, MaNV, Ngaynhap, Thanhtien)  values ('" + mapn + "','" + mancc + "','" + manv + "','" + ngaynhap + "','" + t + "')" +
                    "insert into CTnhap values ('" + mapn + "', '" + masp + "','" + sl + "','" + gia + "')");
                MessageBox.Show("Thêm thành công");
                loadPN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại bị trùng khóa !!", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PhieuNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isthoat)
            Application.Exit();
        }
    }
}
