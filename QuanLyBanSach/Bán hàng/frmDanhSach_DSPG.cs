using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmDanhSach_DSPG : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;
        frmBanHang_LapPhieuGiao frmL;
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
        public frmDanhSach_DSPG(frmMain frm,frmBanHang_LapPhieuGiao frml)
        {
            InitializeComponent();
            frm1 = frm;
            frmL = frml;
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
            frmChiTiet_CTPG frm = new frmChiTiet_CTPG(frm1,this);
            frm1.showFrm<frmChiTiet_CTPG>(frm);
        }

        private void btnDelPG_Click(object sender, EventArgs e)
        {

            DialogResult dia = MessageBox.Show("Việc xoá Thông tin có thể gây mất thông tin hay ảnh hưởng đến chi tiết phiếu giao , bạn có chắc muốn xoá ", "Xoá Thông tin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {
                try
                {
                    var x = gridviewDSPG.GetRowCellValue(gridviewDSPG.FocusedRowHandle, cMaPG).ToString();
                    var pg = context.PhieuGiaos.FirstOrDefault(K => K.MaPG == x.Trim());

                    if (pg != null)
                    {
                        context.PhieuGiaos.DeleteOnSubmit(pg);
                        context.SubmitChanges();
                        MessageBox.Show("Xóa Đối tượng thành công");
                        loadData();

                    }
                    else
                    {

                        MessageBox.Show("Xoá thất bại");

                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xoá đối tượng");
                }

               
            }
        }
    }
}