using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace Doan.View.Import
{
    public interface IImport
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string SuplierName { get; set; }
        string EmployeeID { get; }
        string EmployeeName { get; }
        string TotalPrice { get; set; }
        string ImportPrice { get; set; }
        string Quantity { get; set; }
        string Total { get; set; }
        string message { get; set; }
        string Search { get; set; }
        ObjectCollection cbData { get; }
        DataGridView gvProductData { get; set; }
        DataGridView gvDetailProductData { get; set; }
    }
}
