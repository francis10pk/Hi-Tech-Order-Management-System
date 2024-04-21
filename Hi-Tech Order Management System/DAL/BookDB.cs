using Hi_Tech_Order_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management_System.DAL
{
    internal class BookDB
    {
        public static int CountRecord()
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            DataContext dataContext = new DataContext(dbConnection);
            Table<Book> books = dataContext.GetTable<Book>();
            return books.Count();
        }
        public static bool IsUniqueId(string isbn)
        {
            Book book = SearchRecord(isbn);
            if (book != null)
            {
                return false;
            }
            return true;
        }
        public static Book SearchRecord(string isbn)
        {
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                var searchBook = dbBook.Books.FirstOrDefault(book => book.ISBN == isbn);
                return searchBook; 
            }
        }
    }
}
