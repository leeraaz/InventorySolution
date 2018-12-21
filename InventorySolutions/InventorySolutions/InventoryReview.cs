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
using ZedGraph;
using System.Windows.Forms.DataVisualization.Charting;

namespace InventorySolutions
{
    public partial class InventoryReview : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public InventoryReview()
        {
            InitializeComponent();
            getProducts();
            plotGraph();
            getOrder();
        }

        public void getProducts()
        {
            db.DBConnect = db.DBConnection();
            string getProduct = "Select * from Products;";
            MySqlDataAdapter getdata = new MySqlDataAdapter(getProduct, db.DBConnect);
            DataSet ds = new DataSet();
            getdata.Fill(ds, "Products");
            ProGrid.DataSource = ds.Tables["Products"];
            db.DBConnect.Close();
        }

        public void plotGraph()
        {
            ChartArea chartArea1 = new ChartArea();
            chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chartArea1.AxisY.LabelStyle.Font = new Font("Consolas", 8);
            qtyChart.ChartAreas.Add(chartArea1);

            qtyChart.Series.Add(new Series("Quantity"));

            qtyChart.Series[0].XValueMember = ProGrid.Columns[1].DataPropertyName;
            qtyChart.Series[0].YValueMembers = ProGrid.Columns[3].DataPropertyName;
            qtyChart.DataSource = ProGrid.DataSource;

            qtyChart.Series[0].ChartType = SeriesChartType.Line;
            qtyChart.SaveImage("chart.png", ChartImageFormat.Png);
        }

        public void getOrder()
        {
            db.DBConnect = db.DBConnection();
            string getProduct = "Select * from orders;";
            MySqlDataAdapter getdata = new MySqlDataAdapter(getProduct, db.DBConnect);
            DataSet ds = new DataSet();
            getdata.Fill(ds, "orders");
            orderGrid.DataSource = ds.Tables["orders"];
            db.DBConnect.Close();

            orderChart.Series["Item"].XValueMember = "Item_Name";
            orderChart.Series["Item"].YValueMembers = "Quantity";
            orderChart.DataSource = ds.Tables["orders"];
            orderChart.DataBind();
        }
    }
}
