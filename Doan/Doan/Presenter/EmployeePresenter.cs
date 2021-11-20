using Doan.Model;
using Doan.View.Employee;
using System;
using System.Collections.Generic;
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
           
            //DataTable dataTable = new DataTable();
            //dataTable = user.LoadListEmployee();
            manageEmployeeview.gvEmployee.DataSource = user.LoadListEmployee();
            return true;
        }

        public bool ClearEmployee()
        {
            manageEmployeeview.Employee_idtext = "";
            manageEmployeeview.Nametext = "";
            manageEmployeeview.Citizen_idtext = "";
            manageEmployeeview.Emailtext = "";
            manageEmployeeview.PhoneNumtext = "";
            manageEmployeeview.Positiontext = "";
            manageEmployeeview.Addresstext = "";
            return true;
        }

        public bool RetriveProduct(int index, string employee_id, string name, string citizen_id, string email, string phone, string position, string address)
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
            }    
            return true;
        }

        public bool AddData()
        {
            if (user.AddEmployee(manageEmployeeview.Nametext, manageEmployeeview.Citizen_idtext, manageEmployeeview.Emailtext, 
                manageEmployeeview.PhoneNumtext, manageEmployeeview.Positiontext, manageEmployeeview.Addresstext))
            { 
                //productview.message = "add thành công";
                return true;
            }
            else
            {
               // productview.message = "Add không thành công";
                return false;
            }
        }
    }
}
