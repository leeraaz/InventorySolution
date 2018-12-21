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
    public partial class AllPurchaseDetails : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public AllPurchaseDetails()
        {
            InitializeComponent();
        }

        private void AllPurchaseDetails_Load(object sender, EventArgs e)
        {
            getPurchaseBills();
        }

        public void getPurchaseBills()
        {
            db.DBConnect = db.DBConnection();
            string getPurchaseBill = "Select * from Purchase;";
            MySqlDataAdapter getdata = new MySqlDataAdapter(getPurchaseBill, db.DBConnect);
            DataSet ds = new DataSet();
            getdata.Fill(ds, "Purchase");
            allPurcahseGrid.DataSource = ds.Tables["Purchase"];
            db.DBConnect.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            PurchaseReport purRep = new PurchaseReport();
            purRep.Show();
        }
    }
}
