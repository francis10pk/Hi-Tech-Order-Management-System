using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;
using System.Windows.Forms;

namespace Hi_Tech_Order_Management_System.BLL
{
    public class DataSetBookDB
    {
        private SqlDataAdapter adapter;
        private DataSet dsBookDB;
        private DataTable dtCustomer;
        private SqlCommandBuilder sqlCommandBuilder;

        public DataSetBookDB()
        {
            dsBookDB = new DataSet("BookDS");
            dtCustomer = new DataTable("Customer");

            dsBookDB.Tables.Add(dtCustomer);

            dtCustomer.Columns.Add("CustomerID", typeof(int));
            dtCustomer.Columns.Add("Name", typeof(string));
            dtCustomer.Columns.Add("Street", typeof(string));
            dtCustomer.Columns.Add("City", typeof(string));
            dtCustomer.Columns.Add("PostalCode", typeof(string));
            dtCustomer.Columns.Add("Phone", typeof(string));
            dtCustomer.Columns.Add("Fax", typeof(string));
            dtCustomer.Columns.Add("CreditLimit", typeof(int));

            dtCustomer.PrimaryKey = new DataColumn[] { dtCustomer.Columns["CustomerID"] };
            dtCustomer.Columns["CustomerID"].AutoIncrement = true;
            dtCustomer.Columns["CustomerID"].AutoIncrementSeed = 1111111;
            dtCustomer.Columns["CustomerID"].AutoIncrementStep = 1;

            adapter = new SqlDataAdapter();

            adapter.TableMappings.Add("Customer", "Customer");

            sqlCommandBuilder = new SqlCommandBuilder(adapter);

            SelectCustomerFromDt();
        }
        public DataTable SelectCustomerFromDt()
        {
            if (dtCustomer != null)
            {
                if (dtCustomer.Rows.Count == 0)
                {
                    adapter.SelectCommand = new SqlCommand("select * from customer", UtilityDB.GetDBConnection());
                    adapter.Fill(dsBookDB, "Customer");
                    return null;
                }
            }


            DataTable dt = dsBookDB.Tables["Customer"];

            return dt;
        }


        public void AddCustomerToDt(Customer cst)
        {
            DataRow row = dtCustomer.NewRow();

            row["CustomerID"] = cst.CustomerID;
            row["Name"] = cst.Name;
            row["Street"] = cst.Street;
            row["City"] = cst.City;
            row["PostalCode"] = cst.PostalCode;
            row["Phone"] = cst.Phone;
            row["Fax"] = cst.Fax;
            row["CreditLimit"] = cst.CreditLimit;

            dtCustomer.Rows.Add(row);

         
        }
        public bool UpdateCustomersDB()
        {
            try
            {
                adapter.Update(dsBookDB, "Customer");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), e.ToString());
                return false;
            }
        }
        public bool Delete(int id)
        {

            DataRow rowToDelete = dtCustomer.Rows.Find(id);

            try
            {
                rowToDelete.Delete();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool IsIdExist(int id)
        {
            foreach (DataRow row in dtCustomer.Rows)
                if (Convert.ToInt32(row["CustomerID"]) == id)
                    return true;
            return false;
        }

        public Customer SearchCustomer(int id)
        {
            Customer cst = new Customer();
            foreach(DataRow row in dtCustomer.Rows)
            {
                if(Convert.ToInt32(row["CustomerID"]) == id)
                {
                    cst.CustomerID = id;
                    cst.Name = row["Name"].ToString();
                    cst.Street = row["Street"].ToString();
                    cst.City = row["City"].ToString() ;
                    cst.PostalCode = row["PostalCode"].ToString();
                    cst.Phone = row["Phone"].ToString();
                    cst.Fax = row["Fax"].ToString();
                    cst.CreditLimit = Convert.ToInt32(row["CreditLimit"]);
                    return cst;
                }
            }
            cst = null;
            return cst;
        }

    }
}
