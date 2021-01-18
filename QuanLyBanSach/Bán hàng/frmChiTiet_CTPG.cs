using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmChiTiet_CTPG : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;
        frmDanhSach_DSPG frmPG; 
        public frmChiTiet_CTPG()
        {
            InitializeComponent();
        }
        public frmChiTiet_CTPG(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        public frmChiTiet_CTPG(frmMain frm, frmDanhSach_DSPG frmpg)
        {
            InitializeComponent();
            frm1 = frm;
            frmPG = frmpg;
        }
        //Load

        void loadData()
        {
            var ctpg = from ct in context.CTPGs
                       join s in context.Saches on ct.MaS equals s.MaS
                       select new
                       {
                           ct.MaPG,
                           s.MaS,
                           s.TenS,
                           ct.SoLuongGiao,
                           
                       };
            gridconCTPG.DataSource = ctpg;
        }

        private void frmChiTiet_CTPG_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDeleteUs_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Việc xoá Thông tin có thể ảnh hưởng đến phiếu giao, bạn có chắc muốn xoá ", "Xoá Thông tin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {


                var ctpg = context.CTPGs.FirstOrDefault(k => k.MaS == txtMaS.Text && k.MaPG == txtMaPG.Text);
                var soluongton = context.Saches.FirstOrDefault(s => s.MaS == txtMaS.Text);


                if (ctpg != null)
                {

                    context.CTPGs.DeleteOnSubmit(ctpg);

                    MessageBox.Show("Xóa Đối tượng thành công");
                    loadData();

                    soluongton.SoLuongTon += ctpg.SoLuongGiao;

                    this.context.SubmitChanges();
                    loadData();
                }
                else
                {

                    MessageBox.Show("Xoá thất bại");

                }
            }
        }

        private void gridconCTPG_Click(object sender, EventArgs e)
        {
            if(gridviewCTPG.GetRowCellValue(gridviewCTPG.FocusedRowHandle,cMaPG) == null)
            {
                MessageBox.Show("Không thể thực hiện ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtMaPG.Text = gridviewCTPG.GetRowCellValue(gridviewCTPG.FocusedRowHandle, cMaPG).ToString();
                txtMaS.Text = gridviewCTPG.GetRowCellValue(gridviewCTPG.FocusedRowHandle, cMaS).ToString();
                txtTenS.Text = gridviewCTPG.GetRowCellValue(gridviewCTPG.FocusedRowHandle, cTenSach).ToString();
                var sL = gridviewCTPG.GetRowCellValue(gridviewCTPG.FocusedRowHandle, cSLG).ToString();
                txtSoLuong.Text = int.Parse(sL).ToString();
            }
           
           
        }
    }
}