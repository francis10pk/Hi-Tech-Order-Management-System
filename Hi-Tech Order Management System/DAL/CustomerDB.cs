using Hi_Tech_Order_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management_System.DAL
{
    internal class CustomerDB
    {
        
            public static List<Customer> GetAllRecords()
        {
            List<Customer> listC = new List<Customer>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Customer", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader(); // applied to SELECT
            Customer cst;
            while (reader.Read())
            {
                cst = new Customer();
                cst.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                cst.Name = reader["Name"].ToString();
                cst.Street = reader["Street"].ToString();
                cst.City = reader["City"].ToString() ;
                cst.PostalCode = reader["Phone"].ToString();
                cst.Fax = reader["Fax"].ToString();
                cst.CreditLimit = Convert.ToInt32(reader["CreditLimit"]);
                listC.Add(cst);
            }
            conn.Close();
            return listC;
        }
    }
}
