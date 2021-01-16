using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmDangKi : DevExpress.XtraEditors.XtraForm 
    {
        frmMain frmMain1;
        QLBanSachDataContext QLContext = new QLBanSachDataContext();

        //constructor
        public frmDangKi()
        {
            InitializeComponent();
        }

        public frmDangKi(frmMain main)
        {
            InitializeComponent();
            frmMain1 = main;
        }

        
        //code
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang khachH = new KhachHang();
                if (txtKHID.Text == "" || txtNameKH.Text == "" || txtDoB.Text == "" || txtAddress.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy dủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else if (txtSDT.Text.Length != 10) { 
                    
                  MessageBox.Show("SDT phải có 10 số.");

                }
                else 
                {
                    
                    khachH.MaKH = txtKHID.Text;
                    khachH.TenKH = txtNameKH.Text;
                    khachH.NgaySinhKH = DateTime.Parse(txtDoB.Text).Date;
                       
                    khachH.DiaChiKH = txtAddress.Text;
                    khachH.SdtKH = txtSDT.Text;
                    khachH.EmailTG = txtEmail.Text;

                    var kh = QLContext.KhachHangs.FirstOrDefault(k => k.MaKH == txtKHID.Text);
                    if (kh == null)
                    {
                        QLContext.KhachHangs.InsertOnSubmit(khachH);
                        QLContext.SubmitChanges();
                        MessageBox.Show("Đăng kí tài khoản khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      //  frmMain1.showFrm();

                    }

                }
            }
            catch
            {
                MessageBox.Show("Ngày sinh Kh phải đúng định dạng( d/m/y)");
            }
        }


     }

       
 }
