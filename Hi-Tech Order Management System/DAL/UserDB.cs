using Hi_Tech_Order_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management_System.DAL
{
    public class UserDB
    {
        public static void SaveRecord(UserAccount user)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            if (user.CustomerID == null)
            {
                cmdInsert.CommandText = "Insert into UserAccount ( Username, Email, Password, EmployeeID) " +
                "Values(@username, @email, @password, @employeeid)";
                //cmdInsert.Parameters.AddWithValue("@userid", user.UserID);
                cmdInsert.Parameters.AddWithValue("@username", user.Username);
                cmdInsert.Parameters.AddWithValue("@email", user.Email);
                cmdInsert.Parameters.AddWithValue("@password", user.Password);
                cmdInsert.Parameters.AddWithValue("@employeeid", user.EmployeeID);
                cmdInsert.ExecuteNonQuery();
                conn.Close();
            }
            if (user.EmployeeID == null)
            {
                
                cmdInsert.CommandText = "Insert into UserAccount (Username, Email, Password, CustomerID) " +
                    "Values(@username, @email, @password, @customerid)";
                //cmdInsert.Parameters.AddWithValue("@userid", user.UserID);
                cmdInsert.Parameters.AddWithValue("@username", user.Username);
                cmdInsert.Parameters.AddWithValue("@email", user.Email);
                cmdInsert.Parameters.AddWithValue("@password", user.Password);
                cmdInsert.Parameters.AddWithValue("@customerid", user.CustomerID);
                cmdInsert.ExecuteNonQuery();
                conn.Close();
            }
            
        }
       
        public static UserAccount SearchRecord(int userid)
        {
            UserAccount user = new UserAccount();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM UserAccount " +
                                        "WHERE UserID=@userid";

            cmdSearchById.Parameters.AddWithValue("@userid", userid);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            if (reader.Read())
            {
                user.UserID = Convert.ToInt32(reader["UserID"]);
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString().Trim();
                user.Password = reader["Password"].ToString();
                if (reader["EmployeeID"] != DBNull.Value)
                {
                    user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    user.CustomerID = null;
                }
                else if (reader["CustomerID"] != DBNull.Value)
                {
                    user.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                    user.EmployeeID = null;
                }
                //user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                //user.CustomerID = Convert.ToInt32(reader["CustomerID"]);
            }

            else
            {
                user = null;
            }
            conn.Close();
            return user;

        }
        public static List<UserAccount> SearchRecord(string input) // Username
        { 
            List<UserAccount> listU = new List<UserAccount>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearchByName = new SqlCommand();
            cmdSearchByName.Connection = conn;
            cmdSearchByName.CommandText = "SELECT * FROM UserAccount " +
                                          "WHERE Username = @username ";
            cmdSearchByName.Parameters.AddWithValue("@username", input);
            SqlDataReader reader = cmdSearchByName.ExecuteReader(); 
            UserAccount user;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = new UserAccount();
                    user.UserID = Convert.ToInt32(reader["UserID"]);
                    user.Username = reader["Username"].ToString();
                    user.Email = reader["Email"].ToString().Trim();
                    user.Password = reader["Password"].ToString();
                    if (reader["EmployeeID"] != DBNull.Value)
                    {
                        user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                        user.CustomerID = null;
                    }
                    else if (reader["CustomerID"] != DBNull.Value)
                    {
                        user.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                        user.EmployeeID = null;
                    }


                    listU.Add(user);
                }

            }
            conn.Close();
            return listU;

        }
        public static List<UserAccount> GetAllRecords()
        {
            List<UserAccount> listU = new List<UserAccount>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM UserAccount", conn);

            SqlDataReader reader = cmdSelectAll.ExecuteReader();
            UserAccount user;
            while (reader.Read())
            {
                user = new UserAccount();
                user.UserID = Convert.ToInt32(reader["UserID"]);
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString().Trim();
                user.Password = reader["Password"].ToString();
                if (reader["EmployeeID"] != DBNull.Value)
                {
                    user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    user.CustomerID = null;
                }
                else if (reader["CustomerID"] != DBNull.Value)
                {
                    user.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                    user.EmployeeID = null;
                }
                
                listU.Add(user);

            }
            conn.Close();
            return listU;
        }
        public static bool IsUniqueId(int userId)
        {
            UserAccount user = SearchRecord(userId);
            if (user != null)
            {
                return false;
            }
            return true;
        }
        public static void DeleteRecord(int uId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "DELETE from UserAccount " +
                                     "WHERE UserID=@userid";
            cmdInsert.Parameters.AddWithValue("@userid", uId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateRecord(UserAccount user)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            if(user.CustomerID != null)
            {
                cmdInsert.CommandText = "UPDATE UserAccount " +
                                    "    set Username=@username, " +
                                    "        Password=@pasword, " +
                                    "        Email=@email, " +
                                    "        CustomerID=@customerid " +
                                    " WHERE  UserID=@userid";
                cmdInsert.Parameters.AddWithValue("@customerid", user.CustomerID);
            }
            if(user.EmployeeID != null) 
            {
                cmdInsert.CommandText = "UPDATE UserAccount " +
                                    "    set Username=@username, " +
                                    "        Password=@pasword, " +
                                    "        Email=@email, " +
                                    "        EmployeeID=@employeeid " +
                                    " WHERE  UserID=@userid";
                cmdInsert.Parameters.AddWithValue("@employeeid", user.EmployeeID);
            }
            
            cmdInsert.Parameters.AddWithValue("@userid", user.UserID);
            cmdInsert.Parameters.AddWithValue("@username", user.Username);
            cmdInsert.Parameters.AddWithValue("@email", user.Email);
            cmdInsert.Parameters.AddWithValue("@pasword", user.Password);
            cmdInsert.ExecuteNonQuery();
            conn.Close();


        }
        
        

    }
}
