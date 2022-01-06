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

        BunifuDataGridView IProduct.gvData 
        {
            get { return dtgvProduct; } 
            set { dtgvProduct = value; }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            productPresenter.GetProductType();
            productPresenter.GetProduct();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dtgvProduct_DoubleClick(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            productPresenter.RetriveProduct(dtgvProduct.CurrentRow.Index,dtgvProduct.CurrentRow.Cells[0].Value.ToString()
                , dtgvProduct.CurrentRow.Cells[1].Value.ToString(), dtgvProduct.CurrentRow.Cells[2].Value.ToString(), 
                dtgvProduct.CurrentRow.Cells[3].Value.ToString(), dtgvProduct.CurrentRow.Cells[4].Value.ToString(),
                dtgvProduct.CurrentRow.Cells[5].Value.ToString(), dtgvProduct.CurrentRow.Cells[6].Value.ToString());
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
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
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            if (productPresenter.CheckInformationEdit())
            {
                if (productPresenter.EditData())
                {
                    productPresenter.GetProduct();
                    productPresenter.ClearInformation();
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please check information again!");
                btnEdit.Enabled = true;
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            ProductPresenter productPresenter = new ProductPresenter(this);
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1);
            }
            if (productPresenter.CheckInformation())
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }
    }
}
