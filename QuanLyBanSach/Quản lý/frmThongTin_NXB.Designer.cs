
namespace QuanLyBanSach.Quản_lý
{
    partial class frmThongTin_NXB
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
            this.gridviewNXBInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDiaChiNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSdtNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridconNXBInfo = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbEmailNXB = new System.Windows.Forms.Label();
            this.lbSDTNXB = new System.Windows.Forms.Label();
            this.lbAdressKH = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteUs = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNXBInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridconNXBInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridviewNXBInfo
            // 
            this.gridviewNXBInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaNXB,
            this.cTenNXB,
            this.cDiaChiNXB,
            this.cSdtNXB,
            this.cEmail});
            this.gridviewNXBInfo.GridControl = this.gridconNXBInfo;
            this.gridviewNXBInfo.IndicatorWidth = 30;
            this.gridviewNXBInfo.Name = "gridviewNXBInfo";
            this.gridviewNXBInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridviewNXBInfo_CustomDrawRowIndicator);
            // 
            // cMaNXB
            // 
            this.cMaNXB.Caption = "Mã NXB";
            this.cMaNXB.FieldName = "MaNXB";
            this.cMaNXB.Name = "cMaNXB";
            this.cMaNXB.OptionsColumn.ReadOnly = true;
            this.cMaNXB.Visible = true;
            this.cMaNXB.VisibleIndex = 0;
            // 
            // cTenNXB
            // 
            this.cTenNXB.Caption = "Tên NXB";
            this.cTenNXB.FieldName = "TenNXB";
            this.cTenNXB.Name = "cTenNXB";
            this.cTenNXB.OptionsColumn.ReadOnly = true;
            this.cTenNXB.Visible = true;
            this.cTenNXB.VisibleIndex = 1;
            // 
            // cDiaChiNXB
            // 
            this.cDiaChiNXB.Caption = "Địa chỉ";
            this.cDiaChiNXB.FieldName = "DiaChiNXB";
            this.cDiaChiNXB.Name = "cDiaChiNXB";
            this.cDiaChiNXB.OptionsColumn.ReadOnly = true;
            this.cDiaChiNXB.Visible = true;
            this.cDiaChiNXB.VisibleIndex = 2;
            // 
            // cSdtNXB
            // 
            this.cSdtNXB.Caption = "Số điện thoại";
            this.cSdtNXB.FieldName = "SdtNXB";
            this.cSdtNXB.Name = "cSdtNXB";
            this.cSdtNXB.OptionsColumn.ReadOnly = true;
            this.cSdtNXB.Visible = true;
            this.cSdtNXB.VisibleIndex = 3;
            // 
            // cEmail
            // 
            this.cEmail.Caption = "Email";
            this.cEmail.FieldName = "EmailNXB";
            this.cEmail.Name = "cEmail";
            this.cEmail.OptionsColumn.ReadOnly = true;
            this.cEmail.Visible = true;
            this.cEmail.VisibleIndex = 4;
            // 
            // gridconNXBInfo
            // 
            this.gridconNXBInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridconNXBInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridconNXBInfo.Location = new System.Drawing.Point(0, 14);
            this.gridconNXBInfo.MainView = this.gridviewNXBInfo;
            this.gridconNXBInfo.Name = "gridconNXBInfo";
            this.gridconNXBInfo.Size = new System.Drawing.Size(1295, 411);
            this.gridconNXBInfo.TabIndex = 16;
            this.gridconNXBInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewNXBInfo});
            this.gridconNXBInfo.Click += new System.EventHandler(this.gridconNXBInfo_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Location = new System.Drawing.Point(14, 431);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1281, 488);
            this.panelControl1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(199, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(967, 235);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImage = global::QuanLyBanSach.Properties.Resources.publisher;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.groupControl1.Controls.Add(this.lbEmailNXB);
            this.groupControl1.Controls.Add(this.lbSDTNXB);
            this.groupControl1.Controls.Add(this.lbAdressKH);
            this.groupControl1.Controls.Add(this.lbTenKH);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnRegister);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDeleteUs);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.txtSDT);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.txtTenNXB);
            this.groupControl1.Controls.Add(this.txtMaNXB);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(1301, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(560, 592);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Thông tin nhà xuất bản";
            // 
            // lbEmailNXB
            // 
            this.lbEmailNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEmailNXB.AutoSize = true;
            this.lbEmailNXB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailNXB.ForeColor = System.Drawing.Color.Red;
            this.lbEmailNXB.Location = new System.Drawing.Point(209, 368);
            this.lbEmailNXB.Name = "lbEmailNXB";
            this.lbEmailNXB.Size = new System.Drawing.Size(0, 13);
            this.lbEmailNXB.TabIndex = 4;
            // 
            // lbSDTNXB
            // 
            this.lbSDTNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSDTNXB.AutoSize = true;
            this.lbSDTNXB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDTNXB.ForeColor = System.Drawing.Color.Red;
            this.lbSDTNXB.Location = new System.Drawing.Point(209, 312);
            this.lbSDTNXB.Name = "lbSDTNXB";
            this.lbSDTNXB.Size = new System.Drawing.Size(0, 13);
            this.lbSDTNXB.TabIndex = 4;
            // 
            // lbAdressKH
            // 
            this.lbAdressKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAdressKH.AutoSize = true;
            this.lbAdressKH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdressKH.ForeColor = System.Drawing.Color.Red;
            this.lbAdressKH.Location = new System.Drawing.Point(209, 266);
            this.lbAdressKH.Name = "lbAdressKH";
            this.lbAdressKH.Size = new System.Drawing.Size(0, 13);
            this.lbAdressKH.TabIndex = 4;
            // 
            // lbTenKH
            // 
            this.lbTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.ForeColor = System.Drawing.Color.Red;
            this.lbTenKH.Location = new System.Drawing.Point(209, 207);
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
            this.btnRegister.Image = global::QuanLyBanSach.Properties.Resources.plus;
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
            this.btnUpdate.Image = global::QuanLyBanSach.Properties.Resources.exchange;
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
            this.btnDeleteUs.Image = global::QuanLyBanSach.Properties.Resources.delete;
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
            this.txtEmail.Location = new System.Drawing.Point(197, 338);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 27);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(197, 282);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(261, 27);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(197, 227);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(261, 27);
            this.txtAddress.TabIndex = 1;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNXB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNXB.Location = new System.Drawing.Point(197, 170);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(261, 27);
            this.txtTenNXB.TabIndex = 1;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNXB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNXB.Location = new System.Drawing.Point(197, 115);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.ReadOnly = true;
            this.txtMaNXB.Size = new System.Drawing.Size(261, 27);
            this.txtMaNXB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 341);
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
            this.label5.Location = new System.Drawing.Point(152, 285);
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
            this.label4.Location = new System.Drawing.Point(134, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NXB";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThongTin_NXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 930);
            this.Controls.Add(this.gridconNXBInfo);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmThongTin_NXB";
            this.Text = "frmThongTin_NXB";
            this.Load += new System.EventHandler(this.frmThongTin_NXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNXBInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridconNXBInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmailNXB;
        private System.Windows.Forms.Label lbSDTNXB;
        private System.Windows.Forms.Label lbAdressKH;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteUs;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn cEmail;
        private DevExpress.XtraGrid.Columns.GridColumn cSdtNXB;
        private DevExpress.XtraGrid.Columns.GridColumn cDiaChiNXB;
        private DevExpress.XtraGrid.Columns.GridColumn cTenNXB;
        private DevExpress.XtraGrid.Columns.GridColumn cMaNXB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewNXBInfo;
        private DevExpress.XtraGrid.GridControl gridconNXBInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}