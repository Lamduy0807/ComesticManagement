
namespace Doan.View.Accountant
{
    partial class AddPaySlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPaySlip));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnCancel = new MaterialSurface.OutlinedButton();
            this.btnSave = new MaterialSurface.OutlinedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new Doan.Custom_And_Resources.DateTimePickerCustom();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtContent = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cbStatus = new RJCodeAdvance.RJControls.RJComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.EffectType = MaterialSurface.ET.Custom;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Icon = global::Doan.Properties.Resources.cancel_icon;
            this.btnCancel.Location = new System.Drawing.Point(144, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.MouseState = MaterialSurface.MouseState.OUT;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PrimaryColor = System.Drawing.Color.Gray;
            this.btnCancel.Radius = 6;
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.EffectType = MaterialSurface.ET.Custom;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Icon = global::Doan.Properties.Resources.save_1779882;
            this.btnSave.Location = new System.Drawing.Point(376, 297);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSave.Name = "btnSave";
            this.btnSave.PrimaryColor = System.Drawing.Color.Green;
            this.btnSave.Radius = 6;
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker1.BorderSize = 0;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 223);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(4, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 44);
            this.dateTimePicker1.SkinColor = System.Drawing.Color.White;
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(204, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Pay Slip Information";
            // 
            // txtValue
            // 
            this.txtValue.AcceptsReturn = false;
            this.txtValue.AcceptsTab = false;
            this.txtValue.AnimationSpeed = 200;
            this.txtValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtValue.BackColor = System.Drawing.Color.Transparent;
            this.txtValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtValue.BackgroundImage")));
            this.txtValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtValue.BorderRadius = 8;
            this.txtValue.BorderThickness = 1;
            this.txtValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.DefaultText = "";
            this.txtValue.FillColor = System.Drawing.Color.White;
            this.txtValue.HideSelection = true;
            this.txtValue.IconLeft = null;
            this.txtValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.IconPadding = 10;
            this.txtValue.IconRight = null;
            this.txtValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(376, 117);
            this.txtValue.MaxLength = 32767;
            this.txtValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtValue.Modified = false;
            this.txtValue.Multiline = false;
            this.txtValue.Name = "txtValue";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtValue.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnIdleState = stateProperties20;
            this.txtValue.Padding = new System.Windows.Forms.Padding(3);
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtValue.PlaceholderText = "Enter text";
            this.txtValue.ReadOnly = false;
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(260, 44);
            this.txtValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtValue.TabIndex = 52;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValue.TextMarginBottom = 0;
            this.txtValue.TextMarginLeft = 3;
            this.txtValue.TextMarginTop = 0;
            this.txtValue.TextPlaceholder = "Enter text";
            this.txtValue.UseSystemPasswordChar = false;
            this.txtValue.WordWrap = true;
            // 
            // txtContent
            // 
            this.txtContent.AcceptsReturn = false;
            this.txtContent.AcceptsTab = false;
            this.txtContent.AnimationSpeed = 200;
            this.txtContent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContent.BackColor = System.Drawing.Color.Transparent;
            this.txtContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtContent.BackgroundImage")));
            this.txtContent.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtContent.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContent.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtContent.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtContent.BorderRadius = 8;
            this.txtContent.BorderThickness = 1;
            this.txtContent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.DefaultFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.DefaultText = "";
            this.txtContent.FillColor = System.Drawing.Color.White;
            this.txtContent.HideSelection = true;
            this.txtContent.IconLeft = null;
            this.txtContent.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.IconPadding = 10;
            this.txtContent.IconRight = null;
            this.txtContent.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.Lines = new string[0];
            this.txtContent.Location = new System.Drawing.Point(25, 117);
            this.txtContent.MaxLength = 32767;
            this.txtContent.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtContent.Modified = false;
            this.txtContent.Multiline = false;
            this.txtContent.Name = "txtContent";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContent.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtContent.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContent.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContent.OnIdleState = stateProperties24;
            this.txtContent.Padding = new System.Windows.Forms.Padding(3);
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtContent.PlaceholderText = "Enter text";
            this.txtContent.ReadOnly = false;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.SelectedText = "";
            this.txtContent.SelectionLength = 0;
            this.txtContent.SelectionStart = 0;
            this.txtContent.ShortcutsEnabled = true;
            this.txtContent.Size = new System.Drawing.Size(260, 44);
            this.txtContent.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtContent.TabIndex = 50;
            this.txtContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContent.TextMarginBottom = 0;
            this.txtContent.TextMarginLeft = 3;
            this.txtContent.TextMarginTop = 0;
            this.txtContent.TextPlaceholder = "Enter text";
            this.txtContent.UseSystemPasswordChar = false;
            this.txtContent.WordWrap = true;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbStatus.BorderSize = 1;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cbStatus.IconColor = System.Drawing.SystemColors.Control;
            this.cbStatus.Items.AddRange(new object[] {
            "Incomplete",
            "Completed"});
            this.cbStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cbStatus.Location = new System.Drawing.Point(376, 223);
            this.cbStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(1);
            this.cbStatus.Size = new System.Drawing.Size(260, 44);
            this.cbStatus.TabIndex = 66;
            this.cbStatus.Texts = "";
            // 
            // AddPaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 376);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPaySlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPaySlip";
            this.Load += new System.EventHandler(this.AddPaySlip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSurface.OutlinedButton btnCancel;
        private MaterialSurface.OutlinedButton btnSave;
        private System.Windows.Forms.Label label5;
        private Custom_And_Resources.DateTimePickerCustom dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuTextBox txtValue;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cbStatus;
    }
}