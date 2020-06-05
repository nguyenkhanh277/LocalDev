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

namespace LocalDev.View.ProgramFunctionMasters
{
    public partial class frmProgramFunctionMasterAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        ProgramFunctionMasterRepository _programFunctionMasterRepository;

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

        public frmProgramFunctionMasterAddEdit()
        {
            InitializeComponent();
        }

        public frmProgramFunctionMasterAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmProgramFunctionMasterAddEdit_Load(object sender, EventArgs e)
        {
            _programFunctionMasterRepository = new ProgramFunctionMasterRepository(_projectDataContext);
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
            txtProgramName.Text = "";
            txtFunctionName.Text = "";
            txtExplanation.Text = "";
            chkUsing.Checked = true;
        }

        private void GetData()
        {
            //Get Data Table ProgramFunctionMaster
            ProgramFunctionMaster programFunctionMaster = _programFunctionMasterRepository.GetInfo(_id);
            txtProgramName.Text = programFunctionMaster.ProgramName;
            txtFunctionName.Text = programFunctionMaster.FunctionName;
            txtExplanation.Text = programFunctionMaster.Explanation;
            chkUsing.Checked = (programFunctionMaster.Status == GlobalConstants.StatusValue.Using);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Table ProgramFunctionMaster
                ProgramFunctionMaster programFunctionMaster = new ProgramFunctionMaster();
                programFunctionMaster.Id = _id;
                programFunctionMaster.ProgramName = txtProgramName.Text.Trim();
                programFunctionMaster.FunctionName = txtFunctionName.Text.Trim();
                programFunctionMaster.Explanation = txtExplanation.Text.Trim();
                programFunctionMaster.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _programFunctionMasterRepository.Save(programFunctionMaster);
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