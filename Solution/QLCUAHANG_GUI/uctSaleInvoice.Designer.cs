namespace QLCUAHANG_GUI
{
    partial class uctSaleInvoice
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
            this.grbInfoBill = new System.Windows.Forms.GroupBox();
            this.cmbIDCustomer = new System.Windows.Forms.ComboBox();
            this.lkbClear = new System.Windows.Forms.LinkLabel();
            this.btnUpdateBillExport = new System.Windows.Forms.Button();
            this.btnDeleteBillExport = new System.Windows.Forms.Button();
            this.btnAddBillExport = new System.Windows.Forms.Button();
            this.dtpkDateTimeExport = new System.Windows.Forms.DateTimePicker();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.txtIDBillExport = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPercent = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTransDetailsID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTransPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDetailBillSale = new System.Windows.Forms.GroupBox();
            this.dtgvDetailBillSale = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateProductExportDetail = new System.Windows.Forms.Button();
            this.btnDeleteProductExportDetail = new System.Windows.Forms.Button();
            this.btnAddProductExportDetail = new System.Windows.Forms.Button();
            this.lkbClear1 = new System.Windows.Forms.LinkLabel();
            this.cmbIDBillExportDetail = new System.Windows.Forms.ComboBox();
            this.cmbIDProductDetailStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvInfoListOfBillExport = new System.Windows.Forms.DataGridView();
            this.TransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPQuatity = new System.Windows.Forms.ComboBox();
            this.cmbImportPrice = new System.Windows.Forms.ComboBox();
            this.TransDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbInfoBill.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbDetailBillSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetailBillSale)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoListOfBillExport)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoBill
            // 
            this.grbInfoBill.Controls.Add(this.cmbIDCustomer);
            this.grbInfoBill.Controls.Add(this.lkbClear);
            this.grbInfoBill.Controls.Add(this.btnUpdateBillExport);
            this.grbInfoBill.Controls.Add(this.btnDeleteBillExport);
            this.grbInfoBill.Controls.Add(this.btnAddBillExport);
            this.grbInfoBill.Controls.Add(this.dtpkDateTimeExport);
            this.grbInfoBill.Controls.Add(this.txtIDCustomer);
            this.grbInfoBill.Controls.Add(this.txtIDBillExport);
            this.grbInfoBill.Controls.Add(this.label12);
            this.grbInfoBill.Controls.Add(this.label3);
            this.grbInfoBill.Controls.Add(this.label5);
            this.grbInfoBill.Controls.Add(this.label6);
            this.grbInfoBill.Location = new System.Drawing.Point(12, 41);
            this.grbInfoBill.Name = "grbInfoBill";
            this.grbInfoBill.Size = new System.Drawing.Size(544, 177);
            this.grbInfoBill.TabIndex = 0;
            this.grbInfoBill.TabStop = false;
            // 
            // cmbIDCustomer
            // 
            this.cmbIDCustomer.FormattingEnabled = true;
            this.cmbIDCustomer.Location = new System.Drawing.Point(138, 113);
            this.cmbIDCustomer.Name = "cmbIDCustomer";
            this.cmbIDCustomer.Size = new System.Drawing.Size(129, 21);
            this.cmbIDCustomer.TabIndex = 13;
            this.cmbIDCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbIDCustomer_SelectedIndexChanged);
            // 
            // lkbClear
            // 
            this.lkbClear.AutoSize = true;
            this.lkbClear.Location = new System.Drawing.Point(289, 75);
            this.lkbClear.Name = "lkbClear";
            this.lkbClear.Size = new System.Drawing.Size(31, 13);
            this.lkbClear.TabIndex = 18;
            this.lkbClear.TabStop = true;
            this.lkbClear.Text = "Clear";
            this.lkbClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbClear_LinkClicked);
            // 
            // btnUpdateBillExport
            // 
            this.btnUpdateBillExport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBillExport.Location = new System.Drawing.Point(402, 69);
            this.btnUpdateBillExport.Name = "btnUpdateBillExport";
            this.btnUpdateBillExport.Size = new System.Drawing.Size(61, 25);
            this.btnUpdateBillExport.TabIndex = 16;
            this.btnUpdateBillExport.Text = "Update";
            this.btnUpdateBillExport.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBillExport
            // 
            this.btnDeleteBillExport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBillExport.Location = new System.Drawing.Point(468, 69);
            this.btnDeleteBillExport.Name = "btnDeleteBillExport";
            this.btnDeleteBillExport.Size = new System.Drawing.Size(65, 25);
            this.btnDeleteBillExport.TabIndex = 16;
            this.btnDeleteBillExport.Text = "Delete";
            this.btnDeleteBillExport.UseVisualStyleBackColor = true;
            // 
            // btnAddBillExport
            // 
            this.btnAddBillExport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBillExport.Location = new System.Drawing.Point(340, 69);
            this.btnAddBillExport.Name = "btnAddBillExport";
            this.btnAddBillExport.Size = new System.Drawing.Size(55, 25);
            this.btnAddBillExport.TabIndex = 16;
            this.btnAddBillExport.Text = "Insert";
            this.btnAddBillExport.UseVisualStyleBackColor = true;
            // 
            // dtpkDateTimeExport
            // 
            this.dtpkDateTimeExport.CustomFormat = "dd/m/yyyy";
            this.dtpkDateTimeExport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateTimeExport.Location = new System.Drawing.Point(401, 27);
            this.dtpkDateTimeExport.Name = "dtpkDateTimeExport";
            this.dtpkDateTimeExport.Size = new System.Drawing.Size(129, 20);
            this.dtpkDateTimeExport.TabIndex = 15;
            this.dtpkDateTimeExport.Value = new System.DateTime(2018, 4, 25, 20, 54, 0, 0);
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Enabled = false;
            this.txtIDCustomer.Location = new System.Drawing.Point(138, 70);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.Size = new System.Drawing.Size(129, 20);
            this.txtIDCustomer.TabIndex = 14;
            // 
            // txtIDBillExport
            // 
            this.txtIDBillExport.Enabled = false;
            this.txtIDBillExport.Location = new System.Drawing.Point(138, 28);
            this.txtIDBillExport.Name = "txtIDBillExport";
            this.txtIDBillExport.ReadOnly = true;
            this.txtIDBillExport.Size = new System.Drawing.Size(129, 20);
            this.txtIDBillExport.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Created Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Invoice No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbImportPrice);
            this.groupBox2.Controls.Add(this.cmbPercent);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.txtTransDetailsID);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTransPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTransQuantity);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbUnit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbProductCategory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbProductName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.grbDetailBillSale);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lkbClear1);
            this.groupBox2.Controls.Add(this.cmbIDBillExportDetail);
            this.groupBox2.Controls.Add(this.cmbIDProductDetailStore);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(562, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 446);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cmbPercent
            // 
            this.cmbPercent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPercent.Enabled = false;
            this.cmbPercent.FormattingEnabled = true;
            this.cmbPercent.Location = new System.Drawing.Point(385, 197);
            this.cmbPercent.Name = "cmbPercent";
            this.cmbPercent.Size = new System.Drawing.Size(42, 21);
            this.cmbPercent.TabIndex = 42;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(367, 49);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 25);
            this.btnCalculate.TabIndex = 40;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTransDetailsID
            // 
            this.txtTransDetailsID.Location = new System.Drawing.Point(385, 169);
            this.txtTransDetailsID.Name = "txtTransDetailsID";
            this.txtTransDetailsID.ReadOnly = true;
            this.txtTransDetailsID.Size = new System.Drawing.Size(116, 20);
            this.txtTransDetailsID.TabIndex = 39;
            this.txtTransDetailsID.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(273, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "TransDetails ID";
            this.label16.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(367, 116);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(116, 20);
            this.txtTotal.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(287, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Total";
            // 
            // txtTransPrice
            // 
            this.txtTransPrice.Enabled = false;
            this.txtTransPrice.Location = new System.Drawing.Point(367, 83);
            this.txtTransPrice.Name = "txtTransPrice";
            this.txtTransPrice.Size = new System.Drawing.Size(116, 20);
            this.txtTransPrice.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(287, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Price";
            // 
            // txtTransQuantity
            // 
            this.txtTransQuantity.Location = new System.Drawing.Point(367, 20);
            this.txtTransQuantity.Name = "txtTransQuantity";
            this.txtTransQuantity.Size = new System.Drawing.Size(116, 20);
            this.txtTransQuantity.TabIndex = 33;
            this.txtTransQuantity.TextChanged += new System.EventHandler(this.txtTransQuantity_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(287, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Quantity";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbUnit.Enabled = false;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(142, 146);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(116, 21);
            this.cmbUnit.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Unit";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbProductCategory.Enabled = false;
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(142, 114);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(116, 21);
            this.cmbProductCategory.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Product Category";
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(142, 82);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(116, 21);
            this.cmbProductName.TabIndex = 27;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Product Name";
            // 
            // grbDetailBillSale
            // 
            this.grbDetailBillSale.Controls.Add(this.dtgvDetailBillSale);
            this.grbDetailBillSale.Location = new System.Drawing.Point(0, 242);
            this.grbDetailBillSale.Name = "grbDetailBillSale";
            this.grbDetailBillSale.Size = new System.Drawing.Size(518, 198);
            this.grbDetailBillSale.TabIndex = 14;
            this.grbDetailBillSale.TabStop = false;
            // 
            // dtgvDetailBillSale
            // 
            this.dtgvDetailBillSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetailBillSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransDetailsID,
            this.ProductID,
            this.ProductName,
            this.ProductCategoryName,
            this.TransQuantity,
            this.UnitName,
            this.TransPrice,
            this.Total});
            this.dtgvDetailBillSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDetailBillSale.Location = new System.Drawing.Point(3, 16);
            this.dtgvDetailBillSale.Name = "dtgvDetailBillSale";
            this.dtgvDetailBillSale.ReadOnly = true;
            this.dtgvDetailBillSale.RowHeadersVisible = false;
            this.dtgvDetailBillSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDetailBillSale.Size = new System.Drawing.Size(512, 179);
            this.dtgvDetailBillSale.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateProductExportDetail);
            this.groupBox3.Controls.Add(this.btnDeleteProductExportDetail);
            this.groupBox3.Controls.Add(this.btnAddProductExportDetail);
            this.groupBox3.Location = new System.Drawing.Point(17, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 50);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // btnUpdateProductExportDetail
            // 
            this.btnUpdateProductExportDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProductExportDetail.Location = new System.Drawing.Point(63, 15);
            this.btnUpdateProductExportDetail.Name = "btnUpdateProductExportDetail";
            this.btnUpdateProductExportDetail.Size = new System.Drawing.Size(68, 25);
            this.btnUpdateProductExportDetail.TabIndex = 16;
            this.btnUpdateProductExportDetail.Text = "Update";
            this.btnUpdateProductExportDetail.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProductExportDetail
            // 
            this.btnDeleteProductExportDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductExportDetail.Location = new System.Drawing.Point(137, 15);
            this.btnDeleteProductExportDetail.Name = "btnDeleteProductExportDetail";
            this.btnDeleteProductExportDetail.Size = new System.Drawing.Size(62, 25);
            this.btnDeleteProductExportDetail.TabIndex = 16;
            this.btnDeleteProductExportDetail.Text = "Delete";
            this.btnDeleteProductExportDetail.UseVisualStyleBackColor = true;
            // 
            // btnAddProductExportDetail
            // 
            this.btnAddProductExportDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductExportDetail.Location = new System.Drawing.Point(6, 15);
            this.btnAddProductExportDetail.Name = "btnAddProductExportDetail";
            this.btnAddProductExportDetail.Size = new System.Drawing.Size(51, 25);
            this.btnAddProductExportDetail.TabIndex = 16;
            this.btnAddProductExportDetail.Text = "Insert";
            this.btnAddProductExportDetail.UseVisualStyleBackColor = true;
            // 
            // lkbClear1
            // 
            this.lkbClear1.AutoSize = true;
            this.lkbClear1.Location = new System.Drawing.Point(228, 201);
            this.lkbClear1.Name = "lkbClear1";
            this.lkbClear1.Size = new System.Drawing.Size(31, 13);
            this.lkbClear1.TabIndex = 18;
            this.lkbClear1.TabStop = true;
            this.lkbClear1.Text = "Clear";
            this.lkbClear1.Click += new System.EventHandler(this.lkbClear1_Click);
            // 
            // cmbIDBillExportDetail
            // 
            this.cmbIDBillExportDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbIDBillExportDetail.Enabled = false;
            this.cmbIDBillExportDetail.FormattingEnabled = true;
            this.cmbIDBillExportDetail.Location = new System.Drawing.Point(142, 19);
            this.cmbIDBillExportDetail.Name = "cmbIDBillExportDetail";
            this.cmbIDBillExportDetail.Size = new System.Drawing.Size(116, 21);
            this.cmbIDBillExportDetail.TabIndex = 12;
            // 
            // cmbIDProductDetailStore
            // 
            this.cmbIDProductDetailStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbIDProductDetailStore.Enabled = false;
            this.cmbIDProductDetailStore.FormattingEnabled = true;
            this.cmbIDProductDetailStore.Location = new System.Drawing.Point(142, 49);
            this.cmbIDProductDetailStore.Name = "cmbIDProductDetailStore";
            this.cmbIDProductDetailStore.Size = new System.Drawing.Size(116, 21);
            this.cmbIDProductDetailStore.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Product ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Invoice No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALE INVOICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALE INVOICE DETAILS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvInfoListOfBillExport);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 272);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // dtgvInfoListOfBillExport
            // 
            this.dtgvInfoListOfBillExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfoListOfBillExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransID,
            this.CustomerID,
            this.CustomerName,
            this.CreateDate,
            this.TotalPrice});
            this.dtgvInfoListOfBillExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInfoListOfBillExport.Location = new System.Drawing.Point(3, 21);
            this.dtgvInfoListOfBillExport.Name = "dtgvInfoListOfBillExport";
            this.dtgvInfoListOfBillExport.ReadOnly = true;
            this.dtgvInfoListOfBillExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInfoListOfBillExport.Size = new System.Drawing.Size(538, 248);
            this.dtgvInfoListOfBillExport.TabIndex = 1;
            // 
            // TransID
            // 
            this.TransID.DataPropertyName = "TransID";
            this.TransID.HeaderText = "Invoice No";
            this.TransID.Name = "TransID";
            this.TransID.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 170;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Created Date";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 110;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 140;
            // 
            // cmbPQuatity
            // 
            this.cmbPQuatity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPQuatity.Enabled = false;
            this.cmbPQuatity.FormattingEnabled = true;
            this.cmbPQuatity.Location = new System.Drawing.Point(1051, 61);
            this.cmbPQuatity.Name = "cmbPQuatity";
            this.cmbPQuatity.Size = new System.Drawing.Size(42, 21);
            this.cmbPQuatity.TabIndex = 41;
            // 
            // cmbImportPrice
            // 
            this.cmbImportPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbImportPrice.Enabled = false;
            this.cmbImportPrice.FormattingEnabled = true;
            this.cmbImportPrice.Location = new System.Drawing.Point(433, 198);
            this.cmbImportPrice.Name = "cmbImportPrice";
            this.cmbImportPrice.Size = new System.Drawing.Size(68, 21);
            this.cmbImportPrice.TabIndex = 43;
            // 
            // TransDetailsID
            // 
            this.TransDetailsID.DataPropertyName = "TransDetailsID";
            this.TransDetailsID.HeaderText = "TransDetailsID";
            this.TransDetailsID.Name = "TransDetailsID";
            this.TransDetailsID.ReadOnly = true;
            this.TransDetailsID.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 75;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.DataPropertyName = "ProductCategoryName";
            this.ProductCategoryName.HeaderText = "Category Name";
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.ReadOnly = true;
            this.ProductCategoryName.Width = 80;
            // 
            // TransQuantity
            // 
            this.TransQuantity.DataPropertyName = "TransQuantity";
            this.TransQuantity.HeaderText = "Quantity";
            this.TransQuantity.Name = "TransQuantity";
            this.TransQuantity.ReadOnly = true;
            this.TransQuantity.Width = 75;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit Name";
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
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // uctSaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.cmbPQuatity);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbInfoBill);
            this.Name = "uctSaleInvoice";
            this.Size = new System.Drawing.Size(1158, 490);
            this.Load += new System.EventHandler(this.uctSaleInvoice_Load);
            this.grbInfoBill.ResumeLayout(false);
            this.grbInfoBill.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbDetailBillSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetailBillSale)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoListOfBillExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoBill;
        private System.Windows.Forms.DateTimePicker dtpkDateTimeExport;
        private System.Windows.Forms.TextBox txtIDBillExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.Button btnUpdateBillExport;
        private System.Windows.Forms.Button btnDeleteBillExport;
        private System.Windows.Forms.Button btnAddBillExport;
        private System.Windows.Forms.ComboBox cmbIDProductDetailStore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateProductExportDetail;
        private System.Windows.Forms.Button btnAddProductExportDetail;
        private System.Windows.Forms.Button btnDeleteProductExportDetail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvInfoListOfBillExport;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel lkbClear;
        private System.Windows.Forms.GroupBox grbDetailBillSale;
        private System.Windows.Forms.DataGridView dtgvDetailBillSale;
        private System.Windows.Forms.ComboBox cmbIDBillExportDetail;
        private System.Windows.Forms.LinkLabel lkbClear1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.ComboBox cmbIDCustomer;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTransPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTransQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTransDetailsID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cmbPQuatity;
        private System.Windows.Forms.ComboBox cmbPercent;
        private System.Windows.Forms.ComboBox cmbImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
