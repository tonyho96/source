﻿namespace QLCUAHANG_GUI
{
    partial class uctPhieuHoaDonNhap
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvListOfDetailProductImport = new System.Windows.Forms.DataGridView();
            this.MaHDN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSPDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbClear = new System.Windows.Forms.LinkLabel();
            this.btnUpdateProductImportDetail = new System.Windows.Forms.Button();
            this.btnAddProductImportDetail = new System.Windows.Forms.Button();
            this.btnDeleteProductImportDetail = new System.Windows.Forms.Button();
            this.cmbIDBillImportDetail = new System.Windows.Forms.ComboBox();
            this.cmbIDProductDetailStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmountOfProductImportDetail = new System.Windows.Forms.TextBox();
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
            this.label2.Size = new System.Drawing.Size(196, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN NHẬP HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbIDBillImportDetail);
            this.groupBox2.Controls.Add(this.cmbIDProductDetailStore);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAmountOfProductImportDetail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(502, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 428);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvListOfDetailProductImport);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(519, 269);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // dtgvListOfDetailProductImport
            // 
            this.dtgvListOfDetailProductImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListOfDetailProductImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDN1,
            this.MaSPDL,
            this.SoLuong});
            this.dtgvListOfDetailProductImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListOfDetailProductImport.Location = new System.Drawing.Point(3, 19);
            this.dtgvListOfDetailProductImport.Name = "dtgvListOfDetailProductImport";
            this.dtgvListOfDetailProductImport.ReadOnly = true;
            this.dtgvListOfDetailProductImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListOfDetailProductImport.Size = new System.Drawing.Size(513, 247);
            this.dtgvListOfDetailProductImport.TabIndex = 0;
            // 
            // MaHDN1
            // 
            this.MaHDN1.DataPropertyName = "MaHDN";
            this.MaHDN1.HeaderText = "Mã HD nhập";
            this.MaHDN1.Name = "MaHDN1";
            this.MaHDN1.ReadOnly = true;
            this.MaHDN1.Width = 140;
            // 
            // MaSPDL
            // 
            this.MaSPDL.DataPropertyName = "MaSPDL";
            this.MaSPDL.HeaderText = "Mã SP Đại lí";
            this.MaSPDL.Name = "MaSPDL";
            this.MaSPDL.ReadOnly = true;
            this.MaSPDL.Width = 140;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbClear);
            this.groupBox3.Controls.Add(this.btnUpdateProductImportDetail);
            this.groupBox3.Controls.Add(this.btnAddProductImportDetail);
            this.groupBox3.Controls.Add(this.btnDeleteProductImportDetail);
            this.groupBox3.Location = new System.Drawing.Point(272, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 92);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Location = new System.Drawing.Point(6, 72);
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
            this.btnUpdateProductImportDetail.Location = new System.Drawing.Point(120, 36);
            this.btnUpdateProductImportDetail.Name = "btnUpdateProductImportDetail";
            this.btnUpdateProductImportDetail.Size = new System.Drawing.Size(51, 20);
            this.btnUpdateProductImportDetail.TabIndex = 16;
            this.btnUpdateProductImportDetail.Text = "Sửa";
            this.btnUpdateProductImportDetail.UseVisualStyleBackColor = true;
            // 
            // btnAddProductImportDetail
            // 
            this.btnAddProductImportDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductImportDetail.Location = new System.Drawing.Point(6, 36);
            this.btnAddProductImportDetail.Name = "btnAddProductImportDetail";
            this.btnAddProductImportDetail.Size = new System.Drawing.Size(51, 20);
            this.btnAddProductImportDetail.TabIndex = 16;
            this.btnAddProductImportDetail.Text = "Thêm";
            this.btnAddProductImportDetail.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProductImportDetail
            // 
            this.btnDeleteProductImportDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductImportDetail.Location = new System.Drawing.Point(63, 36);
            this.btnDeleteProductImportDetail.Name = "btnDeleteProductImportDetail";
            this.btnDeleteProductImportDetail.Size = new System.Drawing.Size(51, 20);
            this.btnDeleteProductImportDetail.TabIndex = 16;
            this.btnDeleteProductImportDetail.Text = "Xóa";
            this.btnDeleteProductImportDetail.UseVisualStyleBackColor = true;
            // 
            // cmbIDBillImportDetail
            // 
            this.cmbIDBillImportDetail.FormattingEnabled = true;
            this.cmbIDBillImportDetail.Location = new System.Drawing.Point(121, 12);
            this.cmbIDBillImportDetail.Name = "cmbIDBillImportDetail";
            this.cmbIDBillImportDetail.Size = new System.Drawing.Size(116, 21);
            this.cmbIDBillImportDetail.TabIndex = 12;
            // 
            // cmbIDProductDetailStore
            // 
            this.cmbIDProductDetailStore.FormattingEnabled = true;
            this.cmbIDProductDetailStore.Location = new System.Drawing.Point(121, 47);
            this.cmbIDProductDetailStore.Name = "cmbIDProductDetailStore";
            this.cmbIDProductDetailStore.Size = new System.Drawing.Size(116, 21);
            this.cmbIDProductDetailStore.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mã sản phẩm";
            // 
            // txtAmountOfProductImportDetail
            // 
            this.txtAmountOfProductImportDetail.Location = new System.Drawing.Point(121, 80);
            this.txtAmountOfProductImportDetail.Name = "txtAmountOfProductImportDetail";
            this.txtAmountOfProductImportDetail.Size = new System.Drawing.Size(116, 20);
            this.txtAmountOfProductImportDetail.TabIndex = 9;
            this.txtAmountOfProductImportDetail.Click += new System.EventHandler(this.txtAmountOfProductImportDetail_Click);
            this.txtAmountOfProductImportDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfProductImportDetail_KeyPress_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Mã hóa đơn";
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
            this.btnUpdateBillImport.Text = "Sửa";
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
            this.cmbIDAgency.TextChanged += new System.EventHandler(this.cmbIDAgency_TextChanged);
            // 
            // btnDeleteBillImport
            // 
            this.btnDeleteBillImport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBillImport.Location = new System.Drawing.Point(208, 104);
            this.btnDeleteBillImport.Name = "btnDeleteBillImport";
            this.btnDeleteBillImport.Size = new System.Drawing.Size(81, 32);
            this.btnDeleteBillImport.TabIndex = 16;
            this.btnDeleteBillImport.Text = "Xóa";
            this.btnDeleteBillImport.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(9, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 32);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Làm mới";
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
            this.btnAddImportBill.Text = "Thêm";
            this.btnAddImportBill.UseVisualStyleBackColor = true;
            // 
            // dtpkDateTimeImport
            // 
            this.dtpkDateTimeImport.CustomFormat = "dd/m/yyyy";
            this.dtpkDateTimeImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateTimeImport.Location = new System.Drawing.Point(309, 17);
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendor ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vendor Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
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
            this.dtgvInfoListOfBillImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInfoListOfBillImport.Location = new System.Drawing.Point(3, 19);
            this.dtgvInfoListOfBillImport.Name = "dtgvInfoListOfBillImport";
            this.dtgvInfoListOfBillImport.ReadOnly = true;
            this.dtgvInfoListOfBillImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInfoListOfBillImport.Size = new System.Drawing.Size(463, 250);
            this.dtgvInfoListOfBillImport.TabIndex = 0;
            // 
            // uctPhieuHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uctPhieuHoaDonNhap";
            this.Size = new System.Drawing.Size(1137, 497);
            this.Load += new System.EventHandler(this.uctPhieuHoaDonNhap_Load);
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
        private System.Windows.Forms.TextBox txtAmountOfProductImportDetail;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel lbClear;
        private System.Windows.Forms.ComboBox cmbIDAgency;
        private System.Windows.Forms.Label label4;
    }
}