using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach.Quản_lý
{
    public partial class frmThongTin_NXB : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;
        public frmThongTin_NXB()
        {
            InitializeComponent();
        }
        public frmThongTin_NXB(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;

        }

        void loadData()
        {
            var dsnxb = context.NhaXuatBans.ToList();
            gridconNXBInfo.DataSource = dsnxb;
            autoGenMNXB();
        }
        public void autoGenMNXB()
        {
            string maLonNhat = (from hd in context.NhaXuatBans
                                orderby hd.MaNXB descending
                                select hd.MaNXB).FirstOrDefault();
            if (maLonNhat == null)
            {
                txtMaNXB.Text = "NXB00".ToString();
            }
            else
            {
                int stt = int.Parse(maLonNhat.Substring(3));
                //+1 ra stt tiếp theo
                stt += 1;
                if (stt < 10)
                    txtMaNXB.Text = "NXB0" + stt.ToString();
                else if (stt < 100)
                    txtMaNXB.Text = "NXB" + stt.ToString();
                else
                    txtMaNXB.Text = "NXB" + stt.ToString();
            }
        }

        void clear()
        {
            txtTenNXB.Clear();
            txtAddress.Clear();
            txtSDT.Clear();
            txtEmail.Clear();

        }

        private void frmThongTin_NXB_Load(object sender, System.EventArgs e)
        {
            loadData();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false &&
                Char.IsControl(e.KeyChar) == false ||
                txtSDT.Text.Length == 11 &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn thêm NXB này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    Database.NhaXuatBan nhaxuatban = new Database.NhaXuatBan();
                    if (txtMaNXB.Text == ""
                        || txtTenNXB.Text == ""
                        || txtAddress.Text == ""
                        || txtSDT.Text == ""
                        || txtEmail.Text == "")

                    {
                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }else if( txtSDT.Text.Length != 11 || txtSDT.Text.IndexOf("0") != 0)
                    {
                        MessageBox.Show("SDT phải có 11 chữ số và bắt đầu bằng 0.");
                    }else if (checkEmail() == false)
                    {
                        lbEmailNXB.Text = "Sai dịnh dạng email, vd: 123@gmail.com".ToString();
                    }
                    else
                    {

                        nhaxuatban.MaNXB = txtMaNXB.Text;
                        nhaxuatban.TenNXB = txtTenNXB.Text;
                        nhaxuatban.DiaChiNXB = txtAddress.Text;
                        nhaxuatban.EmailNXB = txtEmail.Text;
                        nhaxuatban.SdtNXB = txtSDT.Text;


                        Database.NhaXuatBan tl = context.NhaXuatBans.FirstOrDefault(ss => ss.MaNXB == txtMaNXB.Text);
                        if (tl == null)
                        {
                            context.NhaXuatBans.InsertOnSubmit(nhaxuatban);
                            context.SubmitChanges();

                            MessageBox.Show("Đăng kí thông tin NXB thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin NXB đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn muốn cập nhật thông tin sách? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {
                try
                {

                    Database.NhaXuatBan nhaxuatban = new Database.NhaXuatBan();
                    if (txtMaNXB.Text == ""
                        || txtTenNXB.Text == ""
                        || txtAddress.Text == ""
                        || txtSDT.Text == ""
                        || txtEmail.Text == "")

                    {

                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtSDT.Text.Length != 11 || txtSDT.Text.IndexOf("0") != 0)
                    {
                        MessageBox.Show("SDT phải có 11 số và phải bắt đầu bằng 0.");
                    }else if (checkEmail() == false)
                    {
                        lbEmailNXB.Text = "Sai dịnh dạng email, vd: 123@gmail.com".ToString();
                    }
                    else
                    {

                        var s = context.NhaXuatBans.FirstOrDefault(nxb => nxb.MaNXB == txtMaNXB.Text);
                        if (s != null)
                        {

                            s.TenNXB = txtTenNXB.Text;
                            s.DiaChiNXB = txtAddress.Text;
                            s.SdtNXB = txtSDT.Text;
                            s.EmailNXB = txtEmail.Text;


                            context.SubmitChanges();
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            clear();
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

        private void btnDeleteUs_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn muốn xoá thông tin sách này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {

                var nxb = context.NhaXuatBans.FirstOrDefault(k => k.MaNXB == txtMaNXB.Text);
                if (nxb != null)
                {
                    try
                    {
                        context.NhaXuatBans.DeleteOnSubmit(nxb);
                        context.SubmitChanges();
                        MessageBox.Show("Xóa Đối tượng thành công");
                        loadData();
                        clear();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xoá đối tượng này");
                    }
                }
                else
                {

                    MessageBox.Show("Xoá thất bại");
                    clear();
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
            loadData();
        }

        private void gridconNXBInfo_Click(object sender, EventArgs e)
        {
            txtMaNXB.Text = gridviewNXBInfo.GetRowCellValue(gridviewNXBInfo.FocusedRowHandle, cMaNXB).ToString();
            txtTenNXB.Text = gridviewNXBInfo.GetRowCellValue(gridviewNXBInfo.FocusedRowHandle, cTenNXB).ToString();
            txtAddress.Text = gridviewNXBInfo.GetRowCellValue(gridviewNXBInfo.FocusedRowHandle, cDiaChiNXB).ToString();
            txtSDT.Text = gridviewNXBInfo.GetRowCellValue(gridviewNXBInfo.FocusedRowHandle, cSdtNXB).ToString();
            txtEmail.Text = gridviewNXBInfo.GetRowCellValue(gridviewNXBInfo.FocusedRowHandle, cEmail).ToString();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lbEmailNXB.Text = "".ToString();
            if (checkEmail() == false)
            {
                lbEmailNXB.Text = "Sai dịnh dạng email, vd: 123@gmail.com".ToString();
            }
        }
        bool checkEmail()
        {
            lbAdressKH.Text = "".ToString();
            string s1 = "@";
            string s2 = ".com";
            string s3 = ".vn";

            if (txtEmail.Text.Contains(s1) && (txtEmail.Text.Contains(s2) || txtEmail.Text.Contains(s3)))
            {
                return true;
            }
            return false;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            lbSDTNXB.Text = "";
            if(txtSDT.Text.Length != 11 || txtSDT.Text.IndexOf("0") != 0)
            {
                lbSDTNXB.Text = "SDT phải có 11 số và phải bắt đầu bằng 0.".ToString();
            }
        }

        private void gridviewNXBInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void txtTenNXB_TextChanged(object sender, EventArgs e)
        {
            lbTenNXB.Text = "";
            if (txtTenNXB.Text == "")
            {
                lbTenNXB.Text = "Tên NXB không được trống!";
            }
        }
    }
}