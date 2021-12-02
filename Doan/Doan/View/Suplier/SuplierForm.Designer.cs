
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
            this.dtgvsuplier = new System.Windows.Forms.DataGridView();
            this.txtEmail = new MaterialSurface.MaterialTextfield();
            this.txtSuplierName = new MaterialSurface.MaterialTextfield();
            this.txtPhoneNumber = new MaterialSurface.MaterialTextfield();
            this.txtSuplierId = new MaterialSurface.MaterialTextfield();
            this.btnAdd = new MaterialSurface.OutlinedButton();
            this.btnEdit = new MaterialSurface.OutlinedButton();
            this.btnDelete = new MaterialSurface.OutlinedButton();
            this.txtAddress = new MaterialSurface.MaterialTextfield();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsuplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvsuplier
            // 
            this.dtgvsuplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvsuplier.Location = new System.Drawing.Point(26, 282);
            this.dtgvsuplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvsuplier.Name = "dtgvsuplier";
            this.dtgvsuplier.RowHeadersWidth = 51;
            this.dtgvsuplier.RowTemplate.Height = 24;
            this.dtgvsuplier.Size = new System.Drawing.Size(1217, 432);
            this.dtgvsuplier.TabIndex = 26;
            this.dtgvsuplier.DoubleClick += new System.EventHandler(this.dtgvsuplier_DoubleClick);
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
            this.txtPhoneNumber.TabIndex = 28;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
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
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.EffectType = MaterialSurface.ET.Custom;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(1024, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.Green;
            this.btnAdd.Radius = 6;
            this.btnAdd.Size = new System.Drawing.Size(219, 64);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.DimGray;
            this.btnEdit.EffectType = MaterialSurface.ET.Custom;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Green;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(1024, 108);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PrimaryColor = System.Drawing.Color.Green;
            this.btnEdit.Radius = 6;
            this.btnEdit.Size = new System.Drawing.Size(219, 64);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(1024, 192);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PrimaryColor = System.Drawing.Color.Green;
            this.btnDelete.Radius = 6;
            this.btnDelete.Size = new System.Drawing.Size(219, 64);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.txtAddress.TabIndex = 34;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // SuplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSuplierName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuplierId);
            this.Controls.Add(this.dtgvsuplier);
            this.Name = "SuplierForm";
            this.Text = "SuplierForm";
            this.Load += new System.EventHandler(this.SuplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsuplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvsuplier;
        private MaterialSurface.MaterialTextfield txtEmail;
        private MaterialSurface.MaterialTextfield txtSuplierName;
        private MaterialSurface.MaterialTextfield txtPhoneNumber;
        private MaterialSurface.MaterialTextfield txtSuplierId;
        private MaterialSurface.OutlinedButton btnAdd;
        private MaterialSurface.OutlinedButton btnEdit;
        private MaterialSurface.OutlinedButton btnDelete;
        private MaterialSurface.MaterialTextfield txtAddress;
    }
}