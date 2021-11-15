using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Model
{
    class ConnectDB
    {
        SqlConnection connect;
        public ConnectDB()
        {
            this.connect = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = doan; Integrated Security = True");
        }
        public DataTable GetData(string sqlquery)
        {
            SqlDataAdapter sqldata = new SqlDataAdapter(sqlquery, this.connect);
            DataTable dataTable = new DataTable();
            sqldata.Fill(dataTable);
            return dataTable;
        }
    }

}
