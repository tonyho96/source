namespace QLCUAHANG_GUI
{
    partial class uctCustomer
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
            this.grbInfoCustomer = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbClear = new System.Windows.Forms.LinkLabel();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbIDCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grbListInfoOfCustomer = new System.Windows.Forms.GroupBox();
            this.dtgvCustomersListOfStore = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbInfoCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbListInfoOfCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomersListOfStore)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoCustomer
            // 
            this.grbInfoCustomer.Controls.Add(this.panel1);
            this.grbInfoCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoCustomer.Location = new System.Drawing.Point(20, 44);
            this.grbInfoCustomer.Name = "grbInfoCustomer";
            this.grbInfoCustomer.Size = new System.Drawing.Size(541, 168);
            this.grbInfoCustomer.TabIndex = 9;
            this.grbInfoCustomer.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbClear);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.txtNameCustomer);
            this.panel1.Controls.Add(this.btnUpdateCustomer);
            this.panel1.Controls.Add(this.txtNumberPhone);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Controls.Add(this.txtAddressCustomer);
            this.panel1.Controls.Add(this.txtIDCustomer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbIDCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 148);
            this.panel1.TabIndex = 5;
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Location = new System.Drawing.Point(30, 123);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(36, 13);
            this.lbClear.TabIndex = 4;
            this.lbClear.TabStop = true;
            this.lbClear.Text = "Clear";
            this.lbClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbClear_LinkClicked);
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(392, 34);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(129, 21);
            this.txtNameCustomer.TabIndex = 3;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(392, 73);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(131, 21);
            this.txtNumberPhone.TabIndex = 3;
            this.txtNumberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberPhone_KeyPress);
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Location = new System.Drawing.Point(147, 73);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(122, 21);
            this.txtAddressCustomer.TabIndex = 3;
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Enabled = false;
            this.txtIDCustomer.Location = new System.Drawing.Point(145, 34);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.ReadOnly = true;
            this.txtIDCustomer.Size = new System.Drawing.Size(124, 21);
            this.txtIDCustomer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer Name";
            // 
            // lbIDCustomer
            // 
            this.lbIDCustomer.AutoSize = true;
            this.lbIDCustomer.Location = new System.Drawing.Point(30, 37);
            this.lbIDCustomer.Name = "lbIDCustomer";
            this.lbIDCustomer.Size = new System.Drawing.Size(78, 13);
            this.lbIDCustomer.TabIndex = 1;
            this.lbIDCustomer.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "CUSTOMER INFORMATION";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(341, 118);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 13;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(217, 118);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 14;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(96, 118);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 15;
            this.btnAddCustomer.Text = "Insert";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // grbListInfoOfCustomer
            // 
            this.grbListInfoOfCustomer.Controls.Add(this.dtgvCustomersListOfStore);
            this.grbListInfoOfCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListInfoOfCustomer.Location = new System.Drawing.Point(20, 228);
            this.grbListInfoOfCustomer.Name = "grbListInfoOfCustomer";
            this.grbListInfoOfCustomer.Size = new System.Drawing.Size(541, 165);
            this.grbListInfoOfCustomer.TabIndex = 18;
            this.grbListInfoOfCustomer.TabStop = false;
            // 
            // dtgvCustomersListOfStore
            // 
            this.dtgvCustomersListOfStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomersListOfStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.CustomerAddress,
            this.CustomerPhone});
            this.dtgvCustomersListOfStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCustomersListOfStore.Location = new System.Drawing.Point(3, 18);
            this.dtgvCustomersListOfStore.Name = "dtgvCustomersListOfStore";
            this.dtgvCustomersListOfStore.ReadOnly = true;
            this.dtgvCustomersListOfStore.RowHeadersVisible = false;
            this.dtgvCustomersListOfStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCustomersListOfStore.Size = new System.Drawing.Size(535, 144);
            this.dtgvCustomersListOfStore.TabIndex = 23;
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
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 140;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "CustomerAddress";
            this.CustomerAddress.HeaderText = "Customer Address";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            this.CustomerAddress.Width = 150;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.DataPropertyName = "CustomerPhone";
            this.CustomerPhone.HeaderText = "Customer Phone";
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.ReadOnly = true;
            this.CustomerPhone.Width = 120;
            // 
            // uctCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.grbListInfoOfCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbInfoCustomer);
            this.Name = "uctCustomer";
            this.Size = new System.Drawing.Size(587, 424);
            this.Load += new System.EventHandler(this.uctCustomer_Load);
            this.grbInfoCustomer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbListInfoOfCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomersListOfStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInfoCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbIDCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox grbListInfoOfCustomer;
        private System.Windows.Forms.DataGridView dtgvCustomersListOfStore;
        private System.Windows.Forms.LinkLabel lbClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
    }
}
