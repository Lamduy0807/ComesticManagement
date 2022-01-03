﻿using Bunifu.UI.WinForms;
using Doan.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan.View.Accountant
{
    public partial class PaySlipForm : Form, IPaySlip
    {
        private string id;
        public PaySlipForm()
        {
            InitializeComponent();
        }

        public PaySlipForm(string id) : this()
        {
            this.id = id;
        }

        public string Date
        {
            get { return dateTimePicker1.Text.ToString(); }
            set { dateTimePicker1.Text = value; }
        }

        public string Status
        {
            get { return cbStatus.Text; }
            set { cbStatus.Text = value; }
        }
        BunifuDataGridView IPaySlip.dgvPaySlip {
            get { return dgvPaySlip; }
            set { dgvPaySlip = value; }
        }

        private void PaySlipForm_Load(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            dateTimePicker1.SkinColor = Color.White;
            btnEdit.Enabled = false;

            PaySlipPresenter paySlipPresenter = new PaySlipPresenter(this);
            paySlipPresenter.LoadPaySlip();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            dateTimePicker1.SkinColor = Color.FromArgb(127, 198, 102);
           
            PaySlipPresenter paySlipPresenter = new PaySlipPresenter(this);
            paySlipPresenter.FilterByDay();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label1.Font = new Font(label1.Font, FontStyle.Regular);
            //cbStatus.Text = "Status";
            dateTimePicker1.SkinColor = Color.White;
            PaySlipPresenter paySlipPresenter = new PaySlipPresenter(this);
            paySlipPresenter.LoadPaySlip();
        }

        private void btnAddPaySlip_Click(object sender, EventArgs e)
        {
            AddPaySlip addPaySlip = new AddPaySlip(true, id);
            addPaySlip.Show();
        }

        private void dgvPaySlip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPaySlip.CurrentRow.Cells[4].Value.ToString() == "Incomplete")
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //chuwaa
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
            dateTimePicker1.SkinColor = Color.White;
            PaySlipPresenter paySlipPresenter = new PaySlipPresenter(this);
            paySlipPresenter.FilterByStatus();
        }
    }
}
