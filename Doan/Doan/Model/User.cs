﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Doan.View.Employee;

namespace Doan.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Employee_id { get; set; }
        public string EmployName { get; set; }
        public string Citizen_id { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
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


        public DataTable LoadListEmployee()
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "Select * from Employee";
            /*DataSet list = new DataSet();*/
            return connect.GetData(sqlQuery);
            
        }
    }
}
