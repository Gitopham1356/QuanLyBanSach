using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmDanhSach_DSHD : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;
        //Constructor
        frmBanHang_LapHoaDon frmL;

        public frmDanhSach_DSHD()
        {
            InitializeComponent();
        }

        public frmDanhSach_DSHD(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
           
        }
        public frmDanhSach_DSHD(frmMain frm, frmBanHang_LapHoaDon frml)
        {
            InitializeComponent();
            frm1 = frm;
            frmL = frml;
        }

        void loadData()
        {
            var dshd = from HD in context.HoaDons
                       select new
                       {
                           HD.MaHD,
                           HD.MaKH,
                           HD.NgayLapHD,
                           HD.TongHD,

                       };
            gridCtrlDSHD.DataSource = dshd;
        }
        private void frmDanhSach_DSHD_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridCtrlDSHD_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToCTHD_Click(object sender, EventArgs e)
        {
            frmChiTiet_CTHD frm = new  frmChiTiet_CTHD(frm1,this);
            frm1.showFrm<frmChiTiet_CTHD>(frm);

        }

        private void btnDelHD_Click(object sender, EventArgs e)
        {
            //DialogResult dia = MessageBox.Show("Bạn có chắc muốn xoá? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dia == DialogResult.No)
            //{
            //}
            //else
            //{
            //    var x = (gridviewDSHD.FocusedRowHandle, cMaHD).ToString();
            //    var hd = context.HoaDons.FirstOrDefault(K => K.MaHD == x.Trim());

            //    if (hd != null)
            //    {

            //        context.HoaDons.DeleteOnSubmit(hd);
            //        context.SubmitChanges();
            //        MessageBox.Show("Xóa Đối tượng thành công");
            //        loadData();

            //    }
            //    else
            //    {

            //        MessageBox.Show("Xoá thất bại");

            //    }
            //}
        }
    }
}