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

namespace Doan.View.Import
{
    public partial class ImportForm : Form, IImport
    {
        public ImportForm()
        {
            InitializeComponent();
        }
        private string _id;

        public string ProductId
        {
            get { return txtProductId.Text; }
            set { txtProductId.Text = value; }
        }
        public string SuplierName
        {
            get { return cbSuplier.GetItemText(cbSuplier.SelectedItem); }
            set { cbSuplier.Text = value; }
        }

        public string EmployeeID
        {
            get { return _id; }
        }

        public string TotalPrice 
        {
            get { return txtTotalPrice.Text; } 
            set { txtTotalPrice.Text = value; } 
        }
        public string ImportPrice
        {
            get { return txtImportPrice.Text; }
            set { txtImportPrice.Text = value; }
        }
        public string Quantity
        {
            get { return txtQuantity.Text; }
            set { txtQuantity.Text = value; }
        }
        public string Total
        {
            get { return txtTotal.Text; }
            set { txtTotal.Text = value; }
        }

        public ComboBox.ObjectCollection cbData
        {
            get
            {
                return cbSuplier.Items;
            }
        }

        public DataGridView gvProductData
        {
            get { return dtgvProduct; }
            set { dtgvProduct = value; }
        }
        public DataGridView gvDetailProductData
        {
            get { return dtgvData; }
            set { dtgvData = value; }
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
        public string Search
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        string IImport.ProductName 
        { 
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; } 
        }

        public ImportForm(string id) : this()
        {
            this._id = id;
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.GetProduct();
            importPresenter.GetSuplier();
            DateTime dateTime = DateTime.UtcNow.Date;
            MessageBox.Show(dateTime.ToString());
        }

        private void dtgvProduct_DoubleClick(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.RetriveProduct(dtgvProduct.CurrentRow.Index, dtgvProduct.CurrentRow.Cells[0].Value.ToString()
                , dtgvProduct.CurrentRow.Cells[1].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            if (importPresenter.AddDataToDataGridview())
            {
                importPresenter.CalculateTotalPrice();
                importPresenter.ClearInformation();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.CalculateTotal();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.SearchInformation(txtSearch.Text);
        }

        private void dtgvData_DoubleClick(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.RetriveData(dtgvData.CurrentRow.Index, dtgvData.CurrentRow.Cells[0].Value.ToString()
                , dtgvData.CurrentRow.Cells[1].Value.ToString(), dtgvData.CurrentRow.Cells[2].Value.ToString(),
                dtgvData.CurrentRow.Cells[3].Value.ToString(), dtgvData.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.DeleteDatainDataGridview();
            importPresenter.CalculateTotalPrice();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.EditData(dtgvData.CurrentRow.Index);
            importPresenter.CalculateTotalPrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.ClearData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            if (importPresenter.AddDataToDB())
                importPresenter.ClearData();
        }
    }
}
