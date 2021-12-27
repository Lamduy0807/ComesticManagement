using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan.View.Statistic
{
    public interface IStatistics
    {
        string Date { get; set; }
        string RevenueMonth { get; set; }
        string RevenueToday { get; set; }
        string SumProduct { get; set; }
        string BillMonth { get; set; }
        string BillToday { get; set; }
        DataGridView gvBestSeller { get; set; }
    }
}
