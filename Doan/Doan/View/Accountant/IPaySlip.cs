using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.View.Accountant
{
    public interface IPaySlip
    {
        string Date { get; set; }
        string Status { get; set; }
        BunifuDataGridView dgvPaySlip { get; set; }
    }
}
