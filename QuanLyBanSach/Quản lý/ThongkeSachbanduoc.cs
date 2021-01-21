using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach.Quản_lý
{
    public partial class ThongkeSachbanduoc : Form
    {
        public ThongkeSachbanduoc()
        {
            InitializeComponent();
        }

        private void ThongkeSachbanduoc_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
