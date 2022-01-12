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

namespace Doan.View.Employee
{
    public partial class EmployeeForm : Form, IManageEmployee
    {

        private string _employee_id;
        public EmployeeForm()
        {
            InitializeComponent();
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

        BunifuDataGridView IManageEmployee.dgvEmployee
        {
            get { return dgvEmployee; }
            set { dgvEmployee = value; }
        }

        public string employee_id { 
            get { return _employee_id; }
            set
            {
                _employee_id = value;
               
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            employeePresenter.LoadListEmployee();

            btnEditEmployee.Enabled = false;
            btnDelete.Enabled = false;
            label2.Font = new Font(label2.Font, FontStyle.Bold);
        }



        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this._employee_id = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            if (dgvEmployee.CurrentRow.Cells[0].Value.ToString() == "")
            {
                btnEditEmployee.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEditEmployee.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee(true);
            newEmployee.Show();
            //EmployeeForm_Load(sender, e);
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (btnEditEmployee.Enabled.ToString() == "True")
            {
                btnEditEmployee.Enabled = false;
                btnDelete.Enabled = false;
                NewEmployee newEmployee = new NewEmployee(false,
                    dgvEmployee.CurrentRow.Cells[0].Value.ToString(),
                    dgvEmployee.CurrentRow.Cells[1].Value.ToString(),
                    dgvEmployee.CurrentRow.Cells[2].Value.ToString(),
                    dgvEmployee.CurrentRow.Cells[3].Value.ToString(),
                    dgvEmployee.CurrentRow.Cells[4].Value.ToString(),
                    dgvEmployee.CurrentRow.Cells[5].Value.ToString(),
                    dgvEmployee.CurrentRow.Cells[6].Value.ToString(),
                     dgvEmployee.CurrentRow.Cells[7].Value.ToString(),
                    dgvEmployee.CurrentRow.Cells[8].Value.ToString());

                newEmployee.Show();
                //EmployeeForm_Load(sender,e);
            }
        }

   

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            employeePresenter.SearchInformation(tbSearch.Text);

            btnEditEmployee.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure delete this employee?", "Notification", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                EmployeePresenter employeePresenter = new EmployeePresenter(this);

                if (employeePresenter.DeleteData())
                {
                    employeePresenter.LoadListEmployee();
                    //employeePresenter.ClearEmployee();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            EmployeePresenter employeePresenter = new EmployeePresenter(this);
            employeePresenter.LoadListEmployee();

            btnEditEmployee.Enabled = false;
            btnDelete.Enabled = false;
            label2.Font = new Font(label2.Font, FontStyle.Bold);
        }
    }
}
