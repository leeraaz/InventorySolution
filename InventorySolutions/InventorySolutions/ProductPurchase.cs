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
    public partial class ProductPurchase : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public ProductPurchase()
        {
            InitializeComponent();
            autoCompelte();
            autoCompelteSupplier();
            autoPurBill();
        }

        public void autoPurBill()
        {
            int a;
            db.DBConnect = db.DBConnection();
            string getID = "Select max(Purchase_Bill_No) from purchase";
            MySqlCommand cmd = new MySqlCommand(getID, db.DBConnect);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtproBillNo.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtproBillNo.Text = a.ToString();
                }
            }
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

        public void autoCompelteSupplier()
        {
            db.DBConnect = db.DBConnection();
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            string getProduct = "Select * from supplier";
            MySqlCommand getdata = new MySqlCommand(getProduct, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    myCollection.Add(myReader.GetString("Company_Name"));
                }
                txtSupplierName.AutoCompleteCustomSource = myCollection;
                db.DBConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
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
                    if (sname == txtProductName.Text)
                    {
                        txtRate.Text = myReader.GetInt32("Purchase_Price").ToString();
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
            addPurchaseGrid.Rows.Add(txtProductName.Text ,txtUnit.Text, txtQty.Text, txtRate.Text, txtTotal.Text);

            txtProductName.Clear();
            txtUnit.Clear();
            txtQty.Clear();
            txtRate.Clear();
            txtTotal.Clear();
            db.DBConnect.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PurchaseBill pb = new PurchaseBill();
            pb.txtPurBillno.Text = txtproBillNo.Text;
            pb.txtSuppName.Text = txtSupplierName.Text;
            pb.txtSupplierAdd.Text = txtSuppAdd.Text;
            pb.purDate.Text = proDate.Text;

            pb.GridPurchase.Rows.Add();
            pb.GridPurchase.AllowUserToAddRows = false;
            pb.GridPurchase.ColumnCount = 5;
            pb.GridPurchase.Columns[0].Name = "Particulars";
            pb.GridPurchase.Columns[1].Name = "Unit";
            pb.GridPurchase.Columns[2].Name = "Qty";
            pb.GridPurchase.Columns[3].Name = "Rate";
            pb.GridPurchase.Columns[4].Name = "Amount";
            foreach (DataGridViewRow row in addPurchaseGrid.Rows)
            {
                if (pb.GridPurchase.RowCount > 0)
                {
                    int n = pb.GridPurchase.Rows.Add() - 1;
                    pb.GridPurchase.Rows[n].Cells[0].Value = row.Cells[0].Value;
                    pb.GridPurchase.Rows[n].Cells[1].Value = row.Cells[1].Value;
                    pb.GridPurchase.Rows[n].Cells[2].Value = row.Cells[2].Value;
                    pb.GridPurchase.Rows[n].Cells[3].Value = row.Cells[3].Value;
                    pb.GridPurchase.Rows[n].Cells[4].Value = row.Cells[4].Value;
                }
            }
            this.Close();
            pb.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSuppAdd_MouseClick(object sender, MouseEventArgs e)
        {
            db.DBConnect = db.DBConnection();
            string getRate = "Select * from supplier";
            MySqlCommand getdata = new MySqlCommand(getRate, db.DBConnect);
            MySqlDataReader myReader;
            try
            {
                myReader = getdata.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("Company_Name");
                    if (sname == txtSupplierName.Text)
                    {
                        txtSuppAdd.Text = myReader.GetString("Address");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured");
            }
        }

        private void ProductPurchase_Load(object sender, EventArgs e)
        {

        }
    }
}
