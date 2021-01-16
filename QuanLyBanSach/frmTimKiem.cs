using System;

namespace QuanLyBanSach
{
    public partial class frmTimKiem : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            cmbList.SelectedIndex = 0;
        }
    }
}