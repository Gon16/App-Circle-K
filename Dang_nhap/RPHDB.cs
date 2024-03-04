using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dang_nhap.Model;
using Microsoft.Reporting.WinForms;

namespace Dang_nhap
{
    public partial class RPHDB : Form
    {
        public RPHDB()
        {
            InitializeComponent();
        }

        HDBDB HOADON = new HDBDB();

        private void RPHDB_Load(object sender, EventArgs e)
        {
            
            List<Hoadon> listHoadon = HOADON.Hoadon.ToList();
            this.reportViewer1.LocalReport.ReportPath = "./hdb.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1",listHoadon);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
