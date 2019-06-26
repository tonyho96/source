namespace QLCUAHANG_GUI
{
    partial class frmInventoryReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usp_InventoryReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JEWELRYSTOREMGMT = new QLCUAHANG_GUI.JEWELRYSTOREMGMT();
            this.DateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_InventoryReportTableAdapter = new QLCUAHANG_GUI.JEWELRYSTOREMGMTTableAdapters.usp_InventoryReportTableAdapter();
            this.DateTableAdapter = new QLCUAHANG_GUI.JEWELRYSTOREMGMTTableAdapters.DateTableAdapter();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usp_InventoryReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JEWELRYSTOREMGMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usp_InventoryReportBindingSource
            // 
            this.usp_InventoryReportBindingSource.DataMember = "usp_InventoryReport";
            this.usp_InventoryReportBindingSource.DataSource = this.JEWELRYSTOREMGMT;
            // 
            // JEWELRYSTOREMGMT
            // 
            this.JEWELRYSTOREMGMT.DataSetName = "JEWELRYSTOREMGMT";
            this.JEWELRYSTOREMGMT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateBindingSource
            // 
            this.DateBindingSource.DataMember = "Date";
            this.DateBindingSource.DataSource = this.JEWELRYSTOREMGMT;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Inventory";
            reportDataSource1.Value = this.usp_InventoryReportBindingSource;
            reportDataSource2.Name = "Date";
            reportDataSource2.Value = this.DateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCUAHANG_GUI.rptInventoryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(929, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_InventoryReportTableAdapter
            // 
            this.usp_InventoryReportTableAdapter.ClearBeforeFill = true;
            // 
            // DateTableAdapter
            // 
            this.DateTableAdapter.ClearBeforeFill = true;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(107, 11);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 1;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(336, 11);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(502, 8);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(102, 23);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 498);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInventoryReport";
            this.Text = "INVENTORY REPORT";
            this.Load += new System.EventHandler(this.frmInventoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_InventoryReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JEWELRYSTOREMGMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_InventoryReportBindingSource;
        private JEWELRYSTOREMGMT JEWELRYSTOREMGMT;
        private System.Windows.Forms.BindingSource DateBindingSource;
        private JEWELRYSTOREMGMTTableAdapters.usp_InventoryReportTableAdapter usp_InventoryReportTableAdapter;
        private JEWELRYSTOREMGMTTableAdapters.DateTableAdapter DateTableAdapter;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
    }
}