namespace InventorySolutions
{
    partial class SalesReport
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
            this.crvSales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvSales
            // 
            this.crvSales.ActiveViewIndex = -1;
            this.crvSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSales.Location = new System.Drawing.Point(0, 0);
            this.crvSales.Name = "crvSales";
            this.crvSales.Size = new System.Drawing.Size(701, 446);
            this.crvSales.TabIndex = 0;
            this.crvSales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 446);
            this.Controls.Add(this.crvSales);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSales;
    }
}