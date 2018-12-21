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
    public partial class SalesBill : Form
    {
        public SalesBill()
        {
            InitializeComponent();
        }
        DatabaseConnection db = new DatabaseConnection();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            db.DBConnect = db.DBConnection();
            string getProduct = "Select * from Products where Product_Name like  '" + txtSaleName.Text + "%' ;";
            MySqlDataAdapter getdata = new MySqlDataAdapter(getProduct, db.DBConnect);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductSale pb = new ProductSale();
            pb.Show();
        }

        public void autoCompelte()
        {
            db.DBConnect = db.DBConnection();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            string getProduct = "Select * from products";// where Product_Name like '" + txtProductName.Text + "%';
            MySqlCommand getdata = new MySqlCommand(getProduct, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    //string sName = myReader.GetString("Product_Name");
                    //myCollection.Add(sName);
                    myCollection.Add(myReader.GetString("Product_Name"));
                }
                // particulars.DataPropertyName = "Product_Name";
                db.DBConnect.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
        }

        private void txtAmount_MouseClick(object sender, MouseEventArgs e)
        {
            txtAmount.Text = (from DataGridViewRow row in GridSales.Rows
                                where row.Cells[3].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[4].FormattedValue)).Sum().ToString();
        }

        private void txtTaxable_MouseClick(object sender, MouseEventArgs e)
        {
            double dis = Convert.ToDouble(txtDiscount.Text);
            double amt = Convert.ToDouble(txtAmount.Text);
            double taxable = amt - ((dis * amt) / 100);

            txtTaxable.Text = taxable.ToString();
        }

        private void txtGrand_MouseClick(object sender, MouseEventArgs e)
        {
            double tax = Convert.ToDouble(txtTax.Text);
            double amt = Convert.ToDouble(txtTaxable.Text);
            double grandTotal = (tax + amt);

            txtGrand.Text = grandTotal.ToString();
        }

        private void btnSalesOk_Click(object sender, EventArgs e)
        {

            db.DBConnect = db.DBConnection();


            for (int i = 0; i < GridSales.Rows.Count - 1; i++)
            {
                /*
                MessageBox.Show("Your value are " + txtSaleBillno.Text+" " + saleDate.Text + " " + txtSaleName.Text + " " +txtSaleAdd.Text + 
                                                  " "+ GridSales.Rows[i].Cells[0].Value + 
                                                  " " + GridSales.Rows[i].Cells[1].Value + " " + GridSales.Rows[i].Cells[2].Value + " " + GridSales.Rows[i].Cells[3].Value + " " +GridSales.Rows[i].Cells[4].Value +
                                                  " " + txtAmount.Text + " " + txtDiscount.Text + " " + txtTaxable.Text + " " + txtTax.Text + " " + txtGrand.Text + ".");
                */ 
                String billdate = saleDate.Text;
                String cusName = txtSaleName.Text;
                String add = txtSaleAdd.Text;
                String totalAmount = txtAmount.Text;
                String discount = txtDiscount.Text;
                String taxable = txtTaxable.Text;
                String tax = txtTax.Text;
                String grandTotal = txtGrand.Text;

                String particulars = GridSales.Rows[i].Cells[0].Value.ToString();
                String unit = GridSales.Rows[i].Cells[1].Value.ToString();
                String qty = GridSales.Rows[i].Cells[2].Value.ToString();
                String rate = GridSales.Rows[i].Cells[3].Value.ToString();
                String amount = GridSales.Rows[i].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(billdate) || String.IsNullOrEmpty(cusName) || String.IsNullOrEmpty(add) || String.IsNullOrEmpty(totalAmount)
                || String.IsNullOrEmpty(tax) || String.IsNullOrEmpty(grandTotal))
                {
                    MessageBox.Show("All the fields should be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string saleInsert = "insert into sales(Bill_Date,Customer_Name,Address,Particulars,Unit,Quantity,Rate,Amount,Total_Amount,Discount_Percentage,Taxable_Amount,Tax_Percentage,Grand_Total)" +
                                        "values('" + billdate + "','" + cusName + "','" + add + "','" + particulars + "','" + unit + "','" + qty +
                                        "','" + rate + "','" + amount + "','" + totalAmount + "','" + discount + "','" + taxable + "','" + tax + "','" + grandTotal + "');";
                    // MessageBox.Show("Your values are " + purInsert);

                    db.DBConnect = db.DBConnection();
                    MySqlCommand myProduct = new MySqlCommand(saleInsert, db.DBConnect);
                    try
                    {
                        //MySqlDataReader inscmd = cmd.ExecuteReader();
                        int num = myProduct.ExecuteNonQuery();
                        if (num > 0)
                        {
                            MessageBox.Show("Bill has been prepared.");
                            this.Close();
                            ProductPurchase pb = new ProductPurchase();
                            pb.Show();
                        }
                        else
                        {
                            MessageBox.Show("Data not inserted.");
                        }
                    }
                    catch (MySqlException er)
                    {
                        MessageBox.Show(er.Message, "An error has occured: ");
                    }
                }
            }
        }
    }
}
