using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmThongTinChung_KhachHang : DevExpress.XtraEditors.XtraForm
    {


        frmMain frm1;
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        
        //constructor
        public frmThongTinChung_KhachHang()
        {
            InitializeComponent();
        }

        public frmThongTinChung_KhachHang(frmMain main)
        {
            InitializeComponent();
            frm1 = main;
        }
        //loadDatabase
        void loadData()
        {
            var dskh = context.KhachHangs.ToList();
            gridctrlCustomerInfo.DataSource = dskh;
            
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
           
            loadData();

        }
        //clear text in textbox

        void ClearText()
        {

           
            txtNameKH.Clear();
            txtDoB.Clear();
            txtAddress.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            autoGenMKH();
        }
      

        public void autoGenMKH()
        {
            string maLonNhat = (from kh in context.KhachHangs
                                orderby kh.MaKH descending
                                select kh.MaKH).FirstOrDefault();
            //Mã KH có dạng "KH001". Cắt chuỗi con từ vị trí thứ 2 ra được stt là "001". Ép thành in ra "1"
            int stt = int.Parse(maLonNhat.Substring(2));
            //+1 ra stt tiếp theo
            if (maLonNhat == null)
            {
                txtKHID.Text = "KH00".ToString();
            }
            else
            {
                stt += 1;
                if (stt < 10)
                    txtKHID.Text = "KH0" + stt.ToString();
                else if (stt < 100)
                    txtKHID.Text = "KH" + stt.ToString();
                else
                    txtKHID.Text = "KH" + stt.ToString();

                txtNameKH.Text = "";
            }
            
        }

        //Register Customer
        private void btnRegister_Click(object sender, EventArgs e)
        {
            lbTenKH.Text = lbDoBKH.Text = lbAdressKH.Text = lbSDTKH.Text = lbEmailKH.Text = "";

            DialogResult dia = MessageBox.Show("Bạn có chắc muốn thêm người này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    Database.KhachHang khachH = new Database.KhachHang();
                    if (txtKHID.Text == "" || txtNameKH.Text == "" || txtDoB.Text == "" || txtAddress.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
<<<<<<< Updated upstream
                    else if (txtSDT.Text.Length != 10)
                    {

                        lbSDTKH.Text=("SDT phải có 10 số.").ToString();

=======
                    else if (txtSDT.Text.Length != 10 || txtSDT.Text.IndexOf("0") != 0)
                    {
                        MessageBox.Show("SDT phải có 10 chữ số và bắt đầu bằng 0.");
                    }
                    else if (checkEmail() == false)
                    {
                        lbEmailKH.Text = "Sai dịnh dạng email, vd: 123@gmail.com".ToString();
>>>>>>> Stashed changes
                    }
                    else
                    {

                        khachH.MaKH = txtKHID.Text;
                        khachH.TenKH = txtNameKH.Text;
                        khachH.NgaySinhKH = DateTime.Parse(txtDoB.Text);
                        khachH.DiaChiKH = txtAddress.Text;
                        khachH.SdtKH = txtSDT.Text;
                        khachH.EmailTG = txtEmail.Text;

                        var kh = context.KhachHangs.FirstOrDefault(k => k.MaKH == txtKHID.Text);
                        if (kh == null)
                        {
                            context.KhachHangs.InsertOnSubmit(khachH);
                            context.SubmitChanges();
                            MessageBox.Show("Đăng kí tài khoản khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            ClearText();
                        }
                        else
                        {
                            MessageBox.Show("Người dùng này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                catch
                {
                    lbDoBKH.Text=("Ngày sinh Kh phải đúng định dạng( d/m/y)").ToString();
                }
            }
        }

        //Update Customer
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lbTenKH.Text = lbDoBKH.Text = lbAdressKH.Text = lbSDTKH.Text = lbEmailKH.Text = "";

            DialogResult dia = MessageBox.Show("Bạn muốn cập nhật người này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {
                try
                {

                    Database.KhachHang khachH = new Database.KhachHang();
                    if (txtKHID.Text == "" || txtNameKH.Text == "" || txtDoB.Text == "" || txtAddress.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                    {

                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
<<<<<<< Updated upstream
                    else if (txtSDT.Text.Length != 10)
                    {

                        lbSDTKH.Text=("SDT phải có 10 số.").ToString();
=======
                    else if (txtSDT.Text.Length != 10 || txtSDT.Text.IndexOf("0") != 0)
                    {
                        MessageBox.Show("SDT phải có 10 chữ số và bắt đầu bằng 0.");
                    }
                    else if (checkEmail() == false)
                    {
                        lbEmailKH.Text = "Sai dịnh dạng email, vd: 123@gmail.com".ToString();
>>>>>>> Stashed changes
                    }
                    else
                    {

                        var kh = context.KhachHangs.FirstOrDefault(k => k.MaKH == txtKHID.Text);
                        if (kh != null)
                        {

                            kh.TenKH = txtNameKH.Text;
                            kh.NgaySinhKH = DateTime.Parse(txtDoB.Text).Date;
                            kh.DiaChiKH = txtAddress.Text;
                            kh.SdtKH = txtSDT.Text;
                            kh.EmailTG = txtEmail.Text;
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

                    lbDoBKH.Text=("Ngày sinh Kh phải đúng định dạng( d/m/y)").ToString();
                }
            }
        }
        //get Data from gridcontrol to textbox
        private void griviewCusInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cDiaChiKH) == null)
            {
                txtAddress.Text = "".ToString();
            }
            else
            {
                txtKHID.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cMaKH).ToString();
                var DoB = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cNgaySinhKH).ToString();

                txtDoB.Text = DateTime.Parse(DoB).ToShortDateString();
                txtNameKH.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cTenKH).ToString();
                txtAddress.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cDiaChiKH).ToString();
                txtSDT.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cSdtKH).ToString();
                txtEmail.Text = griviewCusInfo.GetRowCellValue(griviewCusInfo.FocusedRowHandle, cEmailTG).ToString();
            }

        }

        //Delete Customer
        private void btnDeleteUs_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn muốn xoá người này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {

                var kh = context.KhachHangs.FirstOrDefault(k => k.MaKH == txtKHID.Text && k.MaKH != "KH00");
                if (kh != null)
                {
                    try
                    {
                        context.KhachHangs.DeleteOnSubmit(kh);
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
            loadData();
            autoGenMKH();
            ClearText();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false )
            {
                e.Handled = true;
            }
        }

        private void txtDoB_TextChanged(object sender, EventArgs e)
        {
            lbDoBKH.Text = "".ToString();
            try
            {
                DateTime dateTime = DateTime.Parse(txtDoB.Text);
            }
            catch
            {
                lbDoBKH.Text = "Ngày sinh Kh phải đúng định dạng( d/m/y)".ToString();
            }
        }
<<<<<<< Updated upstream
=======

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            lbSDTKH.Text = "";
            if (txtSDT.Text.Length != 10 || txtSDT.Text.IndexOf("0") != 0)
            {
                lbSDTKH.Text = "SDT phải có 10 số và phải bắt đầu bằng 0.".ToString();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lbEmailKH.Text = "".ToString();
            if (checkEmail() == false)
            {
                lbEmailKH.Text = "Sai dịnh dạng email, vd: 123@gmail.com".ToString();
            }
        }
        bool checkEmail()
        {
            string s1 = "@";
            string s2 = ".com";
            string s3 = ".vn";
            if (txtEmail.Text.Contains(s1) && (txtEmail.Text.Contains(s2) || txtEmail.Text.Contains(s3)))
            {
                return true;
            }
            return false;
        }


>>>>>>> Stashed changes
    }
}
