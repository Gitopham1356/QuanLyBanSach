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
    public partial class frmKH : DevExpress.XtraEditors.XtraForm
    {

        frmMain frm1;
        QLBanSachDataContext context = new QLBanSachDataContext();
     
        void loadData()
        {
            var dskh = context.KhachHangs.ToList();
            gridctrlCustomerInfo.DataSource = dskh;
        }
        public frmKH()
        {
            InitializeComponent();
        }
        
        public frmKH(frmMain frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void frmKH_Load(object sender, EventArgs e)
        {
            
            loadData();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangKi frm = new frmDangKi();
            frm1.showFrm<frmDangKi>(frm);
            
        }

    
    }
}