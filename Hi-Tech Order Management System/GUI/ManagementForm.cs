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

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();  
        }

        //General
        private void buttonExit_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            comboBoxlistEmp_Cstm.Items.Clear();
            UserAccount user = new UserAccount();
            var listU = user.GetUserList();
            comboBoxUserID.Items.Clear();
            foreach (var item in listU)
            {
                comboBoxUserID.Items.Add(item.UserID.ToString());
            }
            Job job = new Job();
            var listJ = job.GetJobList();
            comboBoxJobId.Items.Clear();
            foreach (var item in listJ)
            {
                comboBoxJobId.Items.Add(item.JobID.ToString());
            }
            var listE = Employee.GetEmployeeList();
            comboBoxEmpID.Items.Clear();
            foreach (Employee emp in listE)
            {
                comboBoxEmpID.Items.Add(emp.EmployeeID.ToString());
            }
        }
        //User
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkUser())
            {
                UserAccount user = new UserAccount();
                //user.UserID = Convert.ToInt32(textBoxUserID.Text.Trim());
                user.Username = textBoxUsername.Text.Trim();
                user.Password = textBoxUserPassword.Text.Trim();
                user.Email = textBoxEmail.Text.Trim();
                user.EmployeeID = null;
                user.CustomerID = null;
                if (comboBoxCustomer_Employee.Text == "EmployeeID")
                {
                    user.EmployeeID = Convert.ToInt32(comboBoxlistEmp_Cstm.Text.Trim());
                }
                if (comboBoxCustomer_Employee.Text == "CustomerID")
                {
                    user.CustomerID = Convert.ToInt32(comboBoxlistEmp_Cstm.Text.Trim());
                }

                user.SaveUser(user);
                MessageBox.Show("User data has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxUserID.SelectedIndex = -1;
                textBoxEmail.Clear();
                textBoxUsername.Clear();
                textBoxUserPassword.Clear();
                comboBoxlistEmp_Cstm.SelectedIndex = -1;
                comboBoxCustomer_Employee.SelectedIndex = -1;
                load();
            }
            
        }
        private void comboBoxCustomer_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMessage.Visible = true;
            int indexSelected = comboBoxCustomer_Employee.SelectedIndex;
            comboBoxlistEmp_Cstm.Items.Clear();
            switch (indexSelected)
            {
                case 0:
                    labelMessage.Text = "Please enter Employee ID.";
                    comboBoxlistEmp_Cstm.SelectedIndex = -1;
                    comboBoxlistEmp_Cstm.Focus();
                    var listE = Employee.GetEmployeeList();
                    foreach( Employee emp in listE)
                    {
                        comboBoxlistEmp_Cstm.Items.Add(emp.EmployeeID);
                    }
                    
                    break;
                case 1:
                    labelMessage.Text = "Please enter Customer ID.";
                    comboBoxlistEmp_Cstm.SelectedIndex = -1;
                    comboBoxlistEmp_Cstm.Focus();
                    var listC = Customer.GetCustomerList();
                    foreach (Customer cst in listC)
                    {
                        comboBoxlistEmp_Cstm.Items.Add(cst.CustomerID);
                    }
                    break;

            }
        }
        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMessageSearch.Visible = true;
            int indexSelected = comboBoxSearch.SelectedIndex;
            switch (indexSelected)
            {
                case 0:
                    labelMessageSearch.Text = "Please enter User ID.";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;

                case 1:
                    labelMessageSearch.Text = "Please enter Username.";
                    comboBoxlistEmp_Cstm.SelectedIndex = -1;
                    comboBoxlistEmp_Cstm.Focus();
                    break;
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (checkUser())
            {
                UserAccount user = new UserAccount();
                user.UserID = Convert.ToInt32(comboBoxUserID.Text.Trim());
                user.Username = textBoxUsername.Text.Trim();
                user.Password = textBoxUserPassword.Text.Trim();
                user.Email = textBoxEmail.Text.Trim();
                if (comboBoxCustomer_Employee.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select EmployeeID or CustomerID", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBoxCustomer_Employee.Text == "EmployeeID")
                    {
                        user.EmployeeID = Convert.ToInt32(comboBoxlistEmp_Cstm.Text.Trim());
                        user.CustomerID = null;
                    }
                    if (comboBoxCustomer_Employee.Text == "CustomerID")
                    {
                        user.CustomerID = Convert.ToInt32(comboBoxlistEmp_Cstm.Text.Trim());
                        user.EmployeeID = null;
                    }
                    user.UpdateUser(user);
                    MessageBox.Show("User data has been updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                comboBoxUserID.SelectedIndex = -1;
                textBoxEmail.Clear();
                textBoxUsername.Clear();
                textBoxUserPassword.Clear();
                comboBoxlistEmp_Cstm.SelectedIndex = -1;
                comboBoxCustomer_Employee.SelectedIndex = -1;
                load();
            }
            

        }
        private bool checkUser()
        {
           
            UserAccount user = new UserAccount();
          
            string input = textBoxUsername.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Invalid Username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Clear();
                textBoxUsername.Focus();
                return false;
            }

            input = textBoxEmail.Text.Trim();
            if (!Validator.IsValidEmail(input))
            {
                MessageBox.Show("Invalid Email", "Follow the example bellow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Clear();
                textBoxEmail.Focus();
                return false;
            }

            input = comboBoxlistEmp_Cstm.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                MessageBox.Show("ID must be 5-digit number.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxlistEmp_Cstm.SelectedIndex = -1;
                comboBoxlistEmp_Cstm.Focus();
                return false;
            }
            return true;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string input = comboBoxUserID.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                MessageBox.Show("User ID must be 5-digit number.", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxUserID.SelectedIndex = -1;
                comboBoxUserID.Focus();
                return;
            }
            UserAccount userDel = new UserAccount();
            var answer = MessageBox.Show("Do you really want to delete this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                userDel.DeleteUser(Convert.ToInt32(comboBoxUserID.Text.Trim()));
                MessageBox.Show("User data has been deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxUserID.SelectedIndex = -1;
                comboBoxUserID.Focus();
                load();
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = "";
            UserAccount user = new UserAccount();
            switch (comboBoxSearch.SelectedIndex)
            {
                case 0: // search by EmployeeId
                    input = textBoxSearch.Text.Trim();
                    if (!Validator.IsValidId(input))
                    {
                        MessageBox.Show("Employee Id must be 5-digit number.", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearch.Clear();
                        textBoxSearch.Focus();
                        return;
                    }
                    user = user.SearchUser(Convert.ToInt32(input));
                    if (user != null)
                    {
                        comboBoxUserID.Text = user.UserID.ToString();
                        textBoxUsername.Text = user.Username.ToString();
                        textBoxUserPassword.Text = user.Password.ToString();
                        textBoxEmail.Text = user.Email.ToString();
                        if (user.CustomerID != null)
                        {
                            comboBoxlistEmp_Cstm.Text = user.CustomerID.ToString();
                        }
                        if (user.EmployeeID != null)
                        {
                            comboBoxlistEmp_Cstm.Text = user.EmployeeID.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Invalid User Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearch.Clear();
                        textBoxSearch.Focus();
                        return;
                    }
                    break;
                case 1: // search by FirstName
                    input = textBoxSearch.Text.Trim();
                    List<UserAccount> listU = new List<UserAccount>();
                    listU = user.SearchUser(input);
                    listViewUser.Items.Clear();
                    if (listU.Count == 0)
                    {
                        MessageBox.Show("User not found!", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearch.Clear();
                        textBoxSearch.Focus();
                        return;

                    }
                    else
                    {
                        foreach (UserAccount userItem in listU)
                        {
                            // MessageBox.Show(empItem.EmployeeId.ToString());
                            ListViewItem item = new ListViewItem(userItem.UserID.ToString());
                            item.SubItems.Add(userItem.Username);
                            item.SubItems.Add(userItem.Password);
                            item.SubItems.Add(userItem.Email);
                            item.SubItems.Add((userItem.EmployeeID).ToString());
                            item.SubItems.Add((userItem.CustomerID).ToString());
                            listViewUser.Items.Add(item);
                        }

                    }
                    break;
                default:
                    break;
            }
        }
        private void buttonList_Click(object sender, EventArgs e)
        {
            UserAccount user = new UserAccount();
            List<UserAccount> listU = user.GetUserList();
            listViewUser.Items.Clear();
            foreach (UserAccount userItem in listU)
            {
                ListViewItem item = new ListViewItem(userItem.UserID.ToString());
                item.SubItems.Add(userItem.Username);
                item.SubItems.Add(userItem.Password);
                item.SubItems.Add(userItem.Email);
                item.SubItems.Add((userItem.EmployeeID).ToString());
                item.SubItems.Add((userItem.CustomerID).ToString());
                listViewUser.Items.Add(item);
            }
        }
        
        //Emplooyee
        private void comboBoxEmpSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSearchEmp.Visible = true;
            int indexSelected = comboBoxSearch.SelectedIndex;
            switch (indexSelected)
            {
                case 0:
                    labelMessageSearch.Text = "Please enter Employee ID.";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;

                case 1:
                    labelMessageSearch.Text = "Please enter FirstName or LastName.";
                    comboBoxlistEmp_Cstm.SelectedIndex = -1;
                    comboBoxlistEmp_Cstm.Focus();
                    break;
            }
        }
        private void buttonEmpSave_Click(object sender, EventArgs e)
        {
            if (checkEmployee())
            {
                Employee emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(comboBoxEmpID.Text.Trim());
                emp.FirstName = textBoxFirstName.Text.Trim();
                emp.LastName = textBoxLastName.Text.Trim();
                emp.Email = textBoxEmployeeEmail.Text.Trim();
                emp.JobID = Convert.ToInt32(comboBoxJobId.Text.Trim());
                emp.SaveEmployee(emp);
                MessageBox.Show("Employee data has been saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                load();
            }

        }
        private void buttonEmpList_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            List<Employee> listE = Employee.GetEmployeeList();
            listViewEmployee.Items.Clear();
            foreach (Employee emp in listE)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeID.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.Email);
                item.SubItems.Add(emp.JobID.ToString());
                listViewEmployee.Items.Add(item);
            }
        }
        private bool checkEmployee()
        {
            string input = comboBoxEmpID.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                MessageBox.Show("Employee Id must be 5-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEmpID.SelectedIndex = -1;
                comboBoxEmpID.Focus();
                return false;

            }

            Employee emp = new Employee();
            if (!emp.IsUniqueEmployeeId(Convert.ToInt32(input)))
            {
                MessageBox.Show("Employee Id must be unique.\n" + "Please enter another EmployeeId.", "Duplicate EmployeeId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEmpID.SelectedIndex = -1;
                comboBoxEmpID.Focus();
                return false;
            }
            input = textBoxFirstName.Text.Trim();

            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Invalid First Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return false;
            }

            input = textBoxLastName.Text.Trim();

            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Invalid Last Name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return false;
            }
            return true;
        }
        private void buttonEmpDel_Click(object sender, EventArgs e)
        {
            string input = comboBoxEmpID.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                MessageBox.Show("Employee Id must be 5-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEmpID.SelectedIndex = -1;
                comboBoxEmpID.Focus();
                return;

            }
            
            Employee empDeleted = new Employee();
            var answer = MessageBox.Show("Do you really want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                empDeleted.DeleteEmployee(Convert.ToInt32(comboBoxEmpID.Text.Trim()));
                MessageBox.Show("Employee data has been deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxEmpID.SelectedIndex = -1;
                comboBoxEmpID.Focus();
                load();
            }       
            
        }
        private void buttonEmpUpdate_Click(object sender, EventArgs e)
        {
            if (checkEmployee())
            {
                Employee empUpdated = new Employee();
                empUpdated.EmployeeID = Convert.ToInt32(comboBoxEmpID.Text.Trim());
                empUpdated.FirstName = textBoxFirstName.Text.Trim();
                empUpdated.LastName = textBoxLastName.Text.Trim();
                empUpdated.JobID = Convert.ToInt32(comboBoxJobId.Text.Trim());
                empUpdated.Email = textBoxEmployeeEmail.Text.Trim();
                empUpdated.UpdateEmployee(empUpdated);
                MessageBox.Show("Employee data has been updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxEmpID.SelectedIndex = -1;
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                comboBoxJobId.SelectedIndex = -1;
                textBoxEmployeeEmail.Clear();
                load();
            }
        }
        private void buttonEmpSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxEmpSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option first.", "Search Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            string input = "";
            Employee emp = new Employee();
            switch (comboBoxEmpSearch.SelectedIndex)
            {
                case 0: // search by EmployeeId
                    input = textBoxEmpSearch.Text.Trim();
                    if (!Validator.IsValidId(input))
                    {
                        MessageBox.Show("Employee Id must be 5-digit number.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmpSearch.Clear();
                        textBoxEmpSearch.Focus();
                        return;
                    }
                    emp = emp.SearchEmployee(Convert.ToInt32(input));
                    if (emp != null)
                    {
                        comboBoxEmpID.Text = emp.EmployeeID.ToString();
                        textBoxFirstName.Text = emp.FirstName.ToString();
                        textBoxLastName.Text = emp.LastName.ToString();
                        comboBoxJobId.Text = emp.JobID.ToString();
                        textBoxEmployeeEmail.Text = emp.Email.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Invalid Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmpSearch.Clear();
                        textBoxEmpSearch.Focus();
                        return;
                    }
                    break;
                case 1: // search by FirstName
                    input = textBoxEmpSearch.Text.Trim();
                    List<Employee> listE = new List<Employee>();
                    listE = emp.SearchEmployee(input);
                    listViewEmployee.Items.Clear();

                    if (listE.Count == 0)
                    {
                        MessageBox.Show("Employee not found!", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmpSearch.Clear();
                        textBoxEmpSearch.Focus();
                        return;

                    }
                    else
                    {
                        foreach (Employee empItem in listE)
                        {
                            // MessageBox.Show(empItem.EmployeeId.ToString());
                            ListViewItem item = new ListViewItem(empItem.EmployeeID.ToString());
                            item.SubItems.Add(empItem.FirstName);
                            item.SubItems.Add(empItem.LastName);
                            item.SubItems.Add(empItem.Email);
                            item.SubItems.Add(empItem.JobID.ToString());
                            listViewEmployee.Items.Add(item);
                        }

                    }
                    break;
                default:
                    break;
            }
        }

    }
}
