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

namespace LocalDev.View.Machines
{
    public partial class frmMachineAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        MachineRepository _machineRepository;

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

        public frmMachineAddEdit()
        {
            InitializeComponent();
        }

        public frmMachineAddEdit(bool quickAdd)
        {
            InitializeComponent();
            _quickAdd = quickAdd;
        }

        public frmMachineAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmMachineAddEdit_Load(object sender, EventArgs e)
        {
            _machineRepository = new MachineRepository(_projectDataContext);
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
            txtMachineNo.Text = "";
            txtNote.Text = "";
            chkUsing.Checked = true;
            txtMachineNo.Focus();
        }

        private void GetData()
        {
            //Get Data Table Machine
            Machine machine = _machineRepository.Get(_id);
            txtMachineNo.Text = machine.MachineNo;
            txtNote.Text = machine.Note;
            chkUsing.Checked = (machine.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (txtMachineNo.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachineNo.Focus();
                return false;
            }
            Machine machine = _machineRepository.FirstOrDefault(_ => _.MachineNo.Equals(txtMachineNo.Text.Trim()));
            if (machine != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtMachineNo.Text.Trim() != machine.MachineNo)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachineNo.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Machine
                Machine machine = new Machine();
                machine.Id = _id;
                machine.MachineNo = txtMachineNo.Text.Trim();
                machine.Note = txtNote.Text.Trim();
                machine.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _machineRepository.Save(machine);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        if (_quickAdd)
                        {
                            this.Tag = txtMachineNo.Text.Trim();
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