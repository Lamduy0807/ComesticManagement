using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Model;
using Doan.View.Export;

namespace Doan.Presenter
{
    public class ExportPresenter
    {
        IExport exportview;
        Export export = new Export();


        public ExportPresenter(IExport view)
        {
            exportview = view;
        }

        public bool GetProduct()
        {
            DataTable dt = new DataTable();
            dt = export.GetProductData();
            exportview.gvProductData.DataSource = dt;
            return true;
        }

        public bool ClearInformation()
        {
            exportview.ProductId = "";
            exportview.ProductName = "";
            exportview.ExportPrice = "";
            exportview.Quantity = "";
            exportview.Total = "";

            return true;
        }
        public bool RetriveProduct(int index, string id, string name, string price)
        {
            if (index != -1)
            {
                ClearInformation();
                exportview.ProductId = id;
                exportview.ProductName = name;
                exportview.ExportPrice = price;
            }
            return true;
        }
        public bool RetriveData(int index, string id, string name, string exportprice, string quantity, string total)
        {
            if (index != -1)
            {
                ClearInformation();
                exportview.ProductId = id;
                exportview.ProductName = name;
                exportview.ExportPrice = exportprice;
                exportview.Quantity = quantity;
                exportview.Total = total;
            }
            return true;
        }
        public bool AddDataToDataGridview()
        {
            if (CheckInformation())
            {
                bool found = false;
                if (exportview.gvDetailProductData.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in exportview.gvDetailProductData.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == exportview.ProductId)
                        {
                            row.Cells[3].Value = (int.Parse(exportview.Quantity) + Convert.ToInt16(row.Cells[3].Value.ToString()));
                            row.Cells[4].Value = (double.Parse(exportview.Total) + Convert.ToDouble(row.Cells[4].Value.ToString()));
                            found = true;
                            return true;
                        }
                        if (!found)
                        {
                            exportview.gvDetailProductData.Rows.Add(exportview.ProductId, exportview.ProductName, exportview.ExportPrice, exportview.Quantity, exportview.Total);
                            return true;
                        }
                        else
                        {
                            exportview.gvDetailProductData.Rows.Add(exportview.ProductId, exportview.ProductName, exportview.ExportPrice, exportview.Quantity, exportview.Total);
                            return true;
                        }
                    }
                }
                return true;
            }
            else
            {
                exportview.message = "Please check infromation again";
                return false;
            }
        }
        public bool CalculateTotal()
        {
            if (exportview.Quantity != "")
            {
                if (Convert.ToInt32(exportview.Quantity) > 0)
                {
                    double total = Convert.ToDouble(exportview.ExportPrice) * Convert.ToInt32(exportview.Quantity);
                    exportview.Total = total.ToString();
                }
            }
            return true;
        }
        public bool CalculateTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < exportview.gvDetailProductData.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(exportview.gvDetailProductData.Rows[i].Cells[4].Value);
            }
            exportview.TotalPrice = sum.ToString();
            return true;
        }
        public bool CheckInformation()
        {
            if (string.IsNullOrEmpty(exportview.ProductId))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(exportview.ProductName))
                return false;
            else if (string.IsNullOrEmpty(exportview.ExportPrice))
                return false;
            else if (string.IsNullOrEmpty(exportview.Quantity))
                return false;
            else
                return true;
        }
        public bool SearchInformation(string search)
        {
            DataTable dt = new DataTable();
            dt = export.SearchData(search);
            exportview.gvProductData.DataSource = dt;
            return true;
        }
        public bool DeleteDatainDataGridview()
        {
            foreach (DataGridViewRow item in exportview.gvDetailProductData.SelectedRows)
            {
                DataGridViewRow row = exportview.gvDetailProductData.Rows[item.Index];
                exportview.gvDetailProductData.Rows.RemoveAt(item.Index);
            }
            return true;
        }
        public bool EditData(int index)
        {
            DataGridViewRow newDataRow = exportview.gvDetailProductData.Rows[index];
            newDataRow.Cells[0].Value = exportview.ProductId;
            newDataRow.Cells[1].Value = exportview.ProductName;
            newDataRow.Cells[2].Value = exportview.ExportPrice;
            newDataRow.Cells[3].Value = exportview.Quantity;
            newDataRow.Cells[4].Value = exportview.Total;
            return true;
        }
        public bool ClearData()
        {
            ClearInformation();
            exportview.TotalPrice = "";
            exportview.ExportReason = "";
            exportview.gvDetailProductData.Rows.Clear();
            exportview.gvDetailProductData.Refresh();
            return true;
        }
        public bool AddDataToDB()
        {
            string id = export.AddData(exportview.EmployeeID, exportview.ExportReason, exportview.TotalPrice);

            if (exportview.gvDetailProductData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in exportview.gvDetailProductData.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) != "")
                    {
                        export.AddDetailData(row.Cells[0].Value.ToString(), id, row.Cells[2].Value.ToString(),
                          row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                        export.UpdateProduct(row.Cells[3].Value.ToString(), row.Cells[0].Value.ToString());
                    }
                }
                exportview.message = "Add successfully";
                return true;
            }
            else
            {
                exportview.message = "Check information again";
                return false;
            }
        }
    }
}
