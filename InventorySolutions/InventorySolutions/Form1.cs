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
            SalesBill sb = new SalesBill();
            sb.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseBill pb = new PurchaseBill();
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
    }
}
