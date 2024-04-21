using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;
using Hi_Tech_Order_Management_System.VALIDATION;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }
        //General
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            ControlTab();
            load();
        }
        private void load()
        {
            
            Author author = new Author();
            var listA = author.GetAllAuthor();
            comboBoxAuthorIDs.Items.Clear();
            foreach (var item in listA)
            {
                comboBoxAuthorIDs.Items.Add(item.AuthorID);
            }
            
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                comboBoxCatID.Items.Clear();
                var listC = (from b in dbBook.Categories select b).ToList<Category>();
                foreach (var item in listC)
                {
                    comboBoxCatID.Items.Add(item.CategoryID);
                }
                comboBoxPubID.Items.Clear();

                var listP = (from p in dbBook.Publishers select p).ToList<Publisher>();
                foreach (var item in listP)
                {
                    comboBoxPubID.Items.Add(item.PublisherID);
                }
                comboBoxIDPub.Items.Clear();
                var listidp = (from p in dbBook.Publishers select p).ToList<Publisher>();
                foreach (var item in listidp)
                {
                    comboBoxIDPub.Items.Add(item.PublisherID);
                }
                comboBoxISBN.Items.Clear();
                var listB = (from b in dbBook.Books select b).ToList<Book>();
                foreach (var item in listB)
                {
                    comboBoxISBN.Items.Add(item.ISBN);
                }
                comboBoxAuthorBookID.Items.Clear();
                var listIsbn = (from ab in dbBook.Authors select ab).ToList<Author>();
                foreach (var item in listIsbn)
                {
                    comboBoxAuthorBookID.Items.Add(item.AuthorID);
                }
                comboBoxAuthorBookISBN.Items.Clear();
                var listAID = (from ab in dbBook.Books select ab).ToList<Book>();
                foreach (var item in listAID)
                {
                    comboBoxAuthorBookISBN.Items.Add(item.ISBN);
                }
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        public void ControlTab()
        {
            tabControlBookForm.TabPages["tabPageBook"].Enabled = false;
            tabControlBookForm.TabPages["tabPageAuthorBook"].Enabled = false;

            if (Author.CountAuthor() > 0)
            {
                tabControlBookForm.TabPages["tabPageBook"].Enabled = true;
                Author author = new Author();
                foreach (Author a in author.GetAllAuthor())
                {
                    comboBoxAuthorIDs.Items.Add(a.AuthorID.ToString());
                }
            }
            if (Book.CountBook() > 0 && Author.CountAuthor() > 0)
            {
                tabControlBookForm.TabPages["tabPageAuthorBook"].Enabled = true;
            }
        }
        private void buttonExitAuthorPublish_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        //Book
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkBook())
            {
                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    Book newbook = new Book()
                    {
                        ISBN = textBoxIsbn.Text,
                        Title = textBoxTitle.Text,
                        YearPublished = Convert.ToInt32(textBoxYearPublish.Text),
                        QOH = Convert.ToInt32(textBoxQOH.Text),
                        CategoryID = Convert.ToInt32(comboBoxCatID.Text),
                        PublisherID = Convert.ToInt32(comboBoxPubID.Text),
                        UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text)
                    };
                    dbBook.Books.Add(newbook);

                    dbBook.SaveChanges();
                    MessageBox.Show("Book added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    load();
                }
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            string input = textBoxIsbn.Text.Trim();
            if (!Validator.IsValidISBN(input))
            {
                MessageBox.Show("ISBN incorrect", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIsbn.Clear();
                textBoxIsbn.Focus();
                return;
            }


            input = textBoxTitle.Text.Trim();
            if (!Validator.IsValidTitle(input))
            {
                MessageBox.Show("Invalid Title.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTitle.Clear();
                textBoxTitle.Focus();
                return;
            }

            input = textBoxYearPublish.Text.Trim();
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Invalid Year", "Follow the example bellow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYearPublish.Clear();
                textBoxYearPublish.Focus();
                return;
            }
            input = textBoxQOH.Text.Trim();
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Invalid QOH", "Follow the example bellow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQOH.Clear();
                textBoxQOH.Focus();
                return;
            }
            input = textBoxUnitPrice.Text.Trim();
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Invalid Price", "Follow the example bellow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUnitPrice.Clear();
                textBoxUnitPrice.Focus();
                return;
            }
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                string isbnToUpdate = textBoxIsbn.Text;
                var bookToUpdate = dbBook.Books.FirstOrDefault(b => b.ISBN == isbnToUpdate);

                if (bookToUpdate != null)
                {
                    bookToUpdate.Title = textBoxTitle.Text;
                    bookToUpdate.YearPublished = Convert.ToInt32(textBoxYearPublish.Text);
                    bookToUpdate.QOH = Convert.ToInt32(textBoxQOH.Text);
                    bookToUpdate.CategoryID = Convert.ToInt32(comboBoxCatID.Text);
                    bookToUpdate.PublisherID = Convert.ToInt32(comboBoxPubID.Text);
                    bookToUpdate.UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text);
                    dbBook.SaveChanges();

                    MessageBox.Show("Book Updated successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    load();
                }
                else
                {
                    MessageBox.Show("Book with ISBN " + isbnToUpdate + " not found.");
                }
            }

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string isbn = textBoxIsbn.Text.Trim();

            // Validate ISBN format if needed
            if (!Validator.IsValidISBN(isbn))
            {
                MessageBox.Show("Invalid ISBN format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                //conn.Open();

                // Retrieve all AuthorIDs associated with the given ISBN
                string selectQuery = "SELECT AuthorID FROM AuthorBooks WHERE ISBN = @isbn";

                List<int> authorIds = new List<int>();

                using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn))
                {
                    cmdSelect.Parameters.AddWithValue("@isbn", isbn);

                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int authorId = reader.GetInt32(reader.GetOrdinal("AuthorID"));
                            authorIds.Add(authorId);
                        }
                    }
                }

                // Delete records from AuthorBooks based on AuthorID and ISBN
                string deleteQuery = "DELETE FROM AuthorBooks WHERE AuthorID = @authorId AND ISBN = @isbn";

                foreach (int authorId in authorIds)
                {
                    using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn))
                    {
                        cmdDelete.Parameters.AddWithValue("@authorId", authorId);
                        cmdDelete.Parameters.AddWithValue("@isbn", isbn);
                        cmdDelete.ExecuteNonQuery();
                    }
                }
                using (BooksDBEntities dbContext = new BooksDBEntities())
                {
                    // Find the book to delete
                    var bookToDelete = dbContext.Books.FirstOrDefault(b => b.ISBN == isbn);

                    if (bookToDelete != null)
                    {

                        // Remove the book itself
                        dbContext.Books.Remove(bookToDelete);

                        // Save changes to the database
                        dbContext.SaveChanges();
                    }
                    MessageBox.Show("AuthorBooks associated with ISBN " + isbn + " have been deleted successfully.",
                            "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    load();
                    conn.Close();
                }
            }
        }
        private void ClearTextBoxes()
        {
            textBoxIsbn.Text = "";
            textBoxTitle.Text = "";
            textBoxYearPublish.Text = "";
            textBoxQOH.Text = "";
            comboBoxCatID.SelectedIndex = -1; // Clear ComboBox selection
            comboBoxPubID.SelectedIndex = -1; // Clear ComboBox selection
            textBoxUnitPrice.Text = "";
        }
        private void buttonList_Click(object sender, EventArgs e)
        {
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                try
                {
                    listViewBook.Items.Clear();
                    var booksList = (from b in dbBook.Books
                                     select b).ToList<Book>();
                    foreach (var book in booksList)
                    {
                        ListViewItem item = new ListViewItem(book.ISBN);
                        item.SubItems.Add(book.Title);
                        item.SubItems.Add(book.YearPublished.ToString());
                        item.SubItems.Add(book.QOH.ToString());
                        item.SubItems.Add(book.CategoryID.ToString());
                        item.SubItems.Add(book.PublisherID.ToString());
                        item.SubItems.Add(book.UnitPrice.ToString());
                        listViewBook.Items.Add(item);
                    }
                    MessageBox.Show("Book Listed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}");
                }
            }
               
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxISBN.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    string isbnToSearch = comboBoxISBN.Text;
                    var searchBook = dbBook.Books.FirstOrDefault(b => b.ISBN == isbnToSearch);

                    if (searchBook != null)
                    {
                        textBoxIsbn.Text = searchBook.ISBN;
                        textBoxTitle.Text = searchBook.Title;
                        textBoxYearPublish.Text = searchBook.YearPublished.ToString();
                        textBoxQOH.Text = searchBook.QOH.ToString();
                        comboBoxCatID.Text = searchBook.CategoryID.ToString();
                        comboBoxPubID.Text = searchBook.PublisherID.ToString();
                        textBoxUnitPrice.Text = searchBook.UnitPrice.ToString();

                        MessageBox.Show("Book found successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
        }
        private bool checkBook()
        {
            
            Book book = new Book();
            string input = textBoxIsbn.Text.Trim();
            if (!Validator.IsValidISBN(input))
            {
                MessageBox.Show("ISBN incorrect", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIsbn.Clear();
                textBoxIsbn.Focus();
                return false;
            }
            if (!book.IsUniqueId(input))
            {
                MessageBox.Show("Book ID must be unique.\n" + "Please enter another ID.", "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCatID.SelectedIndex = -1;
                comboBoxCatID.Focus();
                return false;
            }
            input = comboBoxPubID.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                MessageBox.Show("Publisher ID must be 5-digit number.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPubID.SelectedIndex = -1;
                comboBoxPubID.Focus();
                return false;
            }

            if (!book.IsUniqueId(input))
            {
                MessageBox.Show("Publisher ID must be unique.\n" + "Please enter another ID.", "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPubID.SelectedIndex = -1;
                comboBoxPubID.Focus();
                return false;
            }

            input = textBoxTitle.Text.Trim();
            if (!Validator.IsValidTitle(input))
            {
                MessageBox.Show("Invalid Title.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTitle.Clear();
                textBoxTitle.Focus();
                return false;
            }

            input = textBoxYearPublish.Text.Trim();
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Invalid Year", "Follow the example bellow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYearPublish.Clear();
                textBoxYearPublish.Focus();
                return false;
            }
            input = textBoxQOH.Text.Trim();
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Invalid QOH", "Follow the example bellow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQOH.Clear();
                textBoxQOH.Focus();
                return false;
            }
            input = textBoxUnitPrice.Text.Trim();
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Invalid Price", "Follow the example bellow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUnitPrice.Clear();
                textBoxUnitPrice.Focus();
                return false;
            }

            
            return true;
        }
        //Author
        private void buttonSaveAuthor_Click(object sender, EventArgs e)
        {
            if (checkAuthor())
            {
                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    Author author = new Author()
                    {
                        //AuthorID = Convert.ToInt32(comboBoxAuthorIDs.Text),
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        Email = textBoxEmail.Text
                    };
                    dbBook.Authors.Add(author);
                    dbBook.SaveChanges();
                    MessageBox.Show("Author added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAuthorBoxes();
                    load();
                }
            }           
        }
        private void buttonDelAuthor_Click(object sender, EventArgs e)
        {
            int authorID = Convert.ToInt32(comboBoxAuthorIDs.Text.Trim());
            if (!Validator.IsValidId(Convert.ToString(authorID)))
            {
                MessageBox.Show("ID must be 5-digit number.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxAuthorIDs.SelectedIndex=-1;
                comboBoxAuthorIDs.Focus();
                return;
            }

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {

                string selectQuery = "SELECT ISBN FROM AuthorBooks WHERE AuthorID = @authorID";

                List<string> isbns = new List<string>();

                using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn))
                {
                    cmdSelect.Parameters.AddWithValue("@authorID", authorID);

                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string isbn = reader.GetString(reader.GetOrdinal("AuthorID"));
                            isbns.Add(isbn);
                        }
                    }
                }

                // Delete records from AuthorBooks based on AuthorID and ISBN
                string deleteQuery = "DELETE FROM AuthorBooks WHERE AuthorID = @authorId AND ISBN = @isbn";

                foreach (string isbn in isbns)
                {
                    using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn))
                    {
                        cmdDelete.Parameters.AddWithValue("@authorId", authorID);
                        cmdDelete.Parameters.AddWithValue("@isbn", isbn);
                        cmdDelete.ExecuteNonQuery();
                    }
                }
                using (BooksDBEntities dbContext = new BooksDBEntities())
                {
                    // Find the book to delete
                    var authorToDelete = dbContext.Authors.FirstOrDefault(a => a.AuthorID == authorID);

                    if (authorToDelete != null)
                    {

                        // Remove the book itself
                        dbContext.Authors.Remove(authorToDelete);

                        // Save changes to the database
                        dbContext.SaveChanges();
                    }
                    MessageBox.Show("AuthorBooks associated with AuthorID " + authorID + " have been deleted successfully.",
                            "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    load();
                    conn.Close();
                }
                
            }
            ClearTextBoxes();
        }
        private void buttonUpdateAuthor_Click(object sender, EventArgs e)
        {
            if (checkAuthor())
            {

                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    int idToUpdate = Convert.ToInt32(comboBoxAuthorIDs.Text);
                    var authorToUpdate = dbBook.Authors.FirstOrDefault(a => a.AuthorID == idToUpdate);

                    if (authorToUpdate != null)
                    {
                        authorToUpdate.FirstName = textBoxFirstName.Text;
                        authorToUpdate.LastName = textBoxLastName.Text;
                        authorToUpdate.Email = textBoxEmail.Text;
                        dbBook.SaveChanges();

                        MessageBox.Show("Author Updated successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAuthorBoxes();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Author with ID " + idToUpdate + " not found.");
                    }
                }
            }
            
        }
        private void buttonSearchAuth_Click(object sender, EventArgs e)
        {
            if (comboBoxAuthorIDs.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                int authorID = Convert.ToInt32(comboBoxAuthorIDs.Text.Trim());

                try
                {
                    // Perform the author search based on the entered name
                    var authorSearch = dbBook.Authors.FirstOrDefault(a => a.AuthorID == authorID);

                    if (authorSearch != null)
                    {
                        textBoxFirstName.Text = authorSearch.FirstName;
                        textBoxLastName.Text = authorSearch.LastName;
                        textBoxEmail.Text = authorSearch.Email;
                    }
                    else
                    {
                        MessageBox.Show("No authors found matching the specified criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching for authors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void ClearAuthorBoxes()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            comboBoxAuthorIDs.SelectedIndex = -1;
        }
        public bool checkAuthor() 
        {
            
            string input = textBoxFirstName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Not a valid Name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return false;
            }
            input = textBoxLastName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Not a valid Name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return false;
            }
            input = textBoxEmail.Text.Trim();
            if (!Validator.IsValidEmail(input))
            {
                MessageBox.Show("Not a valid Email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Clear();
                textBoxEmail.Focus();
                return false;
            }
            return true;
        }

        //Publisher

        private void buttonPubSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxIDPub.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    int pubID = Convert.ToInt32(comboBoxIDPub.Text.Trim());

                    try
                    {        
                        var pubSearch = dbBook.Publishers.FirstOrDefault(a => a.PublisherID == pubID);
                        if (pubSearch != null)
                        {
                        //pubSearch.PublisherID = Convert.ToInt32(comboBoxIDPub.Text);
                        textBoxNamePub.Text = pubSearch.PName;
                        textBoxCityPub.Text = pubSearch.PCity;
                        textBoxAddPub.Text = pubSearch.PAddress;
                        textBoxPostalPub.Text = pubSearch.PPostalCode;
                        textBoxPubPhone.Text = pubSearch.Phone;
                        textBoxfaxPub.Text = pubSearch.Fax;
                        }
                        else
                        {
                            MessageBox.Show("No Publishers found matching the specified criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while searching for Publisher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }
        private void buttonPubSave_Click(object sender, EventArgs e)
        {
            if (checkPublisher())
            {
                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    Publisher publisher = new Publisher()
                    {
                        PName = textBoxNamePub.Text,
                        PCity = textBoxCityPub.Text,
                        PAddress = textBoxAddPub.Text,
                        PPostalCode = textBoxPostalPub.Text,
                        Phone = textBoxPubPhone.Text,
                        Fax = textBoxfaxPub.Text
                };
                    dbBook.Publishers.Add(publisher);
                    dbBook.SaveChanges();
                    MessageBox.Show("Publisher added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPublisherBoxes();
                    load();
                }
            }
        }
        private void buttonDelPub_Click(object sender, EventArgs e)
        {
            string input = comboBoxIDPub.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                MessageBox.Show("ID must be 5-digit number.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxIDPub.SelectedIndex = -1;
                comboBoxIDPub.Focus();
                return;
            }
            Publisher publisher = new Publisher();
            var answer = MessageBox.Show("Do you really want to delete this Publisher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                int idToDelete = Convert.ToInt32(comboBoxIDPub.Text);
                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    var pubToDelete = dbBook.Publishers.FirstOrDefault(a => a.PublisherID == idToDelete);

                    if (pubToDelete != null)
                    {
                        dbBook.Publishers.Remove(pubToDelete);
                        dbBook.SaveChanges();
                        MessageBox.Show("Publisher deleted successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkPublisher();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Publisher with ID " + idToDelete + " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            load();
        }
        private void buttonPubUpda_Click(object sender, EventArgs e)
        {
            if (checkPublisher())
            {
                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    int idToUpdate = Convert.ToInt32(comboBoxIDPub.Text);
                    var pubToUpdate = dbBook.Publishers.FirstOrDefault(a => a.PublisherID == idToUpdate);

                    if (pubToUpdate != null)
                    {
                        pubToUpdate.PName = textBoxNamePub.Text;
                        pubToUpdate.PCity = textBoxCityPub.Text;
                        pubToUpdate.PAddress = textBoxAddPub.Text;
                        pubToUpdate.PPostalCode = textBoxPostalPub.Text;
                        pubToUpdate.Phone = textBoxPubPhone.Text;
                        pubToUpdate.Fax = textBoxfaxPub.Text;

                        dbBook.SaveChanges();

                        MessageBox.Show("Publisher Updated successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearPublisherBoxes();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Publisher with ID " + idToUpdate + " not found.");
                    }
                }
            }
        }
        private void ClearPublisherBoxes()
        {
            comboBoxIDPub.SelectedIndex = -1;
            textBoxNamePub.Text = "";
            textBoxCityPub.Text = "";
            textBoxAddPub.Text = "";
            textBoxPostalPub.Text = "";
            textBoxPubPhone.Text = "";
            textBoxfaxPub.Text = "";
        }
        public bool checkPublisher()
        {
            
            string input = textBoxNamePub.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Not a valid Name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNamePub.Clear();
                textBoxNamePub.Focus();
                return false;
            }
            input = textBoxCityPub.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Not a valid City Name.", "Invalid City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCityPub.Clear();
                textBoxCityPub.Focus();
                return false;
            }
            input = textBoxAddPub.Text.Trim();
            if (!Validator.IsValidAddress(input))
            {
                MessageBox.Show("Not a valid Address.", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddPub.Clear();
                textBoxAddPub.Focus();
                return false;
            }
            input = textBoxPostalPub.Text.Trim();
            if (!Validator.IsValidPostaCode(input))
            {
                MessageBox.Show("Not a valid Postal Code.", "Invalid Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPostalPub.Clear();
                textBoxPostalPub.Focus();
                return false;
            }
            
            input = textBoxPubPhone.Text.Trim();
            if (!Validator.IsValidPhone(input))
            {
                MessageBox.Show("Not a valid Phone.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPubPhone.Clear();
                textBoxPubPhone.Focus();
                return false;
            }
            
            return true;
        }
        //AuthorBook
        private void buttonSaveAB_Click(object sender, EventArgs e)
        {
            if (checkAuthorBook())
            {
                using (var dbContext = new BooksDBEntities())
                {
                    var book = dbContext.Books.FirstOrDefault(b => b.ISBN == comboBoxAuthorBookISBN.Text);
                    var author = dbContext.Authors.FirstOrDefault(a => a.AuthorID == Convert.ToInt32(comboBoxAuthorBookID.Text));

                    if (book != null && author != null)
                    {
                        var authorBook = new AuthorBook
                        {
                            AuthorId = author.AuthorID,
                            Isbn = book.ISBN,
                            Author = author,
                            Book = book
                        };
                        dbContext.AuthorBooks.Add(authorBook);
                        dbContext.SaveChanges();
                        Console.WriteLine("Author added to the book successfully!");
                        ClearAuthorBookBoxes();
                        load();
                    }
                }
            }
        }
        private void buttonDelAB_Click(object sender, EventArgs e)
        {
            if (checkAuthorBook())
            {
                string bookISBN = comboBoxAuthorBookISBN.Text;
                int authorID = Convert.ToInt32(comboBoxAuthorBookID.Text);

                using (var dbContext = new BooksDBEntities())
                {
                    var authorBookToDelete = dbContext.AuthorBooks
                        .FirstOrDefault(ab => ab.Isbn == bookISBN && ab.AuthorId == authorID);

                    if (authorBookToDelete != null)
                    {
                        dbContext.AuthorBooks.Remove(authorBookToDelete);
                        dbContext.SaveChanges();

                        Console.WriteLine("Author association with the book deleted successfully!");
                        ClearAuthorBookBoxes();
                        load();
                    }
                    else
                    {
                        Console.WriteLine("Author association with the book not found.");
                    }
                }
            }
            
        }
        private void buttonSearchAB_Click(object sender, EventArgs e)
        {
            if (comboBoxAuthorBookISBN.SelectedIndex == -1 && comboBoxAuthorBookID.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            listViewAB.Items.Clear(); // Clear existing items in the ListView

            string isbn = comboBoxAuthorBookISBN.Text.Trim(); // Retrieve the ISBN search criteria from a TextBox
            int authorId = 0;

            // Check if the Author ID search criteria is valid and retrieve its value
            if (!string.IsNullOrEmpty(comboBoxAuthorBookID.Text) && int.TryParse(comboBoxAuthorBookID.Text.Trim(), out authorId))
            {
                // Establish connection and command objects
                using (SqlConnection conn = UtilityDB.GetDBConnection())
                {
                    // SQL query to search for records in the AuthorBooks table based on provided criteria
                    string selectQuery = "SELECT * FROM AuthorBooks WHERE Isbn = @Isbn OR AuthorId = @AuthorId";

                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn))
                    {
                        // Add parameters to the SQL query for Isbn and AuthorId
                        cmdSelect.Parameters.AddWithValue("@Isbn", isbn);
                        cmdSelect.Parameters.AddWithValue("@AuthorId", authorId);

                        try
                        {
                           
                            // Execute the SQL query and retrieve results into a DataTable
                            DataTable dataTable = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
                            adapter.Fill(dataTable);

                            // Iterate through the rows of the DataTable and populate the ListView
                            foreach (DataRow row in dataTable.Rows)
                            {
                                ListViewItem item = new ListViewItem(row["AuthorID"].ToString()); // Assuming AuthorID is the first column
                                item.SubItems.Add(row["Isbn"].ToString()); // Add more subitems as needed for other columns
                                                                           // Add more columns to the ListViewItem using row["ColumnName"].ToString()

                                listViewAB.Items.Add(item); // Add the ListViewItem to the ListView
                            }

                            MessageBox.Show("Author-Book Search results retrieved successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid search criteria for ISBN and/or Author ID.", "Invalid Search Criteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool checkAuthorBook()
        {
            if (comboBoxAuthorBookISBN.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxAuthorBookID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void buttonListAB_Click(object sender, EventArgs e)
        {
            listViewAB.Items.Clear(); // Clear existing items in the ListView

            // Use a DataTable to hold the data retrieved from the database
            DataTable dataTable = new DataTable();

            // SQL query to select all columns from the AuthorBooks table
            string selectQuery = "SELECT * FROM AuthorBooks";

            // Establish connection and command objects
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn))
                {
                    try
                    {
                        
                        // Execute the SQL query and fill the DataTable with the results
                        SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
                        adapter.Fill(dataTable);

                        // Iterate through the rows of the DataTable and populate the ListView
                        foreach (DataRow row in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["AuthorID"].ToString()); // Assuming AuthorID is the first column
                            item.SubItems.Add(row["Isbn"].ToString()); // Add more subitems as needed for other columns
                                                                       // Add more columns to the ListViewItem using row["ColumnName"].ToString()

                            listViewAB.Items.Add(item); // Add the ListViewItem to the ListView
                        }

                        MessageBox.Show("Author-Book List retrieved successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //private void buttonListAB_Click(object sender, EventArgs e)
        //{

        //    using (BooksDBEntities dbBook = new BooksDBEntities())
        //    {
        //        try
        //        {
        //            listViewAB.Items.Clear();
        //            var abList = (from b in dbBook.AuthorBooks
        //                             select b).ToList<AuthorBook>();
        //            foreach (var ab in abList)
        //            {
        //                ListViewItem item = new ListViewItem(ab.AuthorId.ToString());
        //                item.SubItems.Add(ab.Isbn);
        //                listViewAB.Items.Add(item);
        //            }
        //            MessageBox.Show("Author-Book Listed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error occurred: {ex.Message}");
        //        }
        //    }
        //}
        private void ClearAuthorBookBoxes()
        {
            comboBoxAuthorBookISBN.SelectedIndex = -1;
            comboBoxAuthorBookID.SelectedIndex = -1;
        }
    }
}