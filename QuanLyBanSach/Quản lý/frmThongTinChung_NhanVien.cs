using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmThongTinChung_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        BindingSource bs = new BindingSource();

        frmMain frm1;
        public frmThongTinChung_NhanVien()
        {
            InitializeComponent();
        }

        public frmThongTinChung_NhanVien(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        void loadData()
        {
            bs.DataSource = from nv in context.NhanViens
                            select new
                            {
                                nv.MaNV,
                                nv.TenNV,
                                nv.NgaySinhNV,
                                nv.DiaChiNV,
                                nv.SdtNV,
                                nv.EmailNV
                              
                            };
            gridctrlCustomerInfo.DataSource = bs;
        }

        private void frmThongTinChung_NhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}