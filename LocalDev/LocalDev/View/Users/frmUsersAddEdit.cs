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

namespace LocalDev.View.Users
{
    public partial class frmUsersAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        UserRepository _userRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
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
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            chkMale.Checked = true;
            txtNote.Text = "";
            chkUsing.Checked = true;
        }

        private void GetData()
        {
            User user = _userRepository.GetUser(_id);
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            txtFullName.Text = user.FullName;
            txtPhone.Text = user.Phone;
            txtAddress.Text = user.Address;
            chkMale.Checked = (user.Gender == GlobalConstants.GenderValue.Male);
            txtNote.Text = user.Note;
            chkUsing.Checked = (user.Status == GlobalConstants.StatusValue.Using);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if (_userRepository.error)
            {
                XtraMessageBox.Show("Save failed", "Notification");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(_id))
                {
                    XtraMessageBox.Show("Save successfully", "Notification");
                    Clear();
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}