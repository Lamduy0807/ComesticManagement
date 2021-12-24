using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
        public string UserID(string username, string password)
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "Select Employee_id from Employee where Username = '" + username + "' and Password = '" + password + "'";
            return connect.GetData(sqlQuery).Rows[0]["Employee_id"].ToString();
        }
        public string UserName(string username, string password)
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "Select EmployName from Employee where Username = '" + username + "' and Password = '" + password + "'";
            return connect.GetData(sqlQuery).Rows[0]["EmployName"].ToString();
        }
        public DataTable LoadListEmployee()
        {
            ConnectDB connect = new ConnectDB();
            string sqlQuery = "Select * from Employee";           
            return connect.GetData(sqlQuery);

        }

        public bool AddEmployee(string name, string citizen_id, string email, string phone, string position, string address)
        { 
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee (EmployName, Citizen_id, Address, PhoneNumber, Email, Position, Username, Password) VALUES (@name, @citizen_id, @address, @phone, @email, @position, @username, @password)");
            
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@citizen_id", citizen_id);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@address", address);            
            cmd.Parameters.AddWithValue("@username", email);
            cmd.Parameters.AddWithValue("@password", citizen_id);
           
            ConnectDB connect = new ConnectDB();
            if (connect.HandleData(cmd))
            {
                return true;
            }
            else
                return false;
        }

        public bool DeleteEmployee(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE Employee WHERE Employee_id = @id");
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
       
        public bool UpdateEmployee(string id, string name, string citizen_id, string email, string phone, string position,
            string address, string password)
        {  
            SqlCommand cmd = new SqlCommand("UPDATE	Employee SET EmployName = @name, Citizen_id = @citizen_id, Address = @address, PhoneNumber = @phone, Email = @email, Position = @position, Password = @password WHERE Employee_id = @id");
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@citizen_id", citizen_id); 
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@password", password);
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
    }
}
