using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using System.Threading;
using System.Data.SqlClient;



namespace QuanLyBanSach
{
    
    public partial class QuanLy : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public QuanLy()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

        }
        
        
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Xmas 2008 Blue";
        }
        public void QuanLy_Load(object sender, EventArgs e)
        {
            skins();
            
            
        }
        public void anhien()
        {
            barbtnDangXuat.Enabled = true;
          
        }
        public void visibleql()
        {
            riboQuanLy.Visible = true;
        }

        public void TabCreating(XtraTabControl TabControl , string Text, Form Form)
        {
            int Index = KiemTraTonTai(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTabPage = TabControl.TabPages[Index];
                TabControl.SelectedTabPage.Text = Text;
            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = Text };
                TabControl.TabPages.Add(TabPage);
                TabControl.SelectedTabPage = TabPage;

                Form.TopLevel = false;
                Form.Parent = TabPage;
                Form.Show();
                Form.Dock = DockStyle.Fill;
            }
        }
        public void tabclosing()
        {

        }
     

        static int KiemTraTonTai(XtraTabControl TabControlName, string TabName)
        {
            int temp = -1;
            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        private void xtratab_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl TabControl = (XtraTabControl)sender;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
        }

     

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm1 xtraForm1 = new XtraForm1(this);
            TabCreating(this.xtratab,"Đăng nhập",xtraForm1);
           
            
        }
       
    

        private void barbtnDangKi_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Thread thread = new Thread(new ThreadStart(ShowfrmDangKi)); //Tạo luồng mới
            //thread.Start(); //Khởi chạy luồng
            //this.Close(); //đóng Form hiện tại. (Form1)
            frmDangKi frmDangKi = new frmDangKi();
            TabCreating(this.xtratab, "Đăng kí", frmDangKi);
            
        }

    

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void barbtnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            TabCreating(this.xtratab, "Tra cứu", frmTimKiem);
        }

        private void barbtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel)
            {

            }
            else
            {
                XtraForm1 xtraForm1 = new XtraForm1();
                //this.Close();
                xtraForm1.Show();
            }
        }

        private void barbtnLapHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLapHoaDon frmLapHoaDon = new frmLapHoaDon();
            TabCreating(this.xtratab, "Lập hoá đơn", frmLapHoaDon);
        }

        private void barbtnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Chức năng này sẽ sớm được hoàn thiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        //Viết một hàm không trả về giá trị và không có đối số thực hiện việc hiển thị Form2
        //private void ShowfrmDangKi()
        //{
        //    frmDangKi f = new frmDangKi();
        //    f.ShowDialog();
        //}
        ////Công việc tiếp theo là viết code cho sự kiện Button_Click


    }
}