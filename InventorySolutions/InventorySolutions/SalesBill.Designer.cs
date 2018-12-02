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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
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
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(359, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(359, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 65;
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(308, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 62;
            this.lblDate.Text = "Date";
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
            // 
            // txtGrand
            // 
            this.txtGrand.Location = new System.Drawing.Point(257, 371);
            this.txtGrand.Name = "txtGrand";
            this.txtGrand.Size = new System.Drawing.Size(106, 20);
            this.txtGrand.TabIndex = 78;
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
            // GridSales
            // 
            this.GridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.Particulars,
            this.Quantity,
            this.Rate,
            this.Amount});
            this.GridSales.Location = new System.Drawing.Point(12, 97);
            this.GridSales.Name = "GridSales";
            this.GridSales.Size = new System.Drawing.Size(511, 220);
            this.GridSales.TabIndex = 69;
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
            // SalesBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 442);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.GridSales);
            this.Name = "SalesBill";
            this.Text = "SalesBill";
            ((System.ComponentModel.ISupportInitialize)(this.GridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.Label lblDate;
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
        private System.Windows.Forms.Button btnCancel;
    }
}