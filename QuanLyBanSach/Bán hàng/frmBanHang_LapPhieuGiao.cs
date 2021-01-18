using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmBanHang_LapPhieuGiao : DevExpress.XtraEditors.XtraForm
    {

        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();

        frmMain frm1;
       //Constructor

        public frmBanHang_LapPhieuGiao()
        {
            InitializeComponent();
        }
        public frmBanHang_LapPhieuGiao(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        //Kiểm tra xem số lượng tồn có >= số lượng mua hay k

        bool checkSl()
        {
            var t = context.Saches.FirstOrDefault(s => s.MaS == cmbMaS.Text && s.SoLuongTon >= int.Parse(txtSoLuong.Text));
            if (t == null)
            {
                return false;
            }
            return true;
        }

        // Hiển thị
        public void loadNDisplay()
        {


            cmbMaKH.Text = "KH00";
            cmbMaS.Text = "S001";
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

        // hàm sinh mã phiếu giao

        public void autoGenMHD()
        {
            string maLonNhat = (from pg in context.PhieuGiaos
                                orderby pg.MaPG descending
                                select pg.MaPG).FirstOrDefault();
            if (maLonNhat == null)
            {
                txtMaPG.Text = "PG00".ToString();
            }
            else
            {
                int stt = int.Parse(maLonNhat.Substring(2));
                //+1 ra stt tiếp theo
                stt += 1;
                if (stt < 10)
                    txtMaPG.Text = "PG0" + stt.ToString();
                else if (stt < 100)
                    txtMaPG.Text = "PG" + stt.ToString();
                else
                    txtMaPG.Text = "PG" + stt.ToString();
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

        void clear()
        {
            txtSoLuong.Clear();
          

        }
        //truyền MaKH vào collectionS để gợi ý
        public void getDataKH(AutoCompleteStringCollection Data)
        {
            foreach (var hk in context.KhachHangs)
            {
                Data.Add(hk.MaKH);
            }

        }
        //truyền MaS vào collectionS để gợi ý
        public void getDataS(AutoCompleteStringCollection Data)
        {
            foreach (var hk in context.Saches)
            {
                Data.Add(hk.MaS);
            }

        }

        private void frmBanHang_LapPhieuGiao_Load(object sender, EventArgs e)
        {

            AutoCompleteStringCollection DataCollectionKH = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DataCollectionS = new AutoCompleteStringCollection();
            Database.PhieuGiao phieuGiao = new Database.PhieuGiao();

            //truyền vào customsource cmbMAKH

            getDataKH(DataCollectionKH);
            cmbMaKH.AutoCompleteCustomSource = DataCollectionKH;
            //truyền vào customsource cmbMAKH

            getDataS(DataCollectionS);
            cmbMaS.AutoCompleteCustomSource = DataCollectionS;
            //Set ngày tháng lập hoá đơn chỉ dược là ngyà hôm nay

            dtimepickNgayLapPG.MinDate = DateTime.Now;
            datetimeNgayGiaoDK.MinDate = DateTime.Now;
           

            //
            autoGenMHD();
            loadNDisplay();
        }

        private void cmbMaKH_TextChanged(object sender, EventArgs e)
        {
            lbMaKh.Text = "";
            var mak = context.KhachHangs.FirstOrDefault(b => b.MaKH == cmbMaKH.Text);
            if (mak == null)
            {
                lbMaKh.Text = "xMã khách hàng không tồn tại.";
                txtTenKH.Text = "".ToString();
            }
            else
            {
                cmbMaKH.DataSource = context.KhachHangs;
                cmbMaKH.DisplayMember = "MaKH";
                cmbMaKH.ValueMember = "MaKH";

                var khName = context.KhachHangs.FirstOrDefault(k => k.MaKH == cmbMaKH.Text);
                if (khName != null)
                {
                    txtTenKH.Text = khName.TenKH.ToString();
                }
            }
        }

        private void cmbMaS_TextChanged(object sender, EventArgs e)
        {
            lbMaS.Text = "";
            var maS = context.Saches.FirstOrDefault(b => b.MaS == cmbMaS.Text);
            if (maS == null)
            {
                lbMaS.Text = "xMã sách không tồn tại.".ToString();
                cmbTenS.Text = "".ToString();
            }
            else
            {
                lbMaS.Text = "".ToString();
                cmbMaS.DataSource = context.Saches;
                cmbMaS.DisplayMember = "MaS";
                cmbMaS.ValueMember = "MaS";

                var SName = context.Saches.FirstOrDefault(k => k.MaS == cmbMaS.Text);
                if (SName != null)
                {
                    cmbTenS.Text = SName.TenS.ToString();
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Các thay đổi bạn đã thực hiện có thể không được lưu", "Tải lại trang?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
            }
            else
            {
                dgvTTSach.Rows.Clear();
                clear();
                loadNDisplay();
            }
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

        private void btnLuuPG_Click(object sender, EventArgs e)
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

                    var pg = context.PhieuGiaos.FirstOrDefault(p=>p.MaPG == txtMaPG.Text);
                    var kh = context.KhachHangs.FirstOrDefault(k => k.MaKH == cmbMaKH.Text);
                    var maS = context.Saches.FirstOrDefault(b => b.MaS == cmbMaS.Text);
                    if (dtimepickNgayLapPG.Value <= datetimeNgayGiaoDK.Value)
                    {
                        if (maS != null)
                        {

                            if (kh != null)
                            {



                                if (pg == null)
                                {


                                    context.PhieuGiaos.InsertOnSubmit(phieugiao);
                                    context.SubmitChanges();

                                    for (int i = 0; i < dgvTTSach.Rows.Count; i++)
                                    {
                                        Database.CTPG cTPG = new Database.CTPG();
                                        mas = dgvTTSach.Rows[i].Cells[0].Value.ToString();
                                        soluonggiao = int.Parse(dgvTTSach.Rows[i].Cells[2].Value.ToString());


                                        cTPG.MaPG = txtMaPG.Text;
                                        cTPG.MaS = mas;
                                        cTPG.SoLuongGiao = soluonggiao;

                                        var t = context.Saches.FirstOrDefault(s => s.MaS == cmbMaS.Text && s.SoLuongTon >= int.Parse(txtSoLuong.Text));
                                        if (t == null)
                                        {
                                        }
                                        else
                                        {
                                            t.SoLuongTon -= int.Parse(txtSoLuong.Text);
                                        }



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
                            else
                            {
                                MessageBox.Show("Mã khách hàng không tồn tại", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã sách không tồn tại", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày lập phiếu / ngày giao dự kiến không hợp lệ", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Không thực hiện được");
            }
        }

        private void dtimepickNgayLapPG_ValueChanged(object sender, EventArgs e)
        {
            lbNgayGiao.Text = "".ToString();
            if (dtimepickNgayLapPG.Value > datetimeNgayGiaoDK.Value)
            {
                lbNgayGiao.Text = "Ngày giao phải >= ngày lập".ToString();
            }
        }

        private void datetimeNgayGiaoDK_ValueChanged(object sender, EventArgs e)
        {
            lbNgayGiao.Text = "".ToString();
            if (dtimepickNgayLapPG.Value > datetimeNgayGiaoDK.Value)
            {
                lbNgayGiao.Text = "Ngày giao phải >= ngày lập".ToString();
            }
        }
        // chuyển đến danh sách phiếu giao
        private void btnDSPG_Click(object sender, EventArgs e)
        {
            frmDanhSach_DSPG frm = new frmDanhSach_DSPG(frm1, this);
            frm1.showFrm<frmDanhSach_DSPG>(frm);
        }
    }
}