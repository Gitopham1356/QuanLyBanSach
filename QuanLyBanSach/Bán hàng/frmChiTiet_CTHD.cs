﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmChiTiet_CTHD : DevExpress.XtraEditors.XtraForm
    {
        Database.QLBanSachDataContext context = new Database.QLBanSachDataContext();
        frmMain frm1;

        //Constructor
        public frmChiTiet_CTHD()
        {
            InitializeComponent();
        }
        frmDanhSach_DSHD frmDS;
        public frmChiTiet_CTHD(frmMain  frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        public frmChiTiet_CTHD(frmMain frm ,frmDanhSach_DSHD frmds)
        {
            InitializeComponent();
            frm1 = frm;
            frmDS = frmds;
        }
        //Load

        void loadData()
        {
            var cthd = from ct in context.CTHDs 
                       join s in context.Saches on ct.MaS equals s.MaS
                       select new
                       {
                           ct.MaHD,
                           s.MaS,
                           s.TenS,
                           ct.SoLuongBan,
                           ct.GiaBan
                       };
            gridConCTHD.DataSource = cthd;
        }

        private void frmChiTiet_CTHD_Load(object sender, EventArgs e)
        {
            loadData();
        }
        //Hàm xử lý
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }


        private void btnDeleteUs_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Việc xoá Thông tin có thể ảnh hưởng đến hoá đơn, bạn có chắc muốn xoá ", "Xoá Thông tin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
            {
            }
            else
            {
                var x = (gridviewCTHD.FocusedRowHandle, cMaS).ToString();
              
                var cthd = context.CTHDs.FirstOrDefault(k => k.MaS == txtMaS.Text );
                var soluongton = context.Saches.FirstOrDefault(s => s.MaS == txtMaS.Text);
                var thanhtien = context.HoaDons.FirstOrDefault(tt => tt.MaHD == txtMaHD.Text);

                if (cthd != null)
                {

                    context.CTHDs.DeleteOnSubmit(cthd);
                    
                    MessageBox.Show("Xóa Đối tượng thành công");
                    loadData();
                    
                    soluongton.SoLuongTon += cthd.SoLuongBan;
                    
                  
                    var tong = cthd.SoLuongBan * cthd.GiaBan;
                    thanhtien.TongHD -= tong;
                   
                   this.context.SubmitChanges();

                }
                else
                {

                    MessageBox.Show("Xoá thất bại");

                }
            }
        }

        private void gridConCTHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = gridviewCTHD.GetRowCellValue(gridviewCTHD.FocusedRowHandle, cMaHD).ToString();
            txtMaS.Text = gridviewCTHD.GetRowCellValue(gridviewCTHD.FocusedRowHandle, cMaS).ToString();
            txtTenS.Text = gridviewCTHD.GetRowCellValue(gridviewCTHD.FocusedRowHandle, cTenSach).ToString();
            var sL = gridviewCTHD.GetRowCellValue(gridviewCTHD.FocusedRowHandle, cSLB).ToString();
            txtSoLuong.Text = int.Parse(sL).ToString();
            txtDonGia.Text = gridviewCTHD.GetRowCellValue(gridviewCTHD.FocusedRowHandle, cGiaBan).ToString();

            
        }
    }
}