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
                return tbEmail.Text;
                
            }
            set
            {
                tbEmail.Text = value;
                
            }
        }
        public string Citizen_idtext
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
                return tbPosition.Text;
            }
            set
            {
                tbPosition.Text = value;
            }
        }
        public string PhoneNumtext
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


        private string _message;
        public string message {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message);
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            employeePresenter.LoadListEmployee();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeePresenter employeePresenter = new EmployeePresenter(this);            
            if (employeePresenter.AddData())
            {
                employeePresenter.LoadListEmployee();
                employeePresenter.ClearEmployee();
            }
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            employeePresenter.RetriveEmployee(dgvEmployee.CurrentRow.Index, dgvEmployee.CurrentRow.Cells[0].Value.ToString(),
               dgvEmployee.CurrentRow.Cells[1].Value.ToString(), dgvEmployee.CurrentRow.Cells[2].Value.ToString(),
               dgvEmployee.CurrentRow.Cells[3].Value.ToString(), dgvEmployee.CurrentRow.Cells[4].Value.ToString(),
               dgvEmployee.CurrentRow.Cells[5].Value.ToString(), dgvEmployee.CurrentRow.Cells[6].Value.ToString(),
               dgvEmployee.CurrentRow.Cells[7].Value.ToString(), dgvEmployee.CurrentRow.Cells[8].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            if(employeePresenter.DeleteData())
            { employeePresenter.LoadListEmployee();
                employeePresenter.ClearEmployee();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {           
            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            if(employeePresenter.EditData())
            {
                employeePresenter.LoadListEmployee();
                employeePresenter.ClearEmployee();
            }

        }
    }
}
