using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach.Quản_lý
{
    public partial class frmThongTin_TacGia : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;
        public frmThongTin_TacGia()
        {
            InitializeComponent();
        }
        public frmThongTin_TacGia(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;

        }
        void loadData()
        {
            
            var dstg = context.TacGias.ToList();
            gridconTGInfo.DataSource = dstg;
            autoGenMNXB();
          
            
        }
        public void autoGenMNXB()
        {
            string maLonNhat = (from tg in context.TacGias
                                orderby tg.MaTG descending
                                select tg.MaTG).FirstOrDefault();
            if (maLonNhat == null)
            {
                txtTGID.Text = "TG000".ToString();
            }
            else
            {
                int stt = int.Parse(maLonNhat.Substring(3));
                //+1 ra stt tiếp theo
                stt += 1;
                if (stt < 10)
                    txtTGID.Text = "TG00" + stt.ToString();
                else if (stt < 100)
                    txtTGID.Text = "TG0" + stt.ToString();
                else
                    txtTGID.Text = "TG" + stt.ToString();
            }
        }
        bool checkEmail()
        {
            lbTGEmail.Text = "".ToString();
            string s1 = "@gmail.com";
            if (txtTGEmail.Text.Contains(s1))
            {
                return true;
            }
            return false;
        }

        void clear()
        {
            
            txtTGName.Clear();
            txtTGDoB.Clear();
            txtTGSDT.Clear();
            lbTGSDT.Text = "";
            txtTGEmail.Clear();
        }

        private void gridconTGInfo_Click(object sender, System.EventArgs e)
        {
            object sdt = gridvieTGInfo.GetRowCellValue(gridvieTGInfo.FocusedRowHandle, cSdtTG);
            object dob = gridvieTGInfo.GetRowCellValue(gridvieTGInfo.FocusedRowHandle, cNgaySinhTG);
            object email = gridvieTGInfo.GetRowCellValue(gridvieTGInfo.FocusedRowHandle, cEmailTG);
            if (sdt==null && dob==null)
            {
                txtTGSDT.Text = "";
                txtTGDoB.Text = "";
                txtTGEmail.Text = email.ToString();
            }
            else if(sdt == null && email == null)
            {
                txtTGSDT.Text = "";
                txtTGEmail.Text = "";
                txtTGDoB.Text = DateTime.Parse(dob.ToString()).ToShortDateString() ;   
            }
             else if(email ==null && dob == null )
            {
                txtTGDoB.Text = "";
                txtTGEmail.Text = "";
                txtTGSDT.Text = sdt.ToString();
            }
            else if (sdt == null)
            {
                txtTGSDT.Text = "";
                txtTGDoB.Text = DateTime.Parse(dob.ToString()).ToShortDateString();
                txtTGEmail.Text = email.ToString();
            }else if(email == null)
            {
                txtTGEmail.Text = "";
                txtTGDoB.Text = DateTime.Parse(dob.ToString()).ToShortDateString();
                txtTGSDT.Text = sdt.ToString();
            }else if (dob == null)
            {
                txtTGDoB.Text = "";
                txtTGSDT.Text = sdt.ToString();
                txtTGEmail.Text = email.ToString();
            }
            else
            {
                txtTGSDT.Text = sdt.ToString();
                txtTGDoB.Text = DateTime.Parse(dob.ToString()).ToShortDateString();
                txtTGEmail.Text = email.ToString();
            }

            txtTGID.Text = gridvieTGInfo.GetRowCellValue(gridvieTGInfo.FocusedRowHandle, cMaTG).ToString();
            txtTGName.Text = gridvieTGInfo.GetRowCellValue(gridvieTGInfo.FocusedRowHandle, cTenTG).ToString();


        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn thêm NXB này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    Database.TacGia tacgia = new Database.TacGia();
                    if (txtTGID.Text == ""
                        || txtTGName.Text == ""
                        || txtTGDoB.Text == ""
                        || txtTGSDT.Text == ""
                        || txtTGEmail.Text == "")

                    {
                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (txtTGSDT.Text.Length !=10|| txtTGSDT.Text.IndexOf("0") != 0)
                    {
                        MessageBox.Show("SDT không hợp lệ.");
                    }
                    else if (checkEmail() == false)
                    {
                        lbTGEmail.Text = "Sai dịnh dạng email, vd: 123@gmail.com".ToString();
                    }
                    else
                    {

                        tacgia.MaTG = txtTGID.Text;
                        tacgia.TenTG = txtTGName.Text;
                        tacgia.NgaySinhTG = DateTime.Parse(txtTGDoB.Text);
                        tacgia.SdtTG = txtTGSDT.Text;
                        tacgia.EmailTG = txtTGEmail.Text;


                        Database.TacGia tg = context.TacGias.FirstOrDefault(tgs => tgs.MaTG == txtTGID.Text);
                        if (tg == null)
                        {
                            context.TacGias.InsertOnSubmit(tacgia);
                            context.SubmitChanges();

                            MessageBox.Show("Đăng kí thông tin tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin tác giả đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Ngày sinh Kh phải đúng định dạng(d / m / y)");
                }
            }
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
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
                    if (txtTGID.Text == ""
                        || txtTGName.Text == ""
                        || txtTGDoB.Text == ""
                        || txtTGSDT.Text == ""
                        || txtTGEmail.Text == "")

                    {

                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtTGSDT.Text.Length != 10)
                    {
                        MessageBox.Show("SDT phải có 10 chữ số.");
                    }
                    else if (checkEmail() == false)
                    {
                        txtTGEmail.Text = "Sai dịnh dạng email, vd: 123@gmail.com".ToString();
                    }
                    else
                    {

                        var tacg = context.TacGias.FirstOrDefault(tgs => tgs.MaTG == txtTGID.Text);
                        if (tacg != null)
                        {

                            tacg.TenTG = txtTGName.Text;
                            tacg.NgaySinhTG = DateTime.Parse(txtTGDoB.Text);
                            tacg.SdtTG = txtTGSDT.Text;
                            tacg.EmailTG = txtTGEmail.Text;


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

                    MessageBox.Show("Ngày sinh Kh phải đúng định dạng(d / m / y)");
                }
            }
        }

        private void btnDeleteUs_Click(object sender, System.EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn muốn xoá thông tin sách này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {

                var tacgia = context.TacGias.FirstOrDefault(tg => tg.MaTG == txtTGID.Text);
                if (tacgia != null)
                {
                    try
                    {
                        context.TacGias.DeleteOnSubmit(tacgia);
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

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            clear();
            loadData();
        }

        private void frmThongTin_TacGia_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtTGSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && 
                Char.IsControl(e.KeyChar) == false || 
                txtTGSDT.Text.Length ==10 &&
                e.KeyChar !=(char)Keys.Back)
            {
                
                e.Handled = true;
            }
        }

        private void gridvieTGInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void txtTGSDT_TextChanged(object sender, EventArgs e)
        {
            lbTGSDT.Text = "";
            string dauSo = "0";
            if (txtTGSDT.Text.Length != 10|| txtTGSDT.Text.IndexOf(dauSo)!=0)
            {
                lbTGSDT.Text = "SDT phải có 10 số và phải bắt đầu bằng 0".ToString();
            }
        }

    }
}



