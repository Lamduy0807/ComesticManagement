using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Model
{
    public class ConnectDB
    {
        SqlConnection connect;
        public ConnectDB()
        {
            this.connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ComesticDB;Integrated Security=True");
        }
        public DataTable GetData(string sqlquery)
        {
            SqlDataAdapter sqldata = new SqlDataAdapter(sqlquery, this.connect);
            DataTable dataTable = new DataTable();
            sqldata.Fill(dataTable);
            return dataTable;
        }
        public bool AddData(SqlCommand cmd)
        {
            cmd.Connection = this.connect;
            connect.Open();
            if(cmd.ExecuteNonQuery()> 0)
            {
                connect.Close();
                return true;
            }
            connect.Close();
            return false;
        }
    }

}
