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
    public partial class CustomerOrders : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public CustomerOrders()
        {
            InitializeComponent();
        }

        private void CustomerOrders_Load(object sender, EventArgs e)
        {
            cusOrders();
        }

        public void cusOrders()
        {
            db.DBConnect = db.DBConnection();
            string getCus = "select CUSTOMER_FIRSTNAME from customer";
            MySqlCommand getdata = new MySqlCommand(getCus, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("CUSTOMER_FIRSTNAME");
                    comboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
            db.DBConnect.Close();
        }

        public void oneCustomer()
        {

                
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string getOrder = "select customer.CUSTOMER_ID, customer.CUSTOMER_FIRSTNAME from customer, orders" +
            //         " WHERE customer.CUSTOMER_ID = orders.CUSTOMER_ID" +
            //        " and orders.CUSTOMER_ID = " + comboBox1.Text;
            //MySqlDataAdapter orderlist = new MySqlDataAdapter(getOrder, db.DBConnect);
            //DataSet ds = new DataSet();
            //orderlist.Fill(ds, "orders");
            //orderList.DataSource = ds.Tables["orders"];
            //db.DBConnect.Close();
        }

        private void txtCusID_MouseClick(object sender, MouseEventArgs e)
        {

            db.DBConnect = db.DBConnection();
            string getCus = "select * from customer";
            MySqlCommand getdata = new MySqlCommand(getCus, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("CUSTOMER_FIRSTNAME");
                    if(sname == comboBox1.Text)
                    {
                        txtCusID.Text = myReader.GetInt32("CUSTOMER_ID").ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
            db.DBConnect.Close();

            string getOrder = "select * from orders where CUSTOMER_ID = " + txtCusID.Text;
            MySqlDataAdapter orderlist = new MySqlDataAdapter(getOrder, db.DBConnect);
            DataSet ds = new DataSet();
            orderlist.Fill(ds, "orders");
            orderList.DataSource = ds.Tables["orders"];
            db.DBConnect.Close();
        }
    }
}
