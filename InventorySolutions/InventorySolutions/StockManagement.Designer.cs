namespace InventorySolutions
{
    partial class StockManagement
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
            this.btnDele = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtSalePri = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPurPri = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.stockGrid = new System.Windows.Forms.DataGridView();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnManageCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDele
            // 
            this.btnDele.Location = new System.Drawing.Point(200, 12);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(75, 23);
            this.btnDele.TabIndex = 71;
            this.btnDele.Text = "Delete";
            this.btnDele.UseVisualStyleBackColor = true;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(103, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Enabled = false;
            this.lblPurchase.Location = new System.Drawing.Point(7, 160);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(79, 13);
            this.lblPurchase.TabIndex = 68;
            this.lblPurchase.Text = "Purchase Price";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Enabled = false;
            this.lblQty.Location = new System.Drawing.Point(9, 134);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 67;
            this.lblQty.Text = "Quantity";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Enabled = false;
            this.lblGroup.Location = new System.Drawing.Point(9, 108);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 66;
            this.lblGroup.Text = "Group";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Enabled = false;
            this.lblProductName.Location = new System.Drawing.Point(9, 80);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 65;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Enabled = false;
            this.lblProductCode.Location = new System.Drawing.Point(9, 51);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 64;
            this.lblProductCode.Text = "Product Code";
            // 
            // txtSalePri
            // 
            this.txtSalePri.Enabled = false;
            this.txtSalePri.Location = new System.Drawing.Point(407, 154);
            this.txtSalePri.Name = "txtSalePri";
            this.txtSalePri.Size = new System.Drawing.Size(143, 20);
            this.txtSalePri.TabIndex = 61;
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(106, 128);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(163, 20);
            this.txtQty.TabIndex = 60;
            // 
            // txtPurPri
            // 
            this.txtPurPri.Enabled = false;
            this.txtPurPri.Location = new System.Drawing.Point(106, 154);
            this.txtPurPri.Name = "txtPurPri";
            this.txtPurPri.Size = new System.Drawing.Size(100, 20);
            this.txtPurPri.TabIndex = 59;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(106, 74);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(444, 20);
            this.txtProductName.TabIndex = 57;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Enabled = false;
            this.txtProductCode.Location = new System.Drawing.Point(106, 48);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(149, 20);
            this.txtProductCode.TabIndex = 56;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Enabled = false;
            this.lblSale.Location = new System.Drawing.Point(290, 160);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(60, 13);
            this.lblSale.TabIndex = 55;
            this.lblSale.Text = "Sales Price";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Enabled = false;
            this.lblUnit.Location = new System.Drawing.Point(290, 131);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 54;
            this.lblUnit.Text = "Unit";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(475, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Enabled = false;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "Pcs",
            "Kgs",
            "Mtr",
            "Roll"});
            this.cmbUnit.Location = new System.Drawing.Point(368, 128);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(182, 21);
            this.cmbUnit.TabIndex = 73;
            this.cmbUnit.UseWaitCursor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Enabled = false;
            this.lblSize.Location = new System.Drawing.Point(333, 105);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 74;
            this.lblSize.Text = "Size";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Enabled = false;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "1/2\"",
            "3/4\"",
            "1\"",
            "1-1/4\"",
            "1-1/2\"",
            "2\""});
            this.cmbSize.Location = new System.Drawing.Point(368, 102);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(182, 21);
            this.cmbSize.TabIndex = 75;
            // 
            // stockGrid
            // 
            this.stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGrid.Location = new System.Drawing.Point(12, 212);
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.Size = new System.Drawing.Size(538, 248);
            this.stockGrid.TabIndex = 76;
            this.stockGrid.DoubleClick += new System.EventHandler(this.stockGrid_DoubleClick);
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.Enabled = false;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Items.AddRange(new object[] {
            "PPR PIPES",
            "PPR FITTINGS",
            "CPVC PIPES",
            "CPVC FITTINS"});
            this.cmbGroups.Location = new System.Drawing.Point(106, 100);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(221, 21);
            this.cmbGroups.TabIndex = 77;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(160, 183);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 78;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnManageCancel
            // 
            this.btnManageCancel.Enabled = false;
            this.btnManageCancel.Location = new System.Drawing.Point(241, 183);
            this.btnManageCancel.Name = "btnManageCancel";
            this.btnManageCancel.Size = new System.Drawing.Size(75, 23);
            this.btnManageCancel.TabIndex = 79;
            this.btnManageCancel.Text = "Cancel";
            this.btnManageCancel.UseVisualStyleBackColor = true;
            this.btnManageCancel.Click += new System.EventHandler(this.btnManageCancel_Click);
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 472);
            this.Controls.Add(this.btnManageCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.stockGrid);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDele);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.txtSalePri);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPurPri);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.lblUnit);
            this.Name = "StockManagement";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtSalePri;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPurPri;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.DataGridView stockGrid;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnManageCancel;
    }
}