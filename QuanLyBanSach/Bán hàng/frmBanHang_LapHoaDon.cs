using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanSach
{
    public partial class frmBanHang_LapHoaDon : DevExpress.XtraEditors.XtraForm
    {

        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        
        frmMain frm1;
      

        //Constructor
        public frmBanHang_LapHoaDon()
        {
            InitializeComponent();
        }
        public frmBanHang_LapHoaDon(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        //checksố lượng
        bool checkSl()
        {
            var t = context.Saches.FirstOrDefault(s => s.MaS == cmbMaS.Text && s.SoLuongTon >= int.Parse(txtSoLuong.Text));
            if (t == null)
            {              
                return false;
            }
            return true;
        }
        //tổng số lượng tồn còn lại
        void tong()
        {

        }
        //Form loading
        public void autoGenMHD()
        {
            string maLonNhat = (from hd in context.HoaDons
                                orderby hd.MaHD descending
                                select hd.MaHD).FirstOrDefault();
            if (maLonNhat == null)
            {
                txtMaHD.Text = "HD00".ToString();
            }
            else
            {
                int stt = int.Parse(maLonNhat.Substring(2));
                //+1 ra stt tiếp theo
                stt += 1;
                if (stt < 10)
                    txtMaHD.Text = "HD0" + stt.ToString();
                else if (stt < 100)
                    txtMaHD.Text = "KH" + stt.ToString();
                else
                    txtMaHD.Text = "KH" + stt.ToString();
            }
            //Mã thể loại có dạng "TL001". Cắt chuỗi con từ vị trí thứ 2 ra được stt là "001". Ép thành in ra "1"
            

           
        }
        void clear()
        {
            txtSoLuong.Clear();         
            txtThanhTien.Clear();
            
        }
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

        //Hàm buộc viết số trong textbox
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
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
        //truyền MaKH vào collectionkh để gợi ý
        public void getDataKH(AutoCompleteStringCollection Data)
        {
            foreach( var hk in context.KhachHangs)
            {
                Data.Add(hk.MaKH);
            }

        }
        //truyền MaKH vào collectionS để gợi ý
        public void getDataS(AutoCompleteStringCollection Data)
        {
            foreach (var hk in context.KhachHangs)
            {
                Data.Add(hk.MaKH);
            }

        }
        private void frmBanHang_LapHoaDon_Load(object sender, EventArgs e)
        {
           
            AutoCompleteStringCollection DataCollectionKH = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DataCollectionS = new AutoCompleteStringCollection();
            Database.HoaDon hoaDon = new Database.HoaDon();
           
            //truyền vào customsource cmbMAKH

            getDataKH(DataCollectionKH);
            cmbMaKH.AutoCompleteCustomSource = DataCollectionKH;
            //truyền vào customsource cmbMAKH

            getDataKH(DataCollectionKH);
            cmbMaS.AutoCompleteCustomSource = DataCollectionS;
            //Set ngày tháng lập hoá đơn chỉ dược là ngyà hôm nay

            dtimepickNgayBan.MinDate = DateTime.Now;
            dtimepickNgayBan.MaxDate = DateTime.Now;
            
            //
            autoGenMHD();
            loadNDisplay();

        }
        //Event textchange của cmbMaKH, cmbMaS
        //cmbMaKH
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
        //cmbMaS
        private void cmbMaS_TextChanged(object sender, EventArgs e)
        {
            cmbMaS.DataSource = context.Saches;
            cmbMaS.DisplayMember = "MaS";
            cmbMaS.ValueMember = "MaS";

            var sName = context.Saches.FirstOrDefault(s => s.MaS == cmbMaS.Text);
            if (sName != null)
            {
                cmbTenS.Text = sName.TenS.ToString();
                txtDonGia.Text = sName.GiaBan.ToString();
            }
        }

        ////////

        private void InsertUpdate(int selectedRow)
        {
            dgvTTSach.Rows[selectedRow].Cells[0].Value = cmbMaS.Text;
            dgvTTSach.Rows[selectedRow].Cells[1].Value = cmbTenS.Text;
            dgvTTSach.Rows[selectedRow].Cells[2].Value = txtDonGia.Text;
            dgvTTSach.Rows[selectedRow].Cells[3].Value = txtSoLuong.Text;
            dgvTTSach.Rows[selectedRow].Cells[4].Value = txtThanhTien.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMaS.Text == "" || cmbTenS.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }else if(checkSl()== false)
                {
                    MessageBox.Show("Số lượng phải bé hơn số lượng tồn", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    int selectedRow = GetSelectedRow(cmbMaS.Text);
                    if (selectedRow == -1)
                    {
                        selectedRow = dgvTTSach.Rows.Add();
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                        tongTien();
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
        //Updateting details listview
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMaS.Text == "" || cmbTenS.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else if (checkSl() == false)
                {
                    MessageBox.Show("Số lượng phải bé hơn số lượng tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        tongTien();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Deleting details in listview
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
                        tongTien();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Into money
        void Tinh_ThanhTien()
        {
            try
            {
                float s = float.Parse(txtDonGia.Text) * float.Parse(txtSoLuong.Text);
               

                txtThanhTien.Text = s.ToString();
            }
            catch
            {

            }
        }

        //checkSL
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            lbSoLuong.Text = "";
           

            if (txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
            }else if (checkSl() == false)
            {
                lbSoLuong.Text = "xSố lượng phải < hoặc = Số lượng tồn".ToString();
            }
           
            else
            {
                Tinh_ThanhTien();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
            }

            else
            {
                Tinh_ThanhTien();
            }
        }
        //Sum of ThanhTien
        void tongTien()
        {
            float tong = 0;
            for (int i = 0; i < dgvTTSach.Rows.Count; i++)
            {
                tong += float.Parse(dgvTTSach.Rows[i].Cells[4].Value.ToString());
            }
            txtTongTien.Text = tong.ToString();
        }
        //Get MaHD, NgayLapHD, MaKH, TongHD(TongTien) into database
        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            try
            {
                Database.HoaDon hoadon = new Database.HoaDon();
                string mas;
                int soluongban = 0;
                int giaban = 0;


                if (txtMaHD.Text == "" || cmbMaKH.Text == "" || dtimepickNgayBan.Text == ""
                                       || txtTongTien.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                

                else
                {

                    hoadon.MaHD = txtMaHD.Text;
                    hoadon.MaKH = cmbMaKH.Text;
                    hoadon.NgayLapHD = DateTime.Parse(dtimepickNgayBan.Text);
                    hoadon.TongHD = int.Parse(txtTongTien.Text);

                    var hd = context.HoaDons.FirstOrDefault(h => h.MaHD == txtMaHD.Text);
                    var kh = context.KhachHangs.FirstOrDefault(k => k.MaKH == cmbMaKH.Text);
                    if (kh != null)
                    {
                        
                       

                        if (hd == null)
                        {


                            context.HoaDons.InsertOnSubmit(hoadon);
                            context.SubmitChanges();

                            for (int i = 0; i < dgvTTSach.Rows.Count; i++)
                            {
                                Database.CTHD cTHD = new Database.CTHD();
                                mas = dgvTTSach.Rows[i].Cells[0].Value.ToString();
                                giaban = int.Parse(dgvTTSach.Rows[i].Cells[2].Value.ToString());
                                soluongban = int.Parse(dgvTTSach.Rows[i].Cells[3].Value.ToString());
                              

                                cTHD.MaHD = txtMaHD.Text;
                                cTHD.MaS = mas;
                                cTHD.SoLuongBan = soluongban;
                                cTHD.GiaBan = giaban;
                                var t = context.Saches.FirstOrDefault(s => s.MaS == cmbMaS.Text && s.SoLuongTon >= int.Parse(txtSoLuong.Text));
                                if (t == null)
                                {
                                }
                                else
                                {
                                    t.SoLuongTon -= int.Parse(txtSoLuong.Text);
                                }
                                
                               

                                context.CTHDs.InsertOnSubmit(cTHD);
                                this.context.SubmitChanges();
                            }
                            MessageBox.Show("Lập hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNDisplay();

                        }
                        else
                        {
                            MessageBox.Show("Hoá đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch
            {
                MessageBox.Show("");
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


        private void dgvTTSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrows;
            try
            {
                numrows = e.RowIndex;

                cmbMaS.Text = dgvTTSach.Rows[numrows].Cells[0].Value.ToString();
                cmbTenS.Text = dgvTTSach.Rows[numrows].Cells[1].Value.ToString();
                txtDonGia.Text = dgvTTSach.Rows[numrows].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvTTSach.Rows[numrows].Cells[3].Value.ToString();
                txtThanhTien.Text = dgvTTSach.Rows[numrows].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDSHD_Click(object sender, EventArgs e)
        {
            frmDanhSach_DSHD frm = new frmDanhSach_DSHD(frm1,this);
            frm1.showFrm<frmDanhSach_DSHD>(frm);
        }

       
    }


}








