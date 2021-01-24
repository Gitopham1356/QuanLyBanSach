
namespace QuanLyBanSach
{
    partial class frmBanHang_LapPhieuGiao
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
            this.cmbTenS = new System.Windows.Forms.ComboBox();
            this.cmbMaS = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvTTSach = new System.Windows.Forms.DataGridView();
            this.MaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDSPG = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinChung = new System.Windows.Forms.GroupBox();
            this.lbNgayGiao = new System.Windows.Forms.Label();
            this.lbMaKh = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.datetimeNgayGiaoDK = new System.Windows.Forms.DateTimePicker();
            this.dtimepickNgayLapPG = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaPG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grbThongTinSP = new System.Windows.Forms.GroupBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbMaS = new System.Windows.Forms.Label();
            this.standardReportDesigner2 = new DevExpress.XtraReports.UserDesigner.Native.StandardReportDesigner();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSach)).BeginInit();
            this.grbThongTinChung.SuspendLayout();
            this.grbThongTinSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTenS
            // 
            this.cmbTenS.FormattingEnabled = true;
            this.cmbTenS.Location = new System.Drawing.Point(500, 40);
            this.cmbTenS.Name = "cmbTenS";
            this.cmbTenS.Size = new System.Drawing.Size(282, 21);
            this.cmbTenS.TabIndex = 17;
            // 
            // cmbMaS
            // 
            this.cmbMaS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMaS.FormattingEnabled = true;
            this.cmbMaS.Location = new System.Drawing.Point(134, 40);
            this.cmbMaS.Name = "cmbMaS";
            this.cmbMaS.Size = new System.Drawing.Size(184, 21);
            this.cmbMaS.TabIndex = 16;
            this.cmbMaS.TextChanged += new System.EventHandler(this.cmbMaS_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(500, 135);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(332, 135);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = " Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvTTSach
            // 
            this.dgvTTSach.AllowUserToAddRows = false;
            this.dgvTTSach.AllowUserToDeleteRows = false;
            this.dgvTTSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTTSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaS,
            this.tenSach,
            this.SoLuongGiao});
            this.dgvTTSach.Location = new System.Drawing.Point(234, 464);
            this.dgvTTSach.Name = "dgvTTSach";
            this.dgvTTSach.ReadOnly = true;
            this.dgvTTSach.Size = new System.Drawing.Size(1139, 305);
            this.dgvTTSach.TabIndex = 29;
            this.dgvTTSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTSach_CellClick);
            // 
            // MaS
            // 
            this.MaS.HeaderText = "Mã sách";
            this.MaS.Name = "MaS";
            this.MaS.ReadOnly = true;
            // 
            // tenSach
            // 
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.Name = "tenSach";
            this.tenSach.ReadOnly = true;
            // 
            // SoLuongGiao
            // 
            this.SoLuongGiao.HeaderText = "Số lượng";
            this.SoLuongGiao.Name = "SoLuongGiao";
            this.SoLuongGiao.ReadOnly = true;
            // 
            // btnDSPG
            // 
            this.btnDSPG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDSPG.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSPG.Location = new System.Drawing.Point(763, 810);
            this.btnDSPG.Name = "btnDSPG";
            this.btnDSPG.Size = new System.Drawing.Size(299, 33);
            this.btnDSPG.TabIndex = 28;
            this.btnDSPG.Text = "Chuyển đến danh sách phiếu giao";
            this.btnDSPG.UseVisualStyleBackColor = true;
            this.btnDSPG.Click += new System.EventHandler(this.btnDSPG_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuuHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.Location = new System.Drawing.Point(591, 810);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(131, 33);
            this.btnLuuHD.TabIndex = 27;
            this.btnLuuHD.Text = "Lưu phiếu giao";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuPG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thông tin sản phẩm";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(665, 135);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(828, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 18);
            this.label17.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lập Phiếu Giao";
            // 
            // grbThongTinChung
            // 
            this.grbThongTinChung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbThongTinChung.Controls.Add(this.lbNgayGiao);
            this.grbThongTinChung.Controls.Add(this.lbMaKh);
            this.grbThongTinChung.Controls.Add(this.btnRefresh);
            this.grbThongTinChung.Controls.Add(this.cmbMaKH);
            this.grbThongTinChung.Controls.Add(this.datetimeNgayGiaoDK);
            this.grbThongTinChung.Controls.Add(this.dtimepickNgayLapPG);
            this.grbThongTinChung.Controls.Add(this.label2);
            this.grbThongTinChung.Controls.Add(this.txtTenKH);
            this.grbThongTinChung.Controls.Add(this.txtMaPG);
            this.grbThongTinChung.Controls.Add(this.label6);
            this.grbThongTinChung.Controls.Add(this.label5);
            this.grbThongTinChung.Controls.Add(this.label9);
            this.grbThongTinChung.Controls.Add(this.label8);
            this.grbThongTinChung.Controls.Add(this.label4);
            this.grbThongTinChung.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinChung.Location = new System.Drawing.Point(309, 107);
            this.grbThongTinChung.Name = "grbThongTinChung";
            this.grbThongTinChung.Size = new System.Drawing.Size(992, 165);
            this.grbThongTinChung.TabIndex = 22;
            this.grbThongTinChung.TabStop = false;
            // 
            // lbNgayGiao
            // 
            this.lbNgayGiao.AutoSize = true;
            this.lbNgayGiao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGiao.ForeColor = System.Drawing.Color.Red;
            this.lbNgayGiao.Location = new System.Drawing.Point(179, 146);
            this.lbNgayGiao.Name = "lbNgayGiao";
            this.lbNgayGiao.Size = new System.Drawing.Size(0, 13);
            this.lbNgayGiao.TabIndex = 8;
            // 
            // lbMaKh
            // 
            this.lbMaKh.AutoSize = true;
            this.lbMaKh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKh.ForeColor = System.Drawing.Color.Red;
            this.lbMaKh.Location = new System.Drawing.Point(734, 59);
            this.lbMaKh.Name = "lbMaKh";
            this.lbMaKh.Size = new System.Drawing.Size(0, 13);
            this.lbMaKh.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::QuanLyBanSach.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(945, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 30);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.cmbMaKH.AllowDrop = true;
            this.cmbMaKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMaKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(723, 30);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(261, 26);
            this.cmbMaKH.TabIndex = 6;
            this.cmbMaKH.TextChanged += new System.EventHandler(this.cmbMaKH_TextChanged);
            // 
            // datetimeNgayGiaoDK
            // 
            this.datetimeNgayGiaoDK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datetimeNgayGiaoDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNgayGiaoDK.Location = new System.Drawing.Point(172, 118);
            this.datetimeNgayGiaoDK.Name = "datetimeNgayGiaoDK";
            this.datetimeNgayGiaoDK.Size = new System.Drawing.Size(187, 26);
            this.datetimeNgayGiaoDK.TabIndex = 1;
            this.datetimeNgayGiaoDK.ValueChanged += new System.EventHandler(this.datetimeNgayGiaoDK_ValueChanged);
            // 
            // dtimepickNgayLapPG
            // 
            this.dtimepickNgayLapPG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtimepickNgayLapPG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimepickNgayLapPG.Location = new System.Drawing.Point(172, 74);
            this.dtimepickNgayLapPG.Name = "dtimepickNgayLapPG";
            this.dtimepickNgayLapPG.Size = new System.Drawing.Size(187, 26);
            this.dtimepickNgayLapPG.TabIndex = 1;
            this.dtimepickNgayLapPG.ValueChanged += new System.EventHandler(this.dtimepickNgayLapPG_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin chung";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.Location = new System.Drawing.Point(728, 88);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(258, 26);
            this.txtTenKH.TabIndex = 5;
            // 
            // txtMaPG
            // 
            this.txtMaPG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaPG.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPG.Location = new System.Drawing.Point(172, 30);
            this.txtMaPG.Name = "txtMaPG";
            this.txtMaPG.ReadOnly = true;
            this.txtMaPG.Size = new System.Drawing.Size(187, 26);
            this.txtMaPG.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày giao dự kiến";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày lập";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(584, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(587, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã phiếu giao";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(370, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Tên sản sách";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.Location = new System.Drawing.Point(922, 41);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(154, 21);
            this.txtSoLuong.TabIndex = 11;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(828, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mã Sách";
            // 
            // grbThongTinSP
            // 
            this.grbThongTinSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbThongTinSP.Controls.Add(this.lbSoLuong);
            this.grbThongTinSP.Controls.Add(this.lbMaS);
            this.grbThongTinSP.Controls.Add(this.cmbTenS);
            this.grbThongTinSP.Controls.Add(this.cmbMaS);
            this.grbThongTinSP.Controls.Add(this.btnXoa);
            this.grbThongTinSP.Controls.Add(this.btnSua);
            this.grbThongTinSP.Controls.Add(this.btnThem);
            this.grbThongTinSP.Controls.Add(this.label3);
            this.grbThongTinSP.Controls.Add(this.label17);
            this.grbThongTinSP.Controls.Add(this.label15);
            this.grbThongTinSP.Controls.Add(this.txtSoLuong);
            this.grbThongTinSP.Controls.Add(this.label14);
            this.grbThongTinSP.Controls.Add(this.label12);
            this.grbThongTinSP.Location = new System.Drawing.Point(234, 294);
            this.grbThongTinSP.Name = "grbThongTinSP";
            this.grbThongTinSP.Size = new System.Drawing.Size(1139, 164);
            this.grbThongTinSP.TabIndex = 23;
            this.grbThongTinSP.TabStop = false;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lbSoLuong.Location = new System.Drawing.Point(931, 69);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(0, 13);
            this.lbSoLuong.TabIndex = 18;
            // 
            // lbMaS
            // 
            this.lbMaS.AutoSize = true;
            this.lbMaS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaS.ForeColor = System.Drawing.Color.Red;
            this.lbMaS.Location = new System.Drawing.Point(142, 64);
            this.lbMaS.Name = "lbMaS";
            this.lbMaS.Size = new System.Drawing.Size(0, 13);
            this.lbMaS.TabIndex = 8;
            // 
            // frmBanHang_LapPhieuGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 932);
            this.Controls.Add(this.dgvTTSach);
            this.Controls.Add(this.btnDSPG);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbThongTinChung);
            this.Controls.Add(this.grbThongTinSP);
            this.Name = "frmBanHang_LapPhieuGiao";
            this.Text = "frmBanHang_LapPhieuGiao";
            this.Load += new System.EventHandler(this.frmBanHang_LapPhieuGiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSach)).EndInit();
            this.grbThongTinChung.ResumeLayout(false);
            this.grbThongTinChung.PerformLayout();
            this.grbThongTinSP.ResumeLayout(false);
            this.grbThongTinSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTenS;
        private System.Windows.Forms.ComboBox cmbMaS;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTTSach;
        private System.Windows.Forms.Button btnDSPG;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTinChung;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.DateTimePicker datetimeNgayGiaoDK;
        private System.Windows.Forms.DateTimePicker dtimepickNgayLapPG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaPG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbThongTinSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongGiao;
        private System.Windows.Forms.Label lbMaKh;
        private System.Windows.Forms.Label lbNgayGiao;
        private System.Windows.Forms.Label lbMaS;
        private DevExpress.XtraReports.UserDesigner.Native.StandardReportDesigner standardReportDesigner2;
        private System.Windows.Forms.Label lbSoLuong;
    }
}