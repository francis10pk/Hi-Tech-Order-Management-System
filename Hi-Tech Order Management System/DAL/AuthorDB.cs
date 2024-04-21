using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.BLL;

namespace Hi_Tech_Order_Management_System.DAL
{
    internal class AuthorDB
    {
        public static void SaveRecord(Author author)
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            DataContext dataContext = new DataContext(dbConnection);
            Table<Author> authors = dataContext.GetTable<Author>();
            authors.InsertOnSubmit(author);
            dataContext.SubmitChanges();
        }
        public static int CountRecord() 
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            DataContext dataContext = new DataContext(dbConnection);
            Table<Author> authors = dataContext.GetTable<Author>();
            return authors.Count();
        }
        public static List<Author> GetAllAuthor() 
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            DataContext dataContext = new DataContext(dbConnection);
            Table<Author> authors = dataContext.GetTable<Author>();
            List<Author> allAuthors = authors.ToList();

            return allAuthors;
        }
    }
}
