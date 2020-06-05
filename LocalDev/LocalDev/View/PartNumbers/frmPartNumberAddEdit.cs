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

namespace LocalDev.View.PartNumbers
{
    public partial class frmPartNumberAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        PartNumberRepository _partNumberRepository;

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

        public frmPartNumberAddEdit()
        {
            InitializeComponent();
        }

        public frmPartNumberAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmPartNumberAddEdit_Load(object sender, EventArgs e)
        {
            _partNumberRepository = new PartNumberRepository(_projectDataContext);
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
            txtPartNo.Text = "";
            txtModel.Text = "";
            txtNote.Text = "";
            chkUsing.Checked = true;
        }

        private void GetData()
        {
            //Get Data Table PartNumber
            PartNumber partNumber = _partNumberRepository.GetInfo(_id);
            txtPartNo.Text = partNumber.PartNo;
            txtModel.Text = partNumber.Model;
            txtNote.Text = partNumber.Note;
            chkUsing.Checked = (partNumber.Status == GlobalConstants.StatusValue.Using);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Table PartNumber
                PartNumber partNumber = new PartNumber();
                partNumber.Id = _id;
                partNumber.PartNo = txtPartNo.Text.Trim();
                partNumber.Model = txtModel.Text.Trim();
                partNumber.Note = txtNote.Text.Trim();
                partNumber.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _partNumberRepository.Save(partNumber);
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