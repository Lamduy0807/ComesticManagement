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
    public partial class ReceiptsForm : Form, IReceiptsForm
    {

        private string id;
        public ReceiptsForm()
        {
            InitializeComponent();
        }

        public ReceiptsForm(string id) : this()
        {
            this.id = id;
        }

        BunifuDataGridView IReceiptsForm.dgvReceipts
        {
            get { return dgvReceipts; }
            set { dgvReceipts = value; }
        }

        public string Date {
            get { return dateTimePicker1.Text.ToString(); }
            set { dateTimePicker1.Text = value; }
        }

        public string Status
        {
            /*get { return cbStatus.Text; }*/
            get { return cbStatus.SelectedItem.ToString(); }
            set { cbStatus.Text = value; }            
        }

        private void ReceiptsForm_Load(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            dateTimePicker1.SkinColor = Color.White;
            btnEdit.Enabled = false;

            ReceiptsPresenter receiptsPresenter = new ReceiptsPresenter(this);
            receiptsPresenter.LoadReceipts();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            dateTimePicker1.SkinColor = Color.FromArgb(127,198,102);
           
            ReceiptsPresenter receiptsPresenter = new ReceiptsPresenter(this);
            receiptsPresenter.FilterByDay();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label1.Font = new Font(label1.Font, FontStyle.Regular);
            dateTimePicker1.SkinColor = Color.White;
            ReceiptsPresenter receiptsPresenter = new ReceiptsPresenter(this);
            receiptsPresenter.LoadReceipts();

        }

        private void btnAddReceipts_Click(object sender, EventArgs e)
        {
            AddReceiptsForm addReceiptsForm = new AddReceiptsForm(true, id);           
            addReceiptsForm.Show();
        }

        private void dgvReceipts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvReceipts.CurrentRow.Cells[4].Value.ToString() == "Incomplete")
            {
                btnEdit.Enabled = true;               
            }    
            else
            {
                btnEdit.Enabled =false;                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Enabled.ToString() == "True")
            {
                AddReceiptsForm addReceiptsForm = new AddReceiptsForm(false, id, dgvReceipts.CurrentRow.Cells[0].Value.ToString(), dgvReceipts.CurrentRow.Cells[2].Value.ToString(), 
                    dgvReceipts.CurrentRow.Cells[3].Value.ToString(), dgvReceipts.CurrentRow.Cells[5].Value.ToString(),
                    dgvReceipts.CurrentRow.Cells[4].Value.ToString());                
                addReceiptsForm.Show();
            }

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
            dateTimePicker1.SkinColor = Color.White;
            ReceiptsPresenter receiptsPresenter = new ReceiptsPresenter(this);
            receiptsPresenter.FilterByStatus();
        }
    }
}
