using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach.Quản_lý
{
    public partial class frmThongTin_Sach : DevExpress.XtraEditors.XtraForm
    {

        static int dateNow = int.Parse(Convert.ToString(DateTime.Now.Year));
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;
        //Constructor
        public frmThongTin_Sach()
        {
            InitializeComponent();
        }

        public frmThongTin_Sach(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        //Load dữ liệu từ database lên gridcontrol
        void loadData()
        {
            var dss = context.Saches.ToList();
            gridconSachInfo.DataSource = dss;
            autoGenMS();
        }
        //Load dữ liệu từ database lên combobox
        void loadNDisplay()
        {
            cmbMaTL.Text = "TL001";
            cmbMaNXB.Text = "NX001";
            cmbMaTG.Text = "TG001";


            cmbMaTL.DataSource = context.TheLoais;
            cmbMaTL.DisplayMember = "MaTL";
            cmbMaTL.ValueMember = "MaTL";
            var tlName = context.TheLoais.FirstOrDefault(k => k.MaTL == cmbMaTL.Text);
            if (tlName != null)
            {
                lbTenTL.Text = tlName.TenTL.ToString();
            }

            cmbMaTG.DataSource = context.TacGias;
            cmbMaTG.DisplayMember = "MaTG";
            cmbMaTG.ValueMember = "MaTG";
            var tgName = context.TacGias.FirstOrDefault(k => k.MaTG == cmbMaTG.Text);
            if (tgName != null)
            {
                lbTenTG.Text = tgName.TenTG.ToString();
            }

            cmbMaNXB.DataSource = context.NhaXuatBans;
            cmbMaNXB.DisplayMember = "MaNXB";
            cmbMaNXB.ValueMember = "MaNXB";
            var XBName = context.NhaXuatBans.FirstOrDefault(k => k.MaNXB == cmbMaNXB.Text);
            if (XBName != null)
            {
                lbTenNXB.Text = XBName.TenNXB.ToString();
            }

        }

        //Refresh
        void ClearText()
        {

            txtMaS.Clear();
            txtTenS.Clear();
            txtNamXB.Clear();
            txtSoLuong.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            cmbMaTL.Text = "".ToString();
            cmbMaTG.Text = "".ToString();
            cmbMaNXB.Text = "".ToString();
        }

        //Method tự động tạo mã sách
        public void autoGenMS()
        {

            string maLonNhat = (from s in context.Saches
                                orderby s.MaS descending
                                select s.MaS).FirstOrDefault();
            //Mã thể loại có dạng "TL001". Cắt chuỗi con từ vị trí thứ 1 ra được stt là "001". Ép thành in ra "1"

            //+1 ra stt tiếp theo
            if (maLonNhat == null)
            {
                txtMaS.Text = "S000".ToString();
            }
            else
            {
                int stt = int.Parse(maLonNhat.Substring(1));
                stt += 1;
                if (stt < 10)
                    txtMaS.Text = "S00" + stt.ToString();
                else if (stt < 100)
                    txtMaS.Text = "S0" + stt.ToString();
                else
                    txtMaS.Text = "S" + stt.ToString();

                txtTenS.Text = "";
            }
        }

        //buộc nhập số
        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false &&
                Char.IsControl(e.KeyChar) == false ||
                txtNamXB.Text.Length == 4 &&
                 e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //buộc nhập số(Số lượng)
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false &&
                Char.IsControl(e.KeyChar) == false ||
                txtSoLuong.Text.Length == 5 &&
                 e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        //buộc nhập số(Giá Nhập)
        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) == false &&
                Char.IsControl(e.KeyChar) == false ||
                txtGiaNhap.Text.Length == 8
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        //buộc nhập số(Giá bán)
        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) == false &&
                Char.IsControl(e.KeyChar) == false ||
                txtGiaBan.Text.Length == 8
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        //Truyền dữ liệu từ database vào collection của combobox(NXB)
        public void getDataNXB(AutoCompleteStringCollection Data)
        {
            foreach (var item in context.NhaXuatBans)
            {
                Data.Add(item.MaNXB);
            }

        }
        //Truyền dữ liệu từ database vào collection của combobox(Theloai)
        public void getDataTL(AutoCompleteStringCollection Data)
        {
            foreach (var item in context.TheLoais)
            {
                Data.Add(item.MaTL);
            }

        }
        //Truyền dữ liệu từ database vào collection của combobox(TacGia)
        public void getDataTG(AutoCompleteStringCollection Data)
        {
            foreach (var item in context.TacGias)
            {
                Data.Add(item.MaTG);
            }

        }
        // Event thay đổi item trong combobox = thay đổi tên(label TenTL)
        private void cmbMaTL_TextChanged(object sender, EventArgs e)
        {
            lbTenTL.Text = "không hợp lệ".ToString();

            var tlName = context.TheLoais.FirstOrDefault(k => k.MaTL == cmbMaTL.Text);
            if (tlName != null)
            {
                lbTenTL.Text = tlName.TenTL.ToString();
            }
        }
        // Event thay đổi item trong combobox = thay đổi tên(label TenTG)
        private void cmbMaTG_TextChanged(object sender, EventArgs e)
        {
            lbTenTG.Text = "Không hợp lệ.".ToString();

            var tgName = context.TacGias.FirstOrDefault(k => k.MaTG == cmbMaTG.Text);
            if (tgName != null)
            {
                lbTenTG.Text = tgName.TenTG.ToString();
            }
        }
        // Event thay đổi item trong combobox = thay đổi tên(label TenTG)
        private void cmbMaNXB_TextChanged(object sender, EventArgs e)
        {
            lbTenNXB.Text = "Không hợp lệ.".ToString();

            var XBName = context.NhaXuatBans.FirstOrDefault(k => k.MaNXB == cmbMaNXB.Text);
            if (XBName != null)
            {
                lbTenNXB.Text = XBName.TenNXB.ToString();
            }
        }
        private void txtNamXB_TextChanged(object sender, EventArgs e)
        {
            lbNamXB.Text = "";
            if (txtNamXB.Text == "")
            {
            }
            else if (int.Parse(txtNamXB.Text) > dateNow)
            {
                lbNamXB.Text = ("Năm xuất bản phải < năm {0}", dateNow).ToString();
            }
        }


        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            lbGiaNhap.Text = "";
            try
            {
                if (int.Parse(txtGiaNhap.Text) > int.Parse(txtGiaBan.Text))
                {
                    lbGiaNhap.Text = "xGiá nhập phải bé hơn giá bán";
                }
            }
            catch { }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            lbGiaNhap.Text = "";
            try
            {
                if (int.Parse(txtGiaNhap.Text) > int.Parse(txtGiaBan.Text))
                {
                    lbGiaNhap.Text = "xGiá nhập phải bé hơn giá bán";
                }
            }
            catch { }

        }


        //Load
        private void frmThongTin_Sach_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection DataCollectionNXB = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DataCollectionTL = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DataCollectionTG = new AutoCompleteStringCollection();

            getDataNXB(DataCollectionNXB);
            cmbMaNXB.AutoCompleteCustomSource = DataCollectionNXB;

            getDataTG(DataCollectionTL);
            cmbMaTG.AutoCompleteCustomSource = DataCollectionTL;

            getDataTL(DataCollectionTG);
            cmbMaTL.AutoCompleteCustomSource = DataCollectionTG;
            loadData();
            loadNDisplay();

        }

        //Đăng kí sách
        private void btnRegister_Click(object sender, EventArgs e)
        {
            lbTenS.Text = lbNamXB.Text = lbSL.Text = lbGiaNhap.Text = lbGiaXuat.Text = "";
            Database.TheLoai theLoai = context.TheLoais.FirstOrDefault(t => t.MaTL == cmbMaTL.Text);
            Database.NhaXuatBan NXB = context.NhaXuatBans.FirstOrDefault(t => t.MaNXB == cmbMaNXB.Text);
            Database.TacGia tacgia = context.TacGias.FirstOrDefault(t => t.MaTG == cmbMaTG.Text);
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn thêm sách này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    Database.Sach sach = new Database.Sach();
                    if (txtMaS.Text == ""
                        || txtTenS.Text == ""
                        || txtNamXB.Text == ""
                        || txtGiaNhap.Text == ""
                        || txtGiaBan.Text == ""
                        || cmbMaTL.Text == ""
                        || cmbMaNXB.Text == ""
                        || cmbMaTG.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.Parse(txtNamXB.Text) > dateNow)
                    {
                        lbNamXB.Text = ("Năm xuất bản phải < năm {0}", dateNow).ToString();
                    }
                    else if (int.Parse(txtGiaNhap.Text) > int.Parse(txtGiaBan.Text))
                    {

                        lbGiaNhap.Text = ("Giá nhập phải <= giá bán.").ToString();

                    }
                    else if (theLoai == null || NXB == null || tacgia == null)
                    {
                        MessageBox.Show("Sai thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        sach.MaS = txtMaS.Text;
                        sach.TenS = txtTenS.Text;
                        sach.NamXuatBan = int.Parse(txtNamXB.Text);
                        sach.SoLuongTon = int.Parse(txtSoLuong.Text);
                        sach.GiaNhap = int.Parse(txtGiaNhap.Text);
                        sach.GiaBan = int.Parse(txtGiaBan.Text);
                        sach.MaTL = cmbMaTL.Text;
                        sach.MaTG = cmbMaTG.Text;
                        sach.MaNXB = cmbMaNXB.Text;

                        Database.Sach s = context.Saches.FirstOrDefault(ss => ss.MaS == txtMaS.Text);
                        if (s == null)
                        {
                            context.Saches.InsertOnSubmit(sach);
                            context.SubmitChanges();

                            MessageBox.Show("Đăng kí thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            ClearText();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin sách đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("");
                }
            }
        }
        //Cập nhật sách
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lbTenS.Text = lbNamXB.Text = lbSL.Text = lbGiaNhap.Text = lbGiaXuat.Text = "";

            DialogResult dia = MessageBox.Show("Bạn muốn cập nhật thông tin sách? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {
                try
                {

                    Database.Sach sach = new Database.Sach();
                    if (txtMaS.Text == ""
                        || txtTenS.Text == ""
                        || txtNamXB.Text == ""
                        || txtGiaNhap.Text == ""
                        || txtGiaBan.Text == ""
                        || cmbMaTL.Text == ""
                        || cmbMaNXB.Text == ""
                        || cmbMaTG.Text == "")
                    {

                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (int.Parse(txtNamXB.Text) > dateNow)
                    {
                        lbNamXB.Text = ("Năm xuất bản phải < năm {0}", dateNow).ToString();
                    }
                    else if (int.Parse(txtGiaNhap.Text) > int.Parse(txtGiaBan.Text))
                    {

                        lbGiaNhap.Text = ("Giá nhập phải <= giá bán.").ToString();

                    }
                    else
                    {

                        var s = context.Saches.FirstOrDefault(k => k.MaS == txtMaS.Text);
                        if (s != null)
                        {

                            s.TenS = txtTenS.Text;
                            s.NamXuatBan = int.Parse(txtNamXB.Text);
                            s.SoLuongTon = int.Parse(txtSoLuong.Text);
                            s.GiaNhap = int.Parse(txtGiaNhap.Text);
                            s.GiaBan = int.Parse(txtGiaBan.Text);
                            s.MaTL = cmbMaTL.Text;
                            s.MaTG = cmbMaTG.Text;
                            s.MaNXB = cmbMaNXB.Text;

                            context.SubmitChanges();
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            ClearText();
                        }
                        else
                        {

                            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("");
                }
            }
        }
        //xoá sách
        private void btnDeleteUs_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn muốn xoá thông tin sách này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {

                var sach = context.Saches.FirstOrDefault(k => k.MaS == txtMaS.Text);
                if (sach != null)
                {
                    try
                    {
                        context.Saches.DeleteOnSubmit(sach);
                        context.SubmitChanges();
                        MessageBox.Show("Xóa Đối tượng thành công");
                        loadData();
                        ClearText();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xoá đối tượng này");
                    }
                }
                else
                {

                    MessageBox.Show("Xoá thất bại");
                    ClearText();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearText();
            loadData();
            loadNDisplay();
        }
        //Tham chiếu dữ liệu từ gridcontrol -> textbox
        private void gridconSachInfo_Click(object sender, EventArgs e)
        {

            txtMaS.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cMaS).ToString();
            txtTenS.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cTenS).ToString();
            txtNamXB.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cNamXB).ToString();
            txtSoLuong.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cSLT).ToString();
            txtGiaNhap.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cGiaNhap).ToString();
            txtGiaBan.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cGiaBan).ToString();
            cmbMaTL.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cMaTL).ToString();
            cmbMaTG.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cMaTG).ToString();
            cmbMaNXB.Text = gridviewSachInfo.GetRowCellValue(gridviewSachInfo.FocusedRowHandle, cMaNXB).ToString();

        }

        private void gridviewSachInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }


    }
}