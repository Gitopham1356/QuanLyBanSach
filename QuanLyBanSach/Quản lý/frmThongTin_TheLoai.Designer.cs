﻿
namespace QuanLyBanSach.Quản_lý
{
    partial class frmThongTin_TheLoai
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteUs = new System.Windows.Forms.Button();
            this.gridconTheLoaiInfo = new DevExpress.XtraGrid.GridControl();
            this.gridvieTheLoaiInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNameTL = new System.Windows.Forms.TextBox();
            this.txtTLID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridconTheLoaiInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvieTheLoaiInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Image = global::QuanLyBanSach.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(385, 302);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 45);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = global::QuanLyBanSach.Properties.Resources.add_friend1;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(34, 300);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 45);
            this.btnRegister.TabIndex = 3;
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
            this.btnUpdate.Location = new System.Drawing.Point(151, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 45);
            this.btnUpdate.TabIndex = 4;
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
            this.btnDeleteUs.Location = new System.Drawing.Point(290, 300);
            this.btnDeleteUs.Name = "btnDeleteUs";
            this.btnDeleteUs.Size = new System.Drawing.Size(78, 45);
            this.btnDeleteUs.TabIndex = 5;
            this.btnDeleteUs.Text = "Xoá";
            this.btnDeleteUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUs.UseVisualStyleBackColor = true;
            this.btnDeleteUs.Click += new System.EventHandler(this.btnDeleteUs_Click);
            // 
            // gridconTheLoaiInfo
            // 
            this.gridconTheLoaiInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridconTheLoaiInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridconTheLoaiInfo.Location = new System.Drawing.Point(2, 112);
            this.gridconTheLoaiInfo.MainView = this.gridvieTheLoaiInfo;
            this.gridconTheLoaiInfo.Name = "gridconTheLoaiInfo";
            this.gridconTheLoaiInfo.Size = new System.Drawing.Size(1386, 395);
            this.gridconTheLoaiInfo.TabIndex = 12;
            this.gridconTheLoaiInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvieTheLoaiInfo});
            this.gridconTheLoaiInfo.Click += new System.EventHandler(this.gridconTheLoaiInfo_Click);
            // 
            // gridvieTheLoaiInfo
            // 
            this.gridvieTheLoaiInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaTL,
            this.cTenTL});
            this.gridvieTheLoaiInfo.GridControl = this.gridconTheLoaiInfo;
            this.gridvieTheLoaiInfo.IndicatorWidth = 30;
            this.gridvieTheLoaiInfo.Name = "gridvieTheLoaiInfo";
            this.gridvieTheLoaiInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridvieTheLoaiInfo_CustomDrawRowIndicator);
            // 
            // cMaTL
            // 
            this.cMaTL.Caption = "Mã thể loại";
            this.cMaTL.FieldName = "MaTL";
            this.cMaTL.Name = "cMaTL";
            this.cMaTL.OptionsColumn.ReadOnly = true;
            this.cMaTL.Visible = true;
            this.cMaTL.VisibleIndex = 0;
            // 
            // cTenTL
            // 
            this.cTenTL.Caption = "Tên Thể loại";
            this.cTenTL.FieldName = "TenTL";
            this.cTenTL.Name = "cTenTL";
            this.cTenTL.OptionsColumn.ReadOnly = true;
            this.cTenTL.Visible = true;
            this.cTenTL.VisibleIndex = 1;
            // 
            // txtNameTL
            // 
            this.txtNameTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameTL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTL.Location = new System.Drawing.Point(151, 185);
            this.txtNameTL.Name = "txtNameTL";
            this.txtNameTL.Size = new System.Drawing.Size(261, 27);
            this.txtNameTL.TabIndex = 2;
            // 
            // txtTLID
            // 
            this.txtTLID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTLID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTLID.Location = new System.Drawing.Point(151, 126);
            this.txtTLID.Name = "txtTLID";
            this.txtTLID.ReadOnly = true;
            this.txtTLID.Size = new System.Drawing.Size(261, 27);
            this.txtTLID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImage = global::QuanLyBanSach.Properties.Resources.account1;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnRegister);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDeleteUs);
            this.groupControl1.Controls.Add(this.txtNameTL);
            this.groupControl1.Controls.Add(this.txtTLID);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(1394, 111);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(469, 396);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Thông tin thể loại";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên thể loại";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thông Tin Thể Loại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmThongTin_TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 931);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridconTheLoaiInfo);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmThongTin_TheLoai";
            this.Text = "frmThongTin_TheLoai";
            this.Load += new System.EventHandler(this.frmThongTin_TheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridconTheLoaiInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvieTheLoaiInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteUs;
        private DevExpress.XtraGrid.GridControl gridconTheLoaiInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvieTheLoaiInfo;
        private DevExpress.XtraGrid.Columns.GridColumn cMaTL;
        private DevExpress.XtraGrid.Columns.GridColumn cTenTL;
        private System.Windows.Forms.TextBox txtNameTL;
        private System.Windows.Forms.TextBox txtTLID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}