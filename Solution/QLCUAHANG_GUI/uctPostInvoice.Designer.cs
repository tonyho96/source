namespace QLCUAHANG_GUI
{
    partial class uctPostInvoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTransDetailsID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTransPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvListOfDetailProductImport = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbClear = new System.Windows.Forms.LinkLabel();
            this.btnUpdateProductImportDetail = new System.Windows.Forms.Button();
            this.btnAddProductImportDetail = new System.Windows.Forms.Button();
            this.btnDeleteProductImportDetail = new System.Windows.Forms.Button();
            this.cmbIDBillImportDetail = new System.Windows.Forms.ComboBox();
            this.cmbIDProductDetailStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateBillImport = new System.Windows.Forms.Button();
            this.cmbIDAgency = new System.Windows.Forms.ComboBox();
            this.btnDeleteBillImport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddImportBill = new System.Windows.Forms.Button();
            this.dtpkDateTimeImport = new System.Windows.Forms.DateTimePicker();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.txtIDBillImport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvInfoListOfBillImport = new System.Windows.Forms.DataGridView();
            this.TransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListOfDetailProductImport)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoListOfBillImport)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "POST INVOICE DETAILS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "POST INVOICE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTransDetailsID);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtProductID);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbUnit);
            this.groupBox2.Controls.Add(this.txtWeight);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTransPrice);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbProductCategory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbIDBillImportDetail);
            this.groupBox2.Controls.Add(this.cmbIDProductDetailStore);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(502, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 428);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtTransDetailsID
            // 
            this.txtTransDetailsID.Location = new System.Drawing.Point(600, 139);
            this.txtTransDetailsID.Name = "txtTransDetailsID";
            this.txtTransDetailsID.ReadOnly = true;
            this.txtTransDetailsID.Size = new System.Drawing.Size(116, 20);
            this.txtTransDetailsID.TabIndex = 29;
            this.txtTransDetailsID.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(492, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "TransDetails ID";
            this.label16.Visible = false;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(600, 120);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(116, 20);
            this.txtProductID.TabIndex = 27;
            this.txtProductID.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(520, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Product ID";
            this.label15.Visible = false;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(135, 125);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(116, 21);
            this.cmbUnit.TabIndex = 25;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(359, 51);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(116, 20);
            this.txtWeight.TabIndex = 24;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(279, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Weight";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(359, 125);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(116, 20);
            this.txtTotal.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(279, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Total";
            // 
            // txtTransPrice
            // 
            this.txtTransPrice.Location = new System.Drawing.Point(359, 88);
            this.txtTransPrice.Name = "txtTransPrice";
            this.txtTransPrice.Size = new System.Drawing.Size(116, 20);
            this.txtTransPrice.TabIndex = 20;
            this.txtTransPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransPrice_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(279, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Unit";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(135, 84);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(116, 21);
            this.cmbProductCategory.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Product Category";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvListOfDetailProductImport);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(772, 269);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // dtgvListOfDetailProductImport
            // 
            this.dtgvListOfDetailProductImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListOfDetailProductImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductCategoryName,
            this.TransQuantity,
            this.UnitName,
            this.TransPrice,
            this.Weight,
            this.TransDetailsID});
            this.dtgvListOfDetailProductImport.Location = new System.Drawing.Point(3, 19);
            this.dtgvListOfDetailProductImport.Name = "dtgvListOfDetailProductImport";
            this.dtgvListOfDetailProductImport.ReadOnly = true;
            this.dtgvListOfDetailProductImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListOfDetailProductImport.Size = new System.Drawing.Size(758, 247);
            this.dtgvListOfDetailProductImport.TabIndex = 0;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 140;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.DataPropertyName = "ProductCategoryName";
            this.ProductCategoryName.HeaderText = "Product Category";
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.ReadOnly = true;
            this.ProductCategoryName.Width = 125;
            // 
            // TransQuantity
            // 
            this.TransQuantity.DataPropertyName = "TransQuantity";
            this.TransQuantity.HeaderText = "Quantity";
            this.TransQuantity.Name = "TransQuantity";
            this.TransQuantity.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // TransPrice
            // 
            this.TransPrice.DataPropertyName = "TransPrice";
            this.TransPrice.HeaderText = "Price";
            this.TransPrice.Name = "TransPrice";
            this.TransPrice.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // TransDetailsID
            // 
            this.TransDetailsID.DataPropertyName = "TransDetailsID";
            this.TransDetailsID.HeaderText = "TransDetails ID";
            this.TransDetailsID.Name = "TransDetailsID";
            this.TransDetailsID.ReadOnly = true;
            this.TransDetailsID.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbClear);
            this.groupBox3.Controls.Add(this.btnUpdateProductImportDetail);
            this.groupBox3.Controls.Add(this.btnAddProductImportDetail);
            this.groupBox3.Controls.Add(this.btnDeleteProductImportDetail);
            this.groupBox3.Location = new System.Drawing.Point(523, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 105);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option";
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Location = new System.Drawing.Point(6, 80);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(31, 13);
            this.lbClear.TabIndex = 17;
            this.lbClear.TabStop = true;
            this.lbClear.Text = "Clear";
            this.lbClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbClear_LinkClicked);
            // 
            // btnUpdateProductImportDetail
            // 
            this.btnUpdateProductImportDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProductImportDetail.Location = new System.Drawing.Point(86, 27);
            this.btnUpdateProductImportDetail.Name = "btnUpdateProductImportDetail";
            this.btnUpdateProductImportDetail.Size = new System.Drawing.Size(72, 42);
            this.btnUpdateProductImportDetail.TabIndex = 16;
            this.btnUpdateProductImportDetail.Text = "Update";
            this.btnUpdateProductImportDetail.UseVisualStyleBackColor = true;
            // 
            // btnAddProductImportDetail
            // 
            this.btnAddProductImportDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductImportDetail.Location = new System.Drawing.Point(6, 28);
            this.btnAddProductImportDetail.Name = "btnAddProductImportDetail";
            this.btnAddProductImportDetail.Size = new System.Drawing.Size(74, 41);
            this.btnAddProductImportDetail.TabIndex = 16;
            this.btnAddProductImportDetail.Text = "Insert";
            this.btnAddProductImportDetail.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProductImportDetail
            // 
            this.btnDeleteProductImportDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductImportDetail.Location = new System.Drawing.Point(164, 27);
            this.btnDeleteProductImportDetail.Name = "btnDeleteProductImportDetail";
            this.btnDeleteProductImportDetail.Size = new System.Drawing.Size(77, 42);
            this.btnDeleteProductImportDetail.TabIndex = 16;
            this.btnDeleteProductImportDetail.Text = "Delete";
            this.btnDeleteProductImportDetail.UseVisualStyleBackColor = true;
            // 
            // cmbIDBillImportDetail
            // 
            this.cmbIDBillImportDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbIDBillImportDetail.Enabled = false;
            this.cmbIDBillImportDetail.FormattingEnabled = true;
            this.cmbIDBillImportDetail.Location = new System.Drawing.Point(135, 12);
            this.cmbIDBillImportDetail.Name = "cmbIDBillImportDetail";
            this.cmbIDBillImportDetail.Size = new System.Drawing.Size(116, 21);
            this.cmbIDBillImportDetail.TabIndex = 12;
            // 
            // cmbIDProductDetailStore
            // 
            this.cmbIDProductDetailStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbIDProductDetailStore.FormattingEnabled = true;
            this.cmbIDProductDetailStore.Location = new System.Drawing.Point(135, 47);
            this.cmbIDProductDetailStore.Name = "cmbIDProductDetailStore";
            this.cmbIDProductDetailStore.Size = new System.Drawing.Size(116, 21);
            this.cmbIDProductDetailStore.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Product Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(359, 16);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(116, 20);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.Click += new System.EventHandler(this.txtAmountOfProductImportDetail_Click);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(279, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Transaction ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateBillImport);
            this.groupBox1.Controls.Add(this.cmbIDAgency);
            this.groupBox1.Controls.Add(this.btnDeleteBillImport);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAddImportBill);
            this.groupBox1.Controls.Add(this.dtpkDateTimeImport);
            this.groupBox1.Controls.Add(this.txtVendorId);
            this.groupBox1.Controls.Add(this.txtIDBillImport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdateBillImport
            // 
            this.btnUpdateBillImport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBillImport.Location = new System.Drawing.Point(309, 104);
            this.btnUpdateBillImport.Name = "btnUpdateBillImport";
            this.btnUpdateBillImport.Size = new System.Drawing.Size(84, 32);
            this.btnUpdateBillImport.TabIndex = 16;
            this.btnUpdateBillImport.Text = "Update";
            this.btnUpdateBillImport.UseVisualStyleBackColor = true;
            // 
            // cmbIDAgency
            // 
            this.cmbIDAgency.FormattingEnabled = true;
            this.cmbIDAgency.Location = new System.Drawing.Point(100, 68);
            this.cmbIDAgency.Name = "cmbIDAgency";
            this.cmbIDAgency.Size = new System.Drawing.Size(129, 24);
            this.cmbIDAgency.TabIndex = 12;
            this.cmbIDAgency.SelectedIndexChanged += new System.EventHandler(this.CmbIDAgency_SelectedIndexChanged);
            // 
            // btnDeleteBillImport
            // 
            this.btnDeleteBillImport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBillImport.Location = new System.Drawing.Point(208, 104);
            this.btnDeleteBillImport.Name = "btnDeleteBillImport";
            this.btnDeleteBillImport.Size = new System.Drawing.Size(81, 32);
            this.btnDeleteBillImport.TabIndex = 16;
            this.btnDeleteBillImport.Text = "Delete";
            this.btnDeleteBillImport.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(9, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 32);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Refresh";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddImportBill
            // 
            this.btnAddImportBill.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImportBill.Location = new System.Drawing.Point(107, 104);
            this.btnAddImportBill.Name = "btnAddImportBill";
            this.btnAddImportBill.Size = new System.Drawing.Size(83, 32);
            this.btnAddImportBill.TabIndex = 16;
            this.btnAddImportBill.Text = "Insert";
            this.btnAddImportBill.UseVisualStyleBackColor = true;
            // 
            // dtpkDateTimeImport
            // 
            this.dtpkDateTimeImport.CustomFormat = "dd/m/yyyy";
            this.dtpkDateTimeImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateTimeImport.Location = new System.Drawing.Point(329, 17);
            this.dtpkDateTimeImport.Name = "dtpkDateTimeImport";
            this.dtpkDateTimeImport.Size = new System.Drawing.Size(129, 23);
            this.dtpkDateTimeImport.TabIndex = 15;
            this.dtpkDateTimeImport.Value = new System.DateTime(2018, 4, 25, 20, 54, 0, 0);
            // 
            // txtVendorId
            // 
            this.txtVendorId.Enabled = false;
            this.txtVendorId.Location = new System.Drawing.Point(100, 43);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(129, 23);
            this.txtVendorId.TabIndex = 14;
            // 
            // txtIDBillImport
            // 
            this.txtIDBillImport.Enabled = false;
            this.txtIDBillImport.Location = new System.Drawing.Point(100, 17);
            this.txtIDBillImport.Name = "txtIDBillImport";
            this.txtIDBillImport.ReadOnly = true;
            this.txtIDBillImport.Size = new System.Drawing.Size(129, 23);
            this.txtIDBillImport.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendor ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vendor Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Created Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transaction ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvInfoListOfBillImport);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(27, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(469, 272);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // dtgvInfoListOfBillImport
            // 
            this.dtgvInfoListOfBillImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfoListOfBillImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransID,
            this.VendorID,
            this.VendorName,
            this.Address,
            this.PhoneNo,
            this.CreateDate,
            this.TotalPrice});
            this.dtgvInfoListOfBillImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInfoListOfBillImport.Location = new System.Drawing.Point(3, 19);
            this.dtgvInfoListOfBillImport.Name = "dtgvInfoListOfBillImport";
            this.dtgvInfoListOfBillImport.ReadOnly = true;
            this.dtgvInfoListOfBillImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInfoListOfBillImport.Size = new System.Drawing.Size(463, 250);
            this.dtgvInfoListOfBillImport.TabIndex = 0;
            // 
            // TransID
            // 
            this.TransID.DataPropertyName = "TransID";
            this.TransID.HeaderText = "Transaction ID";
            this.TransID.Name = "TransID";
            this.TransID.ReadOnly = true;
            // 
            // VendorID
            // 
            this.VendorID.DataPropertyName = "VendorID";
            this.VendorID.HeaderText = "Vendor ID";
            this.VendorID.Name = "VendorID";
            this.VendorID.ReadOnly = true;
            this.VendorID.Visible = false;
            // 
            // VendorName
            // 
            this.VendorName.DataPropertyName = "VendorName";
            this.VendorName.HeaderText = "Vendor Name";
            this.VendorName.Name = "VendorName";
            this.VendorName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PhoneNo
            // 
            this.PhoneNo.DataPropertyName = "PhoneNo";
            this.PhoneNo.HeaderText = "Phone No";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Created Date";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // uctPostInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uctPostInvoice";
            this.Size = new System.Drawing.Size(1314, 497);
            this.Load += new System.EventHandler(this.uctPostInvoice_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListOfDetailProductImport)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoListOfBillImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateProductImportDetail;
        private System.Windows.Forms.Button btnAddProductImportDetail;
        private System.Windows.Forms.Button btnDeleteProductImportDetail;
        private System.Windows.Forms.ComboBox cmbIDProductDetailStore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateBillImport;
        private System.Windows.Forms.Button btnDeleteBillImport;
        private System.Windows.Forms.Button btnAddImportBill;
        private System.Windows.Forms.DateTimePicker dtpkDateTimeImport;
        private System.Windows.Forms.TextBox txtIDBillImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvInfoListOfBillImport;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvListOfDetailProductImport;
        private System.Windows.Forms.TextBox txtVendorId;
        private System.Windows.Forms.ComboBox cmbIDBillImportDetail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel lbClear;
        private System.Windows.Forms.ComboBox cmbIDAgency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTransPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTransDetailsID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransDetailsID;
    }
}
