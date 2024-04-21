using Hi_Tech_Order_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hi_Tech_Order_Management_System.DAL
{
    internal class OrderDB
    {
        public static List<Order> GetAllRecord()
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            DataContext dataContext = new DataContext(dbConnection);
            Table<Order> orders = dataContext.GetTable<Order>();
            

            return (from o in orders select o).ToList<Order>();
        }
        

    }
}
