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
    public partial class ProductSale : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public ProductSale()
        {
            InitializeComponent();
            autoCompelte();
            autoCompelteCustomer();
            autoSaleBill();
        }

        public void autoSaleBill()
        {
            int a;
            db.DBConnect = db.DBConnection();
            string getID = "Select max(Sales_Bill_No) from sales";
            MySqlCommand cmd = new MySqlCommand(getID, db.DBConnect);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    proBillNo.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    proBillNo.Text = a.ToString();
                }
            }
        }

        public void autoCompelteCustomer()
        {
            db.DBConnect = db.DBConnection();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            string getProduct = "Select * from customer";
            MySqlCommand getdata = new MySqlCommand(getProduct, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    myCollection.Add(myReader.GetString("CUSTOMER_FIRSTNAME"));
                }
                proCusName.AutoCompleteCustomSource = myCollection;
                db.DBConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void autoCompelte()
        {
            db.DBConnect = db.DBConnection();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            string getProduct = "Select * from products";
            MySqlCommand getdata = new MySqlCommand(getProduct, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    myCollection.Add(myReader.GetString("Product_Name"));
                }
                txtProductName.AutoCompleteCustomSource = myCollection;
                db.DBConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           // autoCompelte();
        }

        private void txtRate_MouseClick(object sender, MouseEventArgs e)
        {
            db.DBConnect = db.DBConnection();
            string getRate = "Select * from products";
            MySqlCommand getdata = new MySqlCommand(getRate, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("Product_Name");
                    if(sname == txtProductName.Text)
                    {
                        txtRate.Text = myReader.GetInt32("Sales_Price").ToString();
                        txtUnit.Text = myReader.GetString("Unit");
                        int rate = Convert.ToInt32(txtRate.Text);
                        int qtt = Convert.ToInt32(txtQty.Text);
                        int total = rate * qtt;
                        txtTotal.Text = total.ToString(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addSalesGrid.Rows.Add(txtProductName.Text, txtUnit.Text, txtQty.Text, txtRate.Text, txtTotal.Text);

            txtProductName.Clear();
            txtQty.Clear();
            txtRate.Clear();
            txtTotal.Clear();
            db.DBConnect.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SalesBill sb = new SalesBill();
            sb.txtSaleBillno.Text = proBillNo.Text;
            sb.txtSaleName.Text = proCusName.Text;
            sb.txtSaleAdd.Text = proCusAdd.Text;
            sb.saleDate.Text = proDate.Text;

            sb.GridSales.Rows.Add();
            sb.GridSales.AllowUserToAddRows = false;
            sb.GridSales.ColumnCount = 5;
            sb.GridSales.Columns[0].Name = "Particulars";
            sb.GridSales.Columns[1].Name = "Unit";
            sb.GridSales.Columns[2].Name = "Qty";
            sb.GridSales.Columns[3].Name = "Rate";
            sb.GridSales.Columns[4].Name = "Amount";
            foreach (DataGridViewRow row in addSalesGrid.Rows)
            {
                if (sb.GridSales.RowCount > 0)
                {
                    int n = sb.GridSales.Rows.Add()-1;
                    sb.GridSales.Rows[n].Cells[0].Value = row.Cells[0].Value;
                    sb.GridSales.Rows[n].Cells[1].Value = row.Cells[1].Value;
                    sb.GridSales.Rows[n].Cells[2].Value = row.Cells[2].Value;
                    sb.GridSales.Rows[n].Cells[3].Value = row.Cells[3].Value;
                    sb.GridSales.Rows[n].Cells[4].Value = row.Cells[4].Value;
                }
            }
            this.Close();
            sb.Show();
        }

        private void proCusAdd_MouseClick(object sender, MouseEventArgs e)
        {
            db.DBConnect = db.DBConnection();
            string getRate = "Select * from customer";
            MySqlCommand getdata = new MySqlCommand(getRate, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    string cname = myReader.GetString("CUSTOMER_FIRSTNAME");
                    if (cname == proCusName.Text)
                    {
                        proCusAdd.Text = myReader.GetString("CUSTOMER_ADDRESS");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
        }
    }
}
