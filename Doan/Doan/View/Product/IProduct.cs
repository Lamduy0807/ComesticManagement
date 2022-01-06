using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using static System.Windows.Forms.ComboBox;

namespace Doan.View.Product
{
    public interface IProduct
    {
        string ProductID { get; set; }
        string ProductName { get; set; }
        string Price { get; set; }
        string Unit { get; set; }
        string Description { get; set; }
        string Original { get; set; }
        string ProductType { get; set; }
        string message { get; set; }
        ObjectCollection cbData { get; }
        BunifuDataGridView gvData { get; set; }
    }
}
