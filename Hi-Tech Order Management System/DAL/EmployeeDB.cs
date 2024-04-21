using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;
using Hi_Tech_Order_Management_System.BLL;
using System.Data.SqlClient;

namespace Hi_Tech_Order_Management_System.DAL
{
    public class EmployeeDB
    {
        public static void SaveRecord(Employee employee)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "Insert into Employee " +
                "Values(@employeeid, @firstname, @lastname, @email, @jobid)";
            cmdInsert.Parameters.AddWithValue("@employeeid", employee.JobID);
            cmdInsert.Parameters.AddWithValue("@firstname", employee.FirstName);
            cmdInsert.Parameters.AddWithValue("@lastname", employee.LastName);
            cmdInsert.Parameters.AddWithValue("@email", employee.Email);
            cmdInsert.Parameters.AddWithValue("@jobid", employee.JobID);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static List<Employee> GetAllRecords()
        {
            List<Employee> listE = new List<Employee>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Employee", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader(); // applied to SELECT
            Employee emp;
            while (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.JobID = Convert.ToInt32(reader["JobID"].ToString());
                listE.Add(emp);
            }
            conn.Close();
            return listE;
        }
        public static Employee SearchRecord(int eId)
        {
            Employee emp = new Employee();

            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM Employee " +
                                        "WHERE EmployeeID=@employeeid";

            cmdSearchById.Parameters.AddWithValue("@employeeid", eId);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            if (reader.Read()) 
            {
                emp.EmployeeID = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString().Trim();
                emp.LastName = reader["LastName"].ToString();
                emp.JobID = Convert.ToInt32(reader["JobID"].ToString());

            }

            else  
            {
                emp = null;
            }
            conn.Close();
            return emp;

        }
        public static List<Employee> SearchRecord(string input) // FirstName or LastName
        {
            List<Employee> listE = new List<Employee>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSearchByName = new SqlCommand();
            cmdSearchByName.Connection = conn;
            cmdSearchByName.CommandText = "SELECT * FROM Employee " +
                                          "WHERE FirstName = @FirstName " +
                                          " or LastName=@LastName";
            cmdSearchByName.Parameters.AddWithValue("@FirstName", input);
            cmdSearchByName.Parameters.AddWithValue("@LastName", input);
            SqlDataReader reader = cmdSearchByName.ExecuteReader(); 
            Employee emp;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    emp = new Employee();
                    emp.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobID = Convert.ToInt32(reader["JobID"].ToString());
                    listE.Add(emp);
                }
            }
            conn.Close();
            return listE;
        }
        public static bool IsUniqueId(int eId)
        {
            Employee emp = SearchRecord(eId);
            if (emp != null)
            {
                return false;
            }
            return true;
        }
        public static void UpdateRecord(Employee empUpdated)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "UPDATE Employee " +
                                    "    set FirstName=@FirstName," +
                                    "        LastName=@LastName," +
                                    "        JobID=@JobID " +
                                    "        Email=@Email " +
                                    " WHERE  EmployeeId=@EmployeeId";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", empUpdated.EmployeeID);
            cmdInsert.Parameters.AddWithValue("@FirstName", empUpdated.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", empUpdated.LastName);
            cmdInsert.Parameters.AddWithValue("@JobID", empUpdated.JobID);
            cmdInsert.Parameters.AddWithValue("@Email", empUpdated.Email);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteRecord(int eId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "DELETE Employee " +
                                     "WHERE EmployeeId=@EmployeeId";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", eId);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        
    }
}
