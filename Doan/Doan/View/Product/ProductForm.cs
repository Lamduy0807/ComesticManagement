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

namespace Doan.View.Product
{
    public partial class ProductForm : Form, IProduct
    {
        public ProductForm()
        {
            InitializeComponent();

        }

        public ComboBox.ObjectCollection cbData
        {
           get
            {
                return cbProductType.Items;
            }
        }

        string IProduct.ProductID 
        { 
            get { return (txtProductId.Text); } 
            set { txtProductId.Text = value.ToString(); }
        }
        string IProduct.ProductName 
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; } 
        }
        string IProduct.Price
        {
            get { return (txtPrice.Text); }
            set { txtPrice.Text = value.ToString(); }
        }
        string IProduct.Unit
        {
            get { return cbUnit.Text; }
            set { cbUnit.Text = value; }
        }
        string IProduct.Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }
        string IProduct.Original
        {
            get { return txtOriginal.Text; }
            set { txtOriginal.Text = value; }
        }
        string IProduct.ProductType
        {
            get { return cbProductType.GetItemText(cbProductType.SelectedItem); }
            set { cbProductType.Text= value; }
        }
        private string _message;
        string IProduct.message
        {
            get { return _message; }
            set 
            { 
                _message = value;
                MessageBox.Show(_message);
            }
        }

        public DataGridView gvData 
        {
            get { return dtgvProduct; } 
            set { dtgvProduct = value; }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            productPresenter.GetProductType();
            productPresenter.GetProduct();
        }

        private void dtgvProduct_DoubleClick(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            productPresenter.RetriveProduct(dtgvProduct.CurrentRow.Index,dtgvProduct.CurrentRow.Cells[0].Value.ToString()
                , dtgvProduct.CurrentRow.Cells[1].Value.ToString(), dtgvProduct.CurrentRow.Cells[2].Value.ToString(), 
                dtgvProduct.CurrentRow.Cells[3].Value.ToString(), dtgvProduct.CurrentRow.Cells[4].Value.ToString(),
                dtgvProduct.CurrentRow.Cells[5].Value.ToString(), dtgvProduct.CurrentRow.Cells[6].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            if (productPresenter.AddData())
            {
                productPresenter.GetProduct();
                productPresenter.ClearInformation();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            if (productPresenter.DeleteData())
            { 
                productPresenter.GetProduct();
                productPresenter.ClearInformation();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            if (productPresenter.EditData())
            {
                productPresenter.GetProduct();
                productPresenter.ClearInformation();
            }
        }
    }
}
