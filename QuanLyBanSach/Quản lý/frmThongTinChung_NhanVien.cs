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

        private void gridctrlCustomerInfo_Click(object sender, EventArgs e)
        {{
                var DoB = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cNgaySinhNV).ToString();

                txtNVID.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cMaNV).ToString();
                txtDoBNV.Text = DateTime.Parse(DoB).ToShortDateString();
                txtNameNV.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cTenNV).ToString();
                txtAddressNV.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cDiaChiNV).ToString();
                txtSDTNV.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cSdtNV).ToString();
                txtEmailNV.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cEmailNV).ToString();
            
        }
    }
}