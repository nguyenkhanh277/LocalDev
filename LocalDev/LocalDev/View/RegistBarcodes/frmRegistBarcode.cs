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
using LocalDev.Core.Domain;
using System.Linq.Expressions;
using DevExpress.XtraGrid.Views.Grid;

namespace LocalDev.View.RegistBarcodes
{
    public partial class frmRegistBarcode : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        RegistBarcodeRepository _registBarcodeRepository;
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
                btnRegist_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnRePrint_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnHuy_Click(null, null);
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

        public frmRegistBarcode()
        {
            InitializeComponent();
        }

        private void frmRegistBarcode_Load(object sender, EventArgs e)
        {
            _registBarcodeRepository = new RegistBarcodeRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageGridView(viewDuLieu);
            Search();
        }

        private void Search()
        {
            List<Expression<Func<RegistBarcode, bool>>> expressions = new List<Expression<Func<RegistBarcode, bool>>>();
            if (!chkAllStatus.Checked)
            {
                GlobalConstants.StatusValue statusValue;
                Enum.TryParse<GlobalConstants.StatusValue>((chkUsing.Checked ? GlobalConstants.StatusValue.Using.ToString() : GlobalConstants.StatusValue.NoUse.ToString()), out statusValue);
                expressions.Add(_ => _.Status == statusValue);
            }
            dgvDuLieu.DataSource = _registBarcodeRepository.Find(expressions);
            Control();
        }

        private void Control()
        {
            btnRePrint.Enabled = btnHuy.Enabled = btnExcel.Enabled = (viewDuLieu.RowCount > 0);
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            frmRegistBarcodeAddEdit frm = new frmRegistBarcodeAddEdit();
            frm.ShowDialog();
            Search();
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            //frmRegistBarcodeAddEdit frm = new frmRegistBarcodeAddEdit(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, "Id").ToString());
            //DialogResult dr = frm.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    Search();
            //}
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Bạn có muốn hủy thông tin này?"), LanguageTranslate.ChangeLanguageText("Xác nhận"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _registBarcodeRepository.Cancel(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, "Id").ToString());
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    Search();
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Hủy thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void viewDuLieu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView view = sender as GridView;
                if (view.GetRowCellValue(e.RowHandle, "Status").ToString() == "NoUse")
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Strikeout);
                }
            }
        }
    }
}