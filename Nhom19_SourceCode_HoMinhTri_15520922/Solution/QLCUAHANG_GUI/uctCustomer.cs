using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCUAHANG_BUS;
using QLCUAHANG_DTO;
using QLCUAHANG_DAL;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctCustomer : UserControl
    {
        public uctCustomer()
        {
            InitializeComponent();
        }

        public static uctCustomer uctCustomerInfo = new uctCustomer();

        public void LoadCustomer()
        {
            List<Customer_DTO> customerList = Customer_BUS.LoadCustomerList();
            dtgvCustomersListOfStore.DataSource = customerList;
        }

        private void uctCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            dtgvCustomersListOfStore.CellClick += new DataGridViewCellEventHandler(dtgvCustomersListOfStore_CellClick);

            btnAddCustomer.Click += new EventHandler(btnAddCustomer_Click);
            btnDeleteCustomer.Click += new EventHandler(btnDeleteCustomer_Click);
            btnUpdateCustomer.Click += new EventHandler(btnUpdateCustomer_Click);
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([CustomerID]), 0) + 1 FROM[JEWELRYSTOREMGMT].[dbo].[Customer]"));
        }

        private void dtgvCustomersListOfStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtIDCustomer.Text = Convert.ToString(dtgvCustomersListOfStore.CurrentRow.Cells["CustomerID"].Value);
                txtNameCustomer.Text = Convert.ToString(dtgvCustomersListOfStore.CurrentRow.Cells["CustomerName"].Value);
                txtAddressCustomer.Text = Convert.ToString(dtgvCustomersListOfStore.CurrentRow.Cells["CustomerAddress"].Value);
                txtNumberPhone.Text = Convert.ToString(dtgvCustomersListOfStore.CurrentRow.Cells["CustomerPhone"].Value);
            }
        }

        private void ClearDisplay()
        {
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([CustomerID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Customer]"));
            txtNameCustomer.Text = "";
            txtAddressCustomer.Text = "";
            txtNumberPhone.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "" || txtNumberPhone.Text == "" || txtAddressCustomer.Text == "")
            {
                XtraMessageBox.Show("You have to fullfill the customer information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }

            Customer_DTO customer = new Customer_DTO();
            customer.CustomerID = txtIDCustomer.Text;
            customer.CustomerName = txtNameCustomer.Text;
            customer.CustomerAddress = txtAddressCustomer.Text;
            customer.CustomerPhone = txtNumberPhone.Text;

            if (Customer_BUS.InsertCustomer(customer))
            {
                XtraMessageBox.Show("Insert Customer Sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomer();
                ClearDisplay();
                return;
            }

            XtraMessageBox.Show("Insert Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtIDCustomer.Text == "" || txtNameCustomer.Text == "")
            {
                XtraMessageBox.Show("You have to choose at least 1 customer info to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }

            Customer_DTO customer = new Customer_DTO();
            customer.CustomerID = (string)dtgvCustomersListOfStore.CurrentRow.Cells["MaKH"].Value;
            customer.CustomerName = txtNameCustomer.Text;
            customer.CustomerAddress = txtAddressCustomer.Text;
            customer.CustomerPhone = txtNumberPhone.Text;

            if (Customer_BUS.UpdateCustomer(customer))
            {
                LoadCustomer();
                ClearDisplay();
                XtraMessageBox.Show("Update Customer Sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            XtraMessageBox.Show("Update Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtIDCustomer.Text == "" || txtNameCustomer.Text == "")
            {
                XtraMessageBox.Show("You have to choose at least 1 customer info to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }

            Customer_DTO customer = new Customer_DTO();
            customer.CustomerID = (string)dtgvCustomersListOfStore.CurrentRow.Cells["CustomerID"].Value;

            if (Customer_BUS.DeleteCustomer(customer))
            {
                LoadCustomer();
                XtraMessageBox.Show("Delete Customer Sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
            XtraMessageBox.Show("Delete Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void lbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay();
        }
    }
}
