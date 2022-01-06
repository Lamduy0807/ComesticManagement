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
using Bunifu.UI.WinForms;
using Doan.Presenter;

namespace Doan.View.Export
{
    public partial class ExportForm : Form, IExport
    {
        public ExportForm()
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

        public string EmployeeID
        {
            get { return _id; }
        }

        public string TotalPriceProduct
        {
            get { return txtTotalPrice.Text; }
            set { txtTotalPrice.Text = value; }
        }
        public string ExportPrice
        {
            get { return txtExportPrice.Text; }
            set { txtExportPrice.Text = value; }
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
        BunifuDataGridView IExport.gvProductData
        {
            get { return dtgvProduct; }
            set { dtgvProduct = value; }
        }
        BunifuDataGridView IExport.gvDetailProductData
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

        string IExport.ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }

       
        public string ExportReason 
        {
            get { return txtReason.Text; } 
            set { txtReason.Text = value; } 
        }

        public string EmployeeName { get { return _name; } }

        public ExportForm(string id, string name) : this()
        {
            this._id = id;
            this._name = name;
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.GetProduct();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnCreate.Enabled = false;
        }

        private void dtgvProduct_DoubleClick(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.RetriveProduct(dtgvProduct.CurrentRow.Index, dtgvProduct.CurrentRow.Cells[0].Value.ToString()
                , dtgvProduct.CurrentRow.Cells[1].Value.ToString(), dtgvProduct.CurrentRow.Cells[2].Value.ToString());
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 1);
            }
            else
                exportPresenter.CalculateTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            if (exportPresenter.AddDataToDataGridview())
            {
                exportPresenter.CalculateTotalPrice();
                exportPresenter.ClearInformation();
                btnAdd.Enabled = false;
                btnCancel.Enabled = true;
                btnCreate.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void dtgvData_DoubleClick(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.RetriveData(dtgvData.CurrentRow.Index, dtgvData.CurrentRow.Cells[0].Value.ToString()
                , dtgvData.CurrentRow.Cells[1].Value.ToString(), dtgvData.CurrentRow.Cells[2].Value.ToString(),
                dtgvData.CurrentRow.Cells[3].Value.ToString(), dtgvData.CurrentRow.Cells[4].Value.ToString());
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            if (exportPresenter.EditData(dtgvData.CurrentRow.Index))
            {
                btnEdit.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                exportPresenter.CalculateTotalPrice();
                exportPresenter.ClearInformation();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            if (exportPresenter.DeleteDatainDataGridview())
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                if (!exportPresenter.CheckDB())
                {
                    btnCreate.Enabled = false;
                    btnCancel.Enabled = false;
                }
                exportPresenter.CalculateTotalPrice();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.SearchInformation(txtSearch.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            if (exportPresenter.CheckReason())
            {
                if (exportPresenter.AddDataToDB())
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
                    exportPresenter.ClearData();
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCreate.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            if (exportPresenter.ClearData())
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = false;
                btnDelete.Enabled = false;
                btnCreate.Enabled = false;
            }
            else
                btnCancel.Enabled = true;
        }
        public void Createform(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.Print(e);
        }
        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }
    }
}
