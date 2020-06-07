using DevExpress.XtraBars;

namespace LocalDev.View.Home
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.txtUser = new DevExpress.XtraBars.BarStaticItem();
            this.btnLanguageLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnRegistBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.btnScanBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.btnMachine = new DevExpress.XtraBars.BarButtonItem();
            this.btnMold = new DevExpress.XtraBars.BarButtonItem();
            this.btnShift = new DevExpress.XtraBars.BarButtonItem();
            this.btnPartNumber = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductionHistory = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportProductOK = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportProductNG = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnUsers,
            this.btnChangePassword,
            this.txtUser,
            this.btnLanguageLibrary,
            this.rgbiSkins,
            this.btnRegistBarcode,
            this.btnScanBarcode,
            this.btnMachine,
            this.btnMold,
            this.btnShift,
            this.btnPartNumber,
            this.btnProductionHistory,
            this.btnReportProductOK,
            this.btnReportProductNG,
            this.btnReport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 39;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.txtUser);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.rbpDanhMuc,
            this.rbpChucNang,
            this.rbpBaoCao});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(677, 143);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Quản lý người dùng";
            this.btnUsers.Id = 11;
            this.btnUsers.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.Users;
            this.btnUsers.LargeWidth = 100;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsers_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 12;
            this.btnChangePassword.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.ChangePassword;
            this.btnChangePassword.LargeWidth = 100;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // txtUser
            // 
            this.txtUser.Caption = "     ";
            this.txtUser.Id = 18;
            this.txtUser.Name = "txtUser";
            // 
            // btnLanguageLibrary
            // 
            this.btnLanguageLibrary.Caption = "Ngôn ngữ";
            this.btnLanguageLibrary.Id = 19;
            this.btnLanguageLibrary.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.Translate;
            this.btnLanguageLibrary.LargeWidth = 100;
            this.btnLanguageLibrary.Name = "btnLanguageLibrary";
            this.btnLanguageLibrary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLanguageLibrary_ItemClick);
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Id = 13;
            this.rgbiSkins.Name = "rgbiSkins";
            this.rgbiSkins.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiSkins_GalleryItemClick);
            // 
            // btnRegistBarcode
            // 
            this.btnRegistBarcode.Caption = "Đăng ký in mã vạch";
            this.btnRegistBarcode.Id = 26;
            this.btnRegistBarcode.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.RegistBarcode;
            this.btnRegistBarcode.LargeWidth = 100;
            this.btnRegistBarcode.Name = "btnRegistBarcode";
            this.btnRegistBarcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegistBarcode_ItemClick);
            // 
            // btnScanBarcode
            // 
            this.btnScanBarcode.Caption = "Quét mã vạch sản phẩm";
            this.btnScanBarcode.Id = 27;
            this.btnScanBarcode.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.ScanBarcode;
            this.btnScanBarcode.LargeWidth = 100;
            this.btnScanBarcode.Name = "btnScanBarcode";
            this.btnScanBarcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnScanBarcode_ItemClick);
            // 
            // btnMachine
            // 
            this.btnMachine.Caption = "Danh sách máy";
            this.btnMachine.Id = 31;
            this.btnMachine.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.Machine;
            this.btnMachine.LargeWidth = 100;
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMachine_ItemClick);
            // 
            // btnMold
            // 
            this.btnMold.Caption = "Danh sách khuôn";
            this.btnMold.Id = 32;
            this.btnMold.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.Mold;
            this.btnMold.LargeWidth = 115;
            this.btnMold.Name = "btnMold";
            this.btnMold.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMold_ItemClick);
            // 
            // btnShift
            // 
            this.btnShift.Caption = "Danh sách ca";
            this.btnShift.Id = 33;
            this.btnShift.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.Shift;
            this.btnShift.LargeWidth = 100;
            this.btnShift.Name = "btnShift";
            this.btnShift.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShift_ItemClick);
            // 
            // btnPartNumber
            // 
            this.btnPartNumber.Caption = "Quản lý PartNumber";
            this.btnPartNumber.Id = 34;
            this.btnPartNumber.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.PartNumber;
            this.btnPartNumber.LargeWidth = 100;
            this.btnPartNumber.Name = "btnPartNumber";
            this.btnPartNumber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPartNumber_ItemClick);
            // 
            // btnProductionHistory
            // 
            this.btnProductionHistory.Caption = "Lịch sử sản xuất";
            this.btnProductionHistory.Id = 35;
            this.btnProductionHistory.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.ProductionHistory;
            this.btnProductionHistory.LargeWidth = 100;
            this.btnProductionHistory.Name = "btnProductionHistory";
            this.btnProductionHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductionHistory_ItemClick);
            // 
            // btnReportProductOK
            // 
            this.btnReportProductOK.Caption = "Thống kê sản phẩm OK";
            this.btnReportProductOK.Id = 36;
            this.btnReportProductOK.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.ScanBarcodeOK;
            this.btnReportProductOK.LargeWidth = 100;
            this.btnReportProductOK.Name = "btnReportProductOK";
            this.btnReportProductOK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportProductOK_ItemClick);
            // 
            // btnReportProductNG
            // 
            this.btnReportProductNG.Caption = "Thống kê sản phẩm NG";
            this.btnReportProductNG.Id = 37;
            this.btnReportProductNG.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.ScanBarcodeNG;
            this.btnReportProductNG.LargeWidth = 100;
            this.btnReportProductNG.Name = "btnReportProductNG";
            this.btnReportProductNG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportProductNG_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.Caption = "Báo cáo tổng hợp";
            this.btnReport.Id = 38;
            this.btnReport.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.Report;
            this.btnReport.LargeWidth = 100;
            this.btnReport.Name = "btnReport";
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLanguageLibrary);
            this.ribbonPageGroup1.ItemLinks.Add(this.rgbiSkins);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbpDanhMuc
            // 
            this.rbpDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpDanhMuc.Name = "rbpDanhMuc";
            this.rbpDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPartNumber);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMachine);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnShift);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMold);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // rbpChucNang
            // 
            this.rbpChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpChucNang.Name = "rbpChucNang";
            this.rbpChucNang.Text = "Chức năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRegistBarcode);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnScanBarcode);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProductionHistory);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReportProductOK);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReportProductNG);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReport);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 379);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Chương trình chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem btnUsers;
        private BarButtonItem btnChangePassword;
        private BarStaticItem txtUser;
        private BarButtonItem btnLanguageLibrary;
        private RibbonGalleryBarItem rgbiSkins;
        private BarButtonItem btnRegistBarcode;
        private BarButtonItem btnScanBarcode;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem btnMachine;
        private BarButtonItem btnMold;
        private BarButtonItem btnShift;
        private BarButtonItem btnPartNumber;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private BarButtonItem btnProductionHistory;
        private BarButtonItem btnReportProductOK;
        private BarButtonItem btnReportProductNG;
        private BarButtonItem btnReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}

