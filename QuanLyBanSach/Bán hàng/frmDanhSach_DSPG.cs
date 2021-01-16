using System;
using System.Data;
using System.Linq;

namespace QuanLyBanSach
{
    public partial class frmDanhSach_DSPG : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;
        //Constructor
        public frmDanhSach_DSPG()
        {
            InitializeComponent();
        }
        public frmDanhSach_DSPG(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        void loadData()
        {
            var dshd = from PG in context.PhieuGiaos
                       select new
                       {
                           PG.MaPG,
                           PG.MaKH,
                           PG.NgayLapPG,
                           PG.NgayGiaoDuKien

                       };
            gridCtrlDSPG.DataSource = dshd;
        }
        private void frmDanhSach_DSPG_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnGoToCTPG_Click(object sender, EventArgs e)
        {
            frmChiTiet_CTPG frm = new frmChiTiet_CTPG();
            frm1.showFrm<frmChiTiet_CTPG>(frm);
        }
    }
}