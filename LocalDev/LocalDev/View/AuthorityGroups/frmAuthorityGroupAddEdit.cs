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

namespace LocalDev.View.AuthorityGroups
{
    public partial class frmAuthorityGroupAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        AuthorityGroupRepository _authorityGroupRepository;
        ProgramFunctionMasterRepository _programFunctionMasterRepository;
        ProgramFunctionAuthorityRepository _programFunctionAuthorityRepository;
        IEnumerable<ProgramFunctionAuthority> _oldProgramFunctionAuthority;

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

        public frmAuthorityGroupAddEdit()
        {
            InitializeComponent();
        }

        public frmAuthorityGroupAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmAuthorityGroupAddEdit_Load(object sender, EventArgs e)
        {
            _authorityGroupRepository = new AuthorityGroupRepository(_projectDataContext);
            _programFunctionMasterRepository = new ProgramFunctionMasterRepository(_projectDataContext);
            _programFunctionAuthorityRepository = new ProgramFunctionAuthorityRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageDataGridView(dgvDuLieu);
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                GetData();
            }
            LoadProgramFunction();
        }

        private void Clear()
        {
            txtAuthorityGroupName.Text = "";
            chkUsing.Checked = true;
        }

        private void GetData()
        {
            //Get Data Table AuthorityGroup
            AuthorityGroup authorityGroup = _authorityGroupRepository.Get(_id);
            txtAuthorityGroupName.Text = authorityGroup.AuthorityGroupName;
            chkUsing.Checked = (authorityGroup.Status == GlobalConstants.StatusValue.Using);
        }

        private void LoadProgramFunction()
        {
            Dictionary<ProgramFunctionMasterRepository.SearchConditions, object> conditionsMaster = new Dictionary<ProgramFunctionMasterRepository.SearchConditions, object>();
            conditionsMaster.Add(ProgramFunctionMasterRepository.SearchConditions.SortProgramName_Desc, false);
            var programFunctionMasters = _programFunctionMasterRepository.Find(conditionsMaster);

            Dictionary<ProgramFunctionAuthorityRepository.SearchConditions, object> conditions = new Dictionary<ProgramFunctionAuthorityRepository.SearchConditions, object>();
            conditions.Add(ProgramFunctionAuthorityRepository.SearchConditions.AuthorityGroupID, _id);
            conditions.Add(ProgramFunctionAuthorityRepository.SearchConditions.SortProgramName_Desc, false);
            _oldProgramFunctionAuthority = _programFunctionAuthorityRepository.Find(conditions);

            dgvDuLieu.Rows.Clear();
            int check = 0;
            foreach (var programFunctionMaster in programFunctionMasters)
            {
                check = 0;
                foreach (var programFunctionAuthority in _oldProgramFunctionAuthority)
                {
                    if (programFunctionAuthority.ProgramName == programFunctionMaster.ProgramName &&
                        programFunctionAuthority.FunctionName == programFunctionMaster.FunctionName)
                    {
                        check = 1;
                        break;
                    }
                }
                object[] rowAdd = { check, programFunctionMaster.ProgramName, programFunctionMaster.FunctionName, programFunctionMaster.Explanation };
                dgvDuLieu.Rows.Add(rowAdd);
            }
        }

        private bool CheckData()
        {
            if (txtAuthorityGroupName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                txtAuthorityGroupName.Focus();
                return false;
            }
            AuthorityGroup authorityGroup = _authorityGroupRepository.FirstOrDefault(x => x.AuthorityGroupName.Equals(txtAuthorityGroupName.Text.Trim()));
            if (authorityGroup != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtAuthorityGroupName.Text.Trim() != authorityGroup.AuthorityGroupName)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                txtAuthorityGroupName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table AuthorityGroup
                AuthorityGroup authorityGroup = new AuthorityGroup();
                authorityGroup.AuthorityGroupName = txtAuthorityGroupName.Text.Trim();
                authorityGroup.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _authorityGroupRepository.Save(authorityGroup);
                if (!String.IsNullOrEmpty(_authorityGroupRepository.id))
                {
                    for (int i = 0; i < dgvDuLieu.RowCount; i++)
                    {
                        if (dgvDuLieu.Rows[i].Cells["Assign"].Value.ToString() == "1")
                        {
                            ProgramFunctionAuthority programFunctionAuthority = new ProgramFunctionAuthority();
                            programFunctionAuthority.ProgramName = dgvDuLieu.Rows[i].Cells["ProgramName"].Value.ToString();
                            programFunctionAuthority.FunctionName = dgvDuLieu.Rows[i].Cells["FunctionName"].Value.ToString();
                            programFunctionAuthority.AuthorityGroupID = _authorityGroupRepository.id;
                            _programFunctionAuthorityRepository.Save(programFunctionAuthority);
                        }
                        else
                        {
                            _programFunctionAuthorityRepository.DeleteByProgramAndFunction(dgvDuLieu.Rows[i].Cells["ProgramName"].Value.ToString(), dgvDuLieu.Rows[i].Cells["FunctionName"].Value.ToString());
                        }
                    }
                }
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