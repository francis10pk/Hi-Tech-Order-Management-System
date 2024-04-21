using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class SalesForms : Form
    {
        DataSetBookDB bookDS = new DataSetBookDB();
        public SalesForms()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            comboBoxIDCust.Items.Clear();
            var listC = Customer.GetCustomerList();

            foreach (var item in listC)
            {
                comboBoxIDCust.Items.Add(item.CustomerID);
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            
            string text = comboBoxIDCust.Text.Trim();

            if(!Validator.IsValidId(text))
            {
                MessageBox.Show("The Format is invalid for the ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!bookDS.IsIdExist(Convert.ToInt32(text)))
            {
                MessageBox.Show("The ID doesn't exist in the DataSet");
                return;
            }
            if (!bookDS.Delete(Convert.ToInt32(text)))
            {
                MessageBox.Show("There's a problem at delete the row on the DataTable");
                return;
            }
            
            MessageBox.Show("Delete Completed");
            load();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string text = comboBoxIDCust.Text;
            if (!Validator.IsValidId(text))
            {
                MessageBox.Show("ID must be 5-digit number.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxIDCust.SelectedIndex=-1;
                return;
            }
            text = textBoxCustName.Text;
            if (!Validator.IsValidName(text))
            {
                MessageBox.Show("Not a valid format for Name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustName.Clear();
                return;
            }
            text = textBoxCustPhone.Text;
            if (!Validator.IsValidPhone(text))
            {
                MessageBox.Show("Not a valid format for Phone, follow ex.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustName.Clear();
                return;
            }

            
            text = textBoxCustPostal.Text;
            if (!Validator.IsValidPostaCode(text))
            {
                MessageBox.Show("Not a valid format for PostalCode, follow ex.", "Invalid Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustName.Clear();
                return;

            }
            if (bookDS.UpdateCustomersDB())
            {
                MessageBox.Show("Update Succesfully");
                load();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            string text = comboBoxIDCust.Text;
            if(!Validator.IsValidId(text))
            {
                MessageBox.Show("ID must be 5-digit number.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxIDCust.SelectedIndex=-1;
                return;
            }
            text = textBoxCustName.Text;
            if (!Validator.IsValidName(text))
            {
                MessageBox.Show("Not a valid format for Name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustName.Clear();
                return;
            }
            text = textBoxCustPhone.Text;
            if (!Validator.IsValidPhone(text))
            {
                MessageBox.Show("Not a valid format for Phone, follow ex.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustName.Clear();
                return;
            }

            text = textBoxCustPostal.Text;
            if (!Validator.IsValidPostaCode(text))
                {
                MessageBox.Show("Not a valid format for PostalCode, follow ex.", "Invalid Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustName.Clear();
                return;
            
            }

            Customer cst = new Customer();
            cst.CustomerID = Convert.ToInt32(comboBoxIDCust.Text);
            cst.Name = textBoxCustName.Text;
            cst.Street = textBoxCustStreet.Text;
            cst.City = textBoxCustCity.Text;
            cst.PostalCode = textBoxCustPostal.Text;
            cst.Phone = textBoxCustPhone.Text;
            cst.Fax = textBoxCustFax.Text;
            cst.CreditLimit = Convert.ToInt32(textBoxCustCredit.Text);

            try
            {
                bookDS.AddCustomerToDt(cst);
                MessageBox.Show("The Customer has been added succesfully");
            }
            catch
            {
                MessageBox.Show("There's a problem to add the Customer to the data table");
                return;
            }
            load();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Restart();
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string text = comboBoxIDCust.Text;
            if (!Validator.IsValidId(text))
            {
                MessageBox.Show("Employee Id must be 5-digit number.", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer cst = bookDS.SearchCustomer(Convert.ToInt32(text));

            if(cst == null)
            {
                MessageBox.Show("Customer not found!");
                return;
            }

            
            listViewCustomer.Items.Clear();
            
            ListViewItem item = new ListViewItem(cst.CustomerID.ToString());
            item.SubItems.Add(cst.Name.ToString());
            item.SubItems.Add(cst.Street.ToString());
            item.SubItems.Add(cst.City.ToString());
            item.SubItems.Add(cst.PostalCode.ToString());
            item.SubItems.Add(cst.Fax.ToString());
            item.SubItems.Add(cst.CreditLimit.ToString());
            listViewCustomer.Items.Add(item);
     
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            var lisC = Customer.GetCustomerList();
            listViewCustomer.Items.Clear();
            foreach (Customer cst in lisC)
            {
                ListViewItem item = new ListViewItem(cst.CustomerID.ToString());
                item.SubItems.Add(cst.Name.ToString());
                item.SubItems.Add(cst.Street.ToString());
                item.SubItems.Add(cst.City.ToString());
                item.SubItems.Add(cst.PostalCode.ToString());
                item.SubItems.Add(cst.Fax.ToString());
                item.SubItems.Add(cst.CreditLimit.ToString());
                listViewCustomer.Items.Add(item);
            }
            
        }

    }
}
