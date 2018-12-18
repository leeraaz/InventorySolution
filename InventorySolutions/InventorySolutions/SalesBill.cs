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
                                select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
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
    }
}
