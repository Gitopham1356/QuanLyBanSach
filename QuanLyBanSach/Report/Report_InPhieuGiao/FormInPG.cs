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

namespace QuanLyBanSach.Report.Report_InPhieuGiao
{
    public partial class FormInPG : Form
    {
        private frmBanHang_LapPhieuGiao frmLapPGLocal;

        public FormInPG()
        {
            InitializeComponent();
        }

        public FormInPG(frmBanHang_LapPhieuGiao frmLapPG)
        {
            InitializeComponent();
            frmLapPGLocal = frmLapPG;
        }

        private void FormInPG_Load(object sender, EventArgs e)
        {

            this.reportViewerInPG.RefreshReport();
        }

        private void reportViewerInPG_Load(object sender, EventArgs e)
        {
            QLBanSachDataContext db = new QLBanSachDataContext();

            string maPG = frmLapPGLocal.TextMaPG;
            string maS = frmLapPGLocal.TextMaS;
            string maKH = frmLapPGLocal.TextMaKH;


            var query = (from ct in db.CTPGs
                         join pg in db.PhieuGiaos on ct.MaPG equals pg.MaPG
                         join sach in db.Saches on ct.MaS equals sach.MaS
                         join kh in db.KhachHangs on pg.MaKH equals kh.MaKH
                         where pg.MaPG == maPG /* && sach.MaS == maS*/ && kh.MaKH == maKH
                         select new
                         {
                             MaPG = pg.MaPG,
                             MaS = ct.MaS,
                             TenS = sach.TenS,
                             NgayLapPG = pg.NgayLapPG,
                             NgayGiaoDuKien = pg.NgayGiaoDuKien,
                             TenKH = kh.TenKH,
                             SoLuongGiao = ct.SoLuongGiao,
                             MaKH = pg.MaKH
                         }
                );

            List<ClassInPG> ListInPG = new List<ClassInPG>();


            ReportParameter MaKHParam = new ReportParameter("MaKHParam");
            ReportParameter TenKHParam = new ReportParameter("TenKHParam");
            ReportParameter NgayLapParam = new ReportParameter("NgayLapParam");
            ReportParameter NgayGiaoParam = new ReportParameter("NgayGiaoParam");
            ReportParameter MaPGParam = new ReportParameter("MaPGParam");

            foreach (var item in query)
            {
                ClassInPG classInPG = new ClassInPG();
                classInPG.MaS = item.MaS;
                classInPG.TenS = item.TenS;
                classInPG.SoLuongGiao = (int)item.SoLuongGiao;
                ListInPG.Add(classInPG);

                MaKHParam.Values.Add(item.MaKH);
                TenKHParam.Values.Add(item.TenKH);
                NgayLapParam.Values.Add(item.NgayLapPG.ToString());
                NgayGiaoParam.Values.Add(item.NgayGiaoDuKien.ToString());
                MaPGParam.Values.Add(item.MaPG);
            }

            this.reportViewerInPG.LocalReport.ReportPath = "ReportInPG.rdlc";

            var reportDataSource = new ReportDataSource("DataSetInPG", ListInPG);
            this.reportViewerInPG.LocalReport.DataSources.Clear();

            this.reportViewerInPG.LocalReport.SetParameters(MaKHParam);
            this.reportViewerInPG.LocalReport.SetParameters(TenKHParam);
            this.reportViewerInPG.LocalReport.SetParameters(NgayLapParam);
            this.reportViewerInPG.LocalReport.SetParameters(MaPGParam);
            this.reportViewerInPG.LocalReport.SetParameters(NgayGiaoParam);


            this.reportViewerInPG.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerInPG.RefreshReport();
        }
    }
}
