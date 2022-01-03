using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.View.Accountant
{
    public interface IReceiptsForm    {
        string Date { get; set; }
        string Status { get; set; }
        BunifuDataGridView dgvReceipts { get; set; }
    }
}
