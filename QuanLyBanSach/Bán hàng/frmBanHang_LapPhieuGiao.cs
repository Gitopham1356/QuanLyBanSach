using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmBanHang_LapPhieuGiao : DevExpress.XtraEditors.XtraForm
    {

        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();

        frmMain frm1;
        int ma = 0;
        string mah = "PG";
        public frmBanHang_LapPhieuGiao()
        {
            InitializeComponent();
        }
        public frmBanHang_LapPhieuGiao(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        public void loadNDisplay()
        {

            cmbMaKH.DataSource = context.KhachHangs;
            cmbMaKH.DisplayMember = "MaKH";
            cmbMaKH.ValueMember = "MaKH";

            var khName = context.KhachHangs.FirstOrDefault(k => k.MaKH == cmbMaKH.Text);
            if (khName != null)
            {
                txtTenKH.Text = khName.TenKH.ToString();
            }

            cmbMaS.DataSource = context.Saches;
            cmbMaS.DisplayMember = "MaS";
            cmbMaS.ValueMember = "MaS";

            var sName = context.Saches.FirstOrDefault(s => s.MaS == cmbMaS.Text);
            if (sName != null)
            {
                cmbTenS.Text = sName.TenS.ToString();
            }
        }

        private int GetSelectedRow(string MAS)
        {
            for (int i = 0; i < dgvTTSach.Rows.Count; i++)
            {
                if (dgvTTSach.Rows[i].Cells[0].Value.ToString() == MAS)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {

            dgvTTSach.Rows[selectedRow].Cells[0].Value = cmbMaS.Text;
            dgvTTSach.Rows[selectedRow].Cells[1].Value = cmbTenS.Text;
            dgvTTSach.Rows[selectedRow].Cells[2].Value = txtSoLuong.Text;
        }

        private void frmBanHang_LapPhieuGiao_Load(object sender, EventArgs e)
        {
            Database.PhieuGiao phieugiao = new Database.PhieuGiao();

            if (phieugiao.MaPG == null)
            {
                txtMaPG.Text += (mah + ma.ToString("D2")).ToString();
            }
            else
            {
                ma = phieugiao.MaPG.Count();

                txtMaPG.Text += (mah + ma.ToString("D2")).ToString();
            }
            loadNDisplay();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadNDisplay();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMaS.Text == "" || cmbTenS.Text == "" || txtSoLuong.Text == "")
                {

                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {

                    int selectedRow = GetSelectedRow(cmbMaS.Text);
                    if (selectedRow == -1)
                    {
                        selectedRow = dgvTTSach.Rows.Add();
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {

                        MessageBox.Show("Dữ liệu đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMaS.Text == "" || cmbTenS.Text == "" || txtSoLuong.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    int selectedRow = GetSelectedRow(cmbMaS.Text);
                    if (selectedRow == -1)
                    {

                    }
                    else
                    {

                        InsertUpdate(selectedRow);
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedRow = GetSelectedRow(cmbMaS.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Xoá thất bại.");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá TT sách này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        dgvTTSach.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTTSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrows;
            try
            {
                numrows = e.RowIndex;

                cmbMaS.Text = dgvTTSach.Rows[numrows].Cells[0].Value.ToString();
                cmbTenS.Text = dgvTTSach.Rows[numrows].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvTTSach.Rows[numrows].Cells[2].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            try
            {
                Database.PhieuGiao phieugiao = new Database.PhieuGiao();
                string mas;
                int soluonggiao = 0;



                if (txtMaPG.Text == "" || cmbMaKH.Text == "" || dtimepickNgayLapPG.Text == ""
                                       || datetimeNgayGiaoDK.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    phieugiao.MaPG = txtMaPG.Text;
                    phieugiao.MaKH = cmbMaKH.Text;
                    phieugiao.NgayLapPG = DateTime.Parse(dtimepickNgayLapPG.Text);
                    phieugiao.NgayGiaoDuKien = DateTime.Parse(datetimeNgayGiaoDK.Text);

                    var pg = context.PhieuGiaos.FirstOrDefault(p => p.MaPG == txtMaPG.Text);
                    if (pg == null)
                    {


                        context.PhieuGiaos.InsertOnSubmit(phieugiao);
                        context.SubmitChanges();

                        for (int i = 0; i < dgvTTSach.Rows.Count; i++)
                        {
                            Database.CTPG cTPG = new Database.CTPG();

                            mas = dgvTTSach.Rows[i].Cells[0].Value.ToString();
                            soluonggiao = int.Parse(dgvTTSach.Rows[i].Cells[2].Value.ToString());

                            cTPG.MaS = mas;
                            cTPG.MaPG = txtMaPG.Text;
                            cTPG.SoLuongGiao = soluonggiao;

                            context.CTPGs.InsertOnSubmit(cTPG);
                            this.context.SubmitChanges();
                        }
                        MessageBox.Show("Lập phiếu giao thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadNDisplay();

                    }
                    else
                    {
                        MessageBox.Show("Phiếu giao đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch
            {
                MessageBox.Show("");
            }
        }
    }
}