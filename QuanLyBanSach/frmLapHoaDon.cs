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
    public partial class frmLapHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmLapHoaDon()
        {
            InitializeComponent();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewHD.SelectedItems.Count > 0)
            {
                ListViewItem list = listviewHD.SelectedItems[0];
                txtMaSP.Text = list.Text;
                txtTenSP.Text = list.SubItems[2].Text;
                txtSoLuong.Text = list.SubItems[3].Text;
                txtDonGia.Text = list.SubItems[4].Text;
                txtThanhTien.Text = list.SubItems[5].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    
                    ListViewItem item = check(txtMaSP.Text.Trim());
                    if (item != null)
                    {
                        MessageBox.Show("Thông tin bị trùng lắp","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            item = new ListViewItem(txtMaSP.Text);

                            item.SubItems.Add((listviewHD.Items.Count + 1).ToString());
                            item.SubItems.Add(txtTenSP.Text);
                            float s = float.Parse(txtSoLuong.Text);
                            float t = float.Parse(txtDonGia.Text);
                            
                            item.SubItems.Add(s.ToString());
                            item.SubItems.Add(t.ToString());
                            item.SubItems.Add(txtThanhTien.Text);
                            listviewHD.Items.Add(item);
                            MessageBox.Show("Thêm thông tin thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //xoa
                            txtMaSP.Clear();
                            txtTenSP.Clear();
                            txtSoLuong.Clear();
                            txtDonGia.Clear();
                            txtThanhTien.Clear();
                            tongTien();
                        }
                        catch {
                            MessageBox.Show("Đơn giá/Số lượng phải là số.","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }


                }
               
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    ListViewItem item = check(txtMaSP.Text.Trim());
                    if (item != null)
                    {
                        item.SubItems[2].Text = txtTenSP.Text;
                        item.SubItems[3].Text = txtSoLuong.Text;
                        item.SubItems[4].Text = txtDonGia.Text;
                        MessageBox.Show("Câp nhật dữ liệu thành công");
                        tongTien();
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        ListViewItem check(string masp)
        {
            foreach (ListViewItem item in listviewHD.Items)
            {
                if (item.Text == masp)
                    return item;
            }
            return null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listviewHD.SelectedItems.Count > 0)
            {
                ListViewItem item = new ListViewItem(txtMaSP.Text);
                var result = MessageBox.Show("Bạn muốn xóa", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    listviewHD.SelectedItems[0].Remove();
                    txtMaSP.Text = ""; 
                    txtThanhTien.Text = "";
                    txtTenSP.Text = "";
                    txtDonGia.Text = "";
                    txtSoLuong.Text = "";
                    
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK);
                    tongTien();
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
            }
        }

        void Tinh_ThanhTien()
        {
            try
            {
                float s = float.Parse(txtDonGia.Text) * float.Parse(txtSoLuong.Text);
                s.ToString();

                txtThanhTien.Text = s.ToString();
            }
            catch
            {
               
            }
        }

       
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            
            if (txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
            }
            else
            {
                Tinh_ThanhTien();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
          
            if (txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
            }
            else
            {
                Tinh_ThanhTien();
            }
        }
        void tongTien()
        {
            float tong = 0;
            foreach (ListViewItem listViewItem in listviewHD.Items)
            {
                tong += float.Parse(listViewItem.SubItems[5].Text);
            }
            txtTongTien.Text = tong.ToString();
        }

    }

       

       
    
}