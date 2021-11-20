using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doan.Model;
using Doan.View;
using Doan.View.Employee;
using System.Data;

namespace Doan.Presenter
{
    public class ManageEmployeePresenter
    {
        IManageEmployee manageEmployeeview;
       

        public ManageEmployeePresenter(IManageEmployee view)
        {
            manageEmployeeview = view;
        }

        public bool LoadListEmployee()
        {
            User user = new User();
            //DataTable dataTable = new DataTable();
            //dataTable = user.LoadListEmployee();
            manageEmployeeview.gvEmployee.DataSource = user.LoadListEmployee();
            return true;
        }
    }
}
