namespace InventorySolutions
{
    partial class InventoryReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ProGrid = new System.Windows.Forms.DataGridView();
            this.qtyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.orderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ProGrid
            // 
            this.ProGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProGrid.Location = new System.Drawing.Point(12, 34);
            this.ProGrid.Name = "ProGrid";
            this.ProGrid.Size = new System.Drawing.Size(433, 266);
            this.ProGrid.TabIndex = 1;
            // 
            // qtyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.qtyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.qtyChart.Legends.Add(legend1);
            this.qtyChart.Location = new System.Drawing.Point(462, 34);
            this.qtyChart.Name = "qtyChart";
            this.qtyChart.Size = new System.Drawing.Size(533, 266);
            this.qtyChart.TabIndex = 3;
            this.qtyChart.Text = "Available Quantity";
            // 
            // orderGrid
            // 
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Location = new System.Drawing.Point(12, 333);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.Size = new System.Drawing.Size(433, 266);
            this.orderGrid.TabIndex = 4;
            // 
            // orderChart
            // 
            chartArea2.Name = "ChartArea1";
            this.orderChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.orderChart.Legends.Add(legend2);
            this.orderChart.Location = new System.Drawing.Point(462, 333);
            this.orderChart.Name = "orderChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Item";
            this.orderChart.Series.Add(series1);
            this.orderChart.Size = new System.Drawing.Size(533, 266);
            this.orderChart.TabIndex = 5;
            this.orderChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stock Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of quantity order for a particular item.";
            // 
            // InventoryReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderChart);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.qtyChart);
            this.Controls.Add(this.ProGrid);
            this.Name = "InventoryReview";
            this.Text = "InventoryReview";
            ((System.ComponentModel.ISupportInitialize)(this.ProGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart qtyChart;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart orderChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}