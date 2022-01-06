using Doan.Model;
using Doan.View.Sale;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan.Presenter
{
    public class SalePresenter
    {
        ISale saleview;
        Bill bill = new Bill();

        public SalePresenter(ISale view)
        {
            saleview = view;
        }

        public bool GetProduct()
        {
            DataTable dt = new DataTable();
            dt = bill.GetProductData();
            saleview.dgv_ListProduct.DataSource = dt;
            return true;
        }

        public bool ClearInformation()
        {
            saleview.Product_id = "";
            saleview.Product_Name = "";
            saleview.Price = "";
            saleview.Quantity = "";         

            return true;
        }

        public bool RetriveProduct(int index, string id, string name, string price)
        {
            if (index != -1)
            {
                ClearInformation();
                saleview.Product_id = id;
                saleview.Product_Name = name;
                saleview.Price = price;
                saleview.Quantity = "1";

            }
            return true;
         
        }

        public bool AddDataToDataGridview()
        {
            if (CheckInformation())
            {             

                bool found = false;
                if (saleview.dgvCart.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in saleview.dgvCart.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == saleview.Product_id)
                        {
                            row.Cells[3].Value = (int.Parse(saleview.Quantity) + Convert.ToInt16(row.Cells[3].Value.ToString()));
                           
                            found = true;
                            return true;
                        }
                        
                    }
                    if (!found)
                    {
                        saleview.dgvCart.Rows.Add(saleview.Product_id, saleview.Product_Name, saleview.Price, saleview.Quantity);
                        return true;
                    }
                    
                }
                else
                {
                    saleview.dgvCart.Rows.Add(saleview.Product_id, saleview.Product_Name, saleview.Price, saleview.Quantity);
                    return true;
                }
                return true;
            }
            else
            {
               //exportview.message = "Please check infromation again";
                return false;
            }
            ///////////////////////////////////

           

        }

        public bool CalculateTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < saleview.dgvCart.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(saleview.dgvCart.Rows[i].Cells[2].Value) * Convert.ToDouble(saleview.dgvCart.Rows[i].Cells[3].Value);
            }
            saleview.BillValue= sum.ToString();
            return true;
        }

        public bool CheckInformation()
        {
            if (string.IsNullOrEmpty(saleview.Product_id))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(saleview.Product_Name))
                return false;
            else if (string.IsNullOrEmpty(saleview.Price))
                return false;
            else if (string.IsNullOrEmpty(saleview.Quantity))
                return false;
            else
                return true;
        }

        public bool SearchInformation(string search)
        {
            DataTable dt = new DataTable();
            dt = bill.SearchData(search);
            saleview.dgv_ListProduct.DataSource = dt;
            return true;
        }

        public bool DeleteDatainDataGridview()
        {
            foreach (DataGridViewRow item in saleview.dgvCart.SelectedRows)
            {
                DataGridViewRow row = saleview.dgvCart.Rows[item.Index];
                saleview.dgvCart.Rows.RemoveAt(item.Index);
            }
            return true;
        }

        public bool AddDataToDB()
        {
            string id = bill.AddData(saleview.Employee, saleview.Cus_Name, saleview.Phone, saleview.BillValue);

            ///chỗ này add tự động vô phiếu thu
            string contentReceipt = "Bill ID: " + id;
            string status = "Completed";
            bill.AutoCreateReceipts(saleview.Employee, contentReceipt, saleview.BillValue, status, "");
            ///end
            ///
            if (saleview.dgvCart.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in saleview.dgvCart.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) != "")
                    {
                        bill.AddDetailData(id, row.Cells[0].Value.ToString(),  row.Cells[2].Value.ToString(),
                          row.Cells[3].Value.ToString());
                        //bill.UpdateProduct(row.Cells[3].Value.ToString(), row.Cells[0].Value.ToString());
                    }
                }
                saleview.message = "Add successfully";
                return true;
            }
            else
            {
                saleview.message = "Check information again";
                return false;
            }
        }
        public bool ClearData()
        {
            ClearInformation();
            saleview.Cus_Name = "";
            saleview.Phone = "";
            saleview.BillValue = "";
            saleview.dgvCart.Rows.Clear();
            saleview.dgvCart.Refresh();
            return true;
        }

       
    }
}
