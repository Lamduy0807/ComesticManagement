using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Doan.Model
{
    public class Product
    {
        public int Product_id;
        public string ProductName;
        public float Price;
        public string Unit;
        public string Description;
        public string Original;
        public int ProductType;
        public List<string> GetProductType()
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "select TypeName from ProductType";
            List<string> data = new List<string>();
            foreach(DataRow row in connect.GetData(sqlQuery).Rows)
            {
                data.Add(row["TypeName"].ToString());
            }
            return data;
        }
        public DataTable GetProductData()
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "select Product_id, ProductName, Price, Description, Origin, Unit, TypeName from Product , ProductType where Product.ProductType = ProductType.ProductType_id";
            return connect.GetData(sqlQuery);
        }
        public string GetTypeString(string name)
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "select ProductType_id from ProductType where TypeName = '" + name + "'";
            return connect.GetData(sqlQuery).Rows.ToString();
        }
        public bool AddProduct(string name, string price, string des, string ori, string unit, string type)
        {
            string typeid = GetTypeString(type);

            SqlCommand cmd = new SqlCommand("INSERT INTO Product (ProductName, Price,Description,Origin,Unit,ProductType) VALUES (@name, @price, @des, @ori, @uni, @ptid)");
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@des", des);
            cmd.Parameters.AddWithValue("@ori", ori);
            cmd.Parameters.AddWithValue("@uni", unit);
            //cmd.Parameters.AddWithValue("@ptid", 1);
            cmd.Parameters.Add("@ptid", SqlDbType.Int);
            cmd.Parameters["@ptid"].Value = Convert.ToInt32(typeid);

            ConnectDB connect = new ConnectDB();
            if (connect.AddData(cmd))
            {
                return true;
            }
            else
                return false;
        }
    }
}
