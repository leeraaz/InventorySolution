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
    public partial class Supplier : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            autoSupplierID();
            supplierView();
        }

        public void addSupplier()
        {
            //string supid = txtSupplierID.Text;
            String suppName = txtCompName.Text;
            String address = txtAddress.Text;
            String pan = txtPAN.Text;
            String contact = txtContact.Text;
            String email = txtEmail.Text;

            if (String.IsNullOrEmpty(suppName) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(pan) || String.IsNullOrEmpty(contact) || String.IsNullOrEmpty(email))
            {
                MessageBox.Show("All the fields should be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                //string suppInsert = "insert into supplier(Supplier_ID,Company_Name,Address,PAN,Contact,Email)" +
                //                    "values('" + supid + "','" + suppName + "','" + address + "','" + pan + "','" + contact + "','" + email + "');";

                string suppInsert = "insert into supplier(Company_Name,Address,PAN,Contact,Email)" +
                                    "values('" + suppName + "','" + address + "','" + pan + "','" + contact + "','" + email + "');";

                db.DBConnect = db.DBConnection();
                MySqlCommand myProduct = new MySqlCommand(suppInsert, db.DBConnect);
                try
                {
                    //MySqlDataReader inscmd = cmd.ExecuteReader();
                    int num = myProduct.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Supplier has been inserted.");
                    }
                    else
                    {
                        MessageBox.Show("Supplier details is not inserted.");
                    }
                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message, "An error has occured: ");
                }
            }
        }

        private void btnSuppAdd_Click(object sender, EventArgs e)
        {
            txtCompName.Enabled = true;
            txtAddress.Enabled = true;
            txtPAN.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;

            lblSuppAdd.Enabled = true;
            lblSuppName.Enabled = true;
            lblContact.Enabled = true;
            lblPan.Enabled = true;
            lblEmail.Enabled = true;
            btnOk.Enabled = true;
            btnCancel.Enabled = false;
            btnDele.Enabled = false;
            btnSuppEdit.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnSuppAdd.Enabled == true && btnDele.Enabled == false && btnSuppEdit.Enabled == false)
            {
                addSupplier();
            }
            else if (btnSuppAdd.Enabled == false && btnDele.Enabled == true && btnSuppEdit.Enabled == false)
            {
                deleteSupplier();
            }
            else if (btnSuppAdd.Enabled == false && btnDele.Enabled == false && btnSuppEdit.Enabled == true)
            {
                editSupplier();
            }
        }

        private void btnSuppEdit_Click(object sender, EventArgs e)
        {
            txtCompName.Enabled = true;
            txtAddress.Enabled = true;
            txtPAN.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;

            lblSuppAdd.Enabled = true;
            lblSuppName.Enabled = true;
            lblContact.Enabled = true;
            lblPan.Enabled = true;
            lblEmail.Enabled = true;
            btnOk.Enabled = true;
            btnCancel.Enabled = true;
            btnDele.Enabled = false;
            btnSuppAdd.Enabled = false;
        }

        public void editSupplier()
        {
            //String supid = txtSupplierID.Text;
            String companyName = txtCompName.Text;
            String address = txtAddress.Text;
            String pan = txtPAN.Text;
            String contact = txtContact.Text;
            String email = txtEmail.Text;

            if (String.IsNullOrEmpty(companyName) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(pan) ||  String.IsNullOrEmpty(contact) || String.IsNullOrEmpty(email))
            {
                MessageBox.Show("All the fields should be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string suppUpdate = "update supplier set Company_Name = '" + companyName +
                                                    "',Address = '" + address +
                                                    "',PAN = '" + pan +
                                                    "',Contact = '" + contact +
                                                    "',Email = '" + email +
                                                    "' where Supplier_ID = " + txtSupplierID.Text + ";";
                db.DBConnect = db.DBConnection();
                MySqlCommand prdUpdate = new MySqlCommand(suppUpdate, db.DBConnect);
                try
                {
                    int num = prdUpdate.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Supplier has been updated.");
                    }
                    else
                    {
                        MessageBox.Show("Supplier`s details cannot be updated.");
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
            txtCompName.Enabled = true;
            txtAddress.Enabled = true;
            txtPAN.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;

            lblSuppAdd.Enabled = true;
            lblSuppName.Enabled = true;
            lblContact.Enabled = true;
            lblPan.Enabled = true;
            lblEmail.Enabled = true;
            btnOk.Enabled = true;
            btnCancel.Enabled = true;
            btnSuppAdd.Enabled = false;
            btnSuppEdit.Enabled = false;
        }

        public void deleteSupplier()
        {
            string supid = txtSupplierID.Text;
            String suppID = txtSupplierID.Text;
            String suppName = txtCompName.Text;
            String address = txtAddress.Text;
            String pan = txtPAN.Text;
            String cont = txtContact.Text;
            String email = txtEmail.Text; ;

            if (String.IsNullOrEmpty(suppName) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(pan)|| String.IsNullOrEmpty(cont) || String.IsNullOrEmpty(email))
            {
                MessageBox.Show("All the fields should be filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string report = "delete from supplier where Supplier_ID = '" + suppID + "'";

                db.DBConnect = db.DBConnection();
                MySqlCommand myProduct = new MySqlCommand(report, db.DBConnect);
                try
                {
                    //MySqlDataReader inscmd = cmd.ExecuteReader();
                    int num = myProduct.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Supplier has been deleted.");
                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Supplier cannot be deleted.");
                    }
                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        public void autoSupplierID()
        {
            int a;
            db.DBConnect = db.DBConnection();
            string getID = "Select max(Supplier_ID) from Supplier";
            MySqlCommand cmd = new MySqlCommand(getID, db.DBConnect);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string val = dr[0].ToString();
                if(val == "")
                {
                    txtSupplierID.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtSupplierID.Text = a.ToString(); 
                }
            }
        }

        public void supplierView()
        {
            db.DBConnect = db.DBConnection();
            string getProduct = "Select * from supplier;";
            MySqlDataAdapter getdata = new MySqlDataAdapter(getProduct, db.DBConnect);
            DataSet ds = new DataSet();
            getdata.Fill(ds, "supplier");
            GridSupplier.DataSource = ds.Tables["supplier"];
            db.DBConnect.Close();
        }

        private void GridSupplier_DoubleClick(object sender, EventArgs e)
        {
            if (GridSupplier.SelectedRows.Count > 0)
            {
                txtSupplierID.Text = GridSupplier.SelectedRows[0].Cells[0].Value + string.Empty;
                txtCompName.Text = GridSupplier.SelectedRows[0].Cells[1].Value + string.Empty;
                txtAddress.Text = GridSupplier.SelectedRows[0].Cells[2].Value + string.Empty;
                txtPAN.Text = GridSupplier.SelectedRows[0].Cells[3].Value + string.Empty;
                txtContact.Text = GridSupplier.SelectedRows[0].Cells[4].Value + string.Empty;
                txtEmail.Text = GridSupplier.SelectedRows[0].Cells[5].Value + string.Empty;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}