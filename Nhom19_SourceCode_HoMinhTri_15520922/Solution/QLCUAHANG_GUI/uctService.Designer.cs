namespace QLCUAHANG_GUI
{
    partial class uctService
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
            this.dtgvServiceInfoList = new System.Windows.Forms.DataGridView();
            this.grbAgency = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lbIServiceID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbListAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServiceInfoList)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "SERVICE LIST";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "SERVICE INFORMATION";
            // 
            // grbListAgency
            // 
            this.grbListAgency.Controls.Add(this.dtgvServiceInfoList);
            this.grbListAgency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListAgency.Location = new System.Drawing.Point(512, 82);
            this.grbListAgency.Name = "grbListAgency";
            this.grbListAgency.Size = new System.Drawing.Size(671, 309);
            this.grbListAgency.TabIndex = 15;
            this.grbListAgency.TabStop = false;
            // 
            // dtgvServiceInfoList
            // 
            this.dtgvServiceInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvServiceInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName,
            this.ServicePrice});
            this.dtgvServiceInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvServiceInfoList.Location = new System.Drawing.Point(3, 19);
            this.dtgvServiceInfoList.Name = "dtgvServiceInfoList";
            this.dtgvServiceInfoList.ReadOnly = true;
            this.dtgvServiceInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvServiceInfoList.Size = new System.Drawing.Size(665, 287);
            this.dtgvServiceInfoList.TabIndex = 22;
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
            this.panel2.Controls.Add(this.txtServicePrice);
            this.panel2.Controls.Add(this.txtServiceName);
            this.panel2.Controls.Add(this.lblServicePrice);
            this.panel2.Controls.Add(this.txtServiceID);
            this.panel2.Controls.Add(this.lblServiceName);
            this.panel2.Controls.Add(this.lbIServiceID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 293);
            this.panel2.TabIndex = 2;
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Location = new System.Drawing.Point(152, 105);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(145, 21);
            this.txtServicePrice.TabIndex = 2;
            this.txtServicePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServicePrice_KeyPress);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(152, 65);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(144, 21);
            this.txtServiceName.TabIndex = 2;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePrice.Location = new System.Drawing.Point(22, 108);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(92, 16);
            this.lblServicePrice.TabIndex = 2;
            this.lblServicePrice.Text = "Service Price";
            // 
            // txtServiceID
            // 
            this.txtServiceID.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtServiceID.Location = new System.Drawing.Point(152, 26);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(144, 21);
            this.txtServiceID.TabIndex = 2;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(22, 68);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(95, 16);
            this.lblServiceName.TabIndex = 1;
            this.lblServiceName.Text = "Service Name";
            // 
            // lbIServiceID
            // 
            this.lbIServiceID.AutoSize = true;
            this.lbIServiceID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIServiceID.Location = new System.Drawing.Point(22, 26);
            this.lbIServiceID.Name = "lbIServiceID";
            this.lbIServiceID.Size = new System.Drawing.Size(74, 16);
            this.lbIServiceID.TabIndex = 0;
            this.lbIServiceID.Text = "Service ID";
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
            // btnDeleteService
            // 
            this.btnDeleteService.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.Image = global::QLCUAHANG_GUI.Properties.Resources.delete_3;
            this.btnDeleteService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteService.Location = new System.Drawing.Point(297, 399);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(74, 28);
            this.btnDeleteService.TabIndex = 16;
            this.btnDeleteService.Text = "Delete";
            this.btnDeleteService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteService.UseVisualStyleBackColor = false;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdateService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateService.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.Image = global::QLCUAHANG_GUI.Properties.Resources.update_5;
            this.btnUpdateService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateService.Location = new System.Drawing.Point(405, 399);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(81, 28);
            this.btnUpdateService.TabIndex = 17;
            this.btnUpdateService.Text = "Update";
            this.btnUpdateService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateService.UseVisualStyleBackColor = false;
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.Black;
            this.btnAddService.Image = global::QLCUAHANG_GUI.Properties.Resources.add_2;
            this.btnAddService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddService.Location = new System.Drawing.Point(186, 399);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(74, 28);
            this.btnAddService.TabIndex = 18;
            this.btnAddService.Text = "Insert";
            this.btnAddService.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAddService.UseVisualStyleBackColor = false;
            // 
            // ServiceID
            // 
            this.ServiceID.DataPropertyName = "ServiceID";
            this.ServiceID.HeaderText = "Service ID";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 200;
            // 
            // ServicePrice
            // 
            this.ServicePrice.DataPropertyName = "ServicePrice";
            this.ServicePrice.HeaderText = "Service Price";
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.ReadOnly = true;
            this.ServicePrice.Width = 160;
            // 
            // uctService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.grbListAgency);
            this.Controls.Add(this.grbAgency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "uctService";
            this.Size = new System.Drawing.Size(1226, 525);
            this.Load += new System.EventHandler(this.uctService_Load);
            this.grbListAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServiceInfoList)).EndInit();
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
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lbIServiceID;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dtgvServiceInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrice;
    }
}
