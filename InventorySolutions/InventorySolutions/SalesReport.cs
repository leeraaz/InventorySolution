﻿using System;
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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            CrystalReports.crprSales saleReport = new CrystalReports.crprSales();
            crvSales.ReportSource = null;
            crvSales.ReportSource = saleReport;
        }
    }
}