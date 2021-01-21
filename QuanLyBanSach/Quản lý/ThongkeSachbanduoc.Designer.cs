
namespace QuanLyBanSach.Quản_lý
{
    partial class ThongkeSachbanduoc
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyBanSach.DataSet1();
            this.report1TableAdapter = new QuanLyBanSach.DataSet1TableAdapters.Report1TableAdapter();
            this.dataSet11 = new QuanLyBanSach.DataSet1();
            this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.report1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.report1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanSach.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // report1BindingSource
            // 
            this.report1BindingSource.DataMember = "Report1";
            this.report1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report1TableAdapter
            // 
            this.report1TableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11BindingSource
            // 
            this.dataSet11BindingSource.DataSource = this.dataSet11;
            this.dataSet11BindingSource.Position = 0;
            // 
            // report1BindingSource1
            // 
            this.report1BindingSource1.DataMember = "Report1";
            this.report1BindingSource1.DataSource = this.dataSet11BindingSource;
            // 
            // report1BindingSource2
            // 
            this.report1BindingSource2.DataMember = "Report1";
            this.report1BindingSource2.DataSource = this.dataSet11BindingSource;
            // 
            // ThongkeSachbanduoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongkeSachbanduoc";
            this.Text = "ThongkeSachbanduoc";
            this.Load += new System.EventHandler(this.ThongkeSachbanduoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource report1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.Report1TableAdapter report1TableAdapter;
        private System.Windows.Forms.BindingSource dataSet11BindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource report1BindingSource1;
        private System.Windows.Forms.BindingSource report1BindingSource2;
    }
}