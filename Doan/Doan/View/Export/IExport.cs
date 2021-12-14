using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Doan.View.Export
{
    public interface IExport
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string EmployeeID { get; }
        string TotalPrice { get; set; }
        string ExportPrice { get; set; }
        string Quantity { get; set; }
        string Total { get; set; }
        string message { get; set; }
        string Search { get; set; }
        string ExportReason { get; set; }
        DataGridView gvProductData { get; set; }
        DataGridView gvDetailProductData { get; set; }
    }
}
