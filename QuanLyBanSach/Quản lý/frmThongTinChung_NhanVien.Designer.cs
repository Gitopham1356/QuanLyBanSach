
namespace QuanLyBanSach
{
    partial class frmThongTinChung_NhanVien
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
            this.griviewCusInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNgaySinhNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDiaChiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSdtNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cEmailNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridctrlCustomerInfo = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtAddressNV = new System.Windows.Forms.TextBox();
            this.txtDoBNV = new System.Windows.Forms.TextBox();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.txtNVID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.griviewCusInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlCustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // griviewCusInfo
            // 
            this.griviewCusInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaNV,
            this.cTenNV,
            this.cNgaySinhNV,
            this.cDiaChiNV,
            this.cSdtNV,
            this.cEmailNV});
            this.griviewCusInfo.GridControl = this.gridctrlCustomerInfo;
            this.griviewCusInfo.Name = "griviewCusInfo";
            // 
            // cMaNV
            // 
            this.cMaNV.Caption = "Mã nhân viên";
            this.cMaNV.FieldName = "MaNV";
            this.cMaNV.Name = "cMaNV";
            this.cMaNV.OptionsColumn.ReadOnly = true;
            this.cMaNV.Visible = true;
            this.cMaNV.VisibleIndex = 0;
            // 
            // cTenNV
            // 
            this.cTenNV.Caption = "Tên nhân viên";
            this.cTenNV.FieldName = "TenNV";
            this.cTenNV.Name = "cTenNV";
            this.cTenNV.OptionsColumn.ReadOnly = true;
            this.cTenNV.Visible = true;
            this.cTenNV.VisibleIndex = 1;
            // 
            // cNgaySinhNV
            // 
            this.cNgaySinhNV.Caption = "Ngày sinh";
            this.cNgaySinhNV.FieldName = "NgaySinhNV";
            this.cNgaySinhNV.Name = "cNgaySinhNV";
            this.cNgaySinhNV.OptionsColumn.ReadOnly = true;
            this.cNgaySinhNV.Visible = true;
            this.cNgaySinhNV.VisibleIndex = 2;
            // 
            // cDiaChiNV
            // 
            this.cDiaChiNV.Caption = "Địa chỉ";
            this.cDiaChiNV.FieldName = "DiaChiNV";
            this.cDiaChiNV.Name = "cDiaChiNV";
            this.cDiaChiNV.OptionsColumn.ReadOnly = true;
            this.cDiaChiNV.Visible = true;
            this.cDiaChiNV.VisibleIndex = 3;
            // 
            // cSdtNV
            // 
            this.cSdtNV.Caption = "Số điện thoại";
            this.cSdtNV.FieldName = "SdtNV";
            this.cSdtNV.Name = "cSdtNV";
            this.cSdtNV.OptionsColumn.ReadOnly = true;
            this.cSdtNV.Visible = true;
            this.cSdtNV.VisibleIndex = 4;
            // 
            // cEmailNV
            // 
            this.cEmailNV.Caption = "Email";
            this.cEmailNV.FieldName = "EmailNV";
            this.cEmailNV.Name = "cEmailNV";
            this.cEmailNV.OptionsColumn.ReadOnly = true;
            this.cEmailNV.Visible = true;
            this.cEmailNV.VisibleIndex = 5;
            // 
            // gridctrlCustomerInfo
            // 
            this.gridctrlCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridctrlCustomerInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridctrlCustomerInfo.Location = new System.Drawing.Point(3, 36);
            this.gridctrlCustomerInfo.MainView = this.griviewCusInfo;
            this.gridctrlCustomerInfo.Name = "gridctrlCustomerInfo";
            this.gridctrlCustomerInfo.Size = new System.Drawing.Size(1231, 744);
            this.gridctrlCustomerInfo.TabIndex = 12;
            this.gridctrlCustomerInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.griviewCusInfo});
            this.gridctrlCustomerInfo.Click += new System.EventHandler(this.gridctrlCustomerInfo_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImage = global::QuanLyBanSach.Properties.Resources.account1;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.groupControl1.Controls.Add(this.txtEmailNV);
            this.groupControl1.Controls.Add(this.txtSDTNV);
            this.groupControl1.Controls.Add(this.txtAddressNV);
            this.groupControl1.Controls.Add(this.txtDoBNV);
            this.groupControl1.Controls.Add(this.txtNameNV);
            this.groupControl1.Controls.Add(this.txtNVID);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(1240, 36);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(570, 744);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Thông tin nhân viên";
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNV.Location = new System.Drawing.Point(193, 396);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.ReadOnly = true;
            this.txtEmailNV.Size = new System.Drawing.Size(261, 27);
            this.txtEmailNV.TabIndex = 6;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDTNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNV.Location = new System.Drawing.Point(193, 337);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.ReadOnly = true;
            this.txtSDTNV.Size = new System.Drawing.Size(261, 27);
            this.txtSDTNV.TabIndex = 5;
            // 
            // txtAddressNV
            // 
            this.txtAddressNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddressNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressNV.Location = new System.Drawing.Point(193, 278);
            this.txtAddressNV.Name = "txtAddressNV";
            this.txtAddressNV.ReadOnly = true;
            this.txtAddressNV.Size = new System.Drawing.Size(261, 27);
            this.txtAddressNV.TabIndex = 4;
            // 
            // txtDoBNV
            // 
            this.txtDoBNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDoBNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoBNV.Location = new System.Drawing.Point(193, 219);
            this.txtDoBNV.Name = "txtDoBNV";
            this.txtDoBNV.ReadOnly = true;
            this.txtDoBNV.Size = new System.Drawing.Size(261, 27);
            this.txtDoBNV.TabIndex = 3;
            // 
            // txtNameNV
            // 
            this.txtNameNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameNV.Location = new System.Drawing.Point(193, 160);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.ReadOnly = true;
            this.txtNameNV.Size = new System.Drawing.Size(261, 27);
            this.txtNameNV.TabIndex = 2;
            // 
            // txtNVID
            // 
            this.txtNVID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNVID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVID.Location = new System.Drawing.Point(193, 101);
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.ReadOnly = true;
            this.txtNVID.Size = new System.Drawing.Size(261, 27);
            this.txtNVID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 399);
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
            this.label5.Location = new System.Drawing.Point(144, 345);
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
            this.label4.Location = new System.Drawing.Point(126, 281);
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
            this.label3.Location = new System.Drawing.Point(104, 222);
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
            this.label2.Location = new System.Drawing.Point(68, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // frmThongTinChung_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 825);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridctrlCustomerInfo);
            this.Name = "frmThongTinChung_NhanVien";
            this.Text = "frmNvInfo";
            this.Load += new System.EventHandler(this.frmThongTinChung_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griviewCusInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlCustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtAddressNV;
        private System.Windows.Forms.TextBox txtDoBNV;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.TextBox txtNVID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn cEmailNV;
        private DevExpress.XtraGrid.Columns.GridColumn cSdtNV;
        private DevExpress.XtraGrid.Columns.GridColumn cDiaChiNV;
        private DevExpress.XtraGrid.Columns.GridColumn cNgaySinhNV;
        private DevExpress.XtraGrid.Columns.GridColumn cTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn cMaNV;
        private DevExpress.XtraGrid.Views.Grid.GridView griviewCusInfo;
        private DevExpress.XtraGrid.GridControl gridctrlCustomerInfo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}