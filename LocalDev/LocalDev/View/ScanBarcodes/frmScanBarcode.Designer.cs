namespace LocalDev.View.ScanBarcodes
{
    partial class frmScanBarcode
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
            this.btnScanBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDuLieu = new DevExpress.XtraGrid.GridControl();
            this.viewDuLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.WorkOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpectedDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductionStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chkAllProductionStatus = new System.Windows.Forms.RadioButton();
            this.chkNone = new System.Windows.Forms.RadioButton();
            this.chkInProgress = new System.Windows.Forms.RadioButton();
            this.chkCompleted = new System.Windows.Forms.RadioButton();
            this.chkHold = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            // btnScanBarcode
            // 
            this.btnScanBarcode.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnScanBarcode.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnScanBarcode.Appearance.Options.UseBackColor = true;
            this.btnScanBarcode.Appearance.Options.UseFont = true;
            this.btnScanBarcode.Location = new System.Drawing.Point(12, 5);
            this.btnScanBarcode.Name = "btnScanBarcode";
            this.btnScanBarcode.Size = new System.Drawing.Size(166, 40);
            this.btnScanBarcode.TabIndex = 0;
            this.btnScanBarcode.Text = "Quét mã vạch (F1)";
            this.btnScanBarcode.Click += new System.EventHandler(this.btnScanBarcode_Click);
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
            this.WorkOrder,
            this.PartNo,
            this.Model,
            this.ExpectedDeliveryDate,
            this.Quantity,
            this.UserID,
            this.ProductionStatus});
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
            // WorkOrder
            // 
            this.WorkOrder.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.WorkOrder.AppearanceCell.Options.UseFont = true;
            this.WorkOrder.AppearanceCell.Options.UseTextOptions = true;
            this.WorkOrder.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.WorkOrder.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.WorkOrder.AppearanceHeader.Options.UseFont = true;
            this.WorkOrder.AppearanceHeader.Options.UseTextOptions = true;
            this.WorkOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkOrder.Caption = "Trình tự công việc";
            this.WorkOrder.ColumnEdit = this.repositoryItemMemoEdit1;
            this.WorkOrder.FieldName = "WorkOrder";
            this.WorkOrder.MinWidth = 200;
            this.WorkOrder.Name = "WorkOrder";
            this.WorkOrder.Visible = true;
            this.WorkOrder.VisibleIndex = 0;
            this.WorkOrder.Width = 200;
            // 
            // ExpectedDeliveryDate
            // 
            this.ExpectedDeliveryDate.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExpectedDeliveryDate.AppearanceCell.Options.UseFont = true;
            this.ExpectedDeliveryDate.AppearanceCell.Options.UseTextOptions = true;
            this.ExpectedDeliveryDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ExpectedDeliveryDate.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ExpectedDeliveryDate.AppearanceHeader.Options.UseFont = true;
            this.ExpectedDeliveryDate.AppearanceHeader.Options.UseTextOptions = true;
            this.ExpectedDeliveryDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ExpectedDeliveryDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ExpectedDeliveryDate.Caption = "Ngày dự kiến giao hàng";
            this.ExpectedDeliveryDate.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ExpectedDeliveryDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.ExpectedDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ExpectedDeliveryDate.FieldName = "ExpectedDeliveryDate";
            this.ExpectedDeliveryDate.MaxWidth = 200;
            this.ExpectedDeliveryDate.MinWidth = 200;
            this.ExpectedDeliveryDate.Name = "ExpectedDeliveryDate";
            this.ExpectedDeliveryDate.Visible = true;
            this.ExpectedDeliveryDate.VisibleIndex = 3;
            this.ExpectedDeliveryDate.Width = 200;
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
            this.PartNo.VisibleIndex = 1;
            this.PartNo.Width = 200;
            // 
            // Model
            // 
            this.Model.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Model.AppearanceCell.Options.UseFont = true;
            this.Model.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Model.AppearanceHeader.Options.UseFont = true;
            this.Model.AppearanceHeader.Options.UseTextOptions = true;
            this.Model.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Model.Caption = "Model";
            this.Model.FieldName = "Model";
            this.Model.MaxWidth = 200;
            this.Model.MinWidth = 200;
            this.Model.Name = "Model";
            this.Model.Visible = true;
            this.Model.VisibleIndex = 2;
            this.Model.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Quantity.AppearanceCell.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.Caption = "Số lượng";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MaxWidth = 200;
            this.Quantity.MinWidth = 200;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 4;
            this.Quantity.Width = 200;
            // 
            // ProductionStatus
            // 
            this.ProductionStatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProductionStatus.AppearanceCell.Options.UseFont = true;
            this.ProductionStatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ProductionStatus.AppearanceHeader.Options.UseFont = true;
            this.ProductionStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductionStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductionStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ProductionStatus.Caption = "Trạng thái sản xuất";
            this.ProductionStatus.FieldName = "ProductionStatus";
            this.ProductionStatus.MaxWidth = 200;
            this.ProductionStatus.MinWidth = 200;
            this.ProductionStatus.Name = "ProductionStatus";
            this.ProductionStatus.Visible = true;
            this.ProductionStatus.VisibleIndex = 5;
            this.ProductionStatus.Width = 200;
            // 
            // UserID
            // 
            this.UserID.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserID.AppearanceCell.Options.UseFont = true;
            this.UserID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.UserID.AppearanceHeader.Options.UseFont = true;
            this.UserID.AppearanceHeader.Options.UseTextOptions = true;
            this.UserID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserID.Caption = "Người lập";
            this.UserID.FieldName = "UserID";
            this.UserID.MaxWidth = 150;
            this.UserID.MinWidth = 150;
            this.UserID.Name = "UserID";
            this.UserID.Width = 150;
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
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnScanBarcode);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1290, 50);
            this.panelControl1.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.chkCompleted);
            this.groupControl2.Controls.Add(this.chkHold);
            this.groupControl2.Controls.Add(this.chkAllProductionStatus);
            this.groupControl2.Controls.Add(this.chkNone);
            this.groupControl2.Controls.Add(this.chkInProgress);
            this.groupControl2.Location = new System.Drawing.Point(708, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(445, 40);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Trạng thái sản xuất";
            // 
            // chkAllProductionStatus
            // 
            this.chkAllProductionStatus.AutoSize = true;
            this.chkAllProductionStatus.BackColor = System.Drawing.Color.Transparent;
            this.chkAllProductionStatus.Checked = true;
            this.chkAllProductionStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAllProductionStatus.Location = new System.Drawing.Point(5, 18);
            this.chkAllProductionStatus.Name = "chkAllProductionStatus";
            this.chkAllProductionStatus.Size = new System.Drawing.Size(63, 23);
            this.chkAllProductionStatus.TabIndex = 9;
            this.chkAllProductionStatus.TabStop = true;
            this.chkAllProductionStatus.Text = "Tất cả";
            this.chkAllProductionStatus.UseVisualStyleBackColor = false;
            // 
            // chkNone
            // 
            this.chkNone.AutoSize = true;
            this.chkNone.BackColor = System.Drawing.Color.Transparent;
            this.chkNone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkNone.Location = new System.Drawing.Point(74, 18);
            this.chkNone.Name = "chkNone";
            this.chkNone.Size = new System.Drawing.Size(91, 23);
            this.chkNone.TabIndex = 6;
            this.chkNone.Text = "Chưa xử lý";
            this.chkNone.UseVisualStyleBackColor = false;
            // 
            // chkInProgress
            // 
            this.chkInProgress.AutoSize = true;
            this.chkInProgress.BackColor = System.Drawing.Color.Transparent;
            this.chkInProgress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkInProgress.Location = new System.Drawing.Point(171, 18);
            this.chkInProgress.Name = "chkInProgress";
            this.chkInProgress.Size = new System.Drawing.Size(92, 23);
            this.chkInProgress.TabIndex = 7;
            this.chkInProgress.Text = "Đang xử lý";
            this.chkInProgress.UseVisualStyleBackColor = false;
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.BackColor = System.Drawing.Color.Transparent;
            this.chkCompleted.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkCompleted.Location = new System.Drawing.Point(275, 18);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(78, 23);
            this.chkCompleted.TabIndex = 10;
            this.chkCompleted.Text = "Đã xong";
            this.chkCompleted.UseVisualStyleBackColor = false;
            // 
            // chkHold
            // 
            this.chkHold.AutoSize = true;
            this.chkHold.BackColor = System.Drawing.Color.Transparent;
            this.chkHold.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkHold.Location = new System.Drawing.Point(365, 18);
            this.chkHold.Name = "chkHold";
            this.chkHold.Size = new System.Drawing.Size(73, 23);
            this.chkHold.TabIndex = 11;
            this.chkHold.Text = "Bảo lưu";
            this.chkHold.UseVisualStyleBackColor = false;
            // 
            // frmScanBarcode
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1290, 468);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmScanBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử sản xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmScanBarcode_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel radPanel1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnScanBarcode;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl dgvDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn WorkOrder;
        private DevExpress.XtraGrid.Columns.GridColumn ExpectedDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn PartNo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton chkUsing;
        private System.Windows.Forms.RadioButton chkNoUse;
        private System.Windows.Forms.RadioButton chkAllStatus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Model;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn ProductionStatus;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton chkCompleted;
        private System.Windows.Forms.RadioButton chkHold;
        private System.Windows.Forms.RadioButton chkAllProductionStatus;
        private System.Windows.Forms.RadioButton chkNone;
        private System.Windows.Forms.RadioButton chkInProgress;
    }
}