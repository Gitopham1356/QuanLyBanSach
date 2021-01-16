namespace QuanLyBanSach.Quản_lý
{
    public partial class frmThongTin_TheLoai : DevExpress.XtraEditors.XtraForm
    {
        frmMain frm1;
        public frmThongTin_TheLoai()
        {
            InitializeComponent();
        }
        public frmThongTin_TheLoai(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
    }
}