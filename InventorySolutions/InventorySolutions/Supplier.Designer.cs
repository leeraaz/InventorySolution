namespace InventorySolutions
{
    partial class Supplier
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
            this.lblSuplier = new System.Windows.Forms.Label();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.lblSuppAdd = new System.Windows.Forms.Label();
            this.lblPan = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDele = new System.Windows.Forms.Button();
            this.btnSuppEdit = new System.Windows.Forms.Button();
            this.btnSuppAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPAN = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.GridSupplier = new System.Windows.Forms.DataGridView();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuplier
            // 
            this.lblSuplier.AutoSize = true;
            this.lblSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuplier.Location = new System.Drawing.Point(98, 9);
            this.lblSuplier.Name = "lblSuplier";
            this.lblSuplier.Size = new System.Drawing.Size(307, 33);
            this.lblSuplier.TabIndex = 0;
            this.lblSuplier.Text = "Supplier Registration";
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Enabled = false;
            this.lblSuppName.Location = new System.Drawing.Point(17, 121);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(82, 13);
            this.lblSuppName.TabIndex = 1;
            this.lblSuppName.Text = "Company Name";
            // 
            // lblSuppAdd
            // 
            this.lblSuppAdd.AutoSize = true;
            this.lblSuppAdd.Enabled = false;
            this.lblSuppAdd.Location = new System.Drawing.Point(17, 159);
            this.lblSuppAdd.Name = "lblSuppAdd";
            this.lblSuppAdd.Size = new System.Drawing.Size(45, 13);
            this.lblSuppAdd.TabIndex = 2;
            this.lblSuppAdd.Text = "Address";
            // 
            // lblPan
            // 
            this.lblPan.AutoSize = true;
            this.lblPan.Enabled = false;
            this.lblPan.Location = new System.Drawing.Point(17, 197);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(29, 13);
            this.lblPan.TabIndex = 3;
            this.lblPan.Text = "PAN";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Enabled = false;
            this.lblContact.Location = new System.Drawing.Point(17, 234);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Enabled = false;
            this.lblEmail.Location = new System.Drawing.Point(17, 266);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail";
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(130, 453);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDele
            // 
            this.btnDele.Location = new System.Drawing.Point(228, 54);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(75, 23);
            this.btnDele.TabIndex = 7;
            this.btnDele.Text = "Delete";
            this.btnDele.UseVisualStyleBackColor = true;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // btnSuppEdit
            // 
            this.btnSuppEdit.Location = new System.Drawing.Point(120, 54);
            this.btnSuppEdit.Name = "btnSuppEdit";
            this.btnSuppEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSuppEdit.TabIndex = 8;
            this.btnSuppEdit.Text = "Edit";
            this.btnSuppEdit.UseVisualStyleBackColor = true;
            this.btnSuppEdit.Click += new System.EventHandler(this.btnSuppEdit_Click);
            // 
            // btnSuppAdd
            // 
            this.btnSuppAdd.Location = new System.Drawing.Point(12, 54);
            this.btnSuppAdd.Name = "btnSuppAdd";
            this.btnSuppAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSuppAdd.TabIndex = 9;
            this.btnSuppAdd.Text = "Add";
            this.btnSuppAdd.UseVisualStyleBackColor = true;
            this.btnSuppAdd.Click += new System.EventHandler(this.btnSuppAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(228, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(411, 54);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCompName
            // 
            this.txtCompName.Enabled = false;
            this.txtCompName.Location = new System.Drawing.Point(139, 118);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(340, 20);
            this.txtCompName.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(139, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(139, 231);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(194, 20);
            this.txtContact.TabIndex = 14;
            // 
            // txtPAN
            // 
            this.txtPAN.Enabled = false;
            this.txtPAN.Location = new System.Drawing.Point(139, 194);
            this.txtPAN.Name = "txtPAN";
            this.txtPAN.Size = new System.Drawing.Size(194, 20);
            this.txtPAN.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(139, 156);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(340, 20);
            this.txtAddress.TabIndex = 16;
            // 
            // GridSupplier
            // 
            this.GridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSupplier.Location = new System.Drawing.Point(5, 299);
            this.GridSupplier.Name = "GridSupplier";
            this.GridSupplier.Size = new System.Drawing.Size(474, 150);
            this.GridSupplier.TabIndex = 17;
            this.GridSupplier.DoubleClick += new System.EventHandler(this.GridSupplier_DoubleClick);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Location = new System.Drawing.Point(139, 84);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(66, 20);
            this.txtSupplierID.TabIndex = 19;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Enabled = false;
            this.lblSupplierID.Location = new System.Drawing.Point(17, 87);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(59, 13);
            this.lblSupplierID.TabIndex = 18;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 482);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.GridSupplier);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPAN);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSuppAdd);
            this.Controls.Add(this.btnSuppEdit);
            this.Controls.Add(this.btnDele);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblPan);
            this.Controls.Add(this.lblSuppAdd);
            this.Controls.Add(this.lblSuppName);
            this.Controls.Add(this.lblSuplier);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuplier;
        private System.Windows.Forms.Label lblSuppName;
        private System.Windows.Forms.Label lblSuppAdd;
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Button btnSuppEdit;
        private System.Windows.Forms.Button btnSuppAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPAN;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView GridSupplier;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
    }
}