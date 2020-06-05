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
using LocalDev.Core.Domain;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.View.LanguageLibrarys
{
    public partial class frmLanguageLibraryAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        LanguageLibraryRepository _languageLibraryRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.KeyCode == Keys.F1)
            {
                btnSave_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        string _id = "";

        public frmLanguageLibraryAddEdit()
        {
            InitializeComponent();
        }

        public frmLanguageLibraryAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmLanguageLibraryAddEdit_Load(object sender, EventArgs e)
        {
            _languageLibraryRepository = new LanguageLibraryRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                GetData();
            }
        }

        private void Clear()
        {
            txtEnglish.Text = "";
            txtVietnamese.Text = "";
        }

        private void GetData()
        {
            //Get Data Table Language
            LanguageLibrary languageLibrary = _languageLibraryRepository.GetInfo(_id);
            txtEnglish.Text = languageLibrary.English;
            txtVietnamese.Text = languageLibrary.Vietnamese;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Table Language
                LanguageLibrary languageLibrary = new LanguageLibrary();
                languageLibrary.Id = _id;
                languageLibrary.English = txtEnglish.Text.Trim();
                languageLibrary.Vietnamese = txtVietnamese.Text.Trim();
                _languageLibraryRepository.Save(languageLibrary);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                        Clear();
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}