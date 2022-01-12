
namespace Doan.View.Suplier
{
    partial class SuplierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuplierForm));
            this.txtEmail = new MaterialSurface.MaterialTextfield();
            this.txtSuplierName = new MaterialSurface.MaterialTextfield();
            this.txtPhoneNumber = new MaterialSurface.MaterialTextfield();
            this.txtSuplierId = new MaterialSurface.MaterialTextfield();
            this.txtAddress = new MaterialSurface.MaterialTextfield();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dtgvPsuplier = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dtgvsuplier = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnDelete = new MaterialSurface.OutlinedButton();
            this.btnEdit = new MaterialSurface.OutlinedButton();
            this.btnAdd = new MaterialSurface.OutlinedButton();
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPsuplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsuplier)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.AutoScaleColor = true;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.CountText = false;
            this.txtEmail.FieldType = MaterialSurface.BoxType.Normal;
            this.txtEmail.FloatingLabelText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.HandleError = false;
            this.txtEmail.HelperText = "";
            this.txtEmail.HideSelection = true;
            this.txtEmail.HintText = "Email";
            this.txtEmail.Location = new System.Drawing.Point(47, 207);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSurface.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.ShortcutsEnable = true;
            this.txtEmail.ShowCaret = true;
            this.txtEmail.Size = new System.Drawing.Size(465, 49);
            this.txtEmail.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtEmail.TabIndex = 30;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtSuplierName_TextChanged);
            // 
            // txtSuplierName
            // 
            this.txtSuplierName.AutoScaleColor = true;
            this.txtSuplierName.BackColor = System.Drawing.SystemColors.Control;
            this.txtSuplierName.CountText = false;
            this.txtSuplierName.FieldType = MaterialSurface.BoxType.Normal;
            this.txtSuplierName.FloatingLabelText = "";
            this.txtSuplierName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSuplierName.HandleError = false;
            this.txtSuplierName.HelperText = "";
            this.txtSuplierName.HideSelection = true;
            this.txtSuplierName.HintText = "Suplier Name";
            this.txtSuplierName.Location = new System.Drawing.Point(47, 123);
            this.txtSuplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuplierName.MaxLength = 32767;
            this.txtSuplierName.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSuplierName.Multiline = false;
            this.txtSuplierName.Name = "txtSuplierName";
            this.txtSuplierName.PasswordChar = '\0';
            this.txtSuplierName.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtSuplierName.ReadOnly = false;
            this.txtSuplierName.ShortcutsEnable = true;
            this.txtSuplierName.ShowCaret = true;
            this.txtSuplierName.Size = new System.Drawing.Size(465, 49);
            this.txtSuplierName.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSuplierName.TabIndex = 29;
            this.txtSuplierName.UseSystemPasswordChar = false;
            this.txtSuplierName.TextChanged += new System.EventHandler(this.txtSuplierName_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoScaleColor = true;
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhoneNumber.CountText = false;
            this.txtPhoneNumber.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPhoneNumber.FloatingLabelText = "";
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhoneNumber.HandleError = false;
            this.txtPhoneNumber.HelperText = "";
            this.txtPhoneNumber.HideSelection = true;
            this.txtPhoneNumber.HintText = "Phone Number";
            this.txtPhoneNumber.Location = new System.Drawing.Point(542, 207);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtPhoneNumber.ReadOnly = false;
            this.txtPhoneNumber.ShortcutsEnable = true;
            this.txtPhoneNumber.ShowCaret = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(447, 49);
            this.txtPhoneNumber.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPhoneNumber.TabIndex = 32;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtSuplierName_TextChanged);
            // 
            // txtSuplierId
            // 
            this.txtSuplierId.AutoScaleColor = true;
            this.txtSuplierId.BackColor = System.Drawing.SystemColors.Control;
            this.txtSuplierId.CountText = false;
            this.txtSuplierId.Enabled = false;
            this.txtSuplierId.FieldType = MaterialSurface.BoxType.Normal;
            this.txtSuplierId.FloatingLabelText = "";
            this.txtSuplierId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSuplierId.HandleError = false;
            this.txtSuplierId.HelperText = "";
            this.txtSuplierId.HideSelection = true;
            this.txtSuplierId.HintText = "ID";
            this.txtSuplierId.Location = new System.Drawing.Point(47, 38);
            this.txtSuplierId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuplierId.MaxLength = 32767;
            this.txtSuplierId.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSuplierId.Multiline = false;
            this.txtSuplierId.Name = "txtSuplierId";
            this.txtSuplierId.PasswordChar = '\0';
            this.txtSuplierId.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtSuplierId.ReadOnly = true;
            this.txtSuplierId.ShortcutsEnable = true;
            this.txtSuplierId.ShowCaret = true;
            this.txtSuplierId.Size = new System.Drawing.Size(465, 49);
            this.txtSuplierId.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSuplierId.TabIndex = 27;
            this.txtSuplierId.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoScaleColor = true;
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.CountText = false;
            this.txtAddress.FieldType = MaterialSurface.BoxType.Normal;
            this.txtAddress.FloatingLabelText = "";
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.HandleError = false;
            this.txtAddress.HelperText = "";
            this.txtAddress.HideSelection = true;
            this.txtAddress.HintText = "Address";
            this.txtAddress.Location = new System.Drawing.Point(542, 54);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSurface.MouseState.OUT;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtAddress.ReadOnly = false;
            this.txtAddress.ShortcutsEnable = true;
            this.txtAddress.ShowCaret = true;
            this.txtAddress.Size = new System.Drawing.Size(447, 149);
            this.txtAddress.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtAddress.TabIndex = 31;
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtSuplierName_TextChanged);
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.BorderRadius = 4;
            this.bunifuGroupBox1.BorderThickness = 2;
            this.bunifuGroupBox1.Controls.Add(this.dtgvPsuplier);
            this.bunifuGroupBox1.Controls.Add(this.dtgvsuplier);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(47, 279);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(1235, 450);
            this.bunifuGroupBox1.TabIndex = 45;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = " Suppliers Table ";
            // 
            // dtgvPsuplier
            // 
            this.dtgvPsuplier.AllowCustomTheming = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dtgvPsuplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvPsuplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPsuplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPsuplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvPsuplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPsuplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvPsuplier.ColumnHeadersHeight = 40;
            this.dtgvPsuplier.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvPsuplier.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvPsuplier.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvPsuplier.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dtgvPsuplier.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvPsuplier.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.dtgvPsuplier.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dtgvPsuplier.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dtgvPsuplier.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvPsuplier.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvPsuplier.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.dtgvPsuplier.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvPsuplier.CurrentTheme.Name = null;
            this.dtgvPsuplier.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.dtgvPsuplier.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvPsuplier.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvPsuplier.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dtgvPsuplier.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPsuplier.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvPsuplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPsuplier.EnableHeadersVisualStyles = false;
            this.dtgvPsuplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dtgvPsuplier.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.dtgvPsuplier.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvPsuplier.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvPsuplier.Location = new System.Drawing.Point(3, 27);
            this.dtgvPsuplier.Name = "dtgvPsuplier";
            this.dtgvPsuplier.ReadOnly = true;
            this.dtgvPsuplier.RowHeadersVisible = false;
            this.dtgvPsuplier.RowHeadersWidth = 51;
            this.dtgvPsuplier.RowTemplate.Height = 40;
            this.dtgvPsuplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPsuplier.Size = new System.Drawing.Size(1229, 420);
            this.dtgvPsuplier.TabIndex = 61;
            this.dtgvPsuplier.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgvPsuplier.DoubleClick += new System.EventHandler(this.dtgvsuplier_DoubleClick);
            // 
            // dtgvsuplier
            // 
            this.dtgvsuplier.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dtgvsuplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvsuplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvsuplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvsuplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvsuplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvsuplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvsuplier.ColumnHeadersHeight = 40;
            this.dtgvsuplier.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgvsuplier.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvsuplier.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvsuplier.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvsuplier.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvsuplier.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgvsuplier.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvsuplier.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvsuplier.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvsuplier.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvsuplier.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgvsuplier.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvsuplier.CurrentTheme.Name = null;
            this.dtgvsuplier.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvsuplier.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvsuplier.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvsuplier.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgvsuplier.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvsuplier.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvsuplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvsuplier.EnableHeadersVisualStyles = false;
            this.dtgvsuplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgvsuplier.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgvsuplier.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvsuplier.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvsuplier.Location = new System.Drawing.Point(3, 27);
            this.dtgvsuplier.Name = "dtgvsuplier";
            this.dtgvsuplier.ReadOnly = true;
            this.dtgvsuplier.RowHeadersVisible = false;
            this.dtgvsuplier.RowHeadersWidth = 51;
            this.dtgvsuplier.RowTemplate.Height = 40;
            this.dtgvsuplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvsuplier.Size = new System.Drawing.Size(1229, 420);
            this.dtgvsuplier.TabIndex = 1;
            this.dtgvsuplier.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgvsuplier.DoubleClick += new System.EventHandler(this.dtgvsuplier_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Icon = ((System.Drawing.Image)(resources.GetObject("btnDelete.Icon")));
            this.btnDelete.Location = new System.Drawing.Point(1032, 192);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10);
            this.btnDelete.PrimaryColor = System.Drawing.Color.Red;
            this.btnDelete.Radius = 6;
            this.btnDelete.Size = new System.Drawing.Size(247, 64);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.DimGray;
            this.btnEdit.EffectType = MaterialSurface.ET.Custom;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.btnEdit.Icon = ((System.Drawing.Image)(resources.GetObject("btnEdit.Icon")));
            this.btnEdit.Location = new System.Drawing.Point(1032, 112);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(10);
            this.btnEdit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10);
            this.btnEdit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.btnEdit.Radius = 6;
            this.btnEdit.Size = new System.Drawing.Size(247, 64);
            this.btnEdit.TabIndex = 63;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.EffectType = MaterialSurface.ET.Custom;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Icon = ((System.Drawing.Image)(resources.GetObject("btnAdd.Icon")));
            this.btnAdd.Location = new System.Drawing.Point(1032, 38);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.Green;
            this.btnAdd.Radius = 6;
            this.btnAdd.Size = new System.Drawing.Size(247, 64);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SuplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSuplierName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuplierId);
            this.Name = "SuplierForm";
            this.Text = "SuplierForm";
            this.Load += new System.EventHandler(this.SuplierForm_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPsuplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsuplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSurface.MaterialTextfield txtEmail;
        private MaterialSurface.MaterialTextfield txtSuplierName;
        private MaterialSurface.MaterialTextfield txtPhoneNumber;
        private MaterialSurface.MaterialTextfield txtSuplierId;
        private MaterialSurface.MaterialTextfield txtAddress;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvsuplier;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvPsuplier;
        private MaterialSurface.OutlinedButton btnDelete;
        private MaterialSurface.OutlinedButton btnEdit;
        private MaterialSurface.OutlinedButton btnAdd;
    }
}