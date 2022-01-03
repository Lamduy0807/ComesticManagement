using Doan.Model;
using Doan.View.Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Presenter
{
    public class EmployeePresenter
    {
        IManageEmployee manageEmployeeview;
        User user = new User();

        public EmployeePresenter(IManageEmployee view)
        {
            manageEmployeeview = view;
        }

        public bool LoadListEmployee()
        {           
            manageEmployeeview.dgvEmployee.DataSource = user.LoadListEmployee();
            return true;
        }
        public bool SearchInformation(string search)
        {
            DataTable dt = new DataTable();
            dt = user.SearchData(search);
            manageEmployeeview.dgvEmployee.DataSource = dt;
            return true;
        }

        /* public bool RetriveEmployee(int index, string employee_id, string name, string citizen_id, string email, string phone, string position, string address, string username, string password)
         {
             if(index  != -1)
             {
                 manageEmployeeview.Employee_idtext = employee_id;
                 manageEmployeeview.Nametext = name;
                 manageEmployeeview.Citizen_idtext = citizen_id;
                 manageEmployeeview.Emailtext = email;
                 manageEmployeeview.PhoneNumtext = phone;
                 manageEmployeeview.Positiontext = position;
                 manageEmployeeview.Addresstext = address;
                 manageEmployeeview.Username = username;
                 manageEmployeeview.Password = password;
             }    
             return true;
         }*/

        /* public bool AddData()
         {
             if (user.AddEmployee(manageEmployeeview.Nametext, manageEmployeeview.Citizen_idtext, manageEmployeeview.Emailtext, 
                 manageEmployeeview.PhoneNumtext, manageEmployeeview.Positiontext, manageEmployeeview.Addresstext))
             {
                 manageEmployeeview.message = "Add employee successfully";
                 return true;
             }
             else
             {
                 manageEmployeeview.message = "Add employee unsuccessfully";
                 return false;
             }
         }*/

        public bool DeleteData()
        {

            if (user.DeleteEmployee(manageEmployeeview.employee_id))
            {
                manageEmployeeview.message = "Deleted employee successfully";
                return true;
            }
            else
            {
                manageEmployeeview.message = "Deleted employee unsuccessfully";
                return false;
            }
        }

        /* public bool EditData()
         {

             if (user.UpdateEmployee(manageEmployeeview.Employee_idtext, manageEmployeeview.Nametext,
                 manageEmployeeview.Citizen_idtext, manageEmployeeview.Emailtext, manageEmployeeview.PhoneNumtext, 
                 manageEmployeeview.Positiontext, manageEmployeeview.Addresstext, manageEmployeeview.Password))
             {
                 manageEmployeeview.message = "Update employee successfully";
                 return true;
             }
             else
                 manageEmployeeview.message = "Update employee unsuccessfully";
             {
                 return false;
             }
         }*/
    }
}
