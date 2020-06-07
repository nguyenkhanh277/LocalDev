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

namespace LocalDev.View.Molds
{
    public partial class frmMoldAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        MoldRepository _moldRepository;

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
        bool _quickAdd = false;

        public frmMoldAddEdit()
        {
            InitializeComponent();
        }

        public frmMoldAddEdit(bool quickAdd)
        {
            InitializeComponent();
            _quickAdd = quickAdd;
        }

        public frmMoldAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmMoldAddEdit_Load(object sender, EventArgs e)
        {
            _moldRepository = new MoldRepository(_projectDataContext);
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
            txtMoldNo.Text = "";
            txtNote.Text = "";
            chkUsing.Checked = true;
            txtMoldNo.Focus();
        }

        private void GetData()
        {
            //Get Data Table Mold
            Mold mold = _moldRepository.Get(_id);
            txtMoldNo.Text = mold.MoldNo;
            txtNote.Text = mold.Note;
            chkUsing.Checked = (mold.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (txtMoldNo.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoldNo.Focus();
                return false;
            }
            Mold mold = _moldRepository.FirstOrDefault(_ => _.MoldNo.Equals(txtMoldNo.Text.Trim()));
            if (mold != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtMoldNo.Text.Trim() != mold.MoldNo)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoldNo.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Mold
                Mold mold = new Mold();
                mold.Id = _id;
                mold.MoldNo = txtMoldNo.Text.Trim();
                mold.Note = txtNote.Text.Trim();
                mold.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _moldRepository.Save(mold);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        if (_quickAdd)
                        {
                            this.Tag = txtMoldNo.Text.Trim();
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                            Clear();
                        }
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}