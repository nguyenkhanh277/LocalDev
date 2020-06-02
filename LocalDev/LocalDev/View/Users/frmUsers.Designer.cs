namespace LocalDev.View.Users
{
    partial class frmUsers
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chkAllGender = new System.Windows.Forms.RadioButton();
            this.chkFemale = new System.Windows.Forms.RadioButton();
            this.chkMale = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkAllStatus = new System.Windows.Forms.RadioButton();
            this.chkUsing = new System.Windows.Forms.RadioButton();
            this.chkNoUse = new System.Windows.Forms.RadioButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDuLieu = new DevExpress.XtraGrid.GridControl();
            this.viewDuLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnProgram = new DevExpress.XtraEditors.SimpleButton();
            this.btnAuthority = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.chkAllGender);
            this.groupControl2.Controls.Add(this.chkFemale);
            this.groupControl2.Controls.Add(this.chkMale);
            this.groupControl2.Location = new System.Drawing.Point(648, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 40);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Gender";
            // 
            // chkAllGender
            // 
            this.chkAllGender.AutoSize = true;
            this.chkAllGender.BackColor = System.Drawing.Color.Transparent;
            this.chkAllGender.Checked = true;
            this.chkAllGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAllGender.Location = new System.Drawing.Point(10, 18);
            this.chkAllGender.Name = "chkAllGender";
            this.chkAllGender.Size = new System.Drawing.Size(42, 23);
            this.chkAllGender.TabIndex = 8;
            this.chkAllGender.TabStop = true;
            this.chkAllGender.Text = "All";
            this.chkAllGender.UseVisualStyleBackColor = false;
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.BackColor = System.Drawing.Color.Transparent;
            this.chkFemale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkFemale.Location = new System.Drawing.Point(121, 18);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(70, 23);
            this.chkFemale.TabIndex = 6;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = false;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.BackColor = System.Drawing.Color.Transparent;
            this.chkMale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkMale.Location = new System.Drawing.Point(58, 18);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(57, 23);
            this.chkMale.TabIndex = 7;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = false;
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
            this.groupControl1.Size = new System.Drawing.Size(200, 40);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Status";
            // 
            // chkAllStatus
            // 
            this.chkAllStatus.AutoSize = true;
            this.chkAllStatus.BackColor = System.Drawing.Color.Transparent;
            this.chkAllStatus.Checked = true;
            this.chkAllStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAllStatus.Location = new System.Drawing.Point(5, 18);
            this.chkAllStatus.Name = "chkAllStatus";
            this.chkAllStatus.Size = new System.Drawing.Size(42, 23);
            this.chkAllStatus.TabIndex = 9;
            this.chkAllStatus.TabStop = true;
            this.chkAllStatus.Text = "All";
            this.chkAllStatus.UseVisualStyleBackColor = false;
            // 
            // chkUsing
            // 
            this.chkUsing.AutoSize = true;
            this.chkUsing.BackColor = System.Drawing.Color.Transparent;
            this.chkUsing.Checked = true;
            this.chkUsing.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkUsing.Location = new System.Drawing.Point(53, 18);
            this.chkUsing.Name = "chkUsing";
            this.chkUsing.Size = new System.Drawing.Size(62, 23);
            this.chkUsing.TabIndex = 6;
            this.chkUsing.TabStop = true;
            this.chkUsing.Text = "Using";
            this.chkUsing.UseVisualStyleBackColor = false;
            // 
            // chkNoUse
            // 
            this.chkNoUse.AutoSize = true;
            this.chkNoUse.BackColor = System.Drawing.Color.Transparent;
            this.chkNoUse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkNoUse.Location = new System.Drawing.Point(121, 18);
            this.chkNoUse.Name = "chkNoUse";
            this.chkNoUse.Size = new System.Drawing.Size(72, 23);
            this.chkNoUse.TabIndex = 7;
            this.chkNoUse.Text = "No Use";
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
            this.btnExcel.Text = "Excel\r\n(F4)";
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
            this.btnRefresh.Text = "Refresh\r\n(F5)";
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
            this.btnClose.Text = "Close\r\n(ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(184, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete\r\n(F3)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(98, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit\r\n(F2)";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(12, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add\r\n(F1)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Username,
            this.FullName,
            this.Phone,
            this.Address,
            this.Gender,
            this.Note});
            this.viewDuLieu.DetailHeight = 284;
            this.viewDuLieu.GridControl = this.dgvDuLieu;
            this.viewDuLieu.IndicatorWidth = 40;
            this.viewDuLieu.Name = "viewDuLieu";
            this.viewDuLieu.OptionsBehavior.Editable = false;
            this.viewDuLieu.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.viewDuLieu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.viewDuLieu.OptionsView.ShowAutoFilterRow = true;
            this.viewDuLieu.OptionsView.ShowGroupPanel = false;
            this.viewDuLieu.RowHeight = 40;
            this.viewDuLieu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewDuLieu_CustomDrawRowIndicator);
            this.viewDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDuLieu_KeyDown);
            this.viewDuLieu.DoubleClick += new System.EventHandler(this.btnEdit_Click);
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
            // Username
            // 
            this.Username.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Username.AppearanceCell.Options.UseFont = true;
            this.Username.AppearanceCell.Options.UseTextOptions = true;
            this.Username.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Username.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Username.AppearanceHeader.Options.UseFont = true;
            this.Username.AppearanceHeader.Options.UseTextOptions = true;
            this.Username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Username.Caption = "Username";
            this.Username.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Username.FieldName = "Username";
            this.Username.MaxWidth = 100;
            this.Username.MinWidth = 100;
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 0;
            this.Username.Width = 100;
            // 
            // FullName
            // 
            this.FullName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FullName.AppearanceCell.Options.UseFont = true;
            this.FullName.AppearanceCell.Options.UseTextOptions = true;
            this.FullName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FullName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.FullName.AppearanceHeader.Options.UseFont = true;
            this.FullName.AppearanceHeader.Options.UseTextOptions = true;
            this.FullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FullName.Caption = "FullName";
            this.FullName.ColumnEdit = this.repositoryItemMemoEdit1;
            this.FullName.FieldName = "FullName";
            this.FullName.MaxWidth = 100;
            this.FullName.MinWidth = 100;
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            this.FullName.Width = 100;
            // 
            // Phone
            // 
            this.Phone.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Phone.AppearanceCell.Options.UseFont = true;
            this.Phone.AppearanceCell.Options.UseTextOptions = true;
            this.Phone.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Phone.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Phone.AppearanceHeader.Options.UseFont = true;
            this.Phone.AppearanceHeader.Options.UseTextOptions = true;
            this.Phone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Phone.Caption = "Phone";
            this.Phone.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Phone.FieldName = "Phone";
            this.Phone.MaxWidth = 100;
            this.Phone.MinWidth = 100;
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 2;
            this.Phone.Width = 100;
            // 
            // Address
            // 
            this.Address.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Address.AppearanceCell.Options.UseFont = true;
            this.Address.AppearanceCell.Options.UseTextOptions = true;
            this.Address.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Address.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Address.AppearanceHeader.Options.UseFont = true;
            this.Address.AppearanceHeader.Options.UseTextOptions = true;
            this.Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Address.Caption = "Address";
            this.Address.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Address.FieldName = "Address";
            this.Address.MaxWidth = 200;
            this.Address.MinWidth = 200;
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 3;
            this.Address.Width = 200;
            // 
            // Gender
            // 
            this.Gender.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Gender.AppearanceCell.Options.UseFont = true;
            this.Gender.AppearanceCell.Options.UseTextOptions = true;
            this.Gender.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Gender.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Gender.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Gender.AppearanceHeader.Options.UseFont = true;
            this.Gender.AppearanceHeader.Options.UseTextOptions = true;
            this.Gender.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Gender.Caption = "Gender";
            this.Gender.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Gender.FieldName = "Gender";
            this.Gender.MaxWidth = 60;
            this.Gender.MinWidth = 60;
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 4;
            this.Gender.Width = 60;
            // 
            // Note
            // 
            this.Note.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Note.AppearanceCell.Options.UseFont = true;
            this.Note.AppearanceCell.Options.UseTextOptions = true;
            this.Note.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Note.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Note.AppearanceHeader.Options.UseFont = true;
            this.Note.AppearanceHeader.Options.UseTextOptions = true;
            this.Note.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Note.Caption = "Note";
            this.Note.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Note.FieldName = "Note";
            this.Note.MinWidth = 100;
            this.Note.Name = "Note";
            this.Note.Visible = true;
            this.Note.VisibleIndex = 5;
            this.Note.Width = 100;
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
            this.panelControl1.Controls.Add(this.btnProgram);
            this.panelControl1.Controls.Add(this.btnAuthority);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1290, 50);
            this.panelControl1.TabIndex = 5;
            // 
            // btnProgram
            // 
            this.btnProgram.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProgram.Appearance.Options.UseFont = true;
            this.btnProgram.Location = new System.Drawing.Point(940, 5);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(80, 40);
            this.btnProgram.TabIndex = 11;
            this.btnProgram.Text = "Program\r\n(F7)";
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // btnAuthority
            // 
            this.btnAuthority.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAuthority.Appearance.Options.UseFont = true;
            this.btnAuthority.Location = new System.Drawing.Point(854, 5);
            this.btnAuthority.Name = "btnAuthority";
            this.btnAuthority.Size = new System.Drawing.Size(80, 40);
            this.btnAuthority.TabIndex = 10;
            this.btnAuthority.Text = "Authority\r\n(F6)";
            this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
            // 
            // frmUsers
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1290, 468);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
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
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl dgvDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton chkUsing;
        private System.Windows.Forms.RadioButton chkNoUse;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton chkFemale;
        private System.Windows.Forms.RadioButton chkMale;
        private System.Windows.Forms.RadioButton chkAllGender;
        private System.Windows.Forms.RadioButton chkAllStatus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnProgram;
        private DevExpress.XtraEditors.SimpleButton btnAuthority;
    }
}