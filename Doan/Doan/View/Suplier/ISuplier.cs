using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan.View.Suplier
{
    public interface ISuplier
    {
        string SuplierId { get; set; }
        string SuplierName { get; set; }
        string SuplierPhone { get; set; }
        string SuplierAddress { get; set; }
        string SuplierEmail { get; set; }
        string message { get; set; }
        DataGridView gvData { get; set; }
    }
}
