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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnPartNumber = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.btnScanBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.txtUser = new DevExpress.XtraBars.BarStaticItem();
            this.btnLanguageLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btn_USER_MANAGER = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CHANGE_USER_PASSWORD = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TMA_LIST = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnPartNumber,
            this.barButtonItem2,
            this.btnInBarcode,
            this.btnScanBarcode,
            this.txtUser,
            this.btnLanguageLibrary});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.txtUser);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.rbpChucNang,
            this.rbpBaoCao});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1096, 143);
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
            // btnPartNumber
            // 
            this.btnPartNumber.Caption = "Quản lý PartNumber";
            this.btnPartNumber.Id = 13;
            this.btnPartNumber.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.PartNuber;
            this.btnPartNumber.LargeWidth = 100;
            this.btnPartNumber.Name = "btnPartNumber";
            this.btnPartNumber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPartNumber_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnInBarcode
            // 
            this.btnInBarcode.Caption = "Đăng ký in mã vạch";
            this.btnInBarcode.Id = 16;
            this.btnInBarcode.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.PrintBarcode;
            this.btnInBarcode.LargeWidth = 100;
            this.btnInBarcode.Name = "btnInBarcode";
            // 
            // btnScanBarcode
            // 
            this.btnScanBarcode.Caption = "Quét mã vạch sản phẩm";
            this.btnScanBarcode.Id = 17;
            this.btnScanBarcode.ImageOptions.LargeImage = global::LocalDev.Properties.Resources.Barcode;
            this.btnScanBarcode.LargeWidth = 100;
            this.btnScanBarcode.Name = "btnScanBarcode";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLanguageLibrary);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
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
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPartNumber);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInBarcode);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnScanBarcode);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "TMA List";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btn_USER_MANAGER
            // 
            this.btn_USER_MANAGER.Caption = "User Manager";
            this.btn_USER_MANAGER.Id = 10;
            this.btn_USER_MANAGER.Name = "btn_USER_MANAGER";
            // 
            // btn_CHANGE_USER_PASSWORD
            // 
            this.btn_CHANGE_USER_PASSWORD.Caption = "Change User Password";
            this.btn_CHANGE_USER_PASSWORD.Id = 9;
            this.btn_CHANGE_USER_PASSWORD.Name = "btn_CHANGE_USER_PASSWORD";
            // 
            // btn_TMA_LIST
            // 
            this.btn_TMA_LIST.Caption = "TMA List";
            this.btn_TMA_LIST.Id = 1;
            this.btn_TMA_LIST.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TMA_LIST.ImageOptions.Image")));
            this.btn_TMA_LIST.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TMA_LIST.ImageOptions.LargeImage")));
            this.btn_TMA_LIST.Name = "btn_TMA_LIST";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 540);
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItem1;
        private Bar bar3;
        private BarButtonItem btn_USER_MANAGER;
        private BarButtonItem btn_CHANGE_USER_PASSWORD;
        private BarButtonItem btn_TMA_LIST;
        private BarButtonItem btnUsers;
        private BarButtonItem btnChangePassword;
        private BarButtonItem btnPartNumber;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem barButtonItem2;
        private BarButtonItem btnInBarcode;
        private BarButtonItem btnScanBarcode;
        private BarStaticItem txtUser;
        private BarButtonItem btnLanguageLibrary;
    }
}

