using Microsoft.Reporting.WinForms;
using QuanLyBanSach.Database;
using QuanLyBanSach.Report.reportInHoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach.Report.reportInPhieuGiao
{
    public partial class FormInPhieuGiao : Form
    {
        private frmBanHang_LapPhieuGiao frmLapPGLocal;

        public FormInPhieuGiao()
        {
            InitializeComponent();
        }

        public FormInPhieuGiao(frmBanHang_LapPhieuGiao frmLapPG)
        {
            InitializeComponent();
            frmLapPGLocal = frmLapPG;
        }

        private void FormInPhieuGiao_Load(object sender, EventArgs e)
        {

            this.reportViewerInPG.RefreshReport();
        }



        private void reportViewerInPG_Load(object sender, EventArgs e)
        {
            QLBanSachDataContext db = new QLBanSachDataContext();

            string maKH = frmLapPGLocal.TextMaKH;
            string maPG = frmLapPGLocal.TextMaPG;
            string maS = frmLapPGLocal.TextMaS;


            //  PhieuGiao, Sach, KhachHang,  CTPG
            var query = (from ct in db.CTPGs
                         join pg in db.PhieuGiaos on ct.MaPG equals pg.MaPG
                         join sach in db.Saches on ct.MaS equals sach.MaS
                         join kh in db.KhachHangs on pg.MaKH equals kh.MaKH
                         where pg.MaPG == maPG && pg.MaKH == maKH && ct.MaS == maS
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
                ).ToList();

            List<ClassInPhieuGiao> ListInPG = new List<ClassInPhieuGiao>();

            foreach (var item in query)
            {
                ClassInPhieuGiao classInPG = new ClassInPhieuGiao();
                classInPG.MaPG = item.MaPG;
                classInPG.MaS = item.MaS;
                classInPG.TenS = item.TenS;
                classInPG.NgayGiaoDuKien = (DateTime)item.NgayGiaoDuKien;
                classInPG.NgayLapPG = (DateTime)item.NgayLapPG;
                classInPG.TenKH = item.TenKH;
                classInPG.SoLuongGiao = (int)item.SoLuongGiao;
                classInPG.SoLuongGiao = (int)item.SoLuongGiao;

                ListInPG.Add(classInPG);

            }

            this.reportViewerInPG.LocalReport.ReportPath = "RPInPG.rdlc";

            var reportDataSource = new ReportDataSource("DatSet1", ListInPG);
            this.reportViewerInPG.LocalReport.DataSources.Clear();
            this.reportViewerInPG.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerInPG.RefreshReport();
        }
    }
}
