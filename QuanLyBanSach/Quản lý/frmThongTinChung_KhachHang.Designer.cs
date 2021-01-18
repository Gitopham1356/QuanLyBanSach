
namespace QuanLyBanSach
{
    partial class frmThongTinChung_KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridctrlCustomerInfo = new DevExpress.XtraGrid.GridControl();
            this.griviewCusInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNgaySinhKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDiaChiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSdtKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cEmailTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbEmailKH = new System.Windows.Forms.Label();
            this.lbSDTKH = new System.Windows.Forms.Label();
            this.lbAdressKH = new System.Windows.Forms.Label();
            this.lbDoBKH = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteUs = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.txtKHID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlCustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griviewCusInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridctrlCustomerInfo
            // 
            this.gridctrlCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridctrlCustomerInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridctrlCustomerInfo.Location = new System.Drawing.Point(-2, 12);
            this.gridctrlCustomerInfo.MainView = this.griviewCusInfo;
            this.gridctrlCustomerInfo.Name = "gridctrlCustomerInfo";
            this.gridctrlCustomerInfo.Size = new System.Drawing.Size(1295, 411);
            this.gridctrlCustomerInfo.TabIndex = 10;
            this.gridctrlCustomerInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griviewCusInfo});
            this.gridctrlCustomerInfo.Click += new System.EventHandler(this.gridctrlCustomerInfo_Click);
            // 
            // griviewCusInfo
            // 
            this.griviewCusInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaKH,
            this.cTenKH,
            this.cNgaySinhKH,
            this.cDiaChiKH,
            this.cSdtKH,
            this.cEmailTG});
            this.griviewCusInfo.GridControl = this.gridctrlCustomerInfo;
            this.griviewCusInfo.Name = "griviewCusInfo";
            // 
            // cMaKH
            // 
            this.cMaKH.Caption = "Mã khách hàng";
            this.cMaKH.FieldName = "MaKH";
            this.cMaKH.Name = "cMaKH";
            this.cMaKH.OptionsColumn.ReadOnly = true;
            this.cMaKH.Visible = true;
            this.cMaKH.VisibleIndex = 0;
            // 
            // cTenKH
            // 
            this.cTenKH.Caption = "Tên khách hàng";
            this.cTenKH.FieldName = "TenKH";
            this.cTenKH.Name = "cTenKH";
            this.cTenKH.OptionsColumn.ReadOnly = true;
            this.cTenKH.Visible = true;
            this.cTenKH.VisibleIndex = 1;
            // 
            // cNgaySinhKH
            // 
            this.cNgaySinhKH.Caption = "Ngày sinh";
            this.cNgaySinhKH.FieldName = "NgaySinhKH";
            this.cNgaySinhKH.Name = "cNgaySinhKH";
            this.cNgaySinhKH.OptionsColumn.ReadOnly = true;
            this.cNgaySinhKH.Visible = true;
            this.cNgaySinhKH.VisibleIndex = 2;
            // 
            // cDiaChiKH
            // 
            this.cDiaChiKH.Caption = "Địa chỉ";
            this.cDiaChiKH.FieldName = "DiaChiKH";
            this.cDiaChiKH.Name = "cDiaChiKH";
            this.cDiaChiKH.OptionsColumn.ReadOnly = true;
            this.cDiaChiKH.Visible = true;
            this.cDiaChiKH.VisibleIndex = 3;
            // 
            // cSdtKH
            // 
            this.cSdtKH.Caption = "Số điện thoại";
            this.cSdtKH.FieldName = "SdtKH";
            this.cSdtKH.Name = "cSdtKH";
            this.cSdtKH.OptionsColumn.ReadOnly = true;
            this.cSdtKH.Visible = true;
            this.cSdtKH.VisibleIndex = 4;
            // 
            // cEmailTG
            // 
            this.cEmailTG.Caption = "Email";
            this.cEmailTG.FieldName = "EmailTG";
            this.cEmailTG.Name = "cEmailTG";
            this.cEmailTG.OptionsColumn.ReadOnly = true;
            this.cEmailTG.Visible = true;
            this.cEmailTG.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImage = global::QuanLyBanSach.Properties.Resources.account1;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.groupControl1.Controls.Add(this.lbEmailKH);
            this.groupControl1.Controls.Add(this.lbSDTKH);
            this.groupControl1.Controls.Add(this.lbAdressKH);
            this.groupControl1.Controls.Add(this.lbDoBKH);
            this.groupControl1.Controls.Add(this.lbTenKH);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnRegister);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDeleteUs);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.txtSDT);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.txtDoB);
            this.groupControl1.Controls.Add(this.txtNameKH);
            this.groupControl1.Controls.Add(this.txtKHID);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(1299, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(560, 592);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Thông tin Khách hàng";
            // 
            // lbEmailKH
            // 
            this.lbEmailKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEmailKH.AutoSize = true;
            this.lbEmailKH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailKH.ForeColor = System.Drawing.Color.Red;
            this.lbEmailKH.Location = new System.Drawing.Point(209, 450);
            this.lbEmailKH.Name = "lbEmailKH";
            this.lbEmailKH.Size = new System.Drawing.Size(0, 13);
            this.lbEmailKH.TabIndex = 4;
            // 
            // lbSDTKH
            // 
            this.lbSDTKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSDTKH.AutoSize = true;
            this.lbSDTKH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDTKH.ForeColor = System.Drawing.Color.Red;
            this.lbSDTKH.Location = new System.Drawing.Point(209, 388);
            this.lbSDTKH.Name = "lbSDTKH";
            this.lbSDTKH.Size = new System.Drawing.Size(0, 13);
            this.lbSDTKH.TabIndex = 4;
            // 
            // lbAdressKH
            // 
            this.lbAdressKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAdressKH.AutoSize = true;
            this.lbAdressKH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdressKH.ForeColor = System.Drawing.Color.Red;
            this.lbAdressKH.Location = new System.Drawing.Point(209, 329);
            this.lbAdressKH.Name = "lbAdressKH";
            this.lbAdressKH.Size = new System.Drawing.Size(0, 13);
            this.lbAdressKH.TabIndex = 4;
            // 
            // lbDoBKH
            // 
            this.lbDoBKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDoBKH.AutoSize = true;
            this.lbDoBKH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoBKH.ForeColor = System.Drawing.Color.Red;
            this.lbDoBKH.Location = new System.Drawing.Point(209, 270);
            this.lbDoBKH.Name = "lbDoBKH";
            this.lbDoBKH.Size = new System.Drawing.Size(0, 13);
            this.lbDoBKH.TabIndex = 4;
            // 
            // lbTenKH
            // 
            this.lbTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.ForeColor = System.Drawing.Color.Red;
            this.lbTenKH.Location = new System.Drawing.Point(209, 211);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(0, 13);
            this.lbTenKH.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Image = global::QuanLyBanSach.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(452, 484);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = global::QuanLyBanSach.Properties.Resources.add_friend1;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(101, 482);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 45);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Thêm";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::QuanLyBanSach.Properties.Resources.update_profile_user1;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(218, 482);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 45);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteUs
            // 
            this.btnDeleteUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUs.Image = global::QuanLyBanSach.Properties.Resources.delete_user;
            this.btnDeleteUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUs.Location = new System.Drawing.Point(357, 482);
            this.btnDeleteUs.Name = "btnDeleteUs";
            this.btnDeleteUs.Size = new System.Drawing.Size(78, 45);
            this.btnDeleteUs.TabIndex = 2;
            this.btnDeleteUs.Text = "Xoá";
            this.btnDeleteUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUs.UseVisualStyleBackColor = true;
            this.btnDeleteUs.Click += new System.EventHandler(this.btnDeleteUs_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(197, 410);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(197, 351);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(261, 27);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(197, 292);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(261, 27);
            this.txtAddress.TabIndex = 1;
            // 
            // txtDoB
            // 
            this.txtDoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDoB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoB.Location = new System.Drawing.Point(197, 233);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(261, 27);
            this.txtDoB.TabIndex = 1;
            this.txtDoB.TextChanged += new System.EventHandler(this.txtDoB_TextChanged);
            // 
            // txtNameKH
            // 
            this.txtNameKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameKH.Location = new System.Drawing.Point(197, 174);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(261, 27);
            this.txtNameKH.TabIndex = 1;
            // 
            // txtKHID
            // 
            this.txtKHID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKHID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHID.Location = new System.Drawing.Point(197, 115);
            this.txtKHID.Name = "txtKHID";
            this.txtKHID.ReadOnly = true;
            this.txtKHID.Size = new System.Drawing.Size(261, 27);
            this.txtKHID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Location = new System.Drawing.Point(12, 429);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1281, 488);
            this.panelControl1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(199, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(967, 235);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmThongTinChung_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 916);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridctrlCustomerInfo);
            this.Name = "frmThongTinChung_KhachHang";
            this.Text = "frmCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlCustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griviewCusInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridctrlCustomerInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView griviewCusInfo;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn cTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn cNgaySinhKH;
        private DevExpress.XtraGrid.Columns.GridColumn cDiaChiKH;
        private DevExpress.XtraGrid.Columns.GridColumn cSdtKH;
        private DevExpress.XtraGrid.Columns.GridColumn cEmailTG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteUs;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.TextBox txtKHID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbEmailKH;
        private System.Windows.Forms.Label lbSDTKH;
        private System.Windows.Forms.Label lbAdressKH;
        private System.Windows.Forms.Label lbDoBKH;
        private System.Windows.Forms.Label lbTenKH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}