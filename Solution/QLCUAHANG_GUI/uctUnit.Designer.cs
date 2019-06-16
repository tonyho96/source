namespace QLCUAHANG_GUI
{
    partial class uctUnit
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
            this.dtgvAgencyInfoList = new System.Windows.Forms.DataGridView();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAgency = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAddressOfAgency = new System.Windows.Forms.TextBox();
            this.txtNameAgency = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDAgency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIDAgency = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteAgency = new System.Windows.Forms.Button();
            this.btnUpdateUnit = new System.Windows.Forms.Button();
            this.btnAddAgency = new System.Windows.Forms.Button();
            this.grbListAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgencyInfoList)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "UNIT LIST";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "UNIT INFORMATION";
            // 
            // grbListAgency
            // 
            this.grbListAgency.Controls.Add(this.dtgvAgencyInfoList);
            this.grbListAgency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListAgency.Location = new System.Drawing.Point(512, 82);
            this.grbListAgency.Name = "grbListAgency";
            this.grbListAgency.Size = new System.Drawing.Size(671, 309);
            this.grbListAgency.TabIndex = 15;
            this.grbListAgency.TabStop = false;
            // 
            // dtgvAgencyInfoList
            // 
            this.dtgvAgencyInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAgencyInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitID,
            this.UnitName,
            this.UnitPrice});
            this.dtgvAgencyInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAgencyInfoList.Location = new System.Drawing.Point(3, 19);
            this.dtgvAgencyInfoList.Name = "dtgvAgencyInfoList";
            this.dtgvAgencyInfoList.ReadOnly = true;
            this.dtgvAgencyInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAgencyInfoList.Size = new System.Drawing.Size(665, 287);
            this.dtgvAgencyInfoList.TabIndex = 22;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.HeaderText = "Unit ID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit Name";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 200;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 160;
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
            this.panel2.Controls.Add(this.txtAddressOfAgency);
            this.panel2.Controls.Add(this.txtNameAgency);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtIDAgency);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbIDAgency);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 293);
            this.panel2.TabIndex = 2;
            // 
            // txtAddressOfAgency
            // 
            this.txtAddressOfAgency.Location = new System.Drawing.Point(152, 105);
            this.txtAddressOfAgency.Name = "txtAddressOfAgency";
            this.txtAddressOfAgency.Size = new System.Drawing.Size(145, 21);
            this.txtAddressOfAgency.TabIndex = 2;
            this.txtAddressOfAgency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddressOfAgency_KeyPress);
            // 
            // txtNameAgency
            // 
            this.txtNameAgency.Location = new System.Drawing.Point(152, 65);
            this.txtNameAgency.Name = "txtNameAgency";
            this.txtNameAgency.Size = new System.Drawing.Size(144, 21);
            this.txtNameAgency.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Unit Price";
            // 
            // txtIDAgency
            // 
            this.txtIDAgency.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtIDAgency.Location = new System.Drawing.Point(152, 26);
            this.txtIDAgency.Name = "txtIDAgency";
            this.txtIDAgency.ReadOnly = true;
            this.txtIDAgency.Size = new System.Drawing.Size(144, 21);
            this.txtIDAgency.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit Name";
            // 
            // lbIDAgency
            // 
            this.lbIDAgency.AutoSize = true;
            this.lbIDAgency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDAgency.Location = new System.Drawing.Point(22, 26);
            this.lbIDAgency.Name = "lbIDAgency";
            this.lbIDAgency.Size = new System.Drawing.Size(51, 16);
            this.lbIDAgency.TabIndex = 0;
            this.lbIDAgency.Text = "Unit ID";
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
            // btnDeleteAgency
            // 
            this.btnDeleteAgency.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteAgency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAgency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAgency.Image = global::QLCUAHANG_GUI.Properties.Resources.delete_3;
            this.btnDeleteAgency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAgency.Location = new System.Drawing.Point(297, 399);
            this.btnDeleteAgency.Name = "btnDeleteAgency";
            this.btnDeleteAgency.Size = new System.Drawing.Size(74, 28);
            this.btnDeleteAgency.TabIndex = 16;
            this.btnDeleteAgency.Text = "Delete";
            this.btnDeleteAgency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAgency.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUnit
            // 
            this.btnUpdateUnit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdateUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUnit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUnit.Image = global::QLCUAHANG_GUI.Properties.Resources.update_5;
            this.btnUpdateUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUnit.Location = new System.Drawing.Point(405, 399);
            this.btnUpdateUnit.Name = "btnUpdateUnit";
            this.btnUpdateUnit.Size = new System.Drawing.Size(81, 28);
            this.btnUpdateUnit.TabIndex = 17;
            this.btnUpdateUnit.Text = "Update";
            this.btnUpdateUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateUnit.UseVisualStyleBackColor = false;
            // 
            // btnAddAgency
            // 
            this.btnAddAgency.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddAgency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAgency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAgency.ForeColor = System.Drawing.Color.Black;
            this.btnAddAgency.Image = global::QLCUAHANG_GUI.Properties.Resources.add_2;
            this.btnAddAgency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAgency.Location = new System.Drawing.Point(186, 399);
            this.btnAddAgency.Name = "btnAddAgency";
            this.btnAddAgency.Size = new System.Drawing.Size(74, 28);
            this.btnAddAgency.TabIndex = 18;
            this.btnAddAgency.Text = "Insert";
            this.btnAddAgency.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAddAgency.UseVisualStyleBackColor = false;
            // 
            // uctUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteAgency);
            this.Controls.Add(this.btnUpdateUnit);
            this.Controls.Add(this.btnAddAgency);
            this.Controls.Add(this.grbListAgency);
            this.Controls.Add(this.grbAgency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "uctUnit";
            this.Size = new System.Drawing.Size(1226, 525);
            this.Load += new System.EventHandler(this.uctUnit_Load);
            this.grbListAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgencyInfoList)).EndInit();
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
        private System.Windows.Forms.TextBox txtAddressOfAgency;
        private System.Windows.Forms.TextBox txtNameAgency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDAgency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIDAgency;
        private System.Windows.Forms.Button btnDeleteAgency;
        private System.Windows.Forms.Button btnUpdateUnit;
        private System.Windows.Forms.Button btnAddAgency;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dtgvAgencyInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}
