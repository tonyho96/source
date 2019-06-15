using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCUAHANG_DTO;
using QLCUAHANG_BUS;
using QLCUAHANG_DAL;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctVendor : UserControl
    {
        public uctVendor()
        {
            InitializeComponent();
        }
        public static uctVendor uctVendorInfo = new uctVendor();
        

        private void uctVendor_Load(object sender, EventArgs e)
        {
            VendorData();
        }

        #region Vendor
        private void VendorData()
        {
            LoadVendorList();
            dtgvAgencyInfoList.CellClick += new DataGridViewCellEventHandler(dtgvAgencyInfoList_CellClick);
            //dtgvAgencyInfoList.Click += new EventHandler(dtgvAgencyInfoList_Click);
            btnAddAgency.Click += new EventHandler(btnAddAgency_Click);
            btnUpdateAgency.Click += new EventHandler(btnUpdateAgency_Click);
            btnDeleteAgency.Click += new EventHandler(btnDeleteAgency_Click);
            txtIDAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaDL=dbo.fcGetMaDL()"));
        }

        private void dtgvAgencyInfoList_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvAgencyInfoList.SelectedRows[0];
            txtIDAgency.Text = Convert.ToString(dr.Cells["VendorID"].Value);
            txtNameAgency.Text = Convert.ToString(dr.Cells["VendorName"].Value);
            txtAddressOfAgency.Text = Convert.ToString(dr.Cells["VendorAddress"].Value);
            txtNumberPhone.Text = Convert.ToString(dr.Cells["VendorPhone"].Value);
        }

        private void dtgvAgencyInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtIDAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["VendorID"].Value);
                txtNameAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["VendorName"].Value);
                txtAddressOfAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["VendorAddress"].Value);
                txtNumberPhone.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["VendorPhone"].Value);
            }
        }

        public void LoadVendorList()
        {
            List<Vendor_DTO> vendor = Vendor_BUS.LoadVendor();
            dtgvAgencyInfoList.DataSource = vendor;
        }

        private void btnAddAgency_Click(object sender, EventArgs e)
        {
            try
            {
                Vendor_DTO vendor = new Vendor_DTO();
                vendor.VendorID = txtIDAgency.Text;
                vendor.VendorName = txtNameAgency.Text;
                vendor.VendorAddress = txtAddressOfAgency.Text;
                vendor.VendorPhone = txtNumberPhone.Text;

                if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "" || txtNumberPhone.Text == "")
                {
                    XtraMessageBox.Show("You have to fullfill vendor information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Vendor_BUS.InsertVendor(vendor))
                {
                    XtraMessageBox.Show("Vendor Info has been inserted sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVendorList();
                    ClearDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Insert Info Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateAgency_Click(object sender, EventArgs e)
        {
            try
            {

                Vendor_DTO vendor = new Vendor_DTO();
                vendor.VendorID = dtgvAgencyInfoList.CurrentRow.Cells["VendorID"].Value.ToString();
                vendor.VendorName = txtNameAgency.Text;
                vendor.VendorAddress = txtAddressOfAgency.Text;
                vendor.VendorPhone = txtNumberPhone.Text;

                if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "" || txtNumberPhone.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one vendor to update!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Vendor_BUS.UpdateVendor(vendor))
                {
                    XtraMessageBox.Show("Vendor Info has been updated sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVendorList();
                    ClearDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Update Info Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void btnDeleteAgency_Click(object sender, EventArgs e)
        {
            try
            {
                Vendor_DTO vendor = new Vendor_DTO();
                vendor.VendorID = dtgvAgencyInfoList.CurrentRow.Cells["VendorID"].Value.ToString();
                vendor.VendorName = txtNameAgency.Text;

                if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "" || txtNumberPhone.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one vendor to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Vendor_BUS.DeleteVendor(vendor))
                {
                    LoadVendorList();
                    XtraMessageBox.Show("Vendor Info has been deleted sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Delete Info Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearDisplay()
        {
            txtIDAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaDL=dbo.fcGetMaDL()"));
            txtNameAgency.Text = "";
            txtAddressOfAgency.Text = "";
            txtNumberPhone.Text = "";
           
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotalDebtOfAgency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}