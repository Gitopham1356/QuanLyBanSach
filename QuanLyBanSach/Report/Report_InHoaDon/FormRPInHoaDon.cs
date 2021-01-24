using Microsoft.Reporting.WinForms;
using QuanLyBanSach.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach.Report.Report_InHoaDon
{
    public partial class FormRPInHoaDon : Form
    {
        private frmBanHang_LapHoaDon frmLapHDLocal;

        public FormRPInHoaDon()
        {
            InitializeComponent();
        }

        private void FormRPInHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewerInHD.RefreshReport();
        }

        public FormRPInHoaDon(frmBanHang_LapHoaDon frmLapHD)
        {
            InitializeComponent();
            frmLapHDLocal = frmLapHD;

        }

        private void reportViewerInHD_Load(object sender, EventArgs e)
        {
            QLBanSachDataContext db = new QLBanSachDataContext();

            string maKH = frmLapHDLocal.TextMaKH;
            string maHD = frmLapHDLocal.TextMaHD;
        

            // CTHD, HoaDon, KhachHang
            var query = (
                from ct in db.CTHDs
                join hd in db.HoaDons on ct.MaHD equals hd.MaHD
                join sach in db.Saches on ct.MaS equals sach.MaS
                join kh in db.KhachHangs on hd.MaKH equals kh.MaKH
                where hd.MaHD == maHD && kh.MaKH == maKH
                select new
                {
                    hd.MaHD,
                    sach.MaS,
                    sach.TenS,
                    hd.NgayLapHD,
                    kh.MaKH,
                    kh.TenKH,
                    ct.GiaBan,
                    ct.SoLuongBan
                });

            List<ClassInHoaDon> ListInHoaDon = new List<ClassInHoaDon>();


            ReportParameter MaKHParam = new ReportParameter("MaKHParam");
            ReportParameter TenKHParam = new ReportParameter("TenKHParam");
            ReportParameter NgayLapParam = new ReportParameter("NgayLapParam");
            ReportParameter MaHDParam = new ReportParameter("MaHDParam");

            foreach (var item in query)
            {
                ClassInHoaDon classInHD = new ClassInHoaDon();
                classInHD.MaS = item.MaS;
                classInHD.TenS = item.TenS;
                classInHD.GiaBan = (int)item.GiaBan;
                classInHD.SoLuongBan = (int)item.SoLuongBan;
                ListInHoaDon.Add(classInHD);

                MaKHParam.Values.Add(item.MaKH);
                TenKHParam.Values.Add(item.TenKH);
                NgayLapParam.Values.Add(item.NgayLapHD.ToString());
                MaHDParam.Values.Add(item.MaHD);
            }

            this.reportViewerInHD.LocalReport.ReportPath = "ReportInHoaDon.rdlc";

            var reportDataSource = new ReportDataSource("DataSetInHoaDon", ListInHoaDon);
            this.reportViewerInHD.LocalReport.DataSources.Clear();

            this.reportViewerInHD.LocalReport.SetParameters(MaKHParam);
            this.reportViewerInHD.LocalReport.SetParameters(TenKHParam);
            this.reportViewerInHD.LocalReport.SetParameters(NgayLapParam);
            this.reportViewerInHD.LocalReport.SetParameters(MaHDParam);

            this.reportViewerInHD.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerInHD.RefreshReport();
        }
    }
}
