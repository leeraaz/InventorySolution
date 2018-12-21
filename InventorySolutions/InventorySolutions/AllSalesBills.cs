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
    public partial class AllSalesBills : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public AllSalesBills()
        {
            InitializeComponent();
        }

        private void AllSalesBills_Load(object sender, EventArgs e)
        {
            getSalesBills();
        }

        public void getSalesBills()
        {
            db.DBConnect = db.DBConnection();
            string getSalesBill = "Select * from sales;";
            MySqlDataAdapter getdata = new MySqlDataAdapter(getSalesBill, db.DBConnect);
            DataSet ds = new DataSet();
            getdata.Fill(ds, "Purchase");
            allSalesGrid.DataSource = ds.Tables["Purchase"];
            db.DBConnect.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SalesReport sale = new SalesReport();
            sale.Show();
        }
    }
}
