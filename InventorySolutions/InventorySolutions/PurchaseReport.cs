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
    public partial class PurchaseReport : Form
    {
        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            CrystalReports.crptPurchase crpt = new CrystalReports.crptPurchase();
            purReport.ReportSource = null;
            purReport.ReportSource = crpt;
        }
    }
}
