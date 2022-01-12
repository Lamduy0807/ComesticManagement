using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Doan.Presenter;

namespace Doan.View.Suplier
{
    public partial class SuplierForm : Form, ISuplier
    {
        public SuplierForm()
        {
            InitializeComponent();
        }

        public string SuplierId 
        { 
            get
            {
                return txtSuplierId.Text;
            }
            set
            {
                txtSuplierId.Text = value.ToString();
            }
        }
        public string SuplierName 
        { 
            get { return txtSuplierName.Text; }
            set { txtSuplierName.Text = value; } 
        }
        public string SuplierPhone {
            get { return txtPhoneNumber.Text; }
            set { txtPhoneNumber.Text = value; } 
        }
        public string SuplierAddress 
        {
            get { return txtAddress.Text; } 
            set { txtAddress.Text = value; } 
        }
        public string SuplierEmail 
        { 
            get { return txtEmail.Text; } 
            set { txtEmail.Text = value; }
        }
        BunifuDataGridView ISuplier.gvData 
        { 
            get { return dtgvPsuplier; }
            set { dtgvPsuplier = value; } 
        }
        private string _message;
        public string message 
        {
            get { return _message; }
            set
            {
                _message = value;
            }
        }

        private void SuplierForm_Load(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            suplierPresenter.GetSuplier();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dtgvsuplier_DoubleClick(object sender, EventArgs e)
        {

            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            suplierPresenter.RetriveSuplier(dtgvPsuplier.CurrentRow.Index, dtgvPsuplier.CurrentRow.Cells[0].Value.ToString()
                , dtgvPsuplier.CurrentRow.Cells[1].Value.ToString(), dtgvPsuplier.CurrentRow.Cells[2].Value.ToString(),
                dtgvPsuplier.CurrentRow.Cells[3].Value.ToString(), dtgvPsuplier.CurrentRow.Cells[4].Value.ToString());
            if (dtgvPsuplier.CurrentRow.Cells[0].Value.ToString() != "")
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            if (suplierPresenter.AddData())
            {
                MessageBox.Show(_message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                suplierPresenter.ClearInformation();
                suplierPresenter.GetSuplier();
            }
            else
            {
                MessageBox.Show(_message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAdd.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            if (suplierPresenter.CheckInformationEdit())
            {
                if (suplierPresenter.EditData())
                {
                    MessageBox.Show(_message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    suplierPresenter.ClearInformation();
                    suplierPresenter.GetSuplier();
                }
                else
                {
                    MessageBox.Show(_message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check information again!");
                btnEdit.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this supplier?", "Question", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SuplierPresenter suplierPresenter = new SuplierPresenter(this);
                if (suplierPresenter.DeleteData())
                {
                    MessageBox.Show(_message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    suplierPresenter.GetSuplier();
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    suplierPresenter.ClearInformation();
                }
            }

        }

        private void txtSuplierName_TextChanged(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Text = txtPhoneNumber.Text.Remove(txtPhoneNumber.Text.Length - 1);
            }
            if (suplierPresenter.CheckInformation())
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }
    }
}
