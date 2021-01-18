
namespace QuanLyBanSach
{
    partial class frmChiTiet_CTHD
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
            this.gridConCTHD = new DevExpress.XtraGrid.GridControl();
            this.gridviewCTHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteUs = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridConCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridConCTHD
            // 
            this.gridConCTHD.Location = new System.Drawing.Point(12, 98);
            this.gridConCTHD.MainView = this.gridviewCTHD;
            this.gridConCTHD.Name = "gridConCTHD";
            this.gridConCTHD.Size = new System.Drawing.Size(1370, 463);
            this.gridConCTHD.TabIndex = 0;
            this.gridConCTHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewCTHD});
            this.gridConCTHD.Click += new System.EventHandler(this.gridConCTHD_Click);
            // 
            // gridviewCTHD
            // 
            this.gridviewCTHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaHD,
            this.cMaS,
            this.cTenSach,
            this.cSLB,
            this.cGiaBan});
            this.gridviewCTHD.GridControl = this.gridConCTHD;
            this.gridviewCTHD.IndicatorWidth = 40;
            this.gridviewCTHD.Name = "gridviewCTHD";
            this.gridviewCTHD.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridviewCTHD_CustomDrawRowIndicator);
            // 
            // cMaHD
            // 
            this.cMaHD.Caption = "Mã hoá đơn";
            this.cMaHD.FieldName = "MaHD";
            this.cMaHD.Name = "cMaHD";
            this.cMaHD.Visible = true;
            this.cMaHD.VisibleIndex = 0;
            this.cMaHD.Width = 258;
            // 
            // cMaS
            // 
            this.cMaS.Caption = "Mã sách";
            this.cMaS.FieldName = "MaS";
            this.cMaS.Name = "cMaS";
            this.cMaS.Visible = true;
            this.cMaS.VisibleIndex = 1;
            this.cMaS.Width = 258;
            // 
            // cTenSach
            // 
            this.cTenSach.Caption = "Tên sách";
            this.cTenSach.FieldName = "TenS";
            this.cTenSach.Name = "cTenSach";
            this.cTenSach.Visible = true;
            this.cTenSach.VisibleIndex = 2;
            this.cTenSach.Width = 258;
            // 
            // cSLB
            // 
            this.cSLB.Caption = "Số lượng bán";
            this.cSLB.FieldName = "SoLuongBan";
            this.cSLB.Name = "cSLB";
            this.cSLB.Visible = true;
            this.cSLB.VisibleIndex = 3;
            this.cSLB.Width = 258;
            // 
            // cGiaBan
            // 
            this.cGiaBan.Caption = "Đơn giá";
            this.cGiaBan.FieldName = "GiaBan";
            this.cGiaBan.Name = "cGiaBan";
            this.cGiaBan.Visible = true;
            this.cGiaBan.VisibleIndex = 4;
            this.cGiaBan.Width = 260;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT HOÁ ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImage = global::QuanLyBanSach.Properties.Resources.details1;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnDeleteUs);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.txtTenS);
            this.groupControl1.Controls.Add(this.txtMaS);
            this.groupControl1.Controls.Add(this.txtMaHD);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Location = new System.Drawing.Point(1388, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 463);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Thông Tin Chi Tiết";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Image = global::QuanLyBanSach.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(333, 367);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteUs
            // 
            this.btnDeleteUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUs.Image = global::QuanLyBanSach.Properties.Resources.file__1_;
            this.btnDeleteUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUs.Location = new System.Drawing.Point(145, 367);
            this.btnDeleteUs.Name = "btnDeleteUs";
            this.btnDeleteUs.Size = new System.Drawing.Size(136, 45);
            this.btnDeleteUs.TabIndex = 2;
            this.btnDeleteUs.Text = "Xoá hoá đơn";
            this.btnDeleteUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUs.UseVisualStyleBackColor = true;
            this.btnDeleteUs.Click += new System.EventHandler(this.btnDeleteUs_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(145, 293);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(261, 27);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(144, 243);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(261, 27);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTenS
            // 
            this.txtTenS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenS.Location = new System.Drawing.Point(144, 193);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(261, 27);
            this.txtTenS.TabIndex = 1;
            // 
            // txtMaS
            // 
            this.txtMaS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaS.Location = new System.Drawing.Point(145, 143);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(261, 27);
            this.txtMaS.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(144, 93);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(261, 27);
            this.txtMaHD.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng bán";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã hoá đơn";
            // 
            // frmChiTiet_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1864, 904);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridConCTHD);
            this.Name = "frmChiTiet_CTHD";
            this.Text = "frmChiTiet_CTHD";
            this.Load += new System.EventHandler(this.frmChiTiet_CTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConCTHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewCTHD;
        private DevExpress.XtraGrid.Columns.GridColumn cMaHD;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn cMaS;
        private DevExpress.XtraGrid.Columns.GridColumn cSLB;
        private DevExpress.XtraGrid.Columns.GridColumn cGiaBan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteUs;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn cTenSach;
    }
}