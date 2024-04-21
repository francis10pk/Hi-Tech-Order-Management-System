using Hi_Tech_Order_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Hi_Tech_Order_Management_System.VALIDATION;
using Application = System.Windows.Forms.Application;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                comboBoxCustomerID.Items.Clear();
                var listC = Customer.GetCustomerList();
                foreach (var item in listC)
                {
                    comboBoxCustomerID.Items.Add(item.CustomerID.ToString());
                }
                comboBoxOrderID.Items.Clear();
                var listO = (from b in dbBook.Orders
                             select b).ToList<Order>();
                foreach (var item in listO)
                {
                    comboBoxOrderID.Items.Add(item.OrderID.ToString());
                }
            }
        }
        private void ClearTextBoxes() 
        {
            comboBoxOrderID.SelectedIndex = -1;
            comboBoxCustomerID.SelectedIndex = -1;
            comboBoxPayment.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            dateTimePickerDate.Value = DateTime.Now;
            textBoxAmount.Text = "";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input = textBoxAmount.Text;
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Amount must be a number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Clear();
                return;
            }
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                Order neworder = new Order()
                {
                    CustomerID = Convert.ToInt32(comboBoxCustomerID.Text),
                    OrderDate = Convert.ToDateTime(dateTimePickerDate.Text),
                    OrderType = comboBoxType.Text,
                    PayMethod = comboBoxPayment.Text,
                    Amount = Convert.ToInt32(textBoxAmount.Text)
                };
                dbBook.Orders.Add(neworder);

                dbBook.SaveChanges();
                MessageBox.Show("Order added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                load();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = textBoxAmount.Text;
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Amount must be a number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Clear();
                return;
            }
            
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                int idToUpdate = Convert.ToInt32(comboBoxOrderID.Text);
                var orderToUpdate = dbBook.Orders.FirstOrDefault(b => b.OrderID == idToUpdate);

                if (orderToUpdate != null)
                {
                    orderToUpdate.OrderID = Convert.ToInt32(comboBoxOrderID.Text);
                    orderToUpdate.CustomerID = Convert.ToInt32(comboBoxCustomerID.Text);
                    orderToUpdate.OrderDate = Convert.ToDateTime(dateTimePickerDate.Value);
                    orderToUpdate.OrderType = comboBoxType.Text;
                    orderToUpdate.PayMethod = comboBoxPayment.Text;
                    orderToUpdate.Amount = Convert.ToInt32(textBoxAmount.Text);
                  
                    dbBook.SaveChanges();

                    MessageBox.Show("Order Updated successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    load();
                }
                else
                {
                    MessageBox.Show("Order with ID " + idToUpdate + " not found.");
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = textBoxAmount.Text;
            if (!Validator.IsValidNumber(input))
            {
                MessageBox.Show("Amount must be a number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAmount.Clear();
                return;
            }
            
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                int orderIDSearch = Convert.ToInt32(comboBoxOrderID.Text);
                var searchOrder = dbBook.Orders.FirstOrDefault(b => b.OrderID == orderIDSearch);

                if (searchOrder != null)
                {
                    comboBoxOrderID.Text = Convert.ToString(searchOrder.OrderID) ;
                    comboBoxCustomerID.Text = Convert.ToString(searchOrder.CustomerID);
                    dateTimePickerDate.Value = Convert.ToDateTime(searchOrder.OrderDate);
                    comboBoxType.Text = searchOrder.OrderType;
                    comboBoxPayment.Text = searchOrder.PayMethod;
                    textBoxAmount.Text = Convert.ToString(searchOrder.Amount);


                    MessageBox.Show("Order found successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var answer = MessageBox.Show("Do you really want to delete this Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                int idToDelete = Convert.ToInt32(comboBoxOrderID.Text);
                using (BooksDBEntities dbBook = new BooksDBEntities())
                {
                    var orderToDelete = dbBook.Orders.FirstOrDefault(a => a.OrderID == idToDelete);

                    if (orderToDelete != null)
                    {
                        dbBook.Orders.Remove(orderToDelete);
                        dbBook.SaveChanges();

                        MessageBox.Show("Order deleted successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Order with ID " + idToDelete + " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            using (BooksDBEntities dbBook = new BooksDBEntities())
            {
                try
                {
                    listView1.Items.Clear();
                    var ordersList = (from b in dbBook.Orders
                                     select b).ToList<Order>();
                    foreach (var order in ordersList)
                    {

                        ListViewItem item = new ListViewItem(order.OrderID.ToString());
                        item.SubItems.Add(order.CustomerID.ToString());
                        item.SubItems.Add(order.OrderDate.ToString());
                        item.SubItems.Add(order.OrderType.ToString());
                        item.SubItems.Add(order.PayMethod.ToString());
                        item.SubItems.Add(order.Amount.ToString());
                        listView1.Items.Add(item);
                    }
                    MessageBox.Show("Orders Listed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}");
                }
            }
        }
    }
}
