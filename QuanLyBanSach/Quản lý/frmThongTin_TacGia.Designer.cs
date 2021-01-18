
namespace QuanLyBanSach.Quản_lý
{
    partial class frmThongTin_TacGia
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
            this.lbTGEmail = new System.Windows.Forms.Label();
            this.lbTGSDT = new System.Windows.Forms.Label();
            this.lbTGDoB = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteUs = new System.Windows.Forms.Button();
            this.txtTGEmail = new System.Windows.Forms.TextBox();
            this.txtTGSDT = new System.Windows.Forms.TextBox();
            this.txtTGDoB = new System.Windows.Forms.TextBox();
            this.txtTGName = new System.Windows.Forms.TextBox();
            this.txtTGID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cEmailTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSdtTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNgaySinhTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridvieTGInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridconTGInfo = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridvieTGInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridconTGInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTGEmail
            // 
            this.lbTGEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTGEmail.AutoSize = true;
            this.lbTGEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGEmail.ForeColor = System.Drawing.Color.Red;
            this.lbTGEmail.Location = new System.Drawing.Point(200, 393);
            this.lbTGEmail.Name = "lbTGEmail";
            this.lbTGEmail.Size = new System.Drawing.Size(0, 13);
            this.lbTGEmail.TabIndex = 4;
            // 
            // lbTGSDT
            // 
            this.lbTGSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTGSDT.AutoSize = true;
            this.lbTGSDT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGSDT.ForeColor = System.Drawing.Color.Red;
            this.lbTGSDT.Location = new System.Drawing.Point(200, 334);
            this.lbTGSDT.Name = "lbTGSDT";
            this.lbTGSDT.Size = new System.Drawing.Size(0, 13);
            this.lbTGSDT.TabIndex = 4;
            // 
            // lbTGDoB
            // 
            this.lbTGDoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTGDoB.AutoSize = true;
            this.lbTGDoB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGDoB.ForeColor = System.Drawing.Color.Red;
            this.lbTGDoB.Location = new System.Drawing.Point(200, 275);
            this.lbTGDoB.Name = "lbTGDoB";
            this.lbTGDoB.Size = new System.Drawing.Size(0, 13);
            this.lbTGDoB.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Image = global::QuanLyBanSach.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(422, 501);
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
            this.btnRegister.Location = new System.Drawing.Point(71, 499);
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
            this.btnUpdate.Location = new System.Drawing.Point(188, 499);
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
            this.btnDeleteUs.Location = new System.Drawing.Point(327, 499);
            this.btnDeleteUs.Name = "btnDeleteUs";
            this.btnDeleteUs.Size = new System.Drawing.Size(78, 45);
            this.btnDeleteUs.TabIndex = 2;
            this.btnDeleteUs.Text = "Xoá";
            this.btnDeleteUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUs.UseVisualStyleBackColor = true;
            this.btnDeleteUs.Click += new System.EventHandler(this.btnDeleteUs_Click);
            // 
            // txtTGEmail
            // 
            this.txtTGEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTGEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGEmail.Location = new System.Drawing.Point(188, 356);
            this.txtTGEmail.Name = "txtTGEmail";
            this.txtTGEmail.Size = new System.Drawing.Size(261, 27);
            this.txtTGEmail.TabIndex = 1;
            // 
            // txtTGSDT
            // 
            this.txtTGSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTGSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGSDT.Location = new System.Drawing.Point(188, 297);
            this.txtTGSDT.Name = "txtTGSDT";
            this.txtTGSDT.Size = new System.Drawing.Size(261, 27);
            this.txtTGSDT.TabIndex = 1;
            this.txtTGSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTGSDT_KeyPress);
            // 
            // txtTGDoB
            // 
            this.txtTGDoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTGDoB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGDoB.Location = new System.Drawing.Point(188, 238);
            this.txtTGDoB.Name = "txtTGDoB";
            this.txtTGDoB.Size = new System.Drawing.Size(261, 27);
            this.txtTGDoB.TabIndex = 1;
            // 
            // txtTGName
            // 
            this.txtTGName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTGName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGName.Location = new System.Drawing.Point(188, 179);
            this.txtTGName.Name = "txtTGName";
            this.txtTGName.Size = new System.Drawing.Size(261, 27);
            this.txtTGName.TabIndex = 1;
            // 
            // txtTGID
            // 
            this.txtTGID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTGID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGID.Location = new System.Drawing.Point(188, 120);
            this.txtTGID.Name = "txtTGID";
            this.txtTGID.Size = new System.Drawing.Size(261, 27);
            this.txtTGID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 364);
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
            this.label5.Location = new System.Drawing.Point(143, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 241);
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
            this.label2.Location = new System.Drawing.Point(95, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tác giả";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tác giả";
            // 
            // cEmailTG
            // 
            this.cEmailTG.Caption = "Email";
            this.cEmailTG.FieldName = "EmailTG";
            this.cEmailTG.Name = "cEmailTG";
            this.cEmailTG.OptionsColumn.ReadOnly = true;
            this.cEmailTG.Visible = true;
            this.cEmailTG.VisibleIndex = 4;
            // 
            // cSdtTG
            // 
            this.cSdtTG.Caption = "Số điện thoại";
            this.cSdtTG.FieldName = "SdtTG";
            this.cSdtTG.Name = "cSdtTG";
            this.cSdtTG.OptionsColumn.ReadOnly = true;
            this.cSdtTG.Visible = true;
            this.cSdtTG.VisibleIndex = 3;
            // 
            // cNgaySinhTG
            // 
            this.cNgaySinhTG.Caption = "Ngày sinh";
            this.cNgaySinhTG.FieldName = "NgaySinhTG";
            this.cNgaySinhTG.Name = "cNgaySinhTG";
            this.cNgaySinhTG.OptionsColumn.ReadOnly = true;
            this.cNgaySinhTG.Visible = true;
            this.cNgaySinhTG.VisibleIndex = 2;
            // 
            // cTenTG
            // 
            this.cTenTG.Caption = "Tên tác giả";
            this.cTenTG.FieldName = "TenTG";
            this.cTenTG.Name = "cTenTG";
            this.cTenTG.OptionsColumn.ReadOnly = true;
            this.cTenTG.Visible = true;
            this.cTenTG.VisibleIndex = 1;
            // 
            // cMaTG
            // 
            this.cMaTG.Caption = "Mã tác giả";
            this.cMaTG.FieldName = "MaTG";
            this.cMaTG.Name = "cMaTG";
            this.cMaTG.OptionsColumn.ReadOnly = true;
            this.cMaTG.Visible = true;
            this.cMaTG.VisibleIndex = 0;
            // 
            // gridvieTGInfo
            // 
            this.gridvieTGInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaTG,
            this.cTenTG,
            this.cNgaySinhTG,
            this.cSdtTG,
            this.cEmailTG});
            this.gridvieTGInfo.GridControl = this.gridconTGInfo;
            this.gridvieTGInfo.IndicatorWidth = 30;
            this.gridvieTGInfo.Name = "gridvieTGInfo";
            this.gridvieTGInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridvieTGInfo_CustomDrawRowIndicator);
            // 
            // gridconTGInfo
            // 
            this.gridconTGInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridconTGInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridconTGInfo.Location = new System.Drawing.Point(2, 40);
            this.gridconTGInfo.MainView = this.gridvieTGInfo;
            this.gridconTGInfo.Name = "gridconTGInfo";
            this.gridconTGInfo.Size = new System.Drawing.Size(1295, 673);
            this.gridconTGInfo.TabIndex = 12;
            this.gridconTGInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvieTGInfo});
            this.gridconTGInfo.Click += new System.EventHandler(this.gridconTGInfo_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImage = global::QuanLyBanSach.Properties.Resources.account1;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.groupControl1.Controls.Add(this.lbTGEmail);
            this.groupControl1.Controls.Add(this.lbTGSDT);
            this.groupControl1.Controls.Add(this.lbTGDoB);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnRegister);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDeleteUs);
            this.groupControl1.Controls.Add(this.txtTGEmail);
            this.groupControl1.Controls.Add(this.txtTGSDT);
            this.groupControl1.Controls.Add(this.txtTGDoB);
            this.groupControl1.Controls.Add(this.txtTGName);
            this.groupControl1.Controls.Add(this.txtTGID);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(1303, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(560, 673);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Thông tin tác giả";
            // 
            // frmThongTin_TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1864, 750);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridconTGInfo);
            this.Name = "frmThongTin_TacGia";
            this.Text = "frmThongTin_TacGia";
            this.Load += new System.EventHandler(this.frmThongTin_TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridvieTGInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridconTGInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTGEmail;
        private System.Windows.Forms.Label lbTGSDT;
        private System.Windows.Forms.Label lbTGDoB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteUs;
        private System.Windows.Forms.TextBox txtTGEmail;
        private System.Windows.Forms.TextBox txtTGSDT;
        private System.Windows.Forms.TextBox txtTGDoB;
        private System.Windows.Forms.TextBox txtTGName;
        private System.Windows.Forms.TextBox txtTGID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn cEmailTG;
        private DevExpress.XtraGrid.Columns.GridColumn cSdtTG;
        private DevExpress.XtraGrid.Columns.GridColumn cNgaySinhTG;
        private DevExpress.XtraGrid.Columns.GridColumn cTenTG;
        private DevExpress.XtraGrid.Columns.GridColumn cMaTG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvieTGInfo;
        private DevExpress.XtraGrid.GridControl gridconTGInfo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}