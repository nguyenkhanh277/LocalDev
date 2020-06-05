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
using LocalDev.Core;
using LocalDev.Persistence.Repositories;
using LocalDev.View.AuthorityGroups;
using LocalDev.View.ProgramFunctionMasters;
using LocalDev.Core.Helper;

namespace LocalDev.View.Users
{
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        UserRepository _userRepository;

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
                btnAdd_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnEdit_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnDelete_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnExcel_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnAuthority_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F7)
            {
                btnProgram_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _userRepository = new UserRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageGridView(viewDuLieu);
            btnProgram.Visible = (GlobalConstants.username.ToUpper() == "ADMIN");
            Search();
        }

        private void Search()
        {
            Dictionary<UserRepository.SearchConditions, object> conditions = new Dictionary<UserRepository.SearchConditions, object>();
            if (!chkAllStatus.Checked)
            {
                conditions.Add(UserRepository.SearchConditions.Status, chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
            }
            if (!chkAllGender.Checked)
            {
                conditions.Add(UserRepository.SearchConditions.Gender, chkMale.Checked ? GlobalConstants.GenderValue.Male : GlobalConstants.GenderValue.Female);
            }
            conditions.Add(UserRepository.SearchConditions.SortUsername_Desc, false);
            dgvDuLieu.DataSource = _userRepository.Find(conditions);
            Control();
        }

        private void Control()
        {
            btnEdit.Enabled = btnDelete.Enabled = btnExcel.Enabled = (viewDuLieu.RowCount > 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUsersAddEdit frm = new frmUsersAddEdit();
            frm.ShowDialog();
            Search();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmUsersAddEdit frm = new frmUsersAddEdit(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, "Id").ToString());
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Search();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Bạn có muốn xóa thông tin này?"), LanguageTranslate.ChangeLanguageText("Xác nhận"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _userRepository.Remove(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, "Id").ToString());
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    Search();
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Xóa thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                    return;
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            GlobalConstants.ExportExcel(dgvDuLieu);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            frmAuthorityGroup frm = new frmAuthorityGroup();
            frm.ShowDialog();
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            frmProgramFunctionMaster frm = new frmProgramFunctionMaster();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewDuLieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (viewDuLieu.RowCount > 0)
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    Clipboard.SetText(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, viewDuLieu.FocusedColumn.Name).ToString());
                    e.Handled = true;
                }
            }
        }

        private void viewDuLieu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}