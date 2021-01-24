
namespace QuanLyBanSach
{
    partial class frmDanhSach_DSHD
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
            this.gridCtrlDSHD = new DevExpress.XtraGrid.GridControl();
            this.gridviewDSHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNgayLapHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTongHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGoToCTHD = new System.Windows.Forms.Button();
            this.btnDelHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrlDSHD
            // 
            this.gridCtrlDSHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridCtrlDSHD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlDSHD.Location = new System.Drawing.Point(300, 158);
            this.gridCtrlDSHD.MainView = this.gridviewDSHD;
            this.gridCtrlDSHD.Margin = new System.Windows.Forms.Padding(2);
            this.gridCtrlDSHD.Name = "gridCtrlDSHD";
            this.gridCtrlDSHD.Size = new System.Drawing.Size(1271, 419);
            this.gridCtrlDSHD.TabIndex = 1;
            this.gridCtrlDSHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewDSHD});
            // 
            // gridviewDSHD
            // 
            this.gridviewDSHD.ColumnPanelRowHeight = 0;
            this.gridviewDSHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaHD,
            this.cMaKH,
            this.cNgayLapHD,
            this.cTongHD});
            this.gridviewDSHD.DetailHeight = 240;
            this.gridviewDSHD.FooterPanelHeight = 0;
            this.gridviewDSHD.GridControl = this.gridCtrlDSHD;
            this.gridviewDSHD.GroupRowHeight = 0;
            this.gridviewDSHD.LevelIndent = 0;
            this.gridviewDSHD.Name = "gridviewDSHD";
            this.gridviewDSHD.PreviewIndent = 0;
            this.gridviewDSHD.RowHeight = 0;
            this.gridviewDSHD.ViewCaptionHeight = 0;
            // 
            // cMaHD
            // 
            this.cMaHD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMaHD.AppearanceCell.Options.UseFont = true;
            this.cMaHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMaHD.AppearanceHeader.Options.UseFont = true;
            this.cMaHD.Caption = "Mã hoá đơn";
            this.cMaHD.FieldName = "MaHD";
            this.cMaHD.Name = "cMaHD";
            this.cMaHD.Visible = true;
            this.cMaHD.VisibleIndex = 0;
            this.cMaHD.Width = 50;
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
            // cNgayLapHD
            // 
            this.cNgayLapHD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNgayLapHD.AppearanceCell.Options.UseFont = true;
            this.cNgayLapHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNgayLapHD.AppearanceHeader.Options.UseFont = true;
            this.cNgayLapHD.Caption = "Ngày lập hoá đơn";
            this.cNgayLapHD.FieldName = "NgayLapHD";
            this.cNgayLapHD.Name = "cNgayLapHD";
            this.cNgayLapHD.Visible = true;
            this.cNgayLapHD.VisibleIndex = 2;
            this.cNgayLapHD.Width = 50;
            // 
            // cTongHD
            // 
            this.cTongHD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTongHD.AppearanceCell.Options.UseFont = true;
            this.cTongHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTongHD.AppearanceHeader.Options.UseFont = true;
            this.cTongHD.Caption = "Tổng hoá đơn";
            this.cTongHD.FieldName = "TongHD";
            this.cTongHD.Name = "cTongHD";
            this.cTongHD.Visible = true;
            this.cTongHD.VisibleIndex = 3;
            this.cTongHD.Width = 50;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(768, 73);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(324, 35);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // btnGoToCTHD
            // 
            this.btnGoToCTHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoToCTHD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToCTHD.Location = new System.Drawing.Point(1248, 582);
            this.btnGoToCTHD.Name = "btnGoToCTHD";
            this.btnGoToCTHD.Size = new System.Drawing.Size(324, 35);
            this.btnGoToCTHD.TabIndex = 6;
            this.btnGoToCTHD.Text = "Đi đến chi tiết hoá đơn";
            this.btnGoToCTHD.UseVisualStyleBackColor = true;
            this.btnGoToCTHD.Click += new System.EventHandler(this.btnGoToCTHD_Click);
            // 
            // btnDelHD
            // 
            this.btnDelHD.Location = new System.Drawing.Point(1576, 187);
            this.btnDelHD.Name = "btnDelHD";
            this.btnDelHD.Size = new System.Drawing.Size(75, 68);
            this.btnDelHD.TabIndex = 9;
            this.btnDelHD.Text = "Xoá hoá đơn";
            this.btnDelHD.UseVisualStyleBackColor = true;
            this.btnDelHD.Click += new System.EventHandler(this.btnDelHD_Click_1);
            // 
            // frmDanhSach_DSHD
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 955);
            this.Controls.Add(this.btnDelHD);
            this.Controls.Add(this.btnGoToCTHD);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridCtrlDSHD);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSach_DSHD";
            this.Text = "frmDanhSach_DSHD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSach_DSHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridCtrlDSHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewDSHD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn cMaHD;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn cNgayLapHD;
        private DevExpress.XtraGrid.Columns.GridColumn cTongHD;
        private System.Windows.Forms.Button btnGoToCTHD;
        private System.Windows.Forms.Button btnDelHD;
    }
}