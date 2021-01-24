using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach.Report.ReportSLBan
{
    public partial class frmReportSLBan : DevExpress.XtraEditors.XtraForm
    {
        frmMain frm1;
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public frmReportSLBan()
        {
            InitializeComponent();
        }
        public frmReportSLBan(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }


        private void frmReportSLBan1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string month1 = dateTimePicker1.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Month.ToString() : dateTimePicker1.Value.Month.ToString();
            string formDate = dateTimePicker1.Value.Year.ToString() + "-" + month1;
            string month2 = dateTimePicker2.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker2.Value.Month.ToString() : dateTimePicker2.Value.Month.ToString();
            string toDate = dateTimePicker2.Value.Year.ToString() + "-" + month2;
            // TODO: This line of code loads data into the 'DataSet1QLSLBan.ReportSLBan' table. You can move, or remove it, as needed.
            this.ReportSLBanTableAdapter.Fill(this.DataSet1QLSLBan.ReportSLBan, formDate, toDate);
            reportViewer1.LocalReport.Refresh();
            
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month1 = dateTimePicker1.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Month.ToString() : dateTimePicker1.Value.Month.ToString();
            string formDate = dateTimePicker1.Value.Year.ToString() + "-" + month1;
            string month2 = dateTimePicker2.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker2.Value.Month.ToString() : dateTimePicker2.Value.Month.ToString();
            string toDate = dateTimePicker2.Value.Year.ToString() + "-" + month2;
            // TODO: This line of code loads data into the 'DataSet1QLSLBan.ReportSLBan' table. You can move, or remove it, as needed.
            this.ReportSLBanTableAdapter.Fill(this.DataSet1QLSLBan.ReportSLBan, formDate, toDate);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}