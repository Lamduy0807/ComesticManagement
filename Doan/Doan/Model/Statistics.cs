using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Doan.Model
{
    public class Statistics
    {
        public DataTable GetTop10ProductData()
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "SELECT TOP 10 with TIES ProductName , Sum(Quantity) as Sales from Product, DetailBill " 
                +"Where DetailBill.Product_id = Product.Product_id "
                +"Group BY ProductName,  Quantity "
                +"Order By Sum(Quantity) DESC";
            return connect.GetData(sqlQuery);
        }
        public string GetNumberOfBillMonth(string month, string year)
        {
            //string sMonth = DateTime.Now.ToString("MM");
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "SELECT COUNT(Bill_id) as SL from Bill Where Month(DateBill) ='" + month + "' and Year(DateBill) = '"+ year + "'";
            return connect.GetData(sqlQuery).Rows[0]["SL"].ToString();
        }
        public string GetNumberOfBillToday(string day, string month, string year)
        {
            //string sDay = DateTime.Now.ToString("dd");
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "SELECT COUNT(Bill_id) as SL from Bill Where Day(DateBill) ='" + day + "' and Month(DateBill) = '"+ month + "' and Year(DateBill) = '"+ year + "'";
            return connect.GetData(sqlQuery).Rows[0]["SL"].ToString();
        }
        public string GetNumberOfRevuewnueMonth(string month, string year)
        {
            //string sMonth = DateTime.Now.ToString("MM");
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "SELECT Sum(BillValue) as Tong from Bill Where Month(DateBill) ='" + month + "' and Year(DateBill) = '" + year + "'";
            return connect.GetData(sqlQuery).Rows[0]["Tong"].ToString();
        }
        public string GetNumberOfRevuenueToday(string day, string month, string year)
        {
            //string sDay = DateTime.Now.ToString("dd");
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "SELECT Sum(BillValue) as Tong from Bill Where Day(DateBill) ='" + day + "' and Month(DateBill) = '" + month + "' and Year(DateBill) = '" + year + "'";
            return connect.GetData(sqlQuery).Rows[0]["Tong"].ToString();
        }

        public DataTable GetChartData(string month, string year)
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "Select CAST (DateBill AS DATE) AS Ngay, sum(BillValue) as Tong from Bill where MONTH(DateBill) = '" + month +"' and Year(DateBill) = '" + year +"' group by CAST (DateBill AS DATE) order by CAST (DateBill AS DATE)";
            return connect.GetData(sqlQuery);
        }
    }
}
