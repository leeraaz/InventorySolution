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
    public partial class PurchaseBill : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public PurchaseBill()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseBill_Load(object sender, EventArgs e)
        {

        }

        private void btnSalesOk_Click(object sender, EventArgs e)
        {
            db.DBConnect = db.DBConnection();


            for (int i = 0; i < GridPurchase.Rows.Count - 1; i++)
            {
                /*
                MessageBox.Show("Your value are " + txtPurBillno.Text+" " + purDate.Text + " " + txtSuppName.Text + " " +txtSupplierAdd.Text + 
                                                  " "+ GridPurchase.Rows[i].Cells[0].Value + 
                                                  " " + GridPurchase.Rows[i].Cells[1].Value + " " + GridPurchase.Rows[i].Cells[2].Value + " " + GridPurchase.Rows[i].Cells[3].Value + 
                                                  " " + txtAmount.Text + " " + txtDiscount.Text + " " + txtTaxable.Text + " " + txtTax.Text + " " + txtGrand.Text + ".");
                                                  

                String billdate = purDate.Text;
                string suppName = txtSuppName.Text;
                string add = txtSupplierAdd.Text;
                string totalAmount = txtAmount.Text;
                string discount = txtDiscount.Text;
                string taxable = txtTaxable.Text;
                string tax = txtTax.Text;
                String grandTotal = txtGrand.Text;

                String particulars = GridPurchase.Rows[i].Cells[0].Value.ToString();
                String unit = GridPurchase.Rows[i].Cells[0].Value.ToString();
                String qty = GridPurchase.Rows[i].Cells[0].Value.ToString();
                String rate = GridPurchase.Rows[i].Cells[0].Value.ToString();
                String amount = GridPurchase.Rows[i].Cells[0].Value.ToString();
                if (String.IsNullOrEmpty(billdate) || String.IsNullOrEmpty(suppName) || String.IsNullOrEmpty(add) || String.IsNullOrEmpty(totalAmount)
                || String.IsNullOrEmpty(tax) || String.IsNullOrEmpty(grandTotal)
                {
                    MessageBox.Show("All the fields should be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string purInsert = "insert into Products(Date,Supplier_Name,Address,Particulars,Unit,Quantity,Rate,Amount,Total_Amount,Discount(%),Taxable_Amount,Tax(%),Grand_Total)" +
                                        "values('" + prdCode + "','" + prdName + "','" + prdGrp + "','" + qty + "','" + unit + "','" + purPrice + "','" + salePrice + "');";

                    db.DBConnect = db.DBConnection();
                    MySqlCommand myProduct = new MySqlCommand(prdInsert, db.DBConnect);
                    try
                    {
                        //MySqlDataReader inscmd = cmd.ExecuteReader();
                        int num = myProduct.ExecuteNonQuery();
                        if (num > 0)
                        {
                            MessageBox.Show("Product has been inserted.");
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
                */
            }
        }

        private void txtAmount_MouseClick(object sender, MouseEventArgs e)
        {
            txtAmount.Text = (from DataGridViewRow row in GridPurchase.Rows
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
