namespace InventorySolutions
{
    partial class SalesBill
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
            this.saleDate = new System.Windows.Forms.DateTimePicker();
            this.txtSaleName = new System.Windows.Forms.TextBox();
            this.txtSaleAdd = new System.Windows.Forms.TextBox();
            this.txtSaleBillno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTaxable = new System.Windows.Forms.TextBox();
            this.txtGrand = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblGrand = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxable = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSalesOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GridSales = new System.Windows.Forms.DataGridView();
            this.particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDate
            // 
            this.saleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.saleDate.Location = new System.Drawing.Point(359, 9);
            this.saleDate.Name = "saleDate";
            this.saleDate.Size = new System.Drawing.Size(84, 20);
            this.saleDate.TabIndex = 68;
            // 
            // txtSaleName
            // 
            this.txtSaleName.Location = new System.Drawing.Point(95, 42);
            this.txtSaleName.Name = "txtSaleName";
            this.txtSaleName.ReadOnly = true;
            this.txtSaleName.Size = new System.Drawing.Size(207, 20);
            this.txtSaleName.TabIndex = 67;
            this.txtSaleName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSaleAdd
            // 
            this.txtSaleAdd.Location = new System.Drawing.Point(359, 42);
            this.txtSaleAdd.Name = "txtSaleAdd";
            this.txtSaleAdd.ReadOnly = true;
            this.txtSaleAdd.Size = new System.Drawing.Size(164, 20);
            this.txtSaleAdd.TabIndex = 66;
            // 
            // txtSaleBillno
            // 
            this.txtSaleBillno.Location = new System.Drawing.Point(59, 9);
            this.txtSaleBillno.Name = "txtSaleBillno";
            this.txtSaleBillno.ReadOnly = true;
            this.txtSaleBillno.Size = new System.Drawing.Size(134, 20);
            this.txtSaleBillno.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Address";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(12, 9);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(40, 13);
            this.lblBillNo.TabIndex = 61;
            this.lblBillNo.Text = "Bill No.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(308, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 62;
            this.lblDate.Text = "Date";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(90, 371);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(91, 20);
            this.txtTax.TabIndex = 80;
            // 
            // txtTaxable
            // 
            this.txtTaxable.Location = new System.Drawing.Point(416, 333);
            this.txtTaxable.Name = "txtTaxable";
            this.txtTaxable.Size = new System.Drawing.Size(95, 20);
            this.txtTaxable.TabIndex = 79;
            this.txtTaxable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTaxable_MouseClick);
            // 
            // txtGrand
            // 
            this.txtGrand.Location = new System.Drawing.Point(257, 371);
            this.txtGrand.Name = "txtGrand";
            this.txtGrand.Size = new System.Drawing.Size(106, 20);
            this.txtGrand.TabIndex = 78;
            this.txtGrand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGrand_MouseClick);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(243, 333);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(83, 20);
            this.txtDiscount.TabIndex = 77;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(90, 336);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(91, 20);
            this.txtAmount.TabIndex = 76;
            this.txtAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAmount_MouseClick);
            // 
            // lblGrand
            // 
            this.lblGrand.AutoSize = true;
            this.lblGrand.Location = new System.Drawing.Point(188, 374);
            this.lblGrand.Name = "lblGrand";
            this.lblGrand.Size = new System.Drawing.Size(63, 13);
            this.lblGrand.TabIndex = 75;
            this.lblGrand.Text = "Grand Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(15, 375);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 74;
            this.lblTax.Text = "Tax";
            // 
            // lblTaxable
            // 
            this.lblTaxable.AutoSize = true;
            this.lblTaxable.Location = new System.Drawing.Point(326, 336);
            this.lblTaxable.Name = "lblTaxable";
            this.lblTaxable.Size = new System.Drawing.Size(84, 13);
            this.lblTaxable.TabIndex = 73;
            this.lblTaxable.Text = "Taxable Amount";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(188, 336);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 72;
            this.lblDiscount.Text = "Discount";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 336);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 71;
            this.lblTotal.Text = "Total Amount";
            // 
            // btnSalesOk
            // 
            this.btnSalesOk.Location = new System.Drawing.Point(162, 407);
            this.btnSalesOk.Name = "btnSalesOk";
            this.btnSalesOk.Size = new System.Drawing.Size(75, 23);
            this.btnSalesOk.TabIndex = 70;
            this.btnSalesOk.Text = "OK";
            this.btnSalesOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GridSales
            // 
            this.GridSales.AllowUserToAddRows = false;
            this.GridSales.AllowUserToDeleteRows = false;
            this.GridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.particulars,
            this.Unit,
            this.Quantity,
            this.Rate,
            this.Amount});
            this.GridSales.Location = new System.Drawing.Point(6, 97);
            this.GridSales.Name = "GridSales";
            this.GridSales.Size = new System.Drawing.Size(620, 224);
            this.GridSales.TabIndex = 83;
            // 
            // particulars
            // 
            this.particulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.particulars.DataPropertyName = "Product_Name";
            this.particulars.HeaderText = "Particulars";
            this.particulars.Name = "particulars";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "(none)";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // SalesBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 442);
            this.Controls.Add(this.GridSales);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.saleDate);
            this.Controls.Add(this.txtSaleName);
            this.Controls.Add(this.txtSaleAdd);
            this.Controls.Add(this.txtSaleBillno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBillNo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTaxable);
            this.Controls.Add(this.txtGrand);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblGrand);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTaxable);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSalesOk);
            this.Name = "SalesBill";
            this.Text = "SalesBill";
            ((System.ComponentModel.ISupportInitialize)(this.GridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTaxable;
        private System.Windows.Forms.TextBox txtGrand;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblGrand;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxable;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSalesOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridView GridSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        public System.Windows.Forms.DateTimePicker saleDate;
        public System.Windows.Forms.TextBox txtSaleName;
        public System.Windows.Forms.TextBox txtSaleAdd;
        public System.Windows.Forms.TextBox txtSaleBillno;
    }
}