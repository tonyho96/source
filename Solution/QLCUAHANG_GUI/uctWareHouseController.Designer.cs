namespace QLCUAHANG_GUI
{
    partial class uctWareHouseController
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbListProductOfAgency = new System.Windows.Forms.GroupBox();
            this.dtgvProductListOfAgency = new System.Windows.Forms.DataGridView();
            this.MaSPDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbListProductOfAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ KHO THEO THÁNG";
            // 
            // grbListProductOfAgency
            // 
            this.grbListProductOfAgency.Controls.Add(this.dtgvProductListOfAgency);
            this.grbListProductOfAgency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListProductOfAgency.Location = new System.Drawing.Point(9, 28);
            this.grbListProductOfAgency.Name = "grbListProductOfAgency";
            this.grbListProductOfAgency.Size = new System.Drawing.Size(919, 417);
            this.grbListProductOfAgency.TabIndex = 9;
            this.grbListProductOfAgency.TabStop = false;
            // 
            // dtgvProductListOfAgency
            // 
            this.dtgvProductListOfAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductListOfAgency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSPDL,
            this.TenSP,
            this.MaDL,
            this.Gia,
            this.DonVi,
            this.ThongSo});
            this.dtgvProductListOfAgency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProductListOfAgency.Location = new System.Drawing.Point(3, 22);
            this.dtgvProductListOfAgency.Name = "dtgvProductListOfAgency";
            this.dtgvProductListOfAgency.ReadOnly = true;
            this.dtgvProductListOfAgency.RowHeadersVisible = false;
            this.dtgvProductListOfAgency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProductListOfAgency.Size = new System.Drawing.Size(913, 392);
            this.dtgvProductListOfAgency.TabIndex = 1;
            // 
            // MaSPDL
            // 
            this.MaSPDL.DataPropertyName = "MaSPDL";
            this.MaSPDL.HeaderText = "Mã SP";
            this.MaSPDL.Name = "MaSPDL";
            this.MaSPDL.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 170;
            // 
            // MaDL
            // 
            this.MaDL.DataPropertyName = "MaDL";
            this.MaDL.HeaderText = "Mã đại lí";
            this.MaDL.Name = "MaDL";
            this.MaDL.ReadOnly = true;
            this.MaDL.Width = 135;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 120;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // ThongSo
            // 
            this.ThongSo.DataPropertyName = "ThongSo";
            this.ThongSo.HeaderText = "Thông số/ Sản phẩm ( kg hoặc ml )";
            this.ThongSo.Name = "ThongSo";
            this.ThongSo.ReadOnly = true;
            this.ThongSo.Width = 280;
            // 
            // uctWareHouseController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbListProductOfAgency);
            this.Controls.Add(this.label1);
            this.Name = "uctWareHouseController";
            this.Size = new System.Drawing.Size(931, 483);
            this.grbListProductOfAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfAgency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbListProductOfAgency;
        private System.Windows.Forms.DataGridView dtgvProductListOfAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongSo;
    }
}
