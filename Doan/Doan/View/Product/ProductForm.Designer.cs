
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.btnDelete = new MaterialSurface.OutlinedButton();
            this.btnEdit = new MaterialSurface.OutlinedButton();
            this.btnAdd = new MaterialSurface.OutlinedButton();
            this.txtOriginal = new MaterialSurface.MaterialTextfield();
            this.txtProductName = new MaterialSurface.MaterialTextfield();
            this.cbProductType = new MaterialSurface.MaterialComboBox();
            this.txtDescription = new MaterialSurface.MaterialTextfield();
            this.txtPrice = new MaterialSurface.MaterialTextfield();
            this.txtProductId = new MaterialSurface.MaterialTextfield();
            this.cbUnit = new MaterialSurface.MaterialComboBox();
            this.outlinedButton4 = new MaterialSurface.OutlinedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(39, 385);
            this.dtgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersWidth = 51;
            this.dtgvProduct.RowTemplate.Height = 24;
            this.dtgvProduct.Size = new System.Drawing.Size(1253, 354);
            this.dtgvProduct.TabIndex = 25;
            this.dtgvProduct.DoubleClick += new System.EventHandler(this.dtgvProduct_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(672, 297);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PrimaryColor = System.Drawing.Color.Green;
            this.btnDelete.Radius = 6;
            this.btnDelete.Size = new System.Drawing.Size(305, 64);
            this.btnDelete.TabIndex = 23;
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
            this.btnEdit.Location = new System.Drawing.Point(361, 297);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PrimaryColor = System.Drawing.Color.Green;
            this.btnEdit.Radius = 6;
            this.btnEdit.Size = new System.Drawing.Size(305, 64);
            this.btnEdit.TabIndex = 22;
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
            this.btnAdd.Location = new System.Drawing.Point(39, 297);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.Green;
            this.btnAdd.Radius = 6;
            this.btnAdd.Size = new System.Drawing.Size(305, 64);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtOriginal.Location = new System.Drawing.Point(521, 153);
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
            this.txtOriginal.Size = new System.Drawing.Size(364, 49);
            this.txtOriginal.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtOriginal.TabIndex = 19;
            this.txtOriginal.UseSystemPasswordChar = false;
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
            this.cbProductType.Location = new System.Drawing.Point(521, 223);
            this.cbProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProductType.MaxDropDownItems = 4;
            this.cbProductType.MouseState = MaterialSurface.MouseState.OUT;
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.cbProductType.Size = new System.Drawing.Size(363, 53);
            this.cbProductType.TabIndex = 17;
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
            this.txtDescription.Location = new System.Drawing.Point(521, 12);
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
            this.txtDescription.Size = new System.Drawing.Size(383, 121);
            this.txtDescription.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtDescription.TabIndex = 16;
            this.txtDescription.UseSystemPasswordChar = false;
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
            this.txtPrice.TabIndex = 15;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // txtProductId
            // 
            this.txtProductId.AutoScaleColor = true;
            this.txtProductId.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductId.CountText = false;
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
            "tube",
            "can"});
            this.cbUnit.Location = new System.Drawing.Point(39, 223);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUnit.MaxDropDownItems = 4;
            this.cbUnit.MouseState = MaterialSurface.MouseState.OUT;
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.cbUnit.Size = new System.Drawing.Size(373, 53);
            this.cbUnit.TabIndex = 13;
            // 
            // outlinedButton4
            // 
            this.outlinedButton4.BorderColor = System.Drawing.Color.DimGray;
            this.outlinedButton4.EffectType = MaterialSurface.ET.Custom;
            this.outlinedButton4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlinedButton4.ForeColor = System.Drawing.Color.Green;
            this.outlinedButton4.Icon = null;
            this.outlinedButton4.Location = new System.Drawing.Point(987, 297);
            this.outlinedButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outlinedButton4.MouseState = MaterialSurface.MouseState.OUT;
            this.outlinedButton4.Name = "outlinedButton4";
            this.outlinedButton4.PrimaryColor = System.Drawing.Color.Green;
            this.outlinedButton4.Radius = 6;
            this.outlinedButton4.Size = new System.Drawing.Size(305, 64);
            this.outlinedButton4.TabIndex = 26;
            this.outlinedButton4.Text = "Choose Image";
            this.outlinedButton4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.outlinedButton4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(987, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outlinedButton4);
            this.Controls.Add(this.dtgvProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOriginal);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvProduct;
        private MaterialSurface.OutlinedButton btnDelete;
        private MaterialSurface.OutlinedButton btnEdit;
        private MaterialSurface.OutlinedButton btnAdd;
        private MaterialSurface.MaterialTextfield txtOriginal;
        private MaterialSurface.MaterialTextfield txtProductName;
        private MaterialSurface.MaterialComboBox cbProductType;
        private MaterialSurface.MaterialTextfield txtDescription;
        private MaterialSurface.MaterialTextfield txtPrice;
        private MaterialSurface.MaterialTextfield txtProductId;
        private MaterialSurface.MaterialComboBox cbUnit;
        private MaterialSurface.OutlinedButton outlinedButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}