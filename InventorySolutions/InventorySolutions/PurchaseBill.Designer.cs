namespace InventorySolutions
{
    partial class PurchaseBill
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.purDate = new System.Windows.Forms.DateTimePicker();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.txtSupplierAdd = new System.Windows.Forms.TextBox();
            this.txtPurBillno = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.GridPurchase = new System.Windows.Forms.DataGridView();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(377, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(211, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // purDate
            // 
            this.purDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purDate.Location = new System.Drawing.Point(619, 6);
            this.purDate.Name = "purDate";
            this.purDate.Size = new System.Drawing.Size(84, 20);
            this.purDate.TabIndex = 1;
            // 
            // txtSuppName
            // 
            this.txtSuppName.Location = new System.Drawing.Point(92, 42);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(611, 20);
            this.txtSuppName.TabIndex = 2;
            // 
            // txtSupplierAdd
            // 
            this.txtSupplierAdd.Location = new System.Drawing.Point(92, 69);
            this.txtSupplierAdd.Name = "txtSupplierAdd";
            this.txtSupplierAdd.Size = new System.Drawing.Size(348, 20);
            this.txtSupplierAdd.TabIndex = 3;
            // 
            // txtPurBillno
            // 
            this.txtPurBillno.Location = new System.Drawing.Point(92, 6);
            this.txtPurBillno.Name = "txtPurBillno";
            this.txtPurBillno.Size = new System.Drawing.Size(134, 20);
            this.txtPurBillno.TabIndex = 0;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(9, 45);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(76, 13);
            this.lblSupplier.TabIndex = 55;
            this.lblSupplier.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Address";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(567, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 53;
            this.lblDate.Text = "Date";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(92, 373);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(161, 20);
            this.txtTax.TabIndex = 7;
            // 
            // txtTaxable
            // 
            this.txtTaxable.Location = new System.Drawing.Point(498, 335);
            this.txtTaxable.Name = "txtTaxable";
            this.txtTaxable.Size = new System.Drawing.Size(204, 20);
            this.txtTaxable.TabIndex = 6;
            this.txtTaxable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTaxable_MouseClick);
            // 
            // txtGrand
            // 
            this.txtGrand.Location = new System.Drawing.Point(332, 374);
            this.txtGrand.Name = "txtGrand";
            this.txtGrand.Size = new System.Drawing.Size(256, 20);
            this.txtGrand.TabIndex = 8;
            this.txtGrand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGrand_MouseClick);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(318, 335);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(84, 20);
            this.txtDiscount.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(92, 335);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(161, 20);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAmount_MouseClick);
            // 
            // lblGrand
            // 
            this.lblGrand.AutoSize = true;
            this.lblGrand.Location = new System.Drawing.Point(263, 377);
            this.lblGrand.Name = "lblGrand";
            this.lblGrand.Size = new System.Drawing.Size(63, 13);
            this.lblGrand.TabIndex = 66;
            this.lblGrand.Text = "Grand Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(24, 377);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 65;
            this.lblTax.Text = "Tax";
            // 
            // lblTaxable
            // 
            this.lblTaxable.AutoSize = true;
            this.lblTaxable.Location = new System.Drawing.Point(408, 338);
            this.lblTaxable.Name = "lblTaxable";
            this.lblTaxable.Size = new System.Drawing.Size(84, 13);
            this.lblTaxable.TabIndex = 64;
            this.lblTaxable.Text = "Taxable Amount";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(263, 338);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 63;
            this.lblDiscount.Text = "Discount";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 338);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "Total Amount";
            // 
            // btnSalesOk
            // 
            this.btnSalesOk.Location = new System.Drawing.Point(148, 410);
            this.btnSalesOk.Name = "btnSalesOk";
            this.btnSalesOk.Size = new System.Drawing.Size(211, 23);
            this.btnSalesOk.TabIndex = 9;
            this.btnSalesOk.Text = "OK";
            this.btnSalesOk.UseVisualStyleBackColor = true;
            this.btnSalesOk.Click += new System.EventHandler(this.btnSalesOk_Click);
            // 
            // GridPurchase
            // 
            this.GridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Particulars,
            this.Unit,
            this.Quantity,
            this.Rate,
            this.Amount});
            this.GridPurchase.Location = new System.Drawing.Point(9, 97);
            this.GridPurchase.Name = "GridPurchase";
            this.GridPurchase.Size = new System.Drawing.Size(694, 220);
            this.GridPurchase.TabIndex = 60;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(9, 9);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(40, 13);
            this.lblBillNo.TabIndex = 52;
            this.lblBillNo.Text = "Bill No.";
            // 
            // Particulars
            // 
            this.Particulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Particulars.HeaderText = "Particulars";
            this.Particulars.Name = "Particulars";
            this.Particulars.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 435);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.purDate);
            this.Controls.Add(this.txtSuppName);
            this.Controls.Add(this.txtSupplierAdd);
            this.Controls.Add(this.txtPurBillno);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.GridPurchase);
            this.Controls.Add(this.lblBillNo);
            this.Name = "PurchaseBill";
            this.Text = "PurchaseBill";
            this.Load += new System.EventHandler(this.PurchaseBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label lblBillNo;
        public System.Windows.Forms.TextBox txtPurBillno;
        public System.Windows.Forms.TextBox txtSuppName;
        public System.Windows.Forms.TextBox txtSupplierAdd;
        public System.Windows.Forms.DateTimePicker purDate;
        public System.Windows.Forms.DataGridView GridPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}