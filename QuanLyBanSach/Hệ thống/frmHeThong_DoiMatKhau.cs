using DevExpress.XtraEditors;
using QuanLyBanSach.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach.Hệ_thống
{
    public partial class frmHeThong_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        QLBanSachDataContext db = new QLBanSachDataContext();

        public frmHeThong_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {           
            Regex regexValiDatePassword = new Regex(@"(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}");
            var oldP = from old in db.NhanViens 
                       where old.MaNV == txtAccount.Text && old.MatKhau == txtOldPassword.Text
                       select old ;
            //txtAccount
            //txtPassword
            if (txtAccount.Text == "" ||
                txtOldPassword.Text == ""||
                txtNewPassword.Text == "" ||
                txtPasswordConfirm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }else if(oldP == null)
            {
                lbOldP.Text = "Sai Mật khẩu!";
            }
            else if (regexValiDatePassword.IsMatch(txtNewPassword.Text) == false)
            {
                lbNewP.Text="Mật khẩu cần ít nhất 8 chữ cái, bao gồm 1 chữ số và 1 ký tự đặc biệt";
            }
            else if(txtNewPassword.Text != txtPasswordConfirm.Text)
            {
                lbConfirm.Text = "Mật khẩu xác nhận không trùng khớp.";
            }
            else
            {
                try
                {
                    var queryNhanVien = from nv in db.NhanViens select nv;
                    foreach (var item in queryNhanVien)
                    {
                        item.MatKhau = txtPasswordConfirm.Text;
                    }
                   
                    db.SubmitChanges();
                    MessageBox.Show("Đổi mật khẩu thành công");

                    lbOldP.Text = "";
                    lbNewP.Text = "";
                    lbConfirm.Text = "";

                }
                catch 
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
        }

        private void frmHeThong_DoiMatKhau_Load(object sender, EventArgs e)
        {
            var queryNhanVien = from nv in db.NhanViens select nv;
            foreach (var item in queryNhanVien)
            {  
                txtAccount.Text = item.MaNV.ToString();
                
               
            }
          
        }


        //làm màu
        private void btnSOldP_MouseLeave(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = true;
        }

        private void btnSOldP_MouseEnter(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = false;
        }

        private void btnSNewP_MouseEnter(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false;
        }

        private void btnSNewP_MouseLeave(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
        }

        private void btnSConP_MouseEnter(object sender, EventArgs e)
        {
            txtPasswordConfirm.UseSystemPasswordChar = false;
        }

        private void btnSConP_MouseLeave(object sender, EventArgs e)
        {
            txtPasswordConfirm.UseSystemPasswordChar = false;
        }
    }
}