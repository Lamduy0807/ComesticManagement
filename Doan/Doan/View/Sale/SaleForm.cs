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
using System.Drawing.Printing;


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
            get { return lbTotal.Text; }
            set { lbTotal.Text = value; }
        }

        BunifuDataGridView ISale.dgvDetailBill
        {
            get { return dgvDetailBill; }
            set { dgvDetailBill = value; }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.GetProduct();
            btnCreateBill.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            bunifuGroupBox4.Hide();

        }

        private void dgv_ListProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SalePresenter salePresenter = new SalePresenter(this);
            if (salePresenter.RetriveProduct(dgv_ListProduct.CurrentRow.Index, dgv_ListProduct.CurrentRow.Cells[0].Value.ToString()
                , dgv_ListProduct.CurrentRow.Cells[1].Value.ToString(), dgv_ListProduct.CurrentRow.Cells[2].Value.ToString()))
            {
                btnAdd.Enabled = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            SalePresenter salePresenter = new SalePresenter(this);
            if (salePresenter.AddDataToDataGridview())
            {
                salePresenter.CalculateTotalPrice();
                salePresenter.ClearInformation();
                btnAdd.Enabled = false;

            }
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
            {
                SalePresenter salePresenter = new SalePresenter(this);
                if (salePresenter.AddDataToDB())
                {
                    salePresenter.GetProduct();

                    DialogResult dr = MessageBox.Show(_message, "Notification", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        PrintDialog printDialog = new PrintDialog();
                        PrintDocument printDocument = new PrintDocument();

                        printDialog.Document = printDocument;
                        printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Createbill); DialogResult result = printDialog.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            printDocument.Print();

                        }
                    }

                    salePresenter.ClearData();
                    btnCreateBill.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = false;
                }
                else
                {
                    MessageBox.Show(_message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Not yet add product into cart. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Createbill(object sender, PrintPageEventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.Print(e);
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            if (salePresenter.RetriveProduct(dgvCart.CurrentRow.Index, dgvCart.CurrentRow.Cells[0].Value.ToString()
                 , dgvCart.CurrentRow.Cells[1].Value.ToString(), dgvCart.CurrentRow.Cells[2].Value.ToString()
                 ))
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SalePresenter salePresenter = new SalePresenter(this);
            salePresenter.DeleteDatainDataGridview();
            salePresenter.CalculateTotalPrice();
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure cancel all information?", "Notification", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SalePresenter salePresenter = new SalePresenter(this);
                salePresenter.ClearData();
                btnCancel.Enabled = false;
            }
        }

        private void txtFind_TextChanged_1(object sender, EventArgs e)
        {
            if (label2.Text == "View all bills")
            {
                SalePresenter salePresenter = new SalePresenter(this);
                salePresenter.SearchInformation(txtFind.Text);
            }
            else
            {
                SalePresenter salePresenter = new SalePresenter(this);
                salePresenter.SearchBill(txtFind.Text);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPhone.Text))
            {
                btnCreateBill.Enabled = true;
            }
            else
            {
                btnCreateBill.Enabled = false;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1);
            }
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPhone.Text))
            {
                btnCreateBill.Enabled = true;
            }
            else
            {
                btnCreateBill.Enabled = false;
            }
        }
        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                MessageBox.Show("Only edit in column Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvCart.CurrentRow.Cells[e.ColumnIndex].Value = _textEdit;
            }
            else
            {
                SalePresenter salePresenter = new SalePresenter(this);
                salePresenter.CalculateTotalPrice();
            }
        }
        private string _textEdit = "";
        private void dgvCart_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (label2.Text == "View all bills")
            {
                _textEdit = dgvCart.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "View all bills")
            {
                SalePresenter salePresenter = new SalePresenter(this);
                salePresenter.GetBill();
                label2.Text = "Selling";
                bunifuGroupBox1.Text = "All bills";
                txtFind.PlaceholderText = "Search bill by ID, name or phone";
                bunifuGroupBox2.Hide();
                bunifuGroupBox3.Hide();
                bunifuGroupBox4.Show();
                btnAdd.Hide();
                btnDelete.Hide();
            }
            else
            {
                SalePresenter salePresenter = new SalePresenter(this);
                salePresenter.GetProduct();
                label2.Text = "View all bills";
                bunifuGroupBox1.Text = "Product table";
                txtFind.PlaceholderText = "Search product by ID, name";
                bunifuGroupBox2.Show();
                bunifuGroupBox3.Show();
                bunifuGroupBox4.Hide();
                btnAdd.Show();
                btnDelete.Show();
            }
        }

        private void dgv_ListProduct_DoubleClick(object sender, EventArgs e)
        {
            if (label2.Text == "Selling")
            {
                SalePresenter salePresenter = new SalePresenter(this);
                if (salePresenter.LoadDetailBill(dgv_ListProduct.CurrentRow.Cells[0].Value.ToString()))
                {
                   /* salePresenter.CalculateTotalPrice();
                    salePresenter.ClearInformation();
                    btnAdd.Enabled = false;*/

                }
            }
        }
    }
}
