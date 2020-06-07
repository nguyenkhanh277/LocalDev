namespace LocalDev.View.RegistBarcodes
{
    partial class frmRegistBarcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkAllStatus = new System.Windows.Forms.RadioButton();
            this.chkUsing = new System.Windows.Forms.RadioButton();
            this.chkNoUse = new System.Windows.Forms.RadioButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnRePrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegist = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDuLieu = new DevExpress.XtraGrid.GridControl();
            this.viewDuLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.PartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RegistDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MachineNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShiftNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoldNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.chkAllStatus);
            this.groupControl1.Controls.Add(this.chkUsing);
            this.groupControl1.Controls.Add(this.chkNoUse);
            this.groupControl1.Location = new System.Drawing.Point(442, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(260, 40);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Trạng thái";
            // 
            // chkAllStatus
            // 
            this.chkAllStatus.AutoSize = true;
            this.chkAllStatus.BackColor = System.Drawing.Color.Transparent;
            this.chkAllStatus.Checked = true;
            this.chkAllStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAllStatus.Location = new System.Drawing.Point(5, 18);
            this.chkAllStatus.Name = "chkAllStatus";
            this.chkAllStatus.Size = new System.Drawing.Size(63, 23);
            this.chkAllStatus.TabIndex = 9;
            this.chkAllStatus.TabStop = true;
            this.chkAllStatus.Text = "Tất cả";
            this.chkAllStatus.UseVisualStyleBackColor = false;
            // 
            // chkUsing
            // 
            this.chkUsing.AutoSize = true;
            this.chkUsing.BackColor = System.Drawing.Color.Transparent;
            this.chkUsing.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkUsing.Location = new System.Drawing.Point(74, 18);
            this.chkUsing.Name = "chkUsing";
            this.chkUsing.Size = new System.Drawing.Size(78, 23);
            this.chkUsing.TabIndex = 6;
            this.chkUsing.Text = "Sử dụng";
            this.chkUsing.UseVisualStyleBackColor = false;
            // 
            // chkNoUse
            // 
            this.chkNoUse.AutoSize = true;
            this.chkNoUse.BackColor = System.Drawing.Color.Transparent;
            this.chkNoUse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkNoUse.Location = new System.Drawing.Point(158, 18);
            this.chkNoUse.Name = "chkNoUse";
            this.chkNoUse.Size = new System.Drawing.Size(97, 23);
            this.chkNoUse.TabIndex = 7;
            this.chkNoUse.Text = "Ko sử dụng";
            this.chkNoUse.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.Location = new System.Drawing.Point(270, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 40);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel (F4)";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(356, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Lọc (F5)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(1198, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHuy.Appearance.Options.UseBackColor = true;
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(184, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 40);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy (F3)";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnRePrint
            // 
            this.btnRePrint.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRePrint.Appearance.Options.UseFont = true;
            this.btnRePrint.Location = new System.Drawing.Point(98, 5);
            this.btnRePrint.Name = "btnRePrint";
            this.btnRePrint.Size = new System.Drawing.Size(80, 40);
            this.btnRePrint.TabIndex = 1;
            this.btnRePrint.Text = "In lại (F2)";
            this.btnRePrint.Click += new System.EventHandler(this.btnRePrint_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnRegist.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRegist.Appearance.Options.UseBackColor = true;
            this.btnRegist.Appearance.Options.UseFont = true;
            this.btnRegist.Location = new System.Drawing.Point(12, 5);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(80, 40);
            this.btnRegist.TabIndex = 0;
            this.btnRegist.Text = "Đăng ký (F1)";
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuLieu.Location = new System.Drawing.Point(0, 50);
            this.dgvDuLieu.MainView = this.viewDuLieu;
            this.dgvDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemMemoEdit1});
            this.dgvDuLieu.Size = new System.Drawing.Size(1290, 418);
            this.dgvDuLieu.TabIndex = 4;
            this.dgvDuLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDuLieu});
            // 
            // viewDuLieu
            // 
            this.viewDuLieu.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.viewDuLieu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseBackColor = true;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseForeColor = true;
            this.viewDuLieu.ColumnPanelRowHeight = 40;
            this.viewDuLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.PartNo,
            this.RegistDate,
            this.MachineNo,
            this.ShiftNo,
            this.MoldNo,
            this.SEQ,
            this.Barcode,
            this.Status});
            this.viewDuLieu.DetailHeight = 284;
            this.viewDuLieu.GridControl = this.dgvDuLieu;
            this.viewDuLieu.IndicatorWidth = 40;
            this.viewDuLieu.Name = "viewDuLieu";
            this.viewDuLieu.OptionsBehavior.Editable = false;
            this.viewDuLieu.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewDuLieu.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.viewDuLieu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.viewDuLieu.OptionsView.ShowAutoFilterRow = true;
            this.viewDuLieu.OptionsView.ShowGroupPanel = false;
            this.viewDuLieu.RowHeight = 40;
            this.viewDuLieu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewDuLieu_CustomDrawRowIndicator);
            this.viewDuLieu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.viewDuLieu_RowCellStyle);
            this.viewDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDuLieu_KeyDown);
            // 
            // Id
            // 
            this.Id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Id.AppearanceCell.Options.UseFont = true;
            this.Id.AppearanceCell.Options.UseTextOptions = true;
            this.Id.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Id.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Id.AppearanceHeader.Options.UseFont = true;
            this.Id.AppearanceHeader.Options.UseTextOptions = true;
            this.Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id.Caption = "Id";
            this.Id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // PartNo
            // 
            this.PartNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PartNo.AppearanceCell.Options.UseFont = true;
            this.PartNo.AppearanceCell.Options.UseTextOptions = true;
            this.PartNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.PartNo.AppearanceHeader.Options.UseFont = true;
            this.PartNo.AppearanceHeader.Options.UseTextOptions = true;
            this.PartNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNo.Caption = "PartNumber";
            this.PartNo.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartNo.FieldName = "PartNo";
            this.PartNo.MaxWidth = 200;
            this.PartNo.MinWidth = 200;
            this.PartNo.Name = "PartNo";
            this.PartNo.Visible = true;
            this.PartNo.VisibleIndex = 0;
            this.PartNo.Width = 200;
            // 
            // RegistDate
            // 
            this.RegistDate.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RegistDate.AppearanceCell.Options.UseFont = true;
            this.RegistDate.AppearanceCell.Options.UseTextOptions = true;
            this.RegistDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RegistDate.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RegistDate.AppearanceHeader.Options.UseFont = true;
            this.RegistDate.AppearanceHeader.Options.UseTextOptions = true;
            this.RegistDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RegistDate.Caption = "Ngày đăng ký";
            this.RegistDate.ColumnEdit = this.repositoryItemMemoEdit1;
            this.RegistDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.RegistDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.RegistDate.FieldName = "RegistDate";
            this.RegistDate.MaxWidth = 100;
            this.RegistDate.MinWidth = 100;
            this.RegistDate.Name = "RegistDate";
            this.RegistDate.Visible = true;
            this.RegistDate.VisibleIndex = 1;
            this.RegistDate.Width = 100;
            // 
            // MachineNo
            // 
            this.MachineNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MachineNo.AppearanceCell.Options.UseFont = true;
            this.MachineNo.AppearanceCell.Options.UseTextOptions = true;
            this.MachineNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MachineNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MachineNo.AppearanceHeader.Options.UseFont = true;
            this.MachineNo.AppearanceHeader.Options.UseTextOptions = true;
            this.MachineNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MachineNo.Caption = "Mã máy";
            this.MachineNo.ColumnEdit = this.repositoryItemMemoEdit1;
            this.MachineNo.FieldName = "MachineNo";
            this.MachineNo.MaxWidth = 100;
            this.MachineNo.MinWidth = 100;
            this.MachineNo.Name = "MachineNo";
            this.MachineNo.Visible = true;
            this.MachineNo.VisibleIndex = 2;
            this.MachineNo.Width = 100;
            // 
            // ShiftNo
            // 
            this.ShiftNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ShiftNo.AppearanceCell.Options.UseFont = true;
            this.ShiftNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShiftNo.AppearanceHeader.Options.UseFont = true;
            this.ShiftNo.AppearanceHeader.Options.UseTextOptions = true;
            this.ShiftNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ShiftNo.Caption = "Mã ca";
            this.ShiftNo.FieldName = "ShiftNo";
            this.ShiftNo.MaxWidth = 100;
            this.ShiftNo.MinWidth = 100;
            this.ShiftNo.Name = "ShiftNo";
            this.ShiftNo.Visible = true;
            this.ShiftNo.VisibleIndex = 3;
            this.ShiftNo.Width = 100;
            // 
            // MoldNo
            // 
            this.MoldNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MoldNo.AppearanceCell.Options.UseFont = true;
            this.MoldNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MoldNo.AppearanceHeader.Options.UseFont = true;
            this.MoldNo.AppearanceHeader.Options.UseTextOptions = true;
            this.MoldNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MoldNo.Caption = "Mã khuôn";
            this.MoldNo.FieldName = "MoldNo";
            this.MoldNo.MaxWidth = 100;
            this.MoldNo.MinWidth = 100;
            this.MoldNo.Name = "MoldNo";
            this.MoldNo.Visible = true;
            this.MoldNo.VisibleIndex = 4;
            this.MoldNo.Width = 100;
            // 
            // SEQ
            // 
            this.SEQ.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SEQ.AppearanceCell.Options.UseFont = true;
            this.SEQ.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SEQ.AppearanceHeader.Options.UseFont = true;
            this.SEQ.AppearanceHeader.Options.UseTextOptions = true;
            this.SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SEQ.Caption = "SEQ";
            this.SEQ.FieldName = "SEQ";
            this.SEQ.MaxWidth = 100;
            this.SEQ.MinWidth = 100;
            this.SEQ.Name = "SEQ";
            this.SEQ.Visible = true;
            this.SEQ.VisibleIndex = 5;
            this.SEQ.Width = 100;
            // 
            // Barcode
            // 
            this.Barcode.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Barcode.AppearanceCell.Options.UseFont = true;
            this.Barcode.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Barcode.AppearanceHeader.Options.UseFont = true;
            this.Barcode.AppearanceHeader.Options.UseTextOptions = true;
            this.Barcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode.Caption = "Mã vạch";
            this.Barcode.FieldName = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Visible = true;
            this.Barcode.VisibleIndex = 6;
            this.Barcode.Width = 412;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnRePrint);
            this.panelControl1.Controls.Add(this.btnRegist);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1290, 50);
            this.panelControl1.TabIndex = 5;
            // 
            // Status
            // 
            this.Status.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Status.AppearanceCell.Options.UseFont = true;
            this.Status.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Status.AppearanceHeader.Options.UseFont = true;
            this.Status.AppearanceHeader.Options.UseTextOptions = true;
            this.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MaxWidth = 100;
            this.Status.MinWidth = 100;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 7;
            this.Status.Width = 100;
            // 
            // frmRegistBarcode
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1290, 468);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegistBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký in mã vạch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel radPanel1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnRePrint;
        private DevExpress.XtraEditors.SimpleButton btnRegist;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl dgvDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn PartNo;
        private DevExpress.XtraGrid.Columns.GridColumn RegistDate;
        private DevExpress.XtraGrid.Columns.GridColumn MachineNo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton chkUsing;
        private System.Windows.Forms.RadioButton chkNoUse;
        private System.Windows.Forms.RadioButton chkAllStatus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ShiftNo;
        private DevExpress.XtraGrid.Columns.GridColumn MoldNo;
        private DevExpress.XtraGrid.Columns.GridColumn SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
    }
}