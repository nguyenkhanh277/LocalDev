using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LocalDev.Persistence;
using LocalDev.Persistence.Repositories;
using LocalDev.Core;

namespace LocalDev.View.Home
{
    public partial class frmSignIn : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        UserRepository _userRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            GlobalConstants.Language = Properties.Settings.Default.Language;
            LoadLanguage(GlobalConstants.Language);
            lblTieuDe.Text = Properties.Settings.Default.Company;
            _userRepository = new UserRepository(_projectDataContext);
            chkKeepMeSignedIn.Checked = Properties.Settings.Default.KeepMeSignedIn;
            if (chkKeepMeSignedIn.Checked)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            _userRepository.CheckSecurity(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (_userRepository.error)
            {
                XtraMessageBox.Show(_userRepository.errorMessage, "Notification");
                return;
            }
            Properties.Settings.Default.KeepMeSignedIn = chkKeepMeSignedIn.Checked;
            if (chkKeepMeSignedIn.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text.Trim();
                Properties.Settings.Default.Password = txtPassword.Text.Trim();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
            }
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn_Click(null, null);
            }
        }

        private void LoadLanguage(int language)
        {
            GlobalConstants.Language = language;
            Properties.Settings.Default.Language = GlobalConstants.Language;
            Properties.Settings.Default.Save();
            if (language == (int)GlobalConstants.LanguageValue.English)
            {
                picEnglish.BackColor = Color.Yellow;
                picVietnamese.BackColor = Color.Transparent;
            }
            else
            {
                picVietnamese.BackColor = Color.Yellow;
                picEnglish.BackColor = Color.Transparent;
            }
            //NgonNgu.DoiNgonNguForm(this);
        }

        private void picVietnamese_Click(object sender, EventArgs e)
        {
            LoadLanguage((int)GlobalConstants.LanguageValue.Vietnamese);
        }

        private void picEnglish_Click(object sender, EventArgs e)
        {
            LoadLanguage((int)GlobalConstants.LanguageValue.English);
        }
    }
}