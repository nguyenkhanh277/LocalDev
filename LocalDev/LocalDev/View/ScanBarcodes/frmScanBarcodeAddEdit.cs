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

namespace LocalDev.View.ScanBarcodes
{
    public partial class frmScanBarcodeAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        ScanBarcodeRepository _scanBarcodeRepository;
        PartNumberRepository _partNumberRepository;
        MachineRepository _machineRepository;
        MoldRepository _moldRepository;
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
        bool _loaded = false;
        public frmScanBarcodeAddEdit()
        {
            InitializeComponent();
        }

        public frmScanBarcodeAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmScanBarcodeAddEdit_Load(object sender, EventArgs e)
        {
            _scanBarcodeRepository = new ScanBarcodeRepository(_projectDataContext);
            _partNumberRepository = new PartNumberRepository(_projectDataContext);
            _machineRepository = new MachineRepository(_projectDataContext);
            _moldRepository = new MoldRepository(_projectDataContext);
            _shiftRepository = new ShiftRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LoadPartNumberData();
            LoadMachineData();
            LoadShiftData();
            LoadMoldData();
            _loaded = true;
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                Close();
            }
        }

        private void Clear()
        {
            dtpRegistDate.Value = DateTime.Now;
            GenerateBarcode();
        }

        private void LoadPartNumberData()
        {
            cbbPartNumber.DataSource = _partNumberRepository.GetAll().ToList();
            cbbPartNumber.SelectedIndex = 0;
        }

        private void LoadMachineData()
        {
            cbbMachine.DataSource = _machineRepository.GetAll().ToList();
            cbbMachine.SelectedIndex = 0;
        }

        private void LoadShiftData()
        {
            cbbShift.DataSource = _shiftRepository.GetAll().ToList();
            cbbShift.SelectedIndex = 0;
        }

        private void LoadMoldData()
        {
            cbbMold.DataSource = _moldRepository.GetAll().ToList();
            cbbMold.SelectedIndex = 0;
        }

        private void GenerateBarcode()
        {
            if (_loaded)
            {
                if (!CheckDataWhenGenerateBarcode())
                {
                    txtBarcode.Text = "";
                    txtBarcode.BackColor = Color.Red;
                }
                else
                {
                    txtBarcode.Text = String.Format("{0}{1}{2}{3}{4}{5}",
                        cbbPartNumber.Text.Trim(),
                        dtpRegistDate.Value.ToString("yyMMdd"),
                        cbbMachine.Text.Trim(),
                        cbbShift.Text.Trim(),
                        cbbMold.Text.Trim(),
                        txtSEQ.Text.Trim());
                    txtBarcode.BackColor = Color.White;
                }
            }
        }

        private void cbbPartNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateBarcode();
        }

        private void cbbMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateBarcode();
        }

        private void cbbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateBarcode();
        }

        private void cbbMold_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateBarcode();
        }

        private bool CheckDataWhenGenerateBarcode()
        {
            if (cbbPartNumber.SelectedValue == null || String.IsNullOrEmpty(cbbPartNumber.Text.Trim()))
            {
                return false;
            }
            else if (cbbMachine.SelectedValue == null || String.IsNullOrEmpty(cbbMachine.Text.Trim()))
            {
                return false;
            }
            else if (cbbMold.SelectedValue == null || String.IsNullOrEmpty(cbbMold.Text.Trim()))
            {
                return false;
            }
            else if (cbbShift.SelectedValue == null || String.IsNullOrEmpty(cbbShift.Text.Trim()))
            {
                return false;
            }
            else if (txtSEQ.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

        private bool CheckData()
        {
            if (cbbPartNumber.SelectedValue == null || String.IsNullOrEmpty(cbbPartNumber.Text.Trim()))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa chọn dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbPartNumber.Focus();
                return false;
            }
            else if (cbbMachine.SelectedValue == null || String.IsNullOrEmpty(cbbMachine.Text.Trim()))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa chọn dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMachine.Focus();
                return false;
            }
            else if (cbbMold.SelectedValue == null || String.IsNullOrEmpty(cbbMold.Text.Trim()))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa chọn dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMold.Focus();
                return false;
            }
            else if (cbbShift.SelectedValue == null || String.IsNullOrEmpty(cbbShift.Text.Trim()))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa chọn dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbShift.Focus();
                return false;
            }
            else if (txtSEQ.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSEQ.Focus();
                return false;
            }
            //ScanBarcode scanBarcode = _scanBarcodeRepository.FirstOrDefault(_ => _.Barcode.Equals(txtBarcode.Text.Trim()));
            //if (scanBarcode != null &&
            //    (
            //        String.IsNullOrEmpty(_id) ||
            //        (!String.IsNullOrEmpty(_id) && txtBarcode.Text.Trim() != scanBarcode.Barcode)
            //    ))
            //{
            //    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cbbPartNumber.Focus();
            //    return false;
            //}
            return true;
        }

        private void PrintBarcode()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table ScanBarcode
                ScanBarcode scanBarcode = new ScanBarcode();
                scanBarcode.Id = _id;
                //scanBarcode.PartNo = cbbPartNumber.Text.Trim();
                //scanBarcode.RegistDate = dtpRegistDate.Value.Date;
                //scanBarcode.MachineNo = cbbMachine.Text.Trim();
                //scanBarcode.MoldNo = cbbMold.Text.Trim();
                //scanBarcode.ShiftNo = cbbShift.Text.Trim();
                //scanBarcode.SEQ = txtSEQ.Text.Trim();
                //scanBarcode.Barcode = txtBarcode.Text.Trim();
                _scanBarcodeRepository.Save(scanBarcode);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        PrintBarcode();
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

        private void btnAddPartNumber_Click(object sender, EventArgs e)
        {
            PartNumbers.frmPartNumberAddEdit frm = new PartNumbers.frmPartNumberAddEdit(true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                _loaded = false;
                LoadPartNumberData();
                _loaded = true;
                cbbPartNumber.Text = (string)frm.Tag;
                GenerateBarcode();
            }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            Machines.frmMachineAddEdit frm = new Machines.frmMachineAddEdit(true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                _loaded = false;
                LoadMachineData();
                _loaded = true;
                cbbMachine.Text = (string)frm.Tag;
                GenerateBarcode();
            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            Shifts.frmShiftAddEdit frm = new Shifts.frmShiftAddEdit();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                _loaded = false;
                LoadShiftData();
                _loaded = true;
                cbbShift.Text = (string)frm.Tag;
                GenerateBarcode();
            }
        }

        private void btnMold_Click(object sender, EventArgs e)
        {
            Molds.frmMoldAddEdit frm = new Molds.frmMoldAddEdit();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                _loaded = false;
                LoadMoldData();
                _loaded = true;
                cbbMold.Text = (string)frm.Tag;
                GenerateBarcode();
            }
        }
    }
}