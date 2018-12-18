namespace InventorySolutions
{
    partial class ProductPurchase
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
            this.proDate = new System.Windows.Forms.DateTimePicker();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSuppAdd = new System.Windows.Forms.TextBox();
            this.txtproBillNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.addPurchaseGrid = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPurchaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // proDate
            // 
            this.proDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.proDate.Location = new System.Drawing.Point(359, 9);
            this.proDate.Name = "proDate";
            this.proDate.Size = new System.Drawing.Size(84, 20);
            this.proDate.TabIndex = 1;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSupplierName.Location = new System.Drawing.Point(95, 42);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(207, 20);
            this.txtSupplierName.TabIndex = 2;
            // 
            // txtSuppAdd
            // 
            this.txtSuppAdd.Location = new System.Drawing.Point(359, 42);
            this.txtSuppAdd.Name = "txtSuppAdd";
            this.txtSuppAdd.Size = new System.Drawing.Size(164, 20);
            this.txtSuppAdd.TabIndex = 3;
            this.txtSuppAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSuppAdd_MouseClick);
            // 
            // txtproBillNo
            // 
            this.txtproBillNo.Location = new System.Drawing.Point(59, 9);
            this.txtproBillNo.Name = "txtproBillNo";
            this.txtproBillNo.Size = new System.Drawing.Size(134, 20);
            this.txtproBillNo.TabIndex = 0;
            this.txtproBillNo.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Address";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(12, 9);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(40, 13);
            this.lblBillNo.TabIndex = 92;
            this.lblBillNo.Text = "Bill No.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(308, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 93;
            this.lblDate.Text = "Date";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(784, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // addPurchaseGrid
            // 
            this.addPurchaseGrid.AllowUserToAddRows = false;
            this.addPurchaseGrid.AllowUserToDeleteRows = false;
            this.addPurchaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPurchaseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Particulars,
            this.Unit,
            this.Quantity,
            this.Rate,
            this.Amount});
            this.addPurchaseGrid.Location = new System.Drawing.Point(199, 70);
            this.addPurchaseGrid.Name = "addPurchaseGrid";
            this.addPurchaseGrid.ReadOnly = true;
            this.addPurchaseGrid.Size = new System.Drawing.Size(660, 220);
            this.addPurchaseGrid.TabIndex = 90;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(93, 183);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(93, 147);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 6;
            this.txtRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRate_MouseClick);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(93, 113);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductName.Location = new System.Drawing.Point(93, 80);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 186);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 83;
            this.lblTotal.Text = "Total";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 82;
            this.lblPrice.Text = "Rate";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 113);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 81;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 83);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 80;
            this.lblProductName.Text = "Product Name";
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
            this.Unit.ReadOnly = true;
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
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(93, 219);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 96;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(12, 219);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 97;
            this.lblUnit.Text = "Unit";
            // 
            // ProductPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 297);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.proDate);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSuppAdd);
            this.Controls.Add(this.txtproBillNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBillNo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.addPurchaseGrid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductName);
            this.Name = "ProductPurchase";
            this.Text = "ProductPurchase";
            ((System.ComponentModel.ISupportInitialize)(this.addPurchaseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker proDate;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSuppAdd;
        private System.Windows.Forms.TextBox txtproBillNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.DataGridView addPurchaseGrid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
    }
}