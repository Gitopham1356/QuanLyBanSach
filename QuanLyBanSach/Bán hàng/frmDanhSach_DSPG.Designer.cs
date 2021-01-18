
namespace QuanLyBanSach
{
    partial class frmDanhSach_DSPG
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridCtrlDSPG = new DevExpress.XtraGrid.GridControl();
            this.gridviewDSPG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaPG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNgayLapPG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNgayGiaoDuKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGoToCTPG = new System.Windows.Forms.Button();
            this.btnDelPG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDSPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDSPG)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(761, 75);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(364, 35);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "DANH SÁCH PHIẾU GIAO";
            // 
            // gridCtrlDSPG
            // 
            this.gridCtrlDSPG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridCtrlDSPG.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlDSPG.Location = new System.Drawing.Point(300, 159);
            this.gridCtrlDSPG.MainView = this.gridviewDSPG;
            this.gridCtrlDSPG.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlDSPG.Name = "gridCtrlDSPG";
            this.gridCtrlDSPG.Size = new System.Drawing.Size(1271, 723);
            this.gridCtrlDSPG.TabIndex = 3;
            this.gridCtrlDSPG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewDSPG});
            // 
            // gridviewDSPG
            // 
            this.gridviewDSPG.ColumnPanelRowHeight = 0;
            this.gridviewDSPG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaPG,
            this.cMaKH,
            this.cNgayLapPG,
            this.cNgayGiaoDuKien});
            this.gridviewDSPG.DetailHeight = 240;
            this.gridviewDSPG.FooterPanelHeight = 0;
            this.gridviewDSPG.GridControl = this.gridCtrlDSPG;
            this.gridviewDSPG.GroupRowHeight = 0;
            this.gridviewDSPG.LevelIndent = 0;
            this.gridviewDSPG.Name = "gridviewDSPG";
            this.gridviewDSPG.PreviewIndent = 0;
            this.gridviewDSPG.RowHeight = 0;
            this.gridviewDSPG.ViewCaptionHeight = 0;
            // 
            // cMaPG
            // 
            this.cMaPG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMaPG.AppearanceCell.Options.UseFont = true;
            this.cMaPG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMaPG.AppearanceHeader.Options.UseFont = true;
            this.cMaPG.Caption = "Mã Phiếu Giao";
            this.cMaPG.FieldName = "MaPG";
            this.cMaPG.Name = "cMaPG";
            this.cMaPG.Visible = true;
            this.cMaPG.VisibleIndex = 0;
            this.cMaPG.Width = 50;
            // 
            // cMaKH
            // 
            this.cMaKH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMaKH.AppearanceCell.Options.UseFont = true;
            this.cMaKH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMaKH.AppearanceHeader.Options.UseFont = true;
            this.cMaKH.Caption = "Mã khách hàng";
            this.cMaKH.FieldName = "MaKH";
            this.cMaKH.Name = "cMaKH";
            this.cMaKH.Visible = true;
            this.cMaKH.VisibleIndex = 1;
            this.cMaKH.Width = 50;
            // 
            // cNgayLapPG
            // 
            this.cNgayLapPG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNgayLapPG.AppearanceCell.Options.UseFont = true;
            this.cNgayLapPG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNgayLapPG.AppearanceHeader.Options.UseFont = true;
            this.cNgayLapPG.Caption = "Ngày lập phiếu giao";
            this.cNgayLapPG.FieldName = "NgayLapPG";
            this.cNgayLapPG.Name = "cNgayLapPG";
            this.cNgayLapPG.Visible = true;
            this.cNgayLapPG.VisibleIndex = 2;
            this.cNgayLapPG.Width = 50;
            // 
            // cNgayGiaoDuKien
            // 
            this.cNgayGiaoDuKien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNgayGiaoDuKien.AppearanceCell.Options.UseFont = true;
            this.cNgayGiaoDuKien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNgayGiaoDuKien.AppearanceHeader.Options.UseFont = true;
            this.cNgayGiaoDuKien.Caption = "Ngày giao dự kiến";
            this.cNgayGiaoDuKien.FieldName = "NgayGiaoDuKien";
            this.cNgayGiaoDuKien.Name = "cNgayGiaoDuKien";
            this.cNgayGiaoDuKien.Visible = true;
            this.cNgayGiaoDuKien.VisibleIndex = 3;
            this.cNgayGiaoDuKien.Width = 50;
            // 
            // btnGoToCTPG
            // 
            this.btnGoToCTPG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoToCTPG.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToCTPG.Location = new System.Drawing.Point(1247, 887);
            this.btnGoToCTPG.Name = "btnGoToCTPG";
            this.btnGoToCTPG.Size = new System.Drawing.Size(324, 35);
            this.btnGoToCTPG.TabIndex = 5;
            this.btnGoToCTPG.Text = "Đi đến chi tiết phiếu giao";
            this.btnGoToCTPG.UseVisualStyleBackColor = true;
            this.btnGoToCTPG.Click += new System.EventHandler(this.btnGoToCTPG_Click);
            // 
            // btnDelPG
            // 
            this.btnDelPG.Location = new System.Drawing.Point(1576, 191);
            this.btnDelPG.Name = "btnDelPG";
            this.btnDelPG.Size = new System.Drawing.Size(75, 68);
            this.btnDelPG.TabIndex = 8;
            this.btnDelPG.Text = "Xoá phiếu giao";
            this.btnDelPG.UseVisualStyleBackColor = true;
            this.btnDelPG.Click += new System.EventHandler(this.btnDelPG_Click);
            // 
            // frmDanhSach_DSPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 958);
            this.Controls.Add(this.btnDelPG);
            this.Controls.Add(this.btnGoToCTPG);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridCtrlDSPG);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSach_DSPG";
            this.Text = "frmDanhSach_DSPG";
            this.Load += new System.EventHandler(this.frmDanhSach_DSPG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDSPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDSPG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridCtrlDSPG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewDSPG;
        private DevExpress.XtraGrid.Columns.GridColumn cMaPG;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn cNgayLapPG;
        private DevExpress.XtraGrid.Columns.GridColumn cNgayGiaoDuKien;
        private System.Windows.Forms.Button btnGoToCTPG;
        private System.Windows.Forms.Button btnDelPG;
    }
}