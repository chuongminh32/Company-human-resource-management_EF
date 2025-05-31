using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyHRManagement.Reports;
using Microsoft.Reporting.WinForms;

namespace CompanyHRManagement.GUI.admin
{
    public partial class ReportSalaries_Form : Form
    {
        private DataTable luongTable;
        private string chucVu;
        private string phongban;
        private string countLuong;
        public ReportSalaries_Form(DataTable dt, string chucVuText, string phongBanText, string countLuongText )
        {
            InitializeComponent();
            luongTable = dt;
            chucVu = chucVuText;
            phongban = phongBanText;
            countLuong = countLuongText;
        }

        private void ReportSalaries_Form_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("LuongDataSet", luongTable); // "LuongDataSet" là tên dataset bạn gán trong RDLC

            // Gán giá trị cho tham số
            ReportParameter[] reportParams = new ReportParameter[]
            {
                new ReportParameter("chucVu", chucVu),
                new ReportParameter("phongBan", phongban),
                new ReportParameter("CountNV", countLuong)

            };

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = "Reports\\RptSalaries.rdlc";
            reportViewer1.LocalReport.SetParameters(reportParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
