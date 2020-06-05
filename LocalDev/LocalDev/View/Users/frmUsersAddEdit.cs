﻿using System;
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

namespace LocalDev.View.Users
{
    public partial class frmUsersAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        UserRepository _userRepository;
        AuthorityGroupRepository _authorityGroupRepository;
        UserAuthorityRepository _userAuthorityRepository;

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

        public frmUsersAddEdit()
        {
            InitializeComponent();
        }

        public frmUsersAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmUsersAddEdit_Load(object sender, EventArgs e)
        {
            _userRepository = new UserRepository(_projectDataContext);
            _authorityGroupRepository = new AuthorityGroupRepository(_projectDataContext);
            _userAuthorityRepository = new UserAuthorityRepository(_projectDataContext);
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
            LoadAuthority();
        }

        private void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword.Enabled = true;
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            chkMale.Checked = true;
            txtNote.Text = "";
            chkUsing.Checked = true;
        }

        private void GetData()
        {
            //Get Data Table User
            User user = _userRepository.GetInfo(_id);
            txtUsername.Text = user.Username;
            txtPassword.Text = "";
            txtPassword.Enabled = false;
            txtFullName.Text = user.FullName;
            txtPhone.Text = user.Phone;
            txtAddress.Text = user.Address;
            chkMale.Checked = (user.Gender == GlobalConstants.GenderValue.Male);
            txtNote.Text = user.Note;
            chkUsing.Checked = (user.Status == GlobalConstants.StatusValue.Using);
        }

        private void LoadAuthority()
        {
            Dictionary<AuthorityGroupRepository.SearchConditions, object> conditionsMaster = new Dictionary<AuthorityGroupRepository.SearchConditions, object>();
            conditionsMaster.Add(AuthorityGroupRepository.SearchConditions.SortId_Desc, false);
            var authorityGroups = _authorityGroupRepository.GetAll(conditionsMaster);

            Dictionary<UserAuthorityRepository.SearchConditions, object> conditions = new Dictionary<UserAuthorityRepository.SearchConditions, object>();
            conditions.Add(UserAuthorityRepository.SearchConditions.UserID, _id);
            conditions.Add(UserAuthorityRepository.SearchConditions.SortAuthorityGroupID_Desc, false);
            var userAuthoritys = _userAuthorityRepository.GetAll(conditions);

            dgvDuLieu.Rows.Clear();
            int check = 0;
            foreach (var authorityGroup in authorityGroups)
            {
                check = 0;
                foreach (var programFunctionAuthority in userAuthoritys)
                {
                    if (programFunctionAuthority.AuthorityGroupID == authorityGroup.Id)
                    {
                        check = 1;
                        break;
                    }
                }
                object[] rowAdd = { check, authorityGroup.Id, authorityGroup.AuthorityGroupName };
                dgvDuLieu.Rows.Add(rowAdd);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Table User
                User user = new User();
                user.Id = _id;
                user.Username = txtUsername.Text.Trim();
                user.Password = txtPassword.Text.Trim();
                user.FullName = txtFullName.Text.Trim();
                user.Phone = txtPhone.Text.Trim();
                user.Address = txtAddress.Text.Trim();
                user.Gender = (chkMale.Checked ? GlobalConstants.GenderValue.Male : GlobalConstants.GenderValue.Female);
                user.Note = txtNote.Text.Trim();
                user.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _userRepository.Save(user);
                if (!String.IsNullOrEmpty(_userRepository.id))
                {
                    _userAuthorityRepository.DeleteByUserID(_userRepository.id);
                    for (int i = 0; i < dgvDuLieu.RowCount; i++)
                    {
                        if (dgvDuLieu.Rows[i].Cells["Assign"].Value.ToString() == "1")
                        {
                            UserAuthority userAuthority = new UserAuthority();
                            userAuthority.AuthorityGroupID = int.Parse(dgvDuLieu.Rows[i].Cells["Id"].Value.ToString());
                            userAuthority.UserID = _userRepository.id;
                            _userAuthorityRepository.Save(userAuthority);
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