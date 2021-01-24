using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;

namespace QuanLyBanSach
{
    
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public frmMain()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }
        //////////////
        void checkIsLogin(Boolean isLogin)
        {
            if (isLogin == false)
            {
                riboManage.Visible = false;
                riboSales.Visible = false;
                barbtnLogout.Enabled = false;
                btnDoiMK.Enabled = false;
            }
        }

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Xmas 2008 Blue";
        }


        public void showFrm<T>(T frm) where T : DevExpress.XtraEditors.XtraForm
        {

            pnlMain.Controls.Clear();

            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
        }


        public void showItem()
        {

            riboManage.Visible = true;
            riboSales.Visible = true;
            barbtnLogout.Enabled = true;
            barbtnLogin.Enabled = false;
            btnDoiMK.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            skins();
            barbtnLogout.Enabled = false;
            btnDoiMK.Enabled = false;
            frmHeThong_DangNhap frm = new frmHeThong_DangNhap(this);
            showFrm<frmHeThong_DangNhap>(frm);

        }
        //////////////

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        //************Page Hệ thống
        private void barbtnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHeThong_DangNhap frm = new frmHeThong_DangNhap(this);
            showFrm<frmHeThong_DangNhap>(frm);

        }

        private void barbtnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dia == DialogResult.Cancel)
            {
            }
            else
            {
                frmHeThong_DangNhap frm = new frmHeThong_DangNhap(this);

                showFrm<frmHeThong_DangNhap>(frm);
                checkIsLogin(false);

            }
        }
        //************Page Quản lý
        //Thông tin chung
        private void barbtnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinChung_KhachHang frm = new frmThongTinChung_KhachHang(this);
            showFrm<frmThongTinChung_KhachHang>(frm);
        }

        private void barbtnStaff_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinChung_NhanVien frm = new frmThongTinChung_NhanVien(this);
            showFrm<frmThongTinChung_NhanVien>(frm);
        }

        //Thông tin

        //*Thể loại
        private void barbtnTL_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quản_lý.frmThongTin_TheLoai frm = new Quản_lý.frmThongTin_TheLoai(this);
            showFrm<Quản_lý.frmThongTin_TheLoai>(frm);
        }
        //**Sách
        private void barbtnBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quản_lý.frmThongTin_Sach frm = new Quản_lý.frmThongTin_Sach(this);
            showFrm<Quản_lý.frmThongTin_Sach>(frm);
        }
        //**Tác giả
        private void barbtnAuthor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quản_lý.frmThongTin_TacGia frm = new Quản_lý.frmThongTin_TacGia(this);
            showFrm<Quản_lý.frmThongTin_TacGia>(frm);
        }
        //**Nhà xuất bản
        private void barbtnPublisher_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quản_lý.frmThongTin_NXB frm = new Quản_lý.frmThongTin_NXB(this);
            showFrm<Quản_lý.frmThongTin_NXB>(frm);
        }
        //************Page bán hàng
        //*Lập hoá đơn
        private void barbtnBills_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBanHang_LapHoaDon frm = new frmBanHang_LapHoaDon(this);
            showFrm<frmBanHang_LapHoaDon>(frm);
        }

        //*Lập phiếu giao

        private void barbtnDeliBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBanHang_LapPhieuGiao frm = new frmBanHang_LapPhieuGiao(this);
            pnlMain.Controls.Clear();

            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
        }
        //Danh sách
        //**Danh sách hoá đơn
        private void barbtnDSHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDanhSach_DSHD frm = new frmDanhSach_DSHD(this);
            showFrm<frmDanhSach_DSHD>(frm);
        }
        //**Danh sách phiếu giao
        private void barbtnDSPG_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDanhSach_DSPG frm = new frmDanhSach_DSPG(this);
            showFrm<frmDanhSach_DSPG>(frm);
        }
        //Chi tiết
        //**Chi tiết hoá đơn
        private void barbtnCTHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChiTiet_CTHD frm = new frmChiTiet_CTHD(this);
            showFrm<frmChiTiet_CTHD>(frm);
        }
        //**Chi tiết phiếu giao
        private void barbtnCTPG_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChiTiet_CTPG frm = new frmChiTiet_CTPG(this);
            showFrm<frmChiTiet_CTPG>(frm);
        }

        private void barbtnTL_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Quản_lý.frmThongTin_TheLoai frm = new Quản_lý.frmThongTin_TheLoai(this);
            showFrm<Quản_lý.frmThongTin_TheLoai>(frm);
        }

        private void barbtnBookSold_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.ReportSLBan.frmReportSLBan frm = new Report.ReportSLBan.frmReportSLBan(this);
            showFrm<Report.ReportSLBan.frmReportSLBan>(frm);
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hệ_thống.frmHeThong_DoiMatKhau frm = new Hệ_thống.frmHeThong_DoiMatKhau();
            showFrm<Hệ_thống.frmHeThong_DoiMatKhau>(frm);


        }
    }
}