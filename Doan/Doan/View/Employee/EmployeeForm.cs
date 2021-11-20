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

namespace Doan.View.Employee
{
    public partial class EmployeeForm : Form, IManageEmployee
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public string Employee_idtext
        {
            get
            {
                return tbEmployeeID.Text;
            }
            set
            {
                tbEmployeeID.Text = value;
            }
        }
        public string Nametext
        {
            get
            {
                return tbName.Text;
            }
            set
            {
                tbName.Text = value;
            }
        }
        public string Emailtext
        {
            get
            {
                return tbCitizenID.Text;
            }
            set
            {
                tbCitizenID.Text = value;
            }
        }
        public string Citizen_idtext
        {
            get
            {
                return tbEmail.Text;
            }
            set
            {
                tbEmail.Text = value;
            }
        }
        public string Addresstext
        {
            get
            {
                return tbAddress.Text;
            }
            set
            {
                tbAddress.Text = value;
            }
        }
        public string Positiontext
        {
            get
            {
                return tbPhone.Text;
            }
            set
            {
                tbPhone.Text = value;
            }
        }
        public string PhoneNumtext
        {
            get
            {
                return tbPosition.Text;
            }
            set
            {
                tbPosition.Text = value;
            }
        }

        public DataGridView gvEmployee
        {
            get { return dgvEmployee; }
            set { dgvEmployee = value; }
        }
        public string Username
        {
            get
            {
                return tbUsername.Text;
            }
            set
            {
                tbUsername.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return tbPassword.Text;
            }
            set
            {
                tbPassword.Text = value;
            }
        }

        //public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*private void button4_Click(object sender, EventArgs e)
        {

        }*/

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            employeePresenter.LoadListEmployee();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            employeePresenter.AddData();

        }
    }
}
