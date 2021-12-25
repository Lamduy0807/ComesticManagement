using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Presenter;
using Doan.Presenter.cImport;

namespace Doan.View.Import
{
    public partial class ImportForm : Form, IImport
    {
        public ImportForm()
        {
            InitializeComponent();
        }
        private string _id;
        private string _name;
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

        public string EmployeeName { get { return _name; } }

        public ImportForm(string id, string name) : this()
        {
            this._id = id;
            this._name = name;
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.GetProduct();
            importPresenter.GetSuplier();        
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
            Command add = new AddCommand(importPresenter);
            Command delete = new DeleteCommand(importPresenter);
            Command cancel = new CancelCommand(importPresenter);
            Command edit = new EditCommand(importPresenter, 0);
            Invorker invorker = new Invorker(add,delete,cancel,edit);
            invorker.AddData();
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
            Command add = new AddCommand(importPresenter);
            Command delete = new DeleteCommand(importPresenter);
            Command cancel = new CancelCommand(importPresenter);
            Command edit = new EditCommand(importPresenter, 0);
            Invorker invorker = new Invorker(add, delete, cancel, edit);
            invorker.DeleteData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            Command edit = new EditCommand(importPresenter, dtgvData.CurrentRow.Index);
            Command add = new AddCommand(importPresenter);
            Command delete = new DeleteCommand(importPresenter);
            Command cancel = new CancelCommand(importPresenter);
            Invorker invorker = new Invorker(add, delete, cancel, edit);
            invorker.EditData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            Command add = new AddCommand(importPresenter);
            Command delete = new DeleteCommand(importPresenter);
            Command cancel = new CancelCommand(importPresenter);
            Command edit = new EditCommand(importPresenter, 0);
            Invorker invorker = new Invorker(add, delete, cancel, edit);
            invorker.CancelData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            if (importPresenter.AddDataToDB())
            {
                PrintDialog printDialog = new PrintDialog();

                PrintDocument printDocument = new PrintDocument();

                printDialog.Document = printDocument;
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Createform);
                DialogResult result = printDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    printDocument.Print();

                }
                importPresenter.ClearData();
            }
        }
        public void Createform(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ImportPresenter importPresenter = new ImportPresenter(this);
            importPresenter.Print(e);
        }
        
    }
}
