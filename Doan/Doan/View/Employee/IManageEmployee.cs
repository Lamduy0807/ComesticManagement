using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace Doan.View.Employee
{
    public interface IManageEmployee
    {
        string Empoyee_idtext { get; set; }
        string Nametext { get; set; }
        string Emailtext { get; set; }
        string Citizen_idtext { get; set; }
        string Addresstext { get; set; }
        string Positiontext { get; set; }
        string PhoneNumtext { get; set; }

        DataGridView gvEmployee { get; set; }
    }
}
