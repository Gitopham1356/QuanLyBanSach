
namespace QuanLyBanSach.Report.Report_InHoaDon
{
    partial class FormRPInHoaDon
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
            this.reportViewerInHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerInHD
            // 
            this.reportViewerInHD.LocalReport.ReportEmbeddedResource = "QuanLyBanSach.Report.Report_InHoaDon.ReportInHoaDon.rdlc";
            this.reportViewerInHD.Location = new System.Drawing.Point(4, -1);
            this.reportViewerInHD.Name = "reportViewerInHD";
            this.reportViewerInHD.ServerReport.BearerToken = null;
            this.reportViewerInHD.Size = new System.Drawing.Size(794, 450);
            this.reportViewerInHD.TabIndex = 0;
            this.reportViewerInHD.Load += new System.EventHandler(this.reportViewerInHD_Load);
            // 
            // FormRPInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerInHD);
            this.Name = "FormRPInHoaDon";
            this.Text = "FormRPInHoaDon";
            this.Load += new System.EventHandler(this.FormRPInHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInHD;
    }
}