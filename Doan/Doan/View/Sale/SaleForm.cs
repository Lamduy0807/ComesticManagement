using Bunifu.UI.WinForms;
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

namespace Doan.View.Sale
{
    public partial class SaleForm : Form, ISale
    {
        public SaleForm()
        {
            InitializeComponent();
        }        

        public string Find {
            get { return txtFind.Text; }
            set { txtFind.Text = value; }
        }
        public string Cus_Name {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }

        private string _id;
        public string Employee {
            get { return _id; }            
        }
        public SaleForm(string id) : this()
        {
            this._id = id;
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

        BunifuDataGridView ISale.dgv_ListProduct
        {
            get { return dgv_ListProduct; }
            set { dgv_ListProduct = value; }
        }

        BunifuDataGridView ISale.dgvCart {
            get { return dgvCart; }
            set { dgvCart = value; }
        }

        string ISale.Product_id { get; set; }
        string ISale.Product_Name { get; set; }
        string ISale.Price { get; set; }
        string ISale.Quantity { get; set; }
        public string BillValue
        {
            get { return txtTotalPrice.Text; }
            set { txtTotalPrice.Text = value; }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.GetProduct();

        }
    
        private void dgv_ListProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.RetriveProduct(dgv_ListProduct.CurrentRow.Index, dgv_ListProduct.CurrentRow.Cells[0].Value.ToString()
                , dgv_ListProduct.CurrentRow.Cells[1].Value.ToString(), dgv_ListProduct.CurrentRow.Cells[2].Value.ToString());
        }        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            if (salePresenter.AddDataToDataGridview())
            {
                salePresenter.CalculateTotalPrice();
                salePresenter.ClearInformation();
            }

        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            if (salePresenter.AddDataToDB())
            {               
                salePresenter.ClearData();
            }    
               
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.RetriveProduct(dgvCart.CurrentRow.Index, dgvCart.CurrentRow.Cells[0].Value.ToString()
                , dgvCart.CurrentRow.Cells[1].Value.ToString(), dgvCart.CurrentRow.Cells[2].Value.ToString()
                );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.DeleteDatainDataGridview();
            salePresenter.CalculateTotalPrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.ClearData();
        }

        private void txtFind_TextChanged_1(object sender, EventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.SearchInformation(txtFind.Text);
        }
    }
}
