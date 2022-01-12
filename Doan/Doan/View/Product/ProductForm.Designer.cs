
namespace Doan.View.Product
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.txtOriginal = new MaterialSurface.MaterialTextfield();
            this.txtProductName = new MaterialSurface.MaterialTextfield();
            this.cbProductType = new MaterialSurface.MaterialComboBox();
            this.txtDescription = new MaterialSurface.MaterialTextfield();
            this.txtPrice = new MaterialSurface.MaterialTextfield();
            this.txtProductId = new MaterialSurface.MaterialTextfield();
            this.cbUnit = new MaterialSurface.MaterialComboBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dtgvProduct = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnDelete = new MaterialSurface.OutlinedButton();
            this.btnEdit = new MaterialSurface.OutlinedButton();
            this.btnAdd = new MaterialSurface.OutlinedButton();
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOriginal
            // 
            this.txtOriginal.AutoScaleColor = true;
            this.txtOriginal.BackColor = System.Drawing.SystemColors.Control;
            this.txtOriginal.CountText = false;
            this.txtOriginal.FieldType = MaterialSurface.BoxType.Normal;
            this.txtOriginal.FloatingLabelText = "";
            this.txtOriginal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOriginal.HandleError = false;
            this.txtOriginal.HelperText = "";
            this.txtOriginal.HideSelection = true;
            this.txtOriginal.HintText = "Original";
            this.txtOriginal.Location = new System.Drawing.Point(560, 135);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOriginal.MaxLength = 32767;
            this.txtOriginal.MouseState = MaterialSurface.MouseState.OUT;
            this.txtOriginal.Multiline = false;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.PasswordChar = '\0';
            this.txtOriginal.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtOriginal.ReadOnly = false;
            this.txtOriginal.ShortcutsEnable = true;
            this.txtOriginal.ShowCaret = true;
            this.txtOriginal.Size = new System.Drawing.Size(382, 49);
            this.txtOriginal.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtOriginal.TabIndex = 22;
            this.txtOriginal.UseSystemPasswordChar = false;
            this.txtOriginal.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
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
            this.txtProductName.Location = new System.Drawing.Point(39, 82);
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
            this.txtProductName.TabIndex = 18;
            this.txtProductName.UseSystemPasswordChar = false;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // cbProductType
            // 
            this.cbProductType.AutoSizing = false;
            this.cbProductType.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbProductType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.DropDownWidth = 121;
            this.cbProductType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.HintText = "Product Type";
            this.cbProductType.ItemHeight = 47;
            this.cbProductType.Location = new System.Drawing.Point(560, 223);
            this.cbProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProductType.MaxDropDownItems = 4;
            this.cbProductType.MouseState = MaterialSurface.MouseState.OUT;
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.cbProductType.Size = new System.Drawing.Size(382, 53);
            this.cbProductType.TabIndex = 23;
            this.cbProductType.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.AutoScaleColor = true;
            this.txtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescription.CountText = false;
            this.txtDescription.FieldType = MaterialSurface.BoxType.Normal;
            this.txtDescription.FloatingLabelText = "";
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescription.HandleError = false;
            this.txtDescription.HelperText = "";
            this.txtDescription.HideSelection = true;
            this.txtDescription.HintText = "Description";
            this.txtDescription.Location = new System.Drawing.Point(550, 10);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = MaterialSurface.MouseState.OUT;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ShortcutsEnable = true;
            this.txtDescription.ShowCaret = true;
            this.txtDescription.Size = new System.Drawing.Size(392, 121);
            this.txtDescription.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtDescription.TabIndex = 21;
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoScaleColor = true;
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.CountText = false;
            this.txtPrice.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPrice.FloatingLabelText = "";
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrice.HandleError = false;
            this.txtPrice.HelperText = "";
            this.txtPrice.HideSelection = true;
            this.txtPrice.HintText = "Price";
            this.txtPrice.Location = new System.Drawing.Point(39, 153);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtPrice.ReadOnly = false;
            this.txtPrice.ShortcutsEnable = true;
            this.txtPrice.ShowCaret = true;
            this.txtPrice.Size = new System.Drawing.Size(373, 49);
            this.txtPrice.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPrice.TabIndex = 19;
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
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
            this.txtProductId.Location = new System.Drawing.Point(39, 10);
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
            this.txtProductId.TabIndex = 14;
            this.txtProductId.UseSystemPasswordChar = false;
            // 
            // cbUnit
            // 
            this.cbUnit.AutoSizing = false;
            this.cbUnit.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.DropDownWidth = 121;
            this.cbUnit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.HintText = "Unit";
            this.cbUnit.ItemHeight = 47;
            this.cbUnit.Items.AddRange(new object[] {
            "Bottle",
            "Tube",
            "Can"});
            this.cbUnit.Location = new System.Drawing.Point(39, 223);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUnit.MaxDropDownItems = 4;
            this.cbUnit.MouseState = MaterialSurface.MouseState.OUT;
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.cbUnit.Size = new System.Drawing.Size(373, 53);
            this.cbUnit.TabIndex = 20;
            this.cbUnit.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
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
            this.bunifuGroupBox1.Location = new System.Drawing.Point(39, 305);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(1238, 424);
            this.bunifuGroupBox1.TabIndex = 45;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Product Table ";
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AllowCustomTheming = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dtgvProduct.Size = new System.Drawing.Size(1232, 394);
            this.dtgvProduct.TabIndex = 1;
            this.dtgvProduct.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProduct_CellContentClick);
            this.dtgvProduct.DoubleClick += new System.EventHandler(this.dtgvProduct_DoubleClick);
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
            this.btnDelete.TabIndex = 60;
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
            this.btnEdit.TabIndex = 59;
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
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.cbUnit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSurface.MaterialTextfield txtOriginal;
        private MaterialSurface.MaterialTextfield txtProductName;
        private MaterialSurface.MaterialComboBox cbProductType;
        private MaterialSurface.MaterialTextfield txtDescription;
        private MaterialSurface.MaterialTextfield txtPrice;
        private MaterialSurface.MaterialTextfield txtProductId;
        private MaterialSurface.MaterialComboBox cbUnit;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvProduct;
        private MaterialSurface.OutlinedButton btnDelete;
        private MaterialSurface.OutlinedButton btnEdit;
        private MaterialSurface.OutlinedButton btnAdd;
    }
}