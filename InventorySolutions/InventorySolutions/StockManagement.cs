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
        public bool Enabled { get; set; }
        public StockManagement()
        {
            InitializeComponent();
            productView();
            getProductID();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getProductID()
        {
            int a;
            db.DBConnect = db.DBConnection();
            string getID = "Select max(Product_Code) from products";
            MySqlCommand cmd = new MySqlCommand(getID, db.DBConnect);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtProductCode.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtProductCode.Text = a.ToString();
                    txtProductCode.ReadOnly = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtProductCode.Enabled = true;
            txtProductName.Enabled = true;
            cmbGroups.Enabled = true;
            cmbSize.Enabled = true;
            txtQty.Enabled = true;
            cmbUnit.Enabled = true;
            txtPurPri.Enabled = true;
            txtSalePri.Enabled = true;

            lblProductCode.Enabled = true;
            lblProductName.Enabled = true;
            lblGroup.Enabled = true;
            lblSize.Enabled = true;
            lblQty.Enabled = true;
            lblUnit.Enabled = true;
            lblPurchase.Enabled = true;
            lblSale.Enabled = true;
            btnOk.Enabled = true;
            btnManageCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnDele.Enabled = false;
        }

        private void addItem()
        {
            String prdCode = txtProductCode.Text;
            String prdName = txtProductName.Text;
            String prdGrp = cmbGroups.Text;
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
                string prdInsert = "insert into Products(Product_Code,Product_Name,Product_Group,Quantity,Unit,Purchase_Price,Sales_Price)" +
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtProductCode.Enabled = true;
            txtProductName.Enabled = true;
            cmbGroups.Enabled = true;
            cmbSize.Enabled = true;
            txtQty.Enabled = true;
            cmbUnit.Enabled = true;
            txtPurPri.Enabled = true;
            txtSalePri.Enabled = true;

            lblProductCode.Enabled = true;
            lblProductName.Enabled = true;
            lblGroup.Enabled = true;
            lblSize.Enabled = true;
            lblQty.Enabled = true;
            lblUnit.Enabled = true;
            lblPurchase.Enabled = true;
            lblSale.Enabled = true;
            btnOk.Enabled = true;
            btnManageCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDele.Enabled = false;
        }

        public void editItem()
        {
            String prdCode = txtProductCode.Text;
            txtProductCode.ReadOnly = true;
            String prdName = txtProductName.Text;
            String prdGrp = cmbGroups.Text;
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
                string prdupdate = "update Products set Product_Name = '" + prdName +
                                                    "',Product_Group = '" + prdGrp +
                                                    "',Quantity = '" + qty +
                                                    "',Unit = '" + unit +
                                                    "',Purchase_Price = '" + purPrice +
                                                    "',Sales_Price = '" + salePrice +
                                                    "' where Product_Code = " + prdCode + ";";
                db.DBConnect = db.DBConnection();
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
                        MessageBox.Show("Product details cannot be updated.");
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
            txtProductCode.Enabled = true;
            txtProductName.Enabled = true;
            cmbGroups.Enabled = true;
            cmbSize.Enabled = true;
            txtQty.Enabled = true;
            cmbUnit.Enabled = true;
            txtPurPri.Enabled = true;
            txtSalePri.Enabled = true;

            lblProductCode.Enabled = true;
            lblProductName.Enabled = true;
            lblGroup.Enabled = true;
            lblSize.Enabled = true;
            lblQty.Enabled = true;
            lblUnit.Enabled = true;
            lblPurchase.Enabled = true;
            lblSale.Enabled = true;
            btnOk.Enabled = true;
            btnManageCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void deleteItem()
        {
            String prdCode = txtProductCode.Text;
            txtProductCode.ReadOnly = true;
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == true && btnDele.Enabled == false && btnEdit.Enabled == false)
            {
                addItem();
            }
            else if (btnAdd.Enabled == false && btnDele.Enabled == true && btnEdit.Enabled == false)
            {
                deleteItem();
            }
            else if (btnAdd.Enabled == false && btnDele.Enabled == false && btnEdit.Enabled == true)
            {
                editItem();
            }
        }

        private void btnManageCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            StockManagement sm = new StockManagement();
            sm.Show();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
