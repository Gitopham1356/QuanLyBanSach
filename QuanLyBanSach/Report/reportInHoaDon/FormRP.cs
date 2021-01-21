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

namespace QuanLyBanSach.Report.reportInHoaDon
{
    public partial class FormRP : Form
    {
        private frmBanHang_LapHoaDon frmLapHDLocal;


        public FormRP()
        {
            InitializeComponent();
        }
        public FormRP(frmBanHang_LapHoaDon frmLapHD)
        {
            InitializeComponent();
            frmLapHDLocal = frmLapHD;

        }

        private void FormRP_Load(object sender, EventArgs e)
        {

            this.reportViewerInHD.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            QLBanSachDataContext db = new QLBanSachDataContext();

            string maKH1 = frmLapHDLocal.TextMaKH;
           string maHD1 = frmLapHDLocal.TextMaHD;

           string maHD = "HD00";
           string maKH = frmLapHDLocal.TextMaHD;

            // CTHD, HoaDon, KhachHang
            var query = (from ct in db.CTHDs
                         join hd in db.HoaDons on ct.MaHD equals hd.MaHD
                         join sach in db.Saches on ct.MaS equals sach.MaS
                         join kh in db.KhachHangs on hd.MaKH equals kh.MaKH
                         where hd.MaHD == maHD && kh.MaKH == maKH
                         select new
                         {
                             MaHD = hd.MaHD,
                             MaS = sach.MaS,
                             TenS = sach.TenS,
                             NgayLapHD = hd.NgayLapHD,
                             MaKH = kh.MaKH,
                             TenKH = kh.TenKH,
                             GiaBan = ct.GiaBan,
                             SoLuongBan = ct.SoLuongBan
                         }
                ).ToList();

            List<ClassInHD> ListInHoaDon = new List<ClassInHD>();

            foreach (var item in query)
            {
                ClassInHD classInHD = new ClassInHD();
                classInHD.MaHD = item.MaHD;
                classInHD.MaS = item.MaS;
                classInHD.TenS = item.TenS;
                classInHD.NgayLapHD = (DateTime)item.NgayLapHD;
                classInHD.MaKH = item.MaKH;
                classInHD.TenKH = item.TenKH;
                classInHD.GiaBan = (int)item.GiaBan;
                classInHD.SoLuongBan = (int)item.SoLuongBan;

                ListInHoaDon.Add(classInHD);
               
            }

            this.reportViewerInHD.LocalReport.ReportPath = "Report1.rdlc";

            var reportDataSource = new ReportDataSource("DataSetPCMinhChau", ListInHoaDon);
            this.reportViewerInHD.LocalReport.DataSources.Clear();
            this.reportViewerInHD.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerInHD.RefreshReport();

        }

    }
}

