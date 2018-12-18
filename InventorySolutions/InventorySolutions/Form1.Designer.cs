namespace InventorySolutions
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSs = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnFav = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.btnPurchase);
            this.panel3.Controls.Add(this.btnSales);
            this.panel3.Controls.Add(this.btnStock);
            this.panel3.Location = new System.Drawing.Point(248, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 502);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(96, 8);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(87, 47);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = "Purchase Bill";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(3, 8);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(87, 47);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sales Bill";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(189, 8);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(87, 47);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Stock Management";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblSs);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(2, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 182);
            this.panel1.TabIndex = 2;
            // 
            // lblSs
            // 
            this.lblSs.AutoSize = true;
            this.lblSs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSs.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSs.Location = new System.Drawing.Point(139, 46);
            this.lblSs.Name = "lblSs";
            this.lblSs.Size = new System.Drawing.Size(2, 31);
            this.lblSs.TabIndex = 3;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDay.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(131, 118);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(2, 24);
            this.lblDay.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 118);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(2, 24);
            this.lblDate.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Harrington", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(32, 34);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(2, 43);
            this.lblTime.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnSupplier);
            this.panel2.Controls.Add(this.btnFav);
            this.panel2.Location = new System.Drawing.Point(1, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 315);
            this.panel2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Inventory";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(3, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(235, 57);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(1, 192);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(235, 57);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(3, 129);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(235, 57);
            this.btnSupplier.TabIndex = 1;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnFav
            // 
            this.btnFav.Location = new System.Drawing.Point(3, 3);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(235, 57);
            this.btnFav.TabIndex = 0;
            this.btnFav.Text = "Favourites";
            this.btnFav.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.addVoucherToolStripMenuItem,
            this.addSupplierToolStripMenuItem,
            this.customerMasterToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.editToolStripMenuItem.Text = "Entry";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteProductToolStripMenuItem,
            this.updateProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.productToolStripMenuItem.Text = "Product Master";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addToolStripMenuItem.Text = "Add Product";
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            // 
            // addVoucherToolStripMenuItem
            // 
            this.addVoucherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleBillsToolStripMenuItem,
            this.purchaseBillsToolStripMenuItem});
            this.addVoucherToolStripMenuItem.Name = "addVoucherToolStripMenuItem";
            this.addVoucherToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addVoucherToolStripMenuItem.Text = "Add Voucher";
            // 
            // saleBillsToolStripMenuItem
            // 
            this.saleBillsToolStripMenuItem.Name = "saleBillsToolStripMenuItem";
            this.saleBillsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saleBillsToolStripMenuItem.Text = "Sale Bills";
            // 
            // purchaseBillsToolStripMenuItem
            // 
            this.purchaseBillsToolStripMenuItem.Name = "purchaseBillsToolStripMenuItem";
            this.purchaseBillsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.purchaseBillsToolStripMenuItem.Text = "Purchase Bills";
            // 
            // addSupplierToolStripMenuItem
            // 
            this.addSupplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSupplierToolStripMenuItem1,
            this.deleteSupplierToolStripMenuItem,
            this.updateSupplierToolStripMenuItem});
            this.addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            this.addSupplierToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addSupplierToolStripMenuItem.Text = "Supplier Master";
            // 
            // addSupplierToolStripMenuItem1
            // 
            this.addSupplierToolStripMenuItem1.Name = "addSupplierToolStripMenuItem1";
            this.addSupplierToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.addSupplierToolStripMenuItem1.Text = "Add Supplier";
            // 
            // deleteSupplierToolStripMenuItem
            // 
            this.deleteSupplierToolStripMenuItem.Name = "deleteSupplierToolStripMenuItem";
            this.deleteSupplierToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteSupplierToolStripMenuItem.Text = "Delete Supplier";
            // 
            // updateSupplierToolStripMenuItem
            // 
            this.updateSupplierToolStripMenuItem.Name = "updateSupplierToolStripMenuItem";
            this.updateSupplierToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.updateSupplierToolStripMenuItem.Text = "Update Supplier";
            // 
            // customerMasterToolStripMenuItem
            // 
            this.customerMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem});
            this.customerMasterToolStripMenuItem.Name = "customerMasterToolStripMenuItem";
            this.customerMasterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.customerMasterToolStripMenuItem.Text = "Customer Master";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSs;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVoucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
    }
}

