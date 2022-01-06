
namespace Doan.View.Accountant
{
    partial class PaySlipForm
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnEdit = new MaterialSurface.OutlinedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPaySlip = new MaterialSurface.OutlinedButton();
            this.dgvPaySlip = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dateTimePicker1 = new Doan.Custom_And_Resources.DateTimePickerCustom();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaySlip)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Incomplete",
            "Completed"});
            this.cbStatus.Location = new System.Drawing.Point(610, 24);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(184, 33);
            this.cbStatus.TabIndex = 55;
            this.cbStatus.Text = "Status";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BorderColor = System.Drawing.Color.DimGray;
            this.btnEdit.EffectType = MaterialSurface.ET.Custom;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Green;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(1122, 24);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PrimaryColor = System.Drawing.Color.Green;
            this.btnEdit.Radius = 6;
            this.btnEdit.Size = new System.Drawing.Size(150, 40);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Edit Pay Slip";
            this.btnEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "All of the pay slip";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Filter";
            // 
            // btnAddPaySlip
            // 
            this.btnAddPaySlip.AutoSize = true;
            this.btnAddPaySlip.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddPaySlip.EffectType = MaterialSurface.ET.Custom;
            this.btnAddPaySlip.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPaySlip.ForeColor = System.Drawing.Color.Green;
            this.btnAddPaySlip.Icon = null;
            this.btnAddPaySlip.Location = new System.Drawing.Point(932, 24);
            this.btnAddPaySlip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPaySlip.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAddPaySlip.Name = "btnAddPaySlip";
            this.btnAddPaySlip.PrimaryColor = System.Drawing.Color.Green;
            this.btnAddPaySlip.Radius = 6;
            this.btnAddPaySlip.Size = new System.Drawing.Size(150, 40);
            this.btnAddPaySlip.TabIndex = 50;
            this.btnAddPaySlip.Text = "Add Pay Slip";
            this.btnAddPaySlip.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddPaySlip.UseVisualStyleBackColor = true;
            this.btnAddPaySlip.Click += new System.EventHandler(this.btnAddPaySlip_Click);
            // 
            // dgvPaySlip
            // 
            this.dgvPaySlip.AllowCustomTheming = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPaySlip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaySlip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaySlip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaySlip.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPaySlip.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaySlip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaySlip.ColumnHeadersHeight = 40;
            this.dgvPaySlip.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaySlip.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPaySlip.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPaySlip.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dgvPaySlip.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPaySlip.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.dgvPaySlip.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dgvPaySlip.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dgvPaySlip.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPaySlip.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPaySlip.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.dgvPaySlip.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPaySlip.CurrentTheme.Name = null;
            this.dgvPaySlip.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.dgvPaySlip.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPaySlip.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPaySlip.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dgvPaySlip.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaySlip.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaySlip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPaySlip.EnableHeadersVisualStyles = false;
            this.dgvPaySlip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPaySlip.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.dgvPaySlip.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPaySlip.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPaySlip.Location = new System.Drawing.Point(0, 65);
            this.dgvPaySlip.Margin = new System.Windows.Forms.Padding(8);
            this.dgvPaySlip.Name = "dgvPaySlip";
            this.dgvPaySlip.ReadOnly = true;
            this.dgvPaySlip.RowHeadersVisible = false;
            this.dgvPaySlip.RowHeadersWidth = 51;
            this.dgvPaySlip.RowTemplate.Height = 40;
            this.dgvPaySlip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaySlip.Size = new System.Drawing.Size(1304, 676);
            this.dgvPaySlip.TabIndex = 49;
            this.dgvPaySlip.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvPaySlip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaySlip_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker1.BorderSize = 0;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(414, 24);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(4, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 30);
            this.dateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(198)))), ((int)(((byte)(102)))));
            this.dateTimePicker1.TabIndex = 51;
            this.dateTimePicker1.TextColor = System.Drawing.Color.White;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PaySlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAddPaySlip);
            this.Controls.Add(this.dgvPaySlip);
            this.Name = "PaySlipForm";
            this.Text = "PaySlipForm";
            this.Load += new System.EventHandler(this.PaySlipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaySlip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatus;
        private MaterialSurface.OutlinedButton btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Custom_And_Resources.DateTimePickerCustom dateTimePicker1;
        private MaterialSurface.OutlinedButton btnAddPaySlip;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPaySlip;
    }
}