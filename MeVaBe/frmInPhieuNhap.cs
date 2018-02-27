using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace MeVaBe
{
    public partial class frmInPhieuNhap : Form
    {
        public frmInPhieuNhap()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            List<PhieuNhapHang> dsPN = context.PhieuNhapHangs.ToList();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MeVaBe.Report1.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dsPN;
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
