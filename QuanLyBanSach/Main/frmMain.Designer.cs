
namespace QuanLyBanSach
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Main = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnTL = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnAuthor = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnBook = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnPublisher = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnBookSold = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnBills = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDeliBill = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCTHD = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCTPG = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDSHD = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDSPG = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.riboSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.riboManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.riboCustomer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.riboStatistics = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.riboSales = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.ExpandCollapseItem.Id = 0;
            this.Main.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Main.ExpandCollapseItem,
            this.Main.SearchEditItem,
            this.barbtnLogin,
            this.barbtnLogout,
            this.barbtnKhachHang,
            this.barButtonItem1,
            this.barbtnStaff,
            this.barbtnCustomer,
            this.barbtnTL,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barbtnAuthor,
            this.barbtnBook,
            this.barbtnPublisher,
            this.barbtnBookSold,
            this.barbtnBills,
            this.barbtnDeliBill,
            this.barbtnCTHD,
            this.barbtnCTPG,
            this.barbtnDSHD,
            this.barbtnDSPG,
            this.btnDoiMK});
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main.MaxItemId = 33;
            this.Main.Name = "Main";
            this.Main.OptionsMenuMinWidth = 495;
            this.Main.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonSystem,
            this.riboManage,
            this.riboSales});
            this.Main.Size = new System.Drawing.Size(846, 158);
            // 
            // barbtnLogin
            // 
            this.barbtnLogin.Caption = "Đăng nhập";
            this.barbtnLogin.Id = 1;
            this.barbtnLogin.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.enter;
            this.barbtnLogin.Name = "barbtnLogin";
            this.barbtnLogin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLogin_ItemClick);
            // 
            // barbtnLogout
            // 
            this.barbtnLogout.Caption = "Đăng xuất";
            this.barbtnLogout.Id = 8;
            this.barbtnLogout.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.logout;
            this.barbtnLogout.Name = "barbtnLogout";
            this.barbtnLogout.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLogout_ItemClick);
            // 
            // barbtnKhachHang
            // 
            this.barbtnKhachHang.AccessibleName = "";
            this.barbtnKhachHang.Caption = "Khách hàng";
            this.barbtnKhachHang.Id = 9;
            this.barbtnKhachHang.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.edit1;
            this.barbtnKhachHang.Name = "barbtnKhachHang";
            this.barbtnKhachHang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barbtnStaff
            // 
            this.barbtnStaff.Caption = "Nhân viên";
            this.barbtnStaff.Id = 11;
            this.barbtnStaff.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.technical_support;
            this.barbtnStaff.Name = "barbtnStaff";
            this.barbtnStaff.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnStaff_ItemClick);
            // 
            // barbtnCustomer
            // 
            this.barbtnCustomer.Caption = "Khách hàng";
            this.barbtnCustomer.Id = 12;
            this.barbtnCustomer.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.customer__1_;
            this.barbtnCustomer.Name = "barbtnCustomer";
            this.barbtnCustomer.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCustomer_ItemClick);
            // 
            // barbtnTL
            // 
            this.barbtnTL.Caption = "Thể loại";
            this.barbtnTL.Id = 13;
            this.barbtnTL.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.list;
            this.barbtnTL.Name = "barbtnTL";
            this.barbtnTL.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnTL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnTL_ItemClick_1);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 15;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 16;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barbtnAuthor
            // 
            this.barbtnAuthor.Caption = "Tác giả";
            this.barbtnAuthor.Id = 17;
            this.barbtnAuthor.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.writer;
            this.barbtnAuthor.Name = "barbtnAuthor";
            this.barbtnAuthor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnAuthor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnAuthor_ItemClick);
            // 
            // barbtnBook
            // 
            this.barbtnBook.Caption = "Sách";
            this.barbtnBook.Id = 19;
            this.barbtnBook.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.books3;
            this.barbtnBook.Name = "barbtnBook";
            this.barbtnBook.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnBook_ItemClick);
            // 
            // barbtnPublisher
            // 
            this.barbtnPublisher.Caption = "Nhà xuất bản";
            this.barbtnPublisher.Id = 20;
            this.barbtnPublisher.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.publisher;
            this.barbtnPublisher.Name = "barbtnPublisher";
            this.barbtnPublisher.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnPublisher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnPublisher_ItemClick);
            // 
            // barbtnBookSold
            // 
            this.barbtnBookSold.Caption = "Sách bán được";
            this.barbtnBookSold.Id = 23;
            this.barbtnBookSold.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnBookSold.ImageOptions.Image")));
            this.barbtnBookSold.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnBookSold.ImageOptions.LargeImage")));
            this.barbtnBookSold.Name = "barbtnBookSold";
            this.barbtnBookSold.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnBookSold.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnBookSold_ItemClick);
            // 
            // barbtnBills
            // 
            this.barbtnBills.Caption = "Lập hoá đơn";
            this.barbtnBills.Id = 26;
            this.barbtnBills.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.invoice;
            this.barbtnBills.Name = "barbtnBills";
            this.barbtnBills.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnBills.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnBills_ItemClick);
            // 
            // barbtnDeliBill
            // 
            this.barbtnDeliBill.Caption = "Lập phiếu giao";
            this.barbtnDeliBill.Id = 27;
            this.barbtnDeliBill.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.delivery_truck;
            this.barbtnDeliBill.Name = "barbtnDeliBill";
            this.barbtnDeliBill.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnDeliBill.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnDeliBill_ItemClick);
            // 
            // barbtnCTHD
            // 
            this.barbtnCTHD.Caption = "Chi tiết hoá đơn";
            this.barbtnCTHD.Id = 28;
            this.barbtnCTHD.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.details;
            this.barbtnCTHD.Name = "barbtnCTHD";
            this.barbtnCTHD.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnCTHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCTHD_ItemClick);
            // 
            // barbtnCTPG
            // 
            this.barbtnCTPG.Caption = "Chi tiết phiếu giao";
            this.barbtnCTPG.Id = 29;
            this.barbtnCTPG.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.detail;
            this.barbtnCTPG.Name = "barbtnCTPG";
            this.barbtnCTPG.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnCTPG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCTPG_ItemClick);
            // 
            // barbtnDSHD
            // 
            this.barbtnDSHD.Caption = "Danh sách hoá đơn";
            this.barbtnDSHD.Id = 30;
            this.barbtnDSHD.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.file;
            this.barbtnDSHD.Name = "barbtnDSHD";
            this.barbtnDSHD.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnDSHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnDSHD_ItemClick);
            // 
            // barbtnDSPG
            // 
            this.barbtnDSPG.Caption = "Danh sách phiếu giao";
            this.barbtnDSPG.Id = 31;
            this.barbtnDSPG.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.bill1;
            this.barbtnDSPG.Name = "barbtnDSPG";
            this.barbtnDSPG.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barbtnDSPG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnDSPG_ItemClick);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Id = 32;
            this.btnDoiMK.ImageOptions.Image = global::QuanLyBanSach.Properties.Resources.password;
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMK_ItemClick);
            // 
            // ribbonSystem
            // 
            this.ribbonSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.riboSystem});
            this.ribbonSystem.Name = "ribbonSystem";
            this.ribbonSystem.Text = "Hệ thống";
            // 
            // riboSystem
            // 
            this.riboSystem.ItemLinks.Add(this.barbtnLogin);
            this.riboSystem.ItemLinks.Add(this.barbtnLogout);
            this.riboSystem.ItemLinks.Add(this.btnDoiMK);
            this.riboSystem.Name = "riboSystem";
            this.riboSystem.Text = "Hệ thống";
            // 
            // riboManage
            // 
            this.riboManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.riboCustomer,
            this.ribbonPageGroup1,
            this.riboStatistics});
            this.riboManage.Name = "riboManage";
            this.riboManage.Text = "Quản lý";
            this.riboManage.Visible = false;
            // 
            // riboCustomer
            // 
            this.riboCustomer.ItemLinks.Add(this.barbtnStaff);
            this.riboCustomer.ItemLinks.Add(this.barbtnCustomer);
            this.riboCustomer.Name = "riboCustomer";
            this.riboCustomer.Text = "Thông tin chung";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnTL);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnAuthor);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnBook);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnPublisher);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thông tin";
            // 
            // riboStatistics
            // 
            this.riboStatistics.ItemLinks.Add(this.barbtnBookSold);
            this.riboStatistics.Name = "riboStatistics";
            this.riboStatistics.Text = "Thống kê số liệu";
            // 
            // riboSales
            // 
            this.riboSales.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup4});
            this.riboSales.Name = "riboSales";
            this.riboSales.Text = "Bán hàng";
            this.riboSales.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnBills);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnDeliBill);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barbtnDSHD);
            this.ribbonPageGroup5.ItemLinks.Add(this.barbtnDSPG);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Danh sách ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnCTHD);
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnCTPG);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Chi tiết";
            // 
            // pnlMain
            // 
            this.pnlMain.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 158);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(846, 498);
            this.pnlMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 656);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.Main);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Ribbon = this.Main;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl Main;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonSystem;
        private DevExpress.XtraBars.BarButtonItem barbtnLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup riboSystem;
        private DevExpress.XtraBars.BarButtonItem barbtnLogout;
        private DevExpress.XtraBars.BarButtonItem barbtnKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage riboManage;
        private DevExpress.XtraBars.Ribbon.RibbonPage riboSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barbtnStaff;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup riboCustomer;
        private DevExpress.XtraBars.BarButtonItem barbtnCustomer;
        private DevExpress.XtraBars.BarButtonItem barbtnTL;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barbtnAuthor;
        private DevExpress.XtraBars.BarButtonItem barbtnBook;
        private DevExpress.XtraBars.BarButtonItem barbtnPublisher;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup riboStatistics;
        private DevExpress.XtraBars.BarButtonItem barbtnBookSold;
        private DevExpress.XtraBars.BarButtonItem barbtnBills;
        private DevExpress.XtraBars.BarButtonItem barbtnDeliBill;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barbtnCTHD;
        private DevExpress.XtraBars.BarButtonItem barbtnCTPG;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barbtnDSHD;
        private DevExpress.XtraBars.BarButtonItem barbtnDSPG;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
    }
}