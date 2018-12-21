using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySolutions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ProductSale sb = new ProductSale();
            sb.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ProductPurchase pb = new ProductPurchase();
            pb.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockManagement sm = new StockManagement();
            sm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSs.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            CustomerOrders cud = new CustomerOrders();
            cud.Show();
        }

        private void btnViewPurchase_Click(object sender, EventArgs e)
        {
            AllPurchaseDetails allpurchase = new AllPurchaseDetails();
            allpurchase.Show();
        }

        private void btnSalesView_Click(object sender, EventArgs e)
        {
            AllSalesBills allsale = new AllSalesBills();
            allsale.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer_List cl = new Customer_List();
            cl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InventoryReview ire = new InventoryReview();
            ire.Show();
        }
    }
}
