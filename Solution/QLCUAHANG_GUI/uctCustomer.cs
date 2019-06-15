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

        private void ClearDisplay()
        {
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
            txtNameCustomer.Text = "";
            txtAddressCustomer.Text = "";
            txtNumberPhone.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtIDCustomer.Text == "" || txtNameCustomer.Text == "" || txtNumberPhone.Text == "" || txtAddressCustomer.Text == "")
            {
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                XtraMessageBox.Show("Thêm thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomer();
                ClearDisplay();
                return;
            }

            XtraMessageBox.Show("Thêm thông tin khách hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtIDCustomer.Text == "" || txtNameCustomer.Text == "")
            {
                XtraMessageBox.Show("Bạn phải lựa chọn khách hàng cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }

            Customer_DTO customer = new Customer_DTO();
            customer.CustomerID = (string)dtgvCustomersListOfStore.CurrentRow.Cells["CustomerID"].Value;

            if (Customer_BUS.DeleteCustomer(customer))
            {
                LoadCustomer();
                XtraMessageBox.Show("Xóa thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
            XtraMessageBox.Show("Xóa thông tin khách hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtIDCustomer.Text == ""||txtNameCustomer.Text=="")
            {
                XtraMessageBox.Show("Bạn phải lựa chọn khách hàng cần sửa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                XtraMessageBox.Show("Sửa thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            XtraMessageBox.Show("Sửa thông tin khách hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
 
        private void uctKhachHang_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            btnAddCustomer.Click += new EventHandler(btnAddCustomer_Click);
            dtgvCustomersListOfStore.CellClick += new DataGridViewCellEventHandler(dtgvCustomersListOfStore_CellClick);

            btnDeleteCustomer.Click += new EventHandler(btnDeleteCustomer_Click);
            btnUpdateCustomer.Click += new EventHandler(btnUpdateCustomer_Click);
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctSearchKhachHang uctKH = new uctSearchKhachHang();
            nhung(uctKH);

        }

        private void nhung(Control ctr)
        {
            pnlListCustomer.Controls.Clear();
            pnlListCustomer.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlListCustomer.Controls.Add(ctr);
            pnlListCustomer.Show();
        }

        private void btnHideList_Click(object sender, EventArgs e)
        {
            pnlListCustomer.Controls.Clear();
            pnlListCustomer.BorderStyle = BorderStyle.None;
        }

        private void lbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay();
        }

        private void dtgvCustomersListOfStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
