using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;
using Hi_Tech_Order_Management_System.BLL;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Linq;

namespace Hi_Tech_Order_Management_System.DAL
{
    internal class JobDB
    {

        
        public static void SaveRecord(Job job)
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            DataContext dataContext = new DataContext(dbConnection);
            Table<Job> jobs = dataContext.GetTable<Job>();
            jobs.InsertOnSubmit(job);
            dataContext.SubmitChanges();
        }
        public static List<Job> GetAllRecords() 
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            DataContext dataContext = new DataContext(dbConnection);
            Table<Job> jobs = dataContext.GetTable<Job>();
            return (from j in jobs select j).ToList<Job>();
            
        }
    }
}
