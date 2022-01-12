
namespace Doan.View.Export
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.txtTotal = new MaterialSurface.MaterialTextfield();
            this.txtQuantity = new MaterialSurface.MaterialTextfield();
            this.txtProductName = new MaterialSurface.MaterialTextfield();
            this.txtExportPrice = new MaterialSurface.MaterialTextfield();
            this.txtProductId = new MaterialSurface.MaterialTextfield();
            this.txtReason = new MaterialSurface.MaterialTextfield();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dtgvData = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dtgvProduct = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnDelete = new MaterialSurface.OutlinedButton();
            this.btnEdit = new MaterialSurface.OutlinedButton();
            this.btnAdd = new MaterialSurface.OutlinedButton();
            this.btnCancel = new MaterialSurface.OutlinedButton();
            this.btnCreate = new MaterialSurface.OutlinedButton();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.AutoScaleColor = true;
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.CountText = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.FieldType = MaterialSurface.BoxType.Normal;
            this.txtTotal.FloatingLabelText = "";
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotal.HandleError = false;
            this.txtTotal.HelperText = "";
            this.txtTotal.HideSelection = true;
            this.txtTotal.HintText = "Price";
            this.txtTotal.Location = new System.Drawing.Point(1091, 240);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSurface.MouseState.OUT;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtTotal.ReadOnly = false;
            this.txtTotal.ShortcutsEnable = true;
            this.txtTotal.ShowCaret = true;
            this.txtTotal.Size = new System.Drawing.Size(184, 49);
            this.txtTotal.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtTotal.TabIndex = 41;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoScaleColor = true;
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.CountText = false;
            this.txtQuantity.FieldType = MaterialSurface.BoxType.Normal;
            this.txtQuantity.FloatingLabelText = "";
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.HandleError = false;
            this.txtQuantity.HelperText = "";
            this.txtQuantity.HideSelection = true;
            this.txtQuantity.HintText = "Quantity";
            this.txtQuantity.Location = new System.Drawing.Point(902, 240);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.MouseState = MaterialSurface.MouseState.OUT;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.ShortcutsEnable = true;
            this.txtQuantity.ShowCaret = true;
            this.txtQuantity.Size = new System.Drawing.Size(184, 49);
            this.txtQuantity.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtQuantity.TabIndex = 40;
            this.txtQuantity.UseSystemPasswordChar = false;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.AutoScaleColor = true;
            this.txtProductName.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductName.CountText = false;
            this.txtProductName.FieldType = MaterialSurface.BoxType.Normal;
            this.txtProductName.FloatingLabelText = "";
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtProductName.HandleError = false;
            this.txtProductName.HelperText = "";
            this.txtProductName.HideSelection = true;
            this.txtProductName.HintText = "Product Name";
            this.txtProductName.Location = new System.Drawing.Point(902, 84);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.MouseState = MaterialSurface.MouseState.OUT;
            this.txtProductName.Multiline = false;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtProductName.ReadOnly = false;
            this.txtProductName.ShortcutsEnable = true;
            this.txtProductName.ShowCaret = true;
            this.txtProductName.Size = new System.Drawing.Size(373, 49);
            this.txtProductName.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtProductName.TabIndex = 38;
            this.txtProductName.UseSystemPasswordChar = false;
            // 
            // txtExportPrice
            // 
            this.txtExportPrice.AutoScaleColor = true;
            this.txtExportPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtExportPrice.CountText = false;
            this.txtExportPrice.Enabled = false;
            this.txtExportPrice.FieldType = MaterialSurface.BoxType.Normal;
            this.txtExportPrice.FloatingLabelText = "";
            this.txtExportPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtExportPrice.HandleError = false;
            this.txtExportPrice.HelperText = "";
            this.txtExportPrice.HideSelection = true;
            this.txtExportPrice.HintText = "Unit Price";
            this.txtExportPrice.Location = new System.Drawing.Point(902, 169);
            this.txtExportPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExportPrice.MaxLength = 32767;
            this.txtExportPrice.MouseState = MaterialSurface.MouseState.OUT;
            this.txtExportPrice.Multiline = false;
            this.txtExportPrice.Name = "txtExportPrice";
            this.txtExportPrice.PasswordChar = '\0';
            this.txtExportPrice.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtExportPrice.ReadOnly = false;
            this.txtExportPrice.ShortcutsEnable = true;
            this.txtExportPrice.ShowCaret = true;
            this.txtExportPrice.Size = new System.Drawing.Size(373, 49);
            this.txtExportPrice.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtExportPrice.TabIndex = 37;
            this.txtExportPrice.UseSystemPasswordChar = false;
            // 
            // txtProductId
            // 
            this.txtProductId.AutoScaleColor = true;
            this.txtProductId.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductId.CountText = false;
            this.txtProductId.Enabled = false;
            this.txtProductId.FieldType = MaterialSurface.BoxType.Normal;
            this.txtProductId.FloatingLabelText = "";
            this.txtProductId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtProductId.HandleError = false;
            this.txtProductId.HelperText = "";
            this.txtProductId.HideSelection = true;
            this.txtProductId.HintText = "Product ID";
            this.txtProductId.Location = new System.Drawing.Point(902, 12);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductId.MaxLength = 32767;
            this.txtProductId.MouseState = MaterialSurface.MouseState.OUT;
            this.txtProductId.Multiline = false;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.PasswordChar = '\0';
            this.txtProductId.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtProductId.ReadOnly = true;
            this.txtProductId.ShortcutsEnable = true;
            this.txtProductId.ShowCaret = true;
            this.txtProductId.Size = new System.Drawing.Size(373, 49);
            this.txtProductId.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtProductId.TabIndex = 36;
            this.txtProductId.UseSystemPasswordChar = false;
            // 
            // txtReason
            // 
            this.txtReason.AutoScaleColor = true;
            this.txtReason.BackColor = System.Drawing.SystemColors.Control;
            this.txtReason.CountText = false;
            this.txtReason.FieldType = MaterialSurface.BoxType.Normal;
            this.txtReason.FloatingLabelText = "";
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtReason.HandleError = false;
            this.txtReason.HelperText = "";
            this.txtReason.HideSelection = true;
            this.txtReason.HintText = "Export Reason";
            this.txtReason.Location = new System.Drawing.Point(909, 497);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReason.MaxLength = 32767;
            this.txtReason.MouseState = MaterialSurface.MouseState.OUT;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.PasswordChar = '\0';
            this.txtReason.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtReason.ReadOnly = false;
            this.txtReason.ShortcutsEnable = true;
            this.txtReason.ShowCaret = true;
            this.txtReason.Size = new System.Drawing.Size(383, 97);
            this.txtReason.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtReason.TabIndex = 51;
            this.txtReason.UseSystemPasswordChar = false;
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox2.BorderRadius = 4;
            this.bunifuGroupBox2.BorderThickness = 2;
            this.bunifuGroupBox2.Controls.Add(this.dtgvData);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(15, 12);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(819, 240);
            this.bunifuGroupBox2.TabIndex = 52;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = " Export Form   ";
            // 
            // dtgvData
            // 
            this.dtgvData.AllowCustomTheming = true;
            this.dtgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dtgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvData.ColumnHeadersHeight = 40;
            this.dtgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.Quan,
            this.TotalPrice});
            this.dtgvData.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvData.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvData.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvData.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dtgvData.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvData.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.dtgvData.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dtgvData.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dtgvData.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvData.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvData.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.dtgvData.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvData.CurrentTheme.Name = null;
            this.dtgvData.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.dtgvData.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvData.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvData.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dtgvData.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvData.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvData.EnableHeadersVisualStyles = false;
            this.dtgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dtgvData.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.dtgvData.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvData.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvData.Location = new System.Drawing.Point(3, 27);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.ReadOnly = true;
            this.dtgvData.RowHeadersVisible = false;
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.RowTemplate.Height = 40;
            this.dtgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvData.Size = new System.Drawing.Size(813, 210);
            this.dtgvData.TabIndex = 1;
            this.dtgvData.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgvData.DoubleClick += new System.EventHandler(this.dtgvData_DoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Quan
            // 
            this.Quan.HeaderText = "Quantities";
            this.Quan.MinimumWidth = 6;
            this.Quan.Name = "Quan";
            this.Quan.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.BorderRadius = 4;
            this.bunifuGroupBox1.BorderThickness = 2;
            this.bunifuGroupBox1.Controls.Add(this.dtgvProduct);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(12, 321);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(819, 408);
            this.bunifuGroupBox1.TabIndex = 53;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = " Product Table ";
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AllowCustomTheming = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dtgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvProduct.ColumnHeadersHeight = 40;
            this.dtgvProduct.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvProduct.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvProduct.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvProduct.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dtgvProduct.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvProduct.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.dtgvProduct.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dtgvProduct.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dtgvProduct.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvProduct.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvProduct.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.dtgvProduct.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvProduct.CurrentTheme.Name = null;
            this.dtgvProduct.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.dtgvProduct.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvProduct.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvProduct.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dtgvProduct.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProduct.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProduct.EnableHeadersVisualStyles = false;
            this.dtgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dtgvProduct.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.dtgvProduct.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvProduct.Location = new System.Drawing.Point(3, 27);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.ReadOnly = true;
            this.dtgvProduct.RowHeadersVisible = false;
            this.dtgvProduct.RowHeadersWidth = 51;
            this.dtgvProduct.RowTemplate.Height = 40;
            this.dtgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProduct.Size = new System.Drawing.Size(813, 378);
            this.dtgvProduct.TabIndex = 1;
            this.dtgvProduct.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgvProduct.DoubleClick += new System.EventHandler(this.dtgvProduct_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = global::Doan.Properties.Resources.search__1_;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(15, 267);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties8;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search product by ID, name";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(517, 44);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 55;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Search product by ID, name";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChange += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Icon = ((System.Drawing.Image)(resources.GetObject("btnDelete.Icon")));
            this.btnDelete.Location = new System.Drawing.Point(912, 422);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10);
            this.btnDelete.PrimaryColor = System.Drawing.Color.Red;
            this.btnDelete.Radius = 6;
            this.btnDelete.Size = new System.Drawing.Size(174, 64);
            this.btnDelete.TabIndex = 61;
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
            this.btnEdit.Location = new System.Drawing.Point(1101, 336);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(10);
            this.btnEdit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10);
            this.btnEdit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.btnEdit.Radius = 6;
            this.btnEdit.Size = new System.Drawing.Size(174, 64);
            this.btnEdit.TabIndex = 60;
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
            this.btnAdd.Location = new System.Drawing.Point(912, 336);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.Green;
            this.btnAdd.Radius = 6;
            this.btnAdd.Size = new System.Drawing.Size(174, 64);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.EffectType = MaterialSurface.ET.Custom;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Icon = global::Doan.Properties.Resources.cancel_icon;
            this.btnCancel.Location = new System.Drawing.Point(1101, 422);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.MouseState = MaterialSurface.MouseState.OUT;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PrimaryColor = System.Drawing.Color.Crimson;
            this.btnCancel.Radius = 6;
            this.btnCancel.Size = new System.Drawing.Size(174, 64);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BorderColor = System.Drawing.Color.DimGray;
            this.btnCreate.EffectType = MaterialSurface.ET.Custom;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCreate.Icon = global::Doan.Properties.Resources.icons8_create_order_48;
            this.btnCreate.Location = new System.Drawing.Point(955, 666);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.MouseState = MaterialSurface.MouseState.OUT;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.PrimaryColor = System.Drawing.Color.DarkCyan;
            this.btnCreate.Radius = 6;
            this.btnCreate.Size = new System.Drawing.Size(267, 64);
            this.btnCreate.TabIndex = 62;
            this.btnCreate.Text = "Create Form";
            this.btnCreate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(991, 610);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(66, 25);
            this.lbTotal.TabIndex = 63;
            this.lbTotal.Text = "0 VND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(920, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Total: ";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.bunifuGroupBox2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtExportPrice);
            this.Controls.Add(this.txtProductId);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.bunifuGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSurface.MaterialTextfield txtTotal;
        private MaterialSurface.MaterialTextfield txtQuantity;
        private MaterialSurface.MaterialTextfield txtProductName;
        private MaterialSurface.MaterialTextfield txtExportPrice;
        private MaterialSurface.MaterialTextfield txtProductId;
        private MaterialSurface.MaterialTextfield txtReason;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvData;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvProduct;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private MaterialSurface.OutlinedButton btnDelete;
        private MaterialSurface.OutlinedButton btnEdit;
        private MaterialSurface.OutlinedButton btnAdd;
        private MaterialSurface.OutlinedButton btnCancel;
        private MaterialSurface.OutlinedButton btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
    }
}