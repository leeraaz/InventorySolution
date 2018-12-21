namespace InventorySolutions
{
    partial class PurchaseReport
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
            this.purReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // purReport
            // 
            this.purReport.ActiveViewIndex = -1;
            this.purReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.purReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purReport.Location = new System.Drawing.Point(0, 0);
            this.purReport.Name = "purReport";
            this.purReport.Size = new System.Drawing.Size(748, 469);
            this.purReport.TabIndex = 0;
            this.purReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 469);
            this.Controls.Add(this.purReport);
            this.Name = "PurchaseReport";
            this.Text = "PurchaseReport";
            this.Load += new System.EventHandler(this.PurchaseReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer purReport;
    }
}