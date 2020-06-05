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
using LocalDev.Core.Helper;

namespace LocalDev.View.AuthorityGroups
{
    public partial class frmAuthorityGroup : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        AuthorityGroupRepository _authorityGroupRepository;

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
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmAuthorityGroup()
        {
            InitializeComponent();
        }

        private void frmAuthorityGroup_Load(object sender, EventArgs e)
        {
            _authorityGroupRepository = new AuthorityGroupRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageGridView(viewDuLieu);
            Search();
        }

        private void Search()
        {
            Dictionary<AuthorityGroupRepository.SearchConditions, object> conditions = new Dictionary<AuthorityGroupRepository.SearchConditions, object>();
            if (!chkAllStatus.Checked)
            {
                conditions.Add(AuthorityGroupRepository.SearchConditions.Status, chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
            }
            conditions.Add(AuthorityGroupRepository.SearchConditions.SortId_Desc, false);
            dgvDuLieu.DataSource = _authorityGroupRepository.Find(conditions);
            Control();
        }

        private void Control()
        {
            btnEdit.Enabled = btnDelete.Enabled = btnExcel.Enabled = (viewDuLieu.RowCount > 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAuthorityGroupAddEdit frm = new frmAuthorityGroupAddEdit();
            frm.ShowDialog();
            Search();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAuthorityGroupAddEdit frm = new frmAuthorityGroupAddEdit(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, "Id").ToString());
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
                _authorityGroupRepository.Remove(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, "Id").ToString());
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