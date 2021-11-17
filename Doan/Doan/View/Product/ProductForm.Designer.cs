
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outlinedButton3 = new MaterialSurface.OutlinedButton();
            this.outlinedButton2 = new MaterialSurface.OutlinedButton();
            this.outlinedButton1 = new MaterialSurface.OutlinedButton();
            this.txtOriginal = new MaterialSurface.MaterialTextfield();
            this.txtProductName = new MaterialSurface.MaterialTextfield();
            this.cbProductType = new MaterialSurface.MaterialComboBox();
            this.txtDescription = new MaterialSurface.MaterialTextfield();
            this.txtPrice = new MaterialSurface.MaterialTextfield();
            this.txtProductId = new MaterialSurface.MaterialTextfield();
            this.cbUnit = new MaterialSurface.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 444);
            this.dataGridView1.TabIndex = 25;
            // 
            // outlinedButton3
            // 
            this.outlinedButton3.BorderColor = System.Drawing.Color.DimGray;
            this.outlinedButton3.EffectType = MaterialSurface.ET.Custom;
            this.outlinedButton3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlinedButton3.ForeColor = System.Drawing.Color.Green;
            this.outlinedButton3.Icon = null;
            this.outlinedButton3.Location = new System.Drawing.Point(968, 209);
            this.outlinedButton3.MouseState = MaterialSurface.MouseState.OUT;
            this.outlinedButton3.Name = "outlinedButton3";
            this.outlinedButton3.PrimaryColor = System.Drawing.Color.Green;
            this.outlinedButton3.Radius = 6;
            this.outlinedButton3.Size = new System.Drawing.Size(305, 64);
            this.outlinedButton3.TabIndex = 23;
            this.outlinedButton3.Text = "Delete";
            this.outlinedButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.outlinedButton3.UseVisualStyleBackColor = true;
            // 
            // outlinedButton2
            // 
            this.outlinedButton2.BorderColor = System.Drawing.Color.DimGray;
            this.outlinedButton2.EffectType = MaterialSurface.ET.Custom;
            this.outlinedButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlinedButton2.ForeColor = System.Drawing.Color.Green;
            this.outlinedButton2.Icon = null;
            this.outlinedButton2.Location = new System.Drawing.Point(968, 103);
            this.outlinedButton2.MouseState = MaterialSurface.MouseState.OUT;
            this.outlinedButton2.Name = "outlinedButton2";
            this.outlinedButton2.PrimaryColor = System.Drawing.Color.Green;
            this.outlinedButton2.Radius = 6;
            this.outlinedButton2.Size = new System.Drawing.Size(305, 64);
            this.outlinedButton2.TabIndex = 22;
            this.outlinedButton2.Text = "Edit";
            this.outlinedButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.outlinedButton2.UseVisualStyleBackColor = true;
            // 
            // outlinedButton1
            // 
            this.outlinedButton1.BorderColor = System.Drawing.Color.DimGray;
            this.outlinedButton1.EffectType = MaterialSurface.ET.Custom;
            this.outlinedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlinedButton1.ForeColor = System.Drawing.Color.Green;
            this.outlinedButton1.Icon = null;
            this.outlinedButton1.Location = new System.Drawing.Point(968, 12);
            this.outlinedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.outlinedButton1.Name = "outlinedButton1";
            this.outlinedButton1.PrimaryColor = System.Drawing.Color.Green;
            this.outlinedButton1.Radius = 6;
            this.outlinedButton1.Size = new System.Drawing.Size(305, 64);
            this.outlinedButton1.TabIndex = 21;
            this.outlinedButton1.Text = "Add";
            this.outlinedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.outlinedButton1.UseVisualStyleBackColor = true;
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
            this.txtOriginal.MaxLength = 32767;
            this.txtOriginal.MouseState = MaterialSurface.MouseState.OUT;
            this.txtOriginal.Multiline = false;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.PasswordChar = '\0';
            this.txtOriginal.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtOriginal.ReadOnly = false;
            this.txtOriginal.ShortcutsEnable = true;
            this.txtOriginal.ShowCaret = true;
            this.txtOriginal.Size = new System.Drawing.Size(349, 49);
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
            this.txtProductName.Location = new System.Drawing.Point(39, 83);
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
            this.cbProductType.MaxDropDownItems = 4;
            this.cbProductType.MouseState = MaterialSurface.MouseState.OUT;
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.cbProductType.Size = new System.Drawing.Size(349, 53);
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
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = MaterialSurface.MouseState.OUT;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ShortcutsEnable = true;
            this.txtDescription.ShowCaret = true;
            this.txtDescription.Size = new System.Drawing.Size(358, 120);
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
            this.txtProductId.MaxLength = 32767;
            this.txtProductId.MouseState = MaterialSurface.MouseState.OUT;
            this.txtProductId.Multiline = false;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.PasswordChar = '\0';
            this.txtProductId.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.txtProductId.ReadOnly = false;
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
            this.cbUnit.Location = new System.Drawing.Point(39, 223);
            this.cbUnit.MaxDropDownItems = 4;
            this.cbUnit.MouseState = MaterialSurface.MouseState.OUT;
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.PrimaryColor = System.Drawing.Color.DarkGreen;
            this.cbUnit.Size = new System.Drawing.Size(373, 53);
            this.cbUnit.TabIndex = 13;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.outlinedButton3);
            this.Controls.Add(this.outlinedButton2);
            this.Controls.Add(this.outlinedButton1);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.cbUnit);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSurface.OutlinedButton outlinedButton3;
        private MaterialSurface.OutlinedButton outlinedButton2;
        private MaterialSurface.OutlinedButton outlinedButton1;
        private MaterialSurface.MaterialTextfield txtOriginal;
        private MaterialSurface.MaterialTextfield txtProductName;
        private MaterialSurface.MaterialComboBox cbProductType;
        private MaterialSurface.MaterialTextfield txtDescription;
        private MaterialSurface.MaterialTextfield txtPrice;
        private MaterialSurface.MaterialTextfield txtProductId;
        private MaterialSurface.MaterialComboBox cbUnit;
    }
}