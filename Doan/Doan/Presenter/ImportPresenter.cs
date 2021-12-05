using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Model;
using Doan.View.Import;

namespace Doan.Presenter
{
    public class ImportPresenter
    {
        IImport importview;
        Import import = new Import();


        public ImportPresenter(IImport view)
        {
            importview = view;
        }

        public bool GetProduct()
        {
            DataTable dt = new DataTable();
            dt = import.GetProductData();
            importview.gvProductData.DataSource = dt;
            return true;
        }
        public bool GetSuplier()
        {
            foreach (string item in import.GetSuplier())
            {
                importview.cbData.Add(item);
            }
            return true;
        }
        public bool ClearInformation()
        {
            importview.ProductId = "";
            importview.ProductName = "";
            importview.ImportPrice = "";
            importview.Quantity = "";
            importview.Total = "";

            return true;
        }
        public bool RetriveProduct(int index, string id, string name)
        {
            if (index != -1)
            {
                ClearInformation();
                importview.ProductId = id;
                importview.ProductName = name;
            }
            return true;
        }
        public bool RetriveData(int index, string id, string name, string importprice, string quantity, string total)
        {
            if (index != -1)
            {
                ClearInformation();
                importview.ProductId = id;
                importview.ProductName = name;
                importview.ImportPrice = importprice;
                importview.Quantity = quantity;
                importview.Total = total;
            }
            return true;
        }
        public bool AddDataToDataGridview()
        {
            if (CheckInformation())
            {
                bool found = false;
                if (importview.gvDetailProductData.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in importview.gvDetailProductData.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == importview.ProductId)
                        {
                            row.Cells[3].Value = (int.Parse(importview.Quantity) + Convert.ToInt16(row.Cells[3].Value.ToString()));
                            row.Cells[4].Value = (double.Parse(importview.Total) + Convert.ToDouble(row.Cells[4].Value.ToString()));
                            found = true;
                            return true;
                        }
                        if (!found)
                        {
                            importview.gvDetailProductData.Rows.Add(importview.ProductId, importview.ProductName, importview.ImportPrice, importview.Quantity, importview.Total);
                            return true;
                        }
                        else
                        {
                            importview.gvDetailProductData.Rows.Add(importview.ProductId, importview.ProductName, importview.ImportPrice, importview.Quantity, importview.Total);
                            return true;
                        }
                    }
                }
                return true;
            }
            else
            {
                importview.message = "Please check infromation again";
                return false;
            }
        }
        public bool CalculateTotal()
        {
            if (importview.Quantity!="")
            {
                if (Convert.ToInt32(importview.Quantity) > 0)
                {
                    double total = Convert.ToDouble(importview.ImportPrice) * Convert.ToInt32(importview.Quantity);
                    importview.Total = total.ToString();
                }
            }
            return true;
        }
        public bool CalculateTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < importview.gvDetailProductData.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(importview.gvDetailProductData.Rows[i].Cells[4].Value);
            }
            importview.TotalPrice = sum.ToString();
            return true;
        }
        public bool CheckInformation()
        {
            if (string.IsNullOrEmpty(importview.ProductId))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(importview.ProductName))
                return false;
            else if (string.IsNullOrEmpty(importview.ImportPrice))
                return false;
            else if (string.IsNullOrEmpty(importview.Quantity))
                return false;
            else
                return true;
        }
        public bool SearchInformation(string search)
        {
            DataTable dt = new DataTable();
            dt = import.SearchData(search);
            importview.gvProductData.DataSource = dt;
            return true;
        }
        public bool DeleteDatainDataGridview()
        {
            foreach(DataGridViewRow item in importview.gvDetailProductData.SelectedRows)
            {
                DataGridViewRow row = importview.gvDetailProductData.Rows[item.Index];
                importview.gvDetailProductData.Rows.RemoveAt(item.Index); 
            }
            return true;
        }
        public bool EditData(int index)
        {
            DataGridViewRow newDataRow = importview.gvDetailProductData.Rows[index];
            newDataRow.Cells[0].Value = importview.ProductId;
            newDataRow.Cells[1].Value = importview.ProductName;
            newDataRow.Cells[2].Value = importview.ImportPrice;
            newDataRow.Cells[3].Value = importview.Quantity;
            newDataRow.Cells[4].Value = importview.Total;
            return true;
        }
        public bool ClearData()
        {
            ClearInformation();
            importview.TotalPrice = "";
            importview.SuplierName = null;
            importview.gvDetailProductData.Rows.Clear();
            importview.gvDetailProductData.Refresh();
            return true;
        }
        public bool AddDataToDB()
        {
            string id = import.AddData(importview.EmployeeID, importview.SuplierName, importview.TotalPrice);

            if (importview.gvDetailProductData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in importview.gvDetailProductData.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) != "")
                    {
                        import.AddDetailData(row.Cells[0].Value.ToString(), id, row.Cells[2].Value.ToString(),
                          row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                        import.UpdateProduct(row.Cells[3].Value.ToString(), row.Cells[0].Value.ToString());
                    }
                }
                importview.message = "Add successfully";
                return true;
            }
            else
            {
                importview.message = "Check information again";
                return false;
            }
        }
    }
}
