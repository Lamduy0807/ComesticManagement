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

namespace Doan.View.Export
{
    public partial class ExportForm : Form, IExport
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private string _id;

        public string ProductId
        {
            get { return txtProductId.Text; }
            set { txtProductId.Text = value; }
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

        public ExportForm(string id) : this()
        {
            this._id = id;
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.GetProduct();
        }

        private void dtgvProduct_DoubleClick(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.RetriveProduct(dtgvProduct.CurrentRow.Index, dtgvProduct.CurrentRow.Cells[0].Value.ToString()
                , dtgvProduct.CurrentRow.Cells[1].Value.ToString(), dtgvProduct.CurrentRow.Cells[2].Value.ToString());
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.CalculateTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            if (exportPresenter.AddDataToDataGridview())
            {
                exportPresenter.CalculateTotalPrice();
                exportPresenter.ClearInformation();
            }
        }

        private void dtgvData_DoubleClick(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.RetriveData(dtgvData.CurrentRow.Index, dtgvData.CurrentRow.Cells[0].Value.ToString()
                , dtgvData.CurrentRow.Cells[1].Value.ToString(), dtgvData.CurrentRow.Cells[2].Value.ToString(),
                dtgvData.CurrentRow.Cells[3].Value.ToString(), dtgvData.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.EditData(dtgvData.CurrentRow.Index);
            exportPresenter.CalculateTotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.DeleteDatainDataGridview();
            exportPresenter.CalculateTotalPrice();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.SearchInformation(txtSearch.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            if (exportPresenter.AddDataToDB())
                exportPresenter.ClearData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExportPresenter exportPresenter = new ExportPresenter(this);
            exportPresenter.ClearData();
        }
    }
}
