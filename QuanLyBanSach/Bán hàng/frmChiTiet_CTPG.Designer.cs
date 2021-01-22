
namespace QuanLyBanSach
{
    partial class frmChiTiet_CTPG
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
            this.btnDeleteUs = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.txtMaPG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cSLG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaPG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridviewCTPG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridconCTPG = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCTPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridconCTPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Image = global::QuanLyBanSach.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(362, 323);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteUs
            // 
            this.btnDeleteUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUs.Image = global::QuanLyBanSach.Properties.Resources.delivery;
            this.btnDeleteUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUs.Location = new System.Drawing.Point(151, 323);
            this.btnDeleteUs.Name = "btnDeleteUs";
            this.btnDeleteUs.Size = new System.Drawing.Size(158, 45);
            this.btnDeleteUs.TabIndex = 2;
            this.btnDeleteUs.Text = "Xoá phiếu giao";
            this.btnDeleteUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUs.UseVisualStyleBackColor = true;
            this.btnDeleteUs.Click += new System.EventHandler(this.btnDeleteUs_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(150, 225);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(261, 27);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTenS
            // 
            this.txtTenS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenS.Location = new System.Drawing.Point(150, 177);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(261, 27);
            this.txtTenS.TabIndex = 1;
            // 
            // txtMaS
            // 
            this.txtMaS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaS.Location = new System.Drawing.Point(151, 129);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(261, 27);
            this.txtMaS.TabIndex = 1;
            // 
            // txtMaPG
            // 
            this.txtMaPG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaPG.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPG.Location = new System.Drawing.Point(150, 81);
            this.txtMaPG.Name = "txtMaPG";
            this.txtMaPG.Size = new System.Drawing.Size(261, 27);
            this.txtMaPG.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng giao";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 180);
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
            this.label2.Location = new System.Drawing.Point(79, 132);
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
            this.label7.Location = new System.Drawing.Point(36, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã phiếu giao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "CHI TIẾT PHIẾU GIAO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cSLG
            // 
            this.cSLG.Caption = "Số lượng giao";
            this.cSLG.FieldName = "SoLuongGiao";
            this.cSLG.Name = "cSLG";
            this.cSLG.Visible = true;
            this.cSLG.VisibleIndex = 3;
            // 
            // cTenSach
            // 
            this.cTenSach.Caption = "Tên sách";
            this.cTenSach.FieldName = "TenS";
            this.cTenSach.Name = "cTenSach";
            this.cTenSach.Visible = true;
            this.cTenSach.VisibleIndex = 2;
            // 
            // cMaS
            // 
            this.cMaS.Caption = "Mã sách";
            this.cMaS.FieldName = "MaS";
            this.cMaS.Name = "cMaS";
            this.cMaS.Visible = true;
            this.cMaS.VisibleIndex = 1;
            // 
            // cMaPG
            // 
            this.cMaPG.Caption = "Mã phiếu giao";
            this.cMaPG.FieldName = "MaPG";
            this.cMaPG.Name = "cMaPG";
            this.cMaPG.Visible = true;
            this.cMaPG.VisibleIndex = 0;
            // 
            // gridviewCTPG
            // 
            this.gridviewCTPG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaPG,
            this.cMaS,
            this.cTenSach,
            this.cSLG});
            this.gridviewCTPG.GridControl = this.gridconCTPG;
            this.gridviewCTPG.Name = "gridviewCTPG";
            this.gridviewCTPG.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridviewCTPG_FocusedRowChanged);
            // 
            // gridconCTPG
            // 
            this.gridconCTPG.Location = new System.Drawing.Point(12, 130);
            this.gridconCTPG.MainView = this.gridviewCTPG;
            this.gridconCTPG.Name = "gridconCTPG";
            this.gridconCTPG.Size = new System.Drawing.Size(1380, 463);
            this.gridconCTPG.TabIndex = 13;
            this.gridconCTPG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewCTPG});
            this.gridconCTPG.Click += new System.EventHandler(this.gridconCTPG_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImage = global::QuanLyBanSach.Properties.Resources.detail1;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnDeleteUs);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.txtTenS);
            this.groupControl1.Controls.Add(this.txtMaS);
            this.groupControl1.Controls.Add(this.txtMaPG);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Location = new System.Drawing.Point(1398, 130);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 463);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Thông Tin Chi Tiết";
            // 
            // frmChiTiet_CTPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 932);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridconCTPG);
            this.Name = "frmChiTiet_CTPG";
            this.Text = "frmChiTiet_CTPG";
            this.Load += new System.EventHandler(this.frmChiTiet_CTPG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCTPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridconCTPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteUs;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.TextBox txtMaPG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn cSLG;
        private DevExpress.XtraGrid.Columns.GridColumn cTenSach;
        private DevExpress.XtraGrid.Columns.GridColumn cMaS;
        private DevExpress.XtraGrid.Columns.GridColumn cMaPG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewCTPG;
        private DevExpress.XtraGrid.GridControl gridconCTPG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}