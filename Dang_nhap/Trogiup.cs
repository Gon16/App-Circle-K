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
    public partial class Trogiup : Form
    {
        bool isthoat = true;
        public Trogiup()
        {
            InitializeComponent();
        }

        private void BTgui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng đợi trong giây lát chúng tôi sẽ phản hồi bạn nhanh nhất có thể", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txttrogiup.ResetText();
        }

        private void btql_Click(object sender, EventArgs e)
        {
            isthoat = false;
            this.Close();
            frmain fm = new frmain();
            fm.Show();
        }


        private void Trogiup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isthoat)
                Application.Exit();
        }
    }
}
