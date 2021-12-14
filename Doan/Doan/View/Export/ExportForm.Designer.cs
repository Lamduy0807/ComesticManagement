
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
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.txtSearch = new MaterialSurface.MaterialTextfield();
            this.btnCancel = new MaterialSurface.OutlinedButton();
            this.btnExport = new MaterialSurface.OutlinedButton();
            this.btnCreate = new MaterialSurface.OutlinedButton();
            this.btnDelete = new MaterialSurface.OutlinedButton();
            this.btnEdit = new MaterialSurface.OutlinedButton();
            this.btnAdd = new MaterialSurface.OutlinedButton();
            this.txtTotal = new MaterialSurface.MaterialTextfield();
            this.txtQuantity = new MaterialSurface.MaterialTextfield();
            this.txtProductName = new MaterialSurface.MaterialTextfield();
            this.txtExportPrice = new MaterialSurface.MaterialTextfield();
            this.txtTotalPrice = new MaterialSurface.MaterialTextfield();
            this.txtProductId = new MaterialSurface.MaterialTextfield();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReason = new MaterialSurface.MaterialTextfield();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(29, 334);
            this.dtgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersWidth = 51;
            this.dtgvProduct.RowTemplate.Height = 24;
            this.dtgvProduct.Size = new System.Drawing.Size(819, 395);
            this.dtgvProduct.TabIndex = 50;
            this.dtgvProduct.DoubleClick += new System.EventHandler(this.dtgvProduct_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoScaleColor = true;
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.CountText = false;
            this.txtSearch.FieldType = MaterialSurface.BoxType.Normal;
            this.txtSearch.FloatingLabelText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.HandleError = false;
            this.txtSearch.HelperText = "";
            this.txtSearch.HideSelection = true;
            this.txtSearch.HintText = "Search";
            this.txtSearch.Location = new System.Drawing.Point(29, 267);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ShortcutsEnable = true;
            this.txtSearch.ShowCaret = true;
            this.txtSearch.Size = new System.Drawing.Size(373, 49);
            this.txtSearch.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSearch.TabIndex = 49;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.EffectType = MaterialSurface.ET.Custom;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Green;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(902, 665);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.MouseState = MaterialSurface.MouseState.OUT;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PrimaryColor = System.Drawing.Color.Green;
            this.btnCancel.Radius = 6;
            this.btnCancel.Size = new System.Drawing.Size(174, 64);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.BorderColor = System.Drawing.Color.DimGray;
            this.btnExport.EffectType = MaterialSurface.ET.Custom;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Green;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(1101, 665);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.MouseState = MaterialSurface.MouseState.OUT;
            this.btnExport.Name = "btnExport";
            this.btnExport.PrimaryColor = System.Drawing.Color.Green;
            this.btnExport.Radius = 6;
            this.btnExport.Size = new System.Drawing.Size(174, 64);
            this.btnExport.TabIndex = 47;
            this.btnExport.Text = "Export Form";
            this.btnExport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.BorderColor = System.Drawing.Color.DimGray;
            this.btnCreate.EffectType = MaterialSurface.ET.Custom;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Green;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(1101, 520);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.MouseState = MaterialSurface.MouseState.OUT;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.PrimaryColor = System.Drawing.Color.Green;
            this.btnCreate.Radius = 6;
            this.btnCreate.Size = new System.Drawing.Size(174, 64);
            this.btnCreate.TabIndex = 46;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(902, 520);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PrimaryColor = System.Drawing.Color.Green;
            this.btnDelete.Radius = 6;
            this.btnDelete.Size = new System.Drawing.Size(174, 64);
            this.btnDelete.TabIndex = 45;
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
            this.btnEdit.ForeColor = System.Drawing.Color.Green;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(1101, 433);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PrimaryColor = System.Drawing.Color.Green;
            this.btnEdit.Radius = 6;
            this.btnEdit.Size = new System.Drawing.Size(174, 64);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.EffectType = MaterialSurface.ET.Custom;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(902, 433);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.Green;
            this.btnAdd.Radius = 6;
            this.btnAdd.Size = new System.Drawing.Size(174, 64);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtQuantity.Location = new System.Drawing.Point(901, 240);
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
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoScaleColor = true;
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalPrice.CountText = false;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.FieldType = MaterialSurface.BoxType.Normal;
            this.txtTotalPrice.FloatingLabelText = "";
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotalPrice.HandleError = false;
            this.txtTotalPrice.HelperText = "";
            this.txtTotalPrice.HideSelection = true;
            this.txtTotalPrice.HintText = "Total Price";
            this.txtTotalPrice.Location = new System.Drawing.Point(902, 588);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalPrice.MaxLength = 32767;
            this.txtTotalPrice.MouseState = MaterialSurface.MouseState.OUT;
            this.txtTotalPrice.Multiline = false;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtTotalPrice.ReadOnly = false;
            this.txtTotalPrice.ShortcutsEnable = true;
            this.txtTotalPrice.ShowCaret = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(373, 49);
            this.txtTotalPrice.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtTotalPrice.TabIndex = 39;
            this.txtTotalPrice.UseSystemPasswordChar = false;
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
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameProduct,
            this.Price,
            this.Quan,
            this.Totalprice});
            this.dtgvData.Location = new System.Drawing.Point(29, 12);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.RowTemplate.Height = 24;
            this.dtgvData.Size = new System.Drawing.Size(819, 239);
            this.dtgvData.TabIndex = 35;
            this.dtgvData.DoubleClick += new System.EventHandler(this.dtgvData_DoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Product Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Product Name";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Export Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quan
            // 
            this.Quan.HeaderText = "Quantities";
            this.Quan.MinimumWidth = 6;
            this.Quan.Name = "Quan";
            this.Quan.Width = 125;
            // 
            // Totalprice
            // 
            this.Totalprice.HeaderText = "Total Price";
            this.Totalprice.MinimumWidth = 6;
            this.Totalprice.Name = "Totalprice";
            this.Totalprice.Width = 125;
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
            this.txtReason.Location = new System.Drawing.Point(901, 318);
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
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.dtgvProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtExportPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.dtgvData);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvProduct;
        private MaterialSurface.MaterialTextfield txtSearch;
        private MaterialSurface.OutlinedButton btnCancel;
        private MaterialSurface.OutlinedButton btnExport;
        private MaterialSurface.OutlinedButton btnCreate;
        private MaterialSurface.OutlinedButton btnDelete;
        private MaterialSurface.OutlinedButton btnEdit;
        private MaterialSurface.OutlinedButton btnAdd;
        private MaterialSurface.MaterialTextfield txtTotal;
        private MaterialSurface.MaterialTextfield txtQuantity;
        private MaterialSurface.MaterialTextfield txtProductName;
        private MaterialSurface.MaterialTextfield txtExportPrice;
        private MaterialSurface.MaterialTextfield txtTotalPrice;
        private MaterialSurface.MaterialTextfield txtProductId;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalprice;
        private MaterialSurface.MaterialTextfield txtReason;
    }
}