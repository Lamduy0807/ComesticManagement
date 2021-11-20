using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Doan.Presenter;
using Doan.Model;
using System.Data.SqlClient;

namespace Doan.View.Employee
{
    public partial class frmManageEmployee : Form, IManageEmployee
    {
        /*private DataTable _employee;*/

        public frmManageEmployee()
        {
            InitializeComponent();
          
        }

        public string Empoyee_idtext
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public string Nametext
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }
        public string Emailtext
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }
        public string Citizen_idtext
        {
            get
            {
                return textBox4.Text;
            }
            set
            {
                textBox4.Text = value;
            }
        }
        public string Addresstext
        {
            get
            {
                return textBox7.Text;
            }
            set
            {
                textBox7.Text = value;
            }
        }
        public string Positiontext
        {
            get
            {
                return textBox5.Text;
            }
            set
            {
                textBox5.Text = value;
            }
        }
        public string PhoneNumtext
        {
            get
            {
                return textBox6.Text;
            }
            set
            {
                textBox6.Text = value;
            }
        }

        public DataGridView gvEmployee
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }

        private void frmManageEmployee_Load(object sender, EventArgs e)
        {
             ManageEmployeePresenter manageEmployeePresenter = new ManageEmployeePresenter(this);          
            manageEmployeePresenter.LoadListEmployee();

            /* SqlConnection con = new SqlConnection();
             con.ConnectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = doan; Integrated Security = True";
             con.Open();
             String sql = "select * from Employee";
             DataSet ds = new DataSet();
             SqlDataAdapter dap = new SqlDataAdapter(sql, con);
             dap.Fill(ds);
             dataGridView1.DataSource = ds.Tables[0];*/



        }

        
    }
}
