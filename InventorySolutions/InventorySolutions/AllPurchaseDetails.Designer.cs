namespace InventorySolutions
{
    partial class AllPurchaseDetails
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
            this.allPurcahseGrid = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPurcahseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // allPurcahseGrid
            // 
            this.allPurcahseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPurcahseGrid.Location = new System.Drawing.Point(13, 48);
            this.allPurcahseGrid.Name = "allPurcahseGrid";
            this.allPurcahseGrid.Size = new System.Drawing.Size(839, 415);
            this.allPurcahseGrid.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(726, 16);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(105, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // AllPurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 475);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.allPurcahseGrid);
            this.Name = "AllPurchaseDetails";
            this.Text = "AllPurchaseDetails";
            this.Load += new System.EventHandler(this.AllPurchaseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allPurcahseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allPurcahseGrid;
        private System.Windows.Forms.Button btnReport;
    }
}