using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }

}
