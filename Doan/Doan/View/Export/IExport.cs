﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Doan.View.Export
{
    public interface IExport
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string EmployeeID { get; }
        string TotalPriceProduct { get; set; }
        string ExportPrice { get; set; }
        string Quantity { get; set; }
        string Total { get; set; }
        string message { get; set; }
        string Search { get; set; }
        string ExportReason { get; set; }
        string EmployeeName { get; }
        BunifuDataGridView gvProductData { get; set; }
        BunifuDataGridView gvDetailProductData { get; set; }
    }
}
