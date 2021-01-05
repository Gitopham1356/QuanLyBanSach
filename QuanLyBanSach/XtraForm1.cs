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
    
    public partial class XtraForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        QuanLy frmql;
        SqlConnection con;
        SqlCommand cmd;
        string query = @"Data Source=DESKTOP-291A4MD;Initial Catalog=QuanLyBanSach;Integrated Security=True";
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from account";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);

        }
        public XtraForm1() 
        {
            InitializeComponent();
        }
       
        public XtraForm1(QuanLy ql)
        {
            InitializeComponent();
            frmql = ql;
            
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(query);
            con.Open();
            cmd  = new SqlCommand("select * from NhanVien where MaNV='" + txtAccount.Text+"'and MatKhau='" + txtPassword.Text+"'",con);
           SqlDataReader sqlDataReader= cmd.ExecuteReader();
            if (sqlDataReader.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmql.anhien();
               // frmql.xtratab_CloseButtonClick(sender, e);
                con.Close();
                

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }

        }


    }
}