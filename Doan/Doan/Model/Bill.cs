using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Model
{
    public class Bill
    {
        public int Bill_id;
        public int Employee_id;
        public string Cus_Name;
        public string PhoneNumber;
        public float BillValue;

        public int Product_id;
        public string Product_Name;
        public float Price;
        public int Quantity;


        public DataTable GetProductData()
        {
            ConnectDB connect = new ConnectDB();
            //string sqlQuery = "select Product_id, ProductName, Price, Description, Origin, Unit, TypeName from Product , ProductType where Product.ProductType = ProductType.ProductType_id";
            string sqlQuery = "select Product_id, ProductName, Price, Origin from Product , ProductType where Product.ProductType = ProductType.ProductType_id";

            return connect.GetData(sqlQuery);
        }
        public DataTable SearchData(string search)
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "select Product_id, ProductName, Price, Origin from Product , ProductType where Product.ProductType = ProductType.ProductType_id and (Product_id like '" + search + "%' or ProductName like N'" + search + "%')";
            return connect.GetData(sqlQuery);
        }

        public string AddData(string employee, string name, string phone, string bill_value)
        {

            DateTime dateTime = DateTime.UtcNow.Date;

            SqlCommand cmd = new SqlCommand("INSERT INTO Bill (Employee_id, Cus_Name, PhoneNumber, BillValue, DateBill) VALUES (@employ, @name, @phone, @bill_value, @date)"
                + "Select Scope_Identity()");

            cmd.Parameters.Add("@employ", SqlDbType.Int);
            cmd.Parameters["@employ"].Value = Convert.ToInt32(employee);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.Add("@date", SqlDbType.Date);
            cmd.Parameters["@date"].Value = dateTime;
            cmd.Parameters.Add("@bill_value", SqlDbType.Float);
            cmd.Parameters["@bill_value"].Value = Convert.ToDouble(bill_value);

            ConnectDB connect = new ConnectDB();
            return connect.GetId(cmd).ToString();
        }

        public bool AddDetailData(string bill_id, string product_id,  string price, string quantity)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DetailBill (Bill_id, Product_id, Quantity, PresentPrice) VALUES (@bill_id, @product_id,  @quan, @price )");
            cmd.Parameters.Add("@product_id", SqlDbType.Int);
            cmd.Parameters["@product_id"].Value = Convert.ToInt32(product_id);
            cmd.Parameters.Add("@bill_id", SqlDbType.Int);
            cmd.Parameters["@bill_id"].Value = Convert.ToInt32(bill_id);
            cmd.Parameters.Add("@price", SqlDbType.Float);
            cmd.Parameters["@price"].Value = Convert.ToDouble(price);
            cmd.Parameters.Add("@quan", SqlDbType.Int);
            cmd.Parameters["@quan"].Value = Convert.ToInt32(quantity);           

            ConnectDB connect = new ConnectDB();
            if (connect.HandleData(cmd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProduct(string quantity, string id)
        {
            SqlCommand cmd = new SqlCommand("Update Product set Quantities = Quantities - @quan where Product_id = @id");
            cmd.Parameters.Add("@quan", SqlDbType.Int);
            cmd.Parameters["@quan"].Value = Convert.ToInt32(quantity);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = Convert.ToInt32(id);

            ConnectDB connect = new ConnectDB();
            if (connect.HandleData(cmd))
            {
                return true;
            }
            else
                return false;
        }


        public bool AutoCreateReceipts(string Employee_id, string Content, string TotalPay, string Status, string Note)
        {
            DateTime dateTime = DateTime.UtcNow.Date;

            SqlCommand cmd = new SqlCommand("INSERT INTO Receipt (Employee_id, Content, CreateDate, TotalPay, Status, Note) VALUES (@Employee_id, @Content, @date, @TotalPay, @Status, @Note)");
            cmd.Parameters.Add("@Employee_id", SqlDbType.Int);
            cmd.Parameters["@Employee_id"].Value = Convert.ToInt32(Employee_id);

            cmd.Parameters.AddWithValue("@Content", Content);
            cmd.Parameters.AddWithValue("@Note", Note);
            cmd.Parameters.AddWithValue("@Status", Status);

            cmd.Parameters.Add("@date", SqlDbType.Date);
            cmd.Parameters["@date"].Value = dateTime;

            cmd.Parameters.Add("@TotalPay", SqlDbType.Float);
            cmd.Parameters["@TotalPay"].Value = Convert.ToDouble(TotalPay);

           


            ConnectDB connect = new ConnectDB();
            if (connect.HandleData(cmd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
