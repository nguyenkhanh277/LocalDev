namespace LocalDev.View.RegistBarcodes
{
    partial class frmRegistBarcodeAddEdit
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtpRegistDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbbPartNumber = new System.Windows.Forms.ComboBox();
            this.cbbMachine = new System.Windows.Forms.ComboBox();
            this.cbbShift = new System.Windows.Forms.ComboBox();
            this.cbbMold = new System.Windows.Forms.ComboBox();
            this.txtSEQ = new DevExpress.XtraEditors.LabelControl();
            this.txtBarcode = new DevExpress.XtraEditors.LabelControl();
            this.btnAddPartNumber = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.btnMold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(265, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(154)))), ((int)(((byte)(242)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(139, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu và in (F1)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "PartNumber";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 192);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mã khuôn";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(45, 251);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 19);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Mã vạch";
            // 
            // dtpRegistDate
            // 
            this.dtpRegistDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpRegistDate.Enabled = false;
            this.dtpRegistDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpRegistDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegistDate.Location = new System.Drawing.Point(45, 99);
            this.dtpRegistDate.Name = "dtpRegistDate";
            this.dtpRegistDate.Size = new System.Drawing.Size(295, 27);
            this.dtpRegistDate.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 74);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngày đăng ký";
            // 
            // lblCa
            // 
            this.lblCa.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCa.Appearance.Options.UseFont = true;
            this.lblCa.Location = new System.Drawing.Point(206, 133);
            this.lblCa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(36, 17);
            this.lblCa.TabIndex = 6;
            this.lblCa.Text = "Mã ca";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 133);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 17);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Mã máy";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(206, 192);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "SEQ";
            // 
            // cbbPartNumber
            // 
            this.cbbPartNumber.DisplayMember = "PartNo";
            this.cbbPartNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPartNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbPartNumber.FormattingEnabled = true;
            this.cbbPartNumber.Location = new System.Drawing.Point(45, 39);
            this.cbbPartNumber.Name = "cbbPartNumber";
            this.cbbPartNumber.Size = new System.Drawing.Size(261, 28);
            this.cbbPartNumber.TabIndex = 1;
            this.cbbPartNumber.ValueMember = "Id";
            this.cbbPartNumber.SelectedIndexChanged += new System.EventHandler(this.cbbPartNumber_SelectedIndexChanged);
            // 
            // cbbMachine
            // 
            this.cbbMachine.DisplayMember = "MachineNo";
            this.cbbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMachine.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbMachine.FormattingEnabled = true;
            this.cbbMachine.Location = new System.Drawing.Point(45, 157);
            this.cbbMachine.Name = "cbbMachine";
            this.cbbMachine.Size = new System.Drawing.Size(100, 28);
            this.cbbMachine.TabIndex = 5;
            this.cbbMachine.ValueMember = "Id";
            this.cbbMachine.SelectedIndexChanged += new System.EventHandler(this.cbbMachine_SelectedIndexChanged);
            // 
            // cbbShift
            // 
            this.cbbShift.DisplayMember = "ShiftNo";
            this.cbbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShift.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbShift.FormattingEnabled = true;
            this.cbbShift.Location = new System.Drawing.Point(206, 157);
            this.cbbShift.Name = "cbbShift";
            this.cbbShift.Size = new System.Drawing.Size(100, 28);
            this.cbbShift.TabIndex = 7;
            this.cbbShift.ValueMember = "Id";
            this.cbbShift.SelectedIndexChanged += new System.EventHandler(this.cbbShift_SelectedIndexChanged);
            // 
            // cbbMold
            // 
            this.cbbMold.DisplayMember = "MoldNo";
            this.cbbMold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMold.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbMold.FormattingEnabled = true;
            this.cbbMold.Location = new System.Drawing.Point(45, 216);
            this.cbbMold.Name = "cbbMold";
            this.cbbMold.Size = new System.Drawing.Size(100, 28);
            this.cbbMold.TabIndex = 9;
            this.cbbMold.ValueMember = "Id";
            this.cbbMold.SelectedIndexChanged += new System.EventHandler(this.cbbMold_SelectedIndexChanged);
            // 
            // txtSEQ
            // 
            this.txtSEQ.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSEQ.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSEQ.Appearance.Options.UseBackColor = true;
            this.txtSEQ.Appearance.Options.UseFont = true;
            this.txtSEQ.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtSEQ.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSEQ.Location = new System.Drawing.Point(206, 215);
            this.txtSEQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSEQ.Name = "txtSEQ";
            this.txtSEQ.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtSEQ.Size = new System.Drawing.Size(134, 30);
            this.txtSEQ.TabIndex = 11;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtBarcode.Appearance.Options.UseBackColor = true;
            this.txtBarcode.Appearance.Options.UseFont = true;
            this.txtBarcode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtBarcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtBarcode.Location = new System.Drawing.Point(45, 278);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtBarcode.Size = new System.Drawing.Size(300, 30);
            this.txtBarcode.TabIndex = 13;
            // 
            // btnAddPartNumber
            // 
            this.btnAddPartNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddPartNumber.BackgroundImage = global::LocalDev.Properties.Resources.Add;
            this.btnAddPartNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPartNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartNumber.Location = new System.Drawing.Point(312, 39);
            this.btnAddPartNumber.Name = "btnAddPartNumber";
            this.btnAddPartNumber.Size = new System.Drawing.Size(28, 28);
            this.btnAddPartNumber.TabIndex = 16;
            this.btnAddPartNumber.UseVisualStyleBackColor = false;
            this.btnAddPartNumber.Click += new System.EventHandler(this.btnAddPartNumber_Click);
            // 
            // btnShift
            // 
            this.btnShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShift.BackgroundImage = global::LocalDev.Properties.Resources.Add;
            this.btnShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShift.Location = new System.Drawing.Point(312, 157);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(28, 28);
            this.btnShift.TabIndex = 17;
            this.btnShift.UseVisualStyleBackColor = false;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddMachine.BackgroundImage = global::LocalDev.Properties.Resources.Add;
            this.btnAddMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMachine.Location = new System.Drawing.Point(151, 157);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(28, 28);
            this.btnAddMachine.TabIndex = 18;
            this.btnAddMachine.UseVisualStyleBackColor = false;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // btnMold
            // 
            this.btnMold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMold.BackgroundImage = global::LocalDev.Properties.Resources.Add;
            this.btnMold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMold.Location = new System.Drawing.Point(151, 216);
            this.btnMold.Name = "btnMold";
            this.btnMold.Size = new System.Drawing.Size(28, 28);
            this.btnMold.TabIndex = 19;
            this.btnMold.UseVisualStyleBackColor = false;
            this.btnMold.Click += new System.EventHandler(this.btnMold_Click);
            // 
            // frmRegistBarcodeAddEdit
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(390, 368);
            this.Controls.Add(this.btnMold);
            this.Controls.Add(this.btnAddMachine);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.btnAddPartNumber);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtSEQ);
            this.Controls.Add(this.cbbMold);
            this.Controls.Add(this.cbbShift);
            this.Controls.Add(this.cbbMachine);
            this.Controls.Add(this.cbbPartNumber);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblCa);
            this.Controls.Add(this.dtpRegistDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmRegistBarcodeAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký in mã vạch";
            this.Load += new System.EventHandler(this.frmRegistBarcodeAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DateTimePicker dtpRegistDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblCa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbbPartNumber;
        private System.Windows.Forms.ComboBox cbbMachine;
        private System.Windows.Forms.ComboBox cbbShift;
        private System.Windows.Forms.ComboBox cbbMold;
        private DevExpress.XtraEditors.LabelControl txtSEQ;
        private DevExpress.XtraEditors.LabelControl txtBarcode;
        private System.Windows.Forms.Button btnAddPartNumber;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.Button btnMold;
    }
}