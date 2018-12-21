using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventorySolutions
{
    public partial class Customer_List : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public Customer_List()
        {
            InitializeComponent();
        }

        private void Customer_List_Load(object sender, EventArgs e)
        {
            getCustomer();
        }

        public void getCustomer()
        {
            db.DBConnect = db.DBConnection();
            string getCustomer = "Select Customer_ID, CUSTOMER_FIRSTNAME, CUSTOMER_LASTNAME,GENDER, CONTACT from customer;";
            MySqlDataAdapter getdata = new MySqlDataAdapter(getCustomer, db.DBConnect);
            DataSet ds = new DataSet();
            getdata.Fill(ds, "Purchase");
            GridCustomer.DataSource = ds.Tables["Purchase"];
            db.DBConnect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(GridCustomer.SelectedRows.Count > 0)
            {
                string cusid = GridCustomer.CurrentRow.Cells["Customer_ID"].Value.ToString();
                string delCus = "delete from customer where Customer_ID = " + cusid + ";";

                db.DBConnect = db.DBConnection();
                MySqlCommand deleteCustomer = new MySqlCommand(delCus, db.DBConnect);
                try
                {
                    //MySqlDataReader inscmd = cmd.ExecuteReader();
                    int num = deleteCustomer.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Customer has been deleted.");
                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Data not deleted.");
                    }
                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                }
                this.Refresh();
            }
        }
    }
}
