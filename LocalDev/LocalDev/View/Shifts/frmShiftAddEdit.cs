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

namespace LocalDev.View.Shifts
{
    public partial class frmShiftAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        ShiftRepository _shiftRepository;

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

        public frmShiftAddEdit()
        {
            InitializeComponent();
        }

        public frmShiftAddEdit(bool quickAdd)
        {
            InitializeComponent();
            _quickAdd = quickAdd;
        }

        public frmShiftAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmShiftAddEdit_Load(object sender, EventArgs e)
        {
            _shiftRepository = new ShiftRepository(_projectDataContext);
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
            txtShiftNo.Text = "";
            txtNote.Text = "";
            chkUsing.Checked = true;
            txtShiftNo.Focus();
        }

        private void GetData()
        {
            //Get Data Table Shift
            Shift shift = _shiftRepository.Get(_id);
            txtShiftNo.Text = shift.ShiftNo;
            txtNote.Text = shift.Note;
            chkUsing.Checked = (shift.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (txtShiftNo.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShiftNo.Focus();
                return false;
            }
            Shift shift = _shiftRepository.FirstOrDefault(_ => _.ShiftNo.Equals(txtShiftNo.Text.Trim()));
            if (shift != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtShiftNo.Text.Trim() != shift.ShiftNo)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShiftNo.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Shift
                Shift shift = new Shift();
                shift.Id = _id;
                shift.ShiftNo = txtShiftNo.Text.Trim();
                shift.Note = txtNote.Text.Trim();
                shift.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _shiftRepository.Save(shift);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        if (_quickAdd)
                        {
                            this.Tag = txtShiftNo.Text.Trim();
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