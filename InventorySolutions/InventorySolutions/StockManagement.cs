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
    public partial class StockManagement : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public StockManagement()
        {
            InitializeComponent();
            productView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String prdCode = txtProductCode.Text;
            String prdName = txtProductName.Text;
            String prdGrp = cmbGroups.Text;
            String prdSize = cmbSize.Text;
            String qty = txtQty.Text;
            String unit = cmbUnit.Text; ;
            String purPrice = txtPurPri.Text;
            String salePrice = txtSalePri.Text;

            if (String.IsNullOrEmpty(prdCode) || String.IsNullOrEmpty(prdName) || String.IsNullOrEmpty(prdGrp) || String.IsNullOrEmpty(qty)
                || String.IsNullOrEmpty(unit) || String.IsNullOrEmpty(purPrice) || String.IsNullOrEmpty(salePrice))
            {
                MessageBox.Show("All the fields should be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string prdInsert = "insert into Products(Product_Code,Product_Name,Product_Group,Size,Quantity,Unit,Purchase_Price,Sales_Price)" +
                                    "values('" + prdCode + "','" + prdName + "','" + prdGrp + "','" + prdSize + "','" + qty + "','" + unit + "','" + purPrice + "','" + salePrice + "');";

                db.DBConnect = db.DBConnection();
                MySqlCommand myProduct = new MySqlCommand(prdInsert, db.DBConnect);
                try
                {
                    //MySqlDataReader inscmd = cmd.ExecuteReader();
                    int num = myProduct.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Product has been inserted.");
                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Data not inserted.");
                    }
                }
                catch (MySqlException er)
                {
                    MessageBox.Show("An error has occured: ", er.Message); 
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.DBConnect = db.DBConnection();
            
            String prdCode = txtProductCode.Text;
            String prdName = txtProductName.Text;
            String prdGrp = cmbGroups.Text;
            String prdSize = cmbSize.Text;
            String qty = txtQty.Text;
            String unit = cmbUnit.Text; ;
            String purPrice = txtPurPri.Text;
            String salePrice = txtSalePri.Text;

            if (String.IsNullOrEmpty(prdCode) || String.IsNullOrEmpty(prdName) || String.IsNullOrEmpty(prdGrp) || String.IsNullOrEmpty(qty)
                || String.IsNullOrEmpty(unit) || String.IsNullOrEmpty(purPrice) || String.IsNullOrEmpty(salePrice))
            {
                MessageBox.Show("All the fields should be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string prdupdate = "update Products set  Product_Name = '" + prdName +
                                                    "',Product_Group = '" + prdGrp +
                                                    "',Size = '" + prdSize +
                                                    "',Quantity = '" + qty +
                                                    "',Unit = '" + unit +
                                                    "',Purchase_Price = '" + purPrice +
                                                    "',Sales_Price = '" + salePrice +
                                                    "where Product_Code = '" + prdCode + ";";
                
                MySqlCommand prdUpdate = new MySqlCommand(prdupdate, db.DBConnect);
                try
                {
                    //MySqlDataReader inscmd = cmd.ExecuteReader();
                    int num = prdUpdate.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Product has been updated.");
                    }
                    else
                    {
                        MessageBox.Show("Data not inserted.");
                    }
                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            String prdCode = txtProductCode.Text;
            String prdName = txtProductName.Text;
            String prdGrp = cmbGroups.Text;
            String prdSize = cmbSize.Text;
            String qty = txtQty.Text;
            String unit = cmbUnit.Text; ;
            String purPrice = txtPurPri.Text;
            String salePrice = txtSalePri.Text;

            if (String.IsNullOrEmpty(prdCode) || String.IsNullOrEmpty(prdName) || String.IsNullOrEmpty(prdGrp) || String.IsNullOrEmpty(qty)
                || String.IsNullOrEmpty(unit) || String.IsNullOrEmpty(purPrice) || String.IsNullOrEmpty(salePrice))
            {
                MessageBox.Show("All the fields should be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string report = "delete from Products where Product_Code = '" + prdCode + "'";

                db.DBConnect = db.DBConnection();
                MySqlCommand myProduct = new MySqlCommand(report, db.DBConnect);
                try
                {
                    //MySqlDataReader inscmd = cmd.ExecuteReader();
                    int num = myProduct.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Product has been deleted.");
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
            }
        }

        public void productView()
        {
            db.DBConnect = db.DBConnection();
            string getProduct = "Select * from Products;";
            MySqlDataAdapter getdata = new MySqlDataAdapter(getProduct, db.DBConnect);
            DataSet ds = new DataSet();
            getdata.Fill(ds, "Products");
            stockGrid.DataSource = ds.Tables["Products"];
            db.DBConnect.Close();
        }

        private void stockGrid_DoubleClick(object sender, EventArgs e)
        {
            if (stockGrid.SelectedRows.Count > 0)
            {
                txtProductCode.Text = stockGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                txtProductName.Text = stockGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                cmbGroups.Text = stockGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                cmbSize.Text = stockGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                txtQty.Text = stockGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                cmbUnit.Text = stockGrid.SelectedRows[0].Cells[5].Value + string.Empty;
                txtPurPri.Text = stockGrid.SelectedRows[0].Cells[6].Value + string.Empty;
                txtSalePri.Text = stockGrid.SelectedRows[0].Cells[7].Value + string.Empty;
            }
        }
    }
}
