using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanSach.Quản_lý
{
    public partial class frmThongTin_TheLoai : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;
        public frmThongTin_TheLoai()
        {
            InitializeComponent();
        }
        public frmThongTin_TheLoai(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        void loadData()
        {
            var dss = context.TheLoais.ToList();
            gridconTheLoaiInfo.DataSource = dss;
            
        }
        void clear()
        {
            autoGenMTL();
            txtNameTL.Clear();
        }

        public void autoGenMTL()
        {
           
            string maLonNhat = (from tl in context.TheLoais
                                orderby tl.MaTL descending
                                select tl.MaTL).FirstOrDefault();
            //Mã thể loại có dạng "TL001". Cắt chuỗi con từ vị trí thứ 2 ra được stt là "001". Ép thành in ra "1"
            int stt = int.Parse(maLonNhat.Substring(2));
            //+1 ra stt tiếp theo
            if (maLonNhat == null)
            {
                txtTLID.Text = "TL000".ToString();
            }
            else
            {
                stt += 1;
                if (stt < 10)
                    txtTLID.Text = "TL00" + stt.ToString();
                else if (stt < 100)
                    txtTLID.Text = "TL0" + stt.ToString();
                else
                    txtTLID.Text = "TL" + stt.ToString();

              
            }
        }

        private void frmThongTin_TheLoai_Load(object sender, System.EventArgs e)
        {
            loadData();
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //dua dialog xuong
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn thêm sách này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    Database.TheLoai theloai = new Database.TheLoai();
                    if (txtTLID.Text == ""
                        || txtNameTL.Text == "")

                    {
                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        theloai.MaTL = txtTLID.Text;
                        theloai.TenTL = txtNameTL.Text;


                        Database.TheLoai tl = context.TheLoais.FirstOrDefault(ss => ss.MaTL == txtTLID.Text);
                        if (tl == null)
                        {
                            context.TheLoais.InsertOnSubmit(theloai);
                            context.SubmitChanges();

                            MessageBox.Show("Đăng kí thông tin thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            clear();
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

                    Database.Sach sach = new Database.Sach();
                    if (txtTLID.Text == ""
                        || txtNameTL.Text == "")
                       
                    {

                        MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        var s = context.TheLoais.FirstOrDefault(k => k.MaTL == txtTLID.Text);
                        if (s != null)
                        {

                            s.TenTL = txtNameTL.Text;
                          

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

                var tl = context.TheLoais.FirstOrDefault(k => k.MaTL == txtTLID.Text);
                if (tl != null)
                {
                    try
                    {
                        context.TheLoais.DeleteOnSubmit(tl);
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
            
            loadData();
            clear();
        }

 

        private void gridvieTheLoaiInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridvieTheLoaiInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtTLID.Text = gridvieTheLoaiInfo.GetRowCellValue(gridvieTheLoaiInfo.FocusedRowHandle, cMaTL).ToString();
            txtNameTL.Text = gridvieTheLoaiInfo.GetRowCellValue(gridvieTheLoaiInfo.FocusedRowHandle, cTenTL).ToString();

        }
    }
}