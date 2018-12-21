namespace InventorySolutions
{
    partial class CustomerOrders
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
            this.orderList = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Location = new System.Drawing.Point(12, 50);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(584, 222);
            this.orderList.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(157, 17);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(240, 17);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.ReadOnly = true;
            this.txtCusID.Size = new System.Drawing.Size(100, 20);
            this.txtCusID.TabIndex = 3;
            this.txtCusID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCusID_MouseClick);
            // 
            // CustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 285);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.orderList);
            this.Name = "CustomerOrders";
            this.Text = "CustomerOrders";
            this.Load += new System.EventHandler(this.CustomerOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCusID;
    }
}