namespace QLCUAHANG_GUI
{
    partial class uctProductCategory
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
            this.label9 = new System.Windows.Forms.Label();
            this.grbListAgency = new System.Windows.Forms.GroupBox();
            this.dtgvCategoryInfoList = new System.Windows.Forms.DataGridView();
            this.ProductCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAgency = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPercentRevenue = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblPercentRevenue = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnInsertCategory = new System.Windows.Forms.Button();
            this.grbListAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategoryInfoList)).BeginInit();
            this.grbAgency.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(789, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "CATEGORY LIST";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "PRODUCT CATEGORY INFORMATION";
            // 
            // grbListAgency
            // 
            this.grbListAgency.Controls.Add(this.dtgvCategoryInfoList);
            this.grbListAgency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListAgency.Location = new System.Drawing.Point(512, 82);
            this.grbListAgency.Name = "grbListAgency";
            this.grbListAgency.Size = new System.Drawing.Size(671, 309);
            this.grbListAgency.TabIndex = 15;
            this.grbListAgency.TabStop = false;
            // 
            // dtgvCategoryInfoList
            // 
            this.dtgvCategoryInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategoryInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCategoryID,
            this.ProductCategoryName,
            this.PercentRevenue});
            this.dtgvCategoryInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCategoryInfoList.Location = new System.Drawing.Point(3, 19);
            this.dtgvCategoryInfoList.Name = "dtgvCategoryInfoList";
            this.dtgvCategoryInfoList.ReadOnly = true;
            this.dtgvCategoryInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCategoryInfoList.Size = new System.Drawing.Size(665, 287);
            this.dtgvCategoryInfoList.TabIndex = 22;
            // 
            // ProductCategoryID
            // 
            this.ProductCategoryID.DataPropertyName = "ProductCategoryID";
            this.ProductCategoryID.HeaderText = "Category ID";
            this.ProductCategoryID.Name = "ProductCategoryID";
            this.ProductCategoryID.ReadOnly = true;
            this.ProductCategoryID.Width = 120;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.DataPropertyName = "ProductCategoryName";
            this.ProductCategoryName.HeaderText = "Category Name";
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.ReadOnly = true;
            this.ProductCategoryName.Width = 200;
            // 
            // PercentRevenue
            // 
            this.PercentRevenue.DataPropertyName = "PercentRevenue";
            this.PercentRevenue.HeaderText = "Percent Revenue";
            this.PercentRevenue.Name = "PercentRevenue";
            this.PercentRevenue.ReadOnly = true;
            this.PercentRevenue.Width = 160;
            // 
            // grbAgency
            // 
            this.grbAgency.Controls.Add(this.panel2);
            this.grbAgency.Location = new System.Drawing.Point(44, 82);
            this.grbAgency.Name = "grbAgency";
            this.grbAgency.Size = new System.Drawing.Size(442, 312);
            this.grbAgency.TabIndex = 14;
            this.grbAgency.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtPercentRevenue);
            this.panel2.Controls.Add(this.txtCategoryName);
            this.panel2.Controls.Add(this.lblPercentRevenue);
            this.panel2.Controls.Add(this.txtCategoryID);
            this.panel2.Controls.Add(this.lblCategoryName);
            this.panel2.Controls.Add(this.lblCategoryID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 293);
            this.panel2.TabIndex = 2;
            // 
            // txtPercentRevenue
            // 
            this.txtPercentRevenue.Location = new System.Drawing.Point(177, 103);
            this.txtPercentRevenue.Name = "txtPercentRevenue";
            this.txtPercentRevenue.Size = new System.Drawing.Size(145, 21);
            this.txtPercentRevenue.TabIndex = 2;
            this.txtPercentRevenue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentRevenue_KeyPress);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(177, 63);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(144, 21);
            this.txtCategoryName.TabIndex = 2;
            // 
            // lblPercentRevenue
            // 
            this.lblPercentRevenue.AutoSize = true;
            this.lblPercentRevenue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentRevenue.Location = new System.Drawing.Point(22, 108);
            this.lblPercentRevenue.Name = "lblPercentRevenue";
            this.lblPercentRevenue.Size = new System.Drawing.Size(120, 16);
            this.lblPercentRevenue.TabIndex = 2;
            this.lblPercentRevenue.Text = "Percent Revenue";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCategoryID.Location = new System.Drawing.Point(177, 26);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(144, 21);
            this.txtCategoryID.TabIndex = 2;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(22, 68);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(107, 16);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryID.Location = new System.Drawing.Point(22, 26);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(86, 16);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "Category ID";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::QLCUAHANG_GUI.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(48, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 28);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Refresh";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Image = global::QLCUAHANG_GUI.Properties.Resources.delete_3;
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(297, 399);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(74, 28);
            this.btnDeleteCategory.TabIndex = 16;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdateCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.Image = global::QLCUAHANG_GUI.Properties.Resources.update_5;
            this.btnUpdateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCategory.Location = new System.Drawing.Point(405, 399);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(81, 28);
            this.btnUpdateCategory.TabIndex = 17;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            // 
            // btnInsertCategory
            // 
            this.btnInsertCategory.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnInsertCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsertCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCategory.ForeColor = System.Drawing.Color.Black;
            this.btnInsertCategory.Image = global::QLCUAHANG_GUI.Properties.Resources.add_2;
            this.btnInsertCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCategory.Location = new System.Drawing.Point(186, 399);
            this.btnInsertCategory.Name = "btnInsertCategory";
            this.btnInsertCategory.Size = new System.Drawing.Size(74, 28);
            this.btnInsertCategory.TabIndex = 18;
            this.btnInsertCategory.Text = "Insert";
            this.btnInsertCategory.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnInsertCategory.UseVisualStyleBackColor = false;
            // 
            // uctProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnInsertCategory);
            this.Controls.Add(this.grbListAgency);
            this.Controls.Add(this.grbAgency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "uctProductCategory";
            this.Size = new System.Drawing.Size(1226, 525);
            this.Load += new System.EventHandler(this.uctProductCategory_Load);
            this.grbListAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategoryInfoList)).EndInit();
            this.grbAgency.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbListAgency;
        private System.Windows.Forms.GroupBox grbAgency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPercentRevenue;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblPercentRevenue;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnInsertCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dtgvCategoryInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentRevenue;
    }
}
