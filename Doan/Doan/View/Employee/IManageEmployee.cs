using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Doan.View.Employee
{
    public interface IManageEmployee
    {
        /*string Employee_idtext { get; set; }
        string Nametext { get; set; }
        string Emailtext { get; set; }
        string Citizen_idtext { get; set; }
        string Addresstext { get; set; }
        string Positiontext { get; set; }
        string PhoneNumtext { get; set; }
        string Username { get; set; }
        string Password { get; set; }*/

        string employee_id { get; set; }
        string message { get; set; }
        BunifuDataGridView dgvEmployee { get; set; }

    }
}
