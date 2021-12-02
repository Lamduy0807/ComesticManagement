using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public DataGridView gvData 
        { 
            get { return dtgvsuplier; }
            set { dtgvsuplier = value; } 
        }
        private string _message;
        public string message 
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message);
            }
        }

        private void SuplierForm_Load(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            suplierPresenter.GetSuplier();
        }

        private void dtgvsuplier_DoubleClick(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            suplierPresenter.RetriveSuplier(dtgvsuplier.CurrentRow.Index, dtgvsuplier.CurrentRow.Cells[0].Value.ToString()
                , dtgvsuplier.CurrentRow.Cells[1].Value.ToString(), dtgvsuplier.CurrentRow.Cells[2].Value.ToString(),
                dtgvsuplier.CurrentRow.Cells[3].Value.ToString(), dtgvsuplier.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            suplierPresenter.AddData();
            suplierPresenter.GetSuplier();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            suplierPresenter.EditData();
            suplierPresenter.GetSuplier();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SuplierPresenter suplierPresenter = new SuplierPresenter(this);
            suplierPresenter.DeleteData();
            suplierPresenter.GetSuplier();
        }
    }
}
