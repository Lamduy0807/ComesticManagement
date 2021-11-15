using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckValidate(string username, string password)
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "Select * from Employee where Username = '" + username + "' and Password = '" + password + "'";
            if (connect.GetData(sqlQuery).Rows.Count == 1)
            {
                return true;
            }
            else
                return false;

        }
    }
}
