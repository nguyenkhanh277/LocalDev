using DevExpress.XtraEditors;
using LocalDev.Core;
using LocalDev.Core.Helper;
using LocalDev.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LocalDev.View.Home
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = LanguageTranslate.ChangeLanguageText(this.Text);
            btnUsers.Caption = LanguageTranslate.ChangeLanguageText(btnUsers.Caption);
            btnChangePassword.Caption = LanguageTranslate.ChangeLanguageText(btnChangePassword.Caption);
            btnPartNumber.Caption = LanguageTranslate.ChangeLanguageText(btnPartNumber.Caption);
            btnInBarcode.Caption = LanguageTranslate.ChangeLanguageText(btnInBarcode.Caption);
            btnScanBarcode.Caption = LanguageTranslate.ChangeLanguageText(btnScanBarcode.Caption);
            rbpHeThong.Text = LanguageTranslate.ChangeLanguageText(rbpHeThong.Text);
            rbpChucNang.Text = LanguageTranslate.ChangeLanguageText(rbpChucNang.Text);
            rbpBaoCao.Text = LanguageTranslate.ChangeLanguageText(rbpBaoCao.Text);
            txtUser.Caption = LanguageTranslate.ChangeLanguageText("Tài khoản") + ": " + GlobalConstants.username + "  |  " + LanguageTranslate.ChangeLanguageText("Tên đầy đủ") + ": " + GlobalConstants.fullName;
            ribbonControl1.SelectPage(rbpChucNang);
        }
        private XtraForm CheckExist(Type fType)
        {
            foreach (XtraForm f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Users.frmUsers));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Users.frmUsers f = new Users.frmUsers();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLanguageLibrary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(LanguageLibrarys.frmLanguageLibrary));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                LanguageLibrarys.frmLanguageLibrary f = new LanguageLibrarys.frmLanguageLibrary();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnPartNumber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(PartNumbers.frmPartNumber));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                PartNumbers.frmPartNumber f = new PartNumbers.frmPartNumber();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
