using System;
using System.Linq;
using System.Windows.Forms;


namespace QuanLyBanSach
{

    public partial class frmHeThong_DangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        frmMain main1;
        Database.QLBanSachDataContext QLContext = new Database.QLBanSachDataContext();

        //kiểm tra mật khẩu >8 kí tự, bao gồm ít nhất 1 chữ hoa, 1 chữ thường và 1 kí tự.



        public frmHeThong_DangNhap()
        {
            InitializeComponent();
        }

        public frmHeThong_DangNhap(frmMain main)
        {
            InitializeComponent();
            main1 = main;

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {



            if (txtAccount.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {

                MessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPassword.Text.Length < 8 && txtPassword.Text.Length > 15)
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 8 đến 15 kí tự.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.NhanVien loginInfo = QLContext.NhanViens.Where(tk => tk.MaNV == txtAccount.Text).ToList().
                                                    Where(mk => mk.MatKhau == txtPassword.Text).FirstOrDefault();

                Database.NhanVien loginAC = QLContext.NhanViens.Where(mk => mk.MatKhau == txtPassword.Text).ToList().
                                                  Where(tk => tk.MaNV == txtAccount.Text).FirstOrDefault();

                var query = from nv in QLContext.NhanViens
                            where nv.MatKhau == txtPassword.Text && nv.MaNV == txtAccount.Text
                            select nv;

                if (query != null && loginInfo!=null && loginAC!=null)
                {

                    this.Hide();
                    main1.showItem();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmHeThong_DangNhap_Load(object sender, EventArgs e)
        {

            var queryNhanVien = from nv in QLContext.NhanViens select nv;
            foreach (var item in queryNhanVien)
            {
                txtAccount.Text = item.MaNV.ToString();
                txtPassword.Text = item.MatKhau.ToString();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}