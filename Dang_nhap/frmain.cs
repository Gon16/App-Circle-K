using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dang_nhap
{
    public partial class frmain : Form
    {
        string TaiKhoan = "", pass = "", quyen = "";
        bool isthoat = true;
        public frmain()
        {
            InitializeComponent();
        }
        public frmain(string TaiKhoan, string pass, string quyen)
        {
            InitializeComponent();
            this.TaiKhoan = TaiKhoan;
            this.pass = pass;   
            this.quyen = quyen;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isthoat)
            Application.Exit();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
            kh = null;
            this.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                this.Hide();
                Sanpham sp = new Sanpham();
                sp.ShowDialog();
                sp = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào trang này!!");
            }    
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

                this.Hide();
                NhanVien nv = new NhanVien();
                nv.ShowDialog();
                nv = null;
                this.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                this.Hide();
                NhaCungCap ncc = new NhaCungCap();
                ncc.ShowDialog();
                ncc = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào trang này!!");
            }

        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoadonban hdb = new Hoadonban();
            hdb.ShowDialog();
            hdb = null;
            this.Show();

        }

        private void hàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            hangton ht = new hangton();
            ht.ShowDialog();
            ht = null;
            this.Show();

        }

        private void gópÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gopy gy = new gopy();
            gy.ShowDialog();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isthoat = false;
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }



        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuNhap fpn = new PhieuNhap();
            fpn.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isthoat)
            Application.Exit();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trogiup tg = new Trogiup();
            tg.ShowDialog();
        }
    }
}
