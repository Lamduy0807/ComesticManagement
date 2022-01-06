
namespace Doan.View.Statistic
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvBestSeller = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconDBHoaDon = new FontAwesome.Sharp.IconPictureBox();
            this.lbBillToday = new System.Windows.Forms.Label();
            this.lbBillThisMonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbProduct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconDBProduct = new FontAwesome.Sharp.IconPictureBox();
            this.lbSumProduct = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.iconDBMoney = new FontAwesome.Sharp.IconPictureBox();
            this.lbRevenueToday = new System.Windows.Forms.Label();
            this.lbRevenueThisMonth = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new Doan.Custom_And_Resources.DateTimePickerCustom();
            this.btnCreate = new MaterialSurface.OutlinedButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBestSeller)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBProduct)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Location = new System.Drawing.Point(23, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 478);
            this.panel4.TabIndex = 10;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(870, 478);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(899, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Best-Selling products";
            // 
            // dtgvBestSeller
            // 
            this.dtgvBestSeller.AllowCustomTheming = true;
            this.dtgvBestSeller.AllowUserToAddRows = false;
            this.dtgvBestSeller.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvBestSeller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBestSeller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBestSeller.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvBestSeller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBestSeller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBestSeller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBestSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBestSeller.ColumnHeadersHeight = 40;
            this.dtgvBestSeller.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBestSeller.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBestSeller.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBestSeller.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dtgvBestSeller.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBestSeller.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.dtgvBestSeller.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dtgvBestSeller.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dtgvBestSeller.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBestSeller.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBestSeller.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.dtgvBestSeller.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBestSeller.CurrentTheme.Name = null;
            this.dtgvBestSeller.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.dtgvBestSeller.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgvBestSeller.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBestSeller.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dtgvBestSeller.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBestSeller.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBestSeller.EnableHeadersVisualStyles = false;
            this.dtgvBestSeller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dtgvBestSeller.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.dtgvBestSeller.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgvBestSeller.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvBestSeller.Location = new System.Drawing.Point(889, 345);
            this.dtgvBestSeller.Name = "dtgvBestSeller";
            this.dtgvBestSeller.ReadOnly = true;
            this.dtgvBestSeller.RowHeadersVisible = false;
            this.dtgvBestSeller.RowHeadersWidth = 51;
            this.dtgvBestSeller.RowTemplate.Height = 40;
            this.dtgvBestSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBestSeller.Size = new System.Drawing.Size(383, 374);
            this.dtgvBestSeller.TabIndex = 1;
            this.dtgvBestSeller.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconDBHoaDon);
            this.panel1.Controls.Add(this.lbBillToday);
            this.panel1.Controls.Add(this.lbBillThisMonth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 167);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Day:";
            // 
            // iconDBHoaDon
            // 
            this.iconDBHoaDon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconDBHoaDon.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconDBHoaDon.IconColor = System.Drawing.Color.White;
            this.iconDBHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBHoaDon.IconSize = 84;
            this.iconDBHoaDon.Location = new System.Drawing.Point(303, 4);
            this.iconDBHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.iconDBHoaDon.Name = "iconDBHoaDon";
            this.iconDBHoaDon.Size = new System.Drawing.Size(84, 92);
            this.iconDBHoaDon.TabIndex = 3;
            this.iconDBHoaDon.TabStop = false;
            // 
            // lbBillToday
            // 
            this.lbBillToday.AutoSize = true;
            this.lbBillToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillToday.ForeColor = System.Drawing.Color.White;
            this.lbBillToday.Location = new System.Drawing.Point(101, 112);
            this.lbBillToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBillToday.Name = "lbBillToday";
            this.lbBillToday.Size = new System.Drawing.Size(110, 25);
            this.lbBillToday.TabIndex = 2;
            this.lbBillToday.Text = "99.000.000";
            // 
            // lbBillThisMonth
            // 
            this.lbBillThisMonth.AutoSize = true;
            this.lbBillThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillThisMonth.ForeColor = System.Drawing.Color.White;
            this.lbBillThisMonth.Location = new System.Drawing.Point(15, 54);
            this.lbBillThisMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBillThisMonth.Name = "lbBillThisMonth";
            this.lbBillThisMonth.Size = new System.Drawing.Size(206, 42);
            this.lbBillThisMonth.TabIndex = 1;
            this.lbBillThisMonth.Text = "10.000.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bills of month";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Controls.Add(this.lbProduct);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.iconDBProduct);
            this.panel2.Controls.Add(this.lbSumProduct);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(459, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 167);
            this.panel2.TabIndex = 8;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct.ForeColor = System.Drawing.Color.White;
            this.lbProduct.Location = new System.Drawing.Point(100, 112);
            this.lbProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(110, 25);
            this.lbProduct.TabIndex = 5;
            this.lbProduct.Text = "99.000.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Day:";
            // 
            // iconDBProduct
            // 
            this.iconDBProduct.BackColor = System.Drawing.Color.DarkMagenta;
            this.iconDBProduct.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.iconDBProduct.IconColor = System.Drawing.Color.White;
            this.iconDBProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBProduct.IconSize = 95;
            this.iconDBProduct.Location = new System.Drawing.Point(291, 1);
            this.iconDBProduct.Margin = new System.Windows.Forms.Padding(4);
            this.iconDBProduct.Name = "iconDBProduct";
            this.iconDBProduct.Size = new System.Drawing.Size(96, 95);
            this.iconDBProduct.TabIndex = 3;
            this.iconDBProduct.TabStop = false;
            // 
            // lbSumProduct
            // 
            this.lbSumProduct.AutoSize = true;
            this.lbSumProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumProduct.ForeColor = System.Drawing.Color.White;
            this.lbSumProduct.Location = new System.Drawing.Point(11, 54);
            this.lbSumProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSumProduct.Name = "lbSumProduct";
            this.lbSumProduct.Size = new System.Drawing.Size(206, 42);
            this.lbSumProduct.TabIndex = 1;
            this.lbSumProduct.Text = "10.000.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Products sold month";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.iconDBMoney);
            this.panel3.Controls.Add(this.lbRevenueToday);
            this.panel3.Controls.Add(this.lbRevenueThisMonth);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(871, 104);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 167);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day:";
            // 
            // iconDBMoney
            // 
            this.iconDBMoney.BackColor = System.Drawing.Color.Crimson;
            this.iconDBMoney.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconDBMoney.IconColor = System.Drawing.Color.White;
            this.iconDBMoney.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBMoney.IconSize = 110;
            this.iconDBMoney.Location = new System.Drawing.Point(268, -14);
            this.iconDBMoney.Margin = new System.Windows.Forms.Padding(4);
            this.iconDBMoney.Name = "iconDBMoney";
            this.iconDBMoney.Size = new System.Drawing.Size(119, 110);
            this.iconDBMoney.TabIndex = 3;
            this.iconDBMoney.TabStop = false;
            // 
            // lbRevenueToday
            // 
            this.lbRevenueToday.AutoSize = true;
            this.lbRevenueToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenueToday.ForeColor = System.Drawing.Color.White;
            this.lbRevenueToday.Location = new System.Drawing.Point(95, 112);
            this.lbRevenueToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRevenueToday.Name = "lbRevenueToday";
            this.lbRevenueToday.Size = new System.Drawing.Size(110, 25);
            this.lbRevenueToday.TabIndex = 2;
            this.lbRevenueToday.Text = "99.000.000";
            // 
            // lbRevenueThisMonth
            // 
            this.lbRevenueThisMonth.AutoSize = true;
            this.lbRevenueThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenueThisMonth.ForeColor = System.Drawing.Color.White;
            this.lbRevenueThisMonth.Location = new System.Drawing.Point(11, 54);
            this.lbRevenueThisMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRevenueThisMonth.Name = "lbRevenueThisMonth";
            this.lbRevenueThisMonth.Size = new System.Drawing.Size(206, 42);
            this.lbRevenueThisMonth.TabIndex = 1;
            this.lbRevenueThisMonth.Text = "10.000.000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Revenue this month";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker1.BorderSize = 0;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 24);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 35);
            this.dateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(198)))), ((int)(((byte)(102)))));
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.TextColor = System.Drawing.Color.White;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BorderColor = System.Drawing.Color.DimGray;
            this.btnCreate.EffectType = MaterialSurface.ET.Custom;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCreate.Icon = global::Doan.Properties.Resources.icons8_create_order_48;
            this.btnCreate.Location = new System.Drawing.Point(991, 12);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.MouseState = MaterialSurface.MouseState.OUT;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.PrimaryColor = System.Drawing.Color.DarkCyan;
            this.btnCreate.Radius = 6;
            this.btnCreate.Size = new System.Drawing.Size(267, 64);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Create Form";
            this.btnCreate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 741);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvBestSeller);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBestSeller)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private Custom_And_Resources.DateTimePickerCustom dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgvBestSeller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconDBHoaDon;
        private System.Windows.Forms.Label lbBillToday;
        private System.Windows.Forms.Label lbBillThisMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox iconDBProduct;
        private System.Windows.Forms.Label lbSumProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconDBMoney;
        private System.Windows.Forms.Label lbRevenueToday;
        private System.Windows.Forms.Label lbRevenueThisMonth;
        private System.Windows.Forms.Label label9;
        private MaterialSurface.OutlinedButton btnCreate;
    }
}