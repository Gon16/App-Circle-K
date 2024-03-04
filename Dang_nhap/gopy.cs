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
    public partial class gopy : Form
    {
        bool isthoat = true;
        
        public gopy()
        {
            InitializeComponent();
        }

        private void BTluu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu góp ý thành công", "Cảm ơn đã góp ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtgopy.ResetText();
        }

        private void btql_Click(object sender, EventArgs e)
        {
            isthoat = false;
            this.Close();
            frmain fm = new frmain();
            fm.Show();
            
        }

        private void gopy_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isthoat)
                Application.Exit();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
