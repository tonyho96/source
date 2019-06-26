using DevExpress.XtraEditors;
using QLCUAHANG_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_GUI
{
    public partial class frmInventoryReport : Form
    {
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DataProvider.OpenConnection();
                string query = string.Format("SELECT DISTINCT [Month] FROM [JEWELRYSTOREMGMT].[dbo].[Date]");
                DataTable dt = DataProvider.GetDataTable(query, con);
                if (dt.Rows.Count == 0)
                {
                    return;
                }

                cmbMonth.DataSource = dt;
                cmbMonth.ValueMember = "Month";
                cmbMonth.DisplayMember = "Month";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection con = DataProvider.OpenConnection();
                string query = string.Format("SELECT DISTINCT [Year] FROM [JEWELRYSTOREMGMT].[dbo].[Date]");
                DataTable dt = DataProvider.GetDataTable(query, con);
                if (dt.Rows.Count == 0)
                {
                    return;
                }

                cmbYear.DataSource = dt;
                cmbYear.ValueMember = "Year";
                cmbYear.DisplayMember = "Year";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: This line of code loads data into the 'JEWELRYSTOREMGMT.usp_InventoryReport' table. You can move, or remove it, as needed.
            this.usp_InventoryReportTableAdapter.Fill(this.JEWELRYSTOREMGMT.usp_InventoryReport, Convert.ToInt32(cmbMonth.Text), Convert.ToInt32(cmbYear.Text));
            //this.usp_InventoryReportTableAdapter.Fill(this.JEWELRYSTOREMGMT.usp_InventoryReport, 6, 2019);
            // TODO: This line of code loads data into the 'JEWELRYSTOREMGMT.Date' table. You can move, or remove it, as needed.
            this.DateTableAdapter.Fill(this.JEWELRYSTOREMGMT.Date);

            this.reportViewer1.RefreshReport();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(cmbMonth.SelectedValue.ToString());
            int year = Convert.ToInt32(cmbYear.SelectedValue.ToString());

            // TODO: This line of code loads data into the 'JEWELRYSTOREMGMT.usp_InventoryReport' table. You can move, or remove it, as needed.
            this.usp_InventoryReportTableAdapter.Fill(this.JEWELRYSTOREMGMT.usp_InventoryReport, month, year);
            //this.usp_InventoryReportTableAdapter.Fill(this.JEWELRYSTOREMGMT.usp_InventoryReport, 6, 2019);
            // TODO: This line of code loads data into the 'JEWELRYSTOREMGMT.Date' table. You can move, or remove it, as needed.
            this.DateTableAdapter.Fill(this.JEWELRYSTOREMGMT.Date);

            this.reportViewer1.RefreshReport();
        }
    }
}
