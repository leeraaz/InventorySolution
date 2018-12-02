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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.GridSales = new System.Windows.Forms.DataGridView();
            this.lblBillNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 58;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 57;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 56;
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
            this.label2.Location = new System.Drawing.Point(305, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Address";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(305, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 53;
            this.lblDate.Text = "Date";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Particulars
            // 
            this.Particulars.HeaderText = "Particulars";
            this.Particulars.Name = "Particulars";
            this.Particulars.ReadOnly = true;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "S.N";
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            this.Serial.Width = 50;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(99, 373);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(91, 20);
            this.txtTax.TabIndex = 71;
            // 
            // txtTaxable
            // 
            this.txtTaxable.Location = new System.Drawing.Point(425, 335);
            this.txtTaxable.Name = "txtTaxable";
            this.txtTaxable.Size = new System.Drawing.Size(95, 20);
            this.txtTaxable.TabIndex = 70;
            // 
            // txtGrand
            // 
            this.txtGrand.Location = new System.Drawing.Point(266, 373);
            this.txtGrand.Name = "txtGrand";
            this.txtGrand.Size = new System.Drawing.Size(106, 20);
            this.txtGrand.TabIndex = 69;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(252, 335);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(83, 20);
            this.txtDiscount.TabIndex = 68;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(99, 338);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(91, 20);
            this.txtAmount.TabIndex = 67;
            // 
            // lblGrand
            // 
            this.lblGrand.AutoSize = true;
            this.lblGrand.Location = new System.Drawing.Point(197, 376);
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
            this.lblTaxable.Location = new System.Drawing.Point(335, 338);
            this.lblTaxable.Name = "lblTaxable";
            this.lblTaxable.Size = new System.Drawing.Size(84, 13);
            this.lblTaxable.TabIndex = 64;
            this.lblTaxable.Text = "Taxable Amount";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(197, 338);
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
            this.btnSalesOk.Location = new System.Drawing.Point(144, 404);
            this.btnSalesOk.Name = "btnSalesOk";
            this.btnSalesOk.Size = new System.Drawing.Size(75, 23);
            this.btnSalesOk.TabIndex = 61;
            this.btnSalesOk.Text = "OK";
            this.btnSalesOk.UseVisualStyleBackColor = true;
            // 
            // GridSales
            // 
            this.GridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.Particulars,
            this.Quantity,
            this.Rate,
            this.Amount});
            this.GridSales.Location = new System.Drawing.Point(9, 97);
            this.GridSales.Name = "GridSales";
            this.GridSales.Size = new System.Drawing.Size(511, 220);
            this.GridSales.TabIndex = 60;
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
            // PurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 435);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.GridSales);
            this.Controls.Add(this.lblBillNo);
            this.Name = "PurchaseBill";
            this.Text = "PurchaseBill";
            ((System.ComponentModel.ISupportInitialize)(this.GridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
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
        private System.Windows.Forms.DataGridView GridSales;
        private System.Windows.Forms.Label lblBillNo;
    }
}