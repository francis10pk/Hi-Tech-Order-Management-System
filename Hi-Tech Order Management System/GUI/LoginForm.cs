using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText= "SELECT COUNT(*) FROM UserAccount " +
                "WHERE Username = @username AND Password = @password";
            cmd.Parameters.AddWithValue("@username", textBoxLoginUser.Text.Trim());
            cmd.Parameters.AddWithValue("@password", textBoxLoginPass.Text.Trim());
            int count = (int)cmd.ExecuteScalar();
            if (count >0)
            {
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "select JobID from Employee where EmployeeID = (select EmployeeID from UserAccount where Username = @user)";
                cmd2.Parameters.AddWithValue("@user", textBoxLoginUser.Text.Trim());
                int idresult = (int)cmd2.ExecuteScalar();
                if (idresult >0) {
                    int jobid = (int)idresult;
                    SetForm(jobid);
                }
                
            }
            else
            {
                MessageBox.Show("Username/Password combination wrong", "Invalid Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
        //to finish
        public void SetForm(int jobid)
        {

            switch (jobid)
            {
                case 10000://admin
                    ManagementForm form = new ManagementForm();
                    this.Hide();
                    form.ShowDialog();
                    break;
                case 10001://Sales
                    SalesForms form1 = new SalesForms();
                    this.Hide();
                    form1.ShowDialog();
                    break;
                case 10002:
                    InventoryForm form2 = new InventoryForm();
                    this.Hide();
                    form2.ShowDialog();
                    break;
                case 10003:
                    OrderForm form3 = new OrderForm();
                    this.Hide();
                    form3.ShowDialog();
                    break;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
