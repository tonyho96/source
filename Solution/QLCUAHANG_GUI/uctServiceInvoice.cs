using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCUAHANG_DAL;
using QLCUAHANG_BUS;
using QLCUAHANG_DTO;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctServiceInvoice : UserControl
    {
        public uctServiceInvoice()
        {
            InitializeComponent();
        }
        public static uctServiceInvoice uctServiceInfo = new uctServiceInvoice();

        private void uctServiceInvoice_Load(object sender, EventArgs e)
        {
            LoadServiceData();
        }

        private void LoadServiceData()
        {
            btnInsertService.Click += new EventHandler(btnInsertService_Click);
            btnUpdateService.Click += new EventHandler(btnUpdateService_Click);
            btnDeleteService.Click += new EventHandler(btnDeleteService_Click);

            dtgvServiceInfoList.CellClick += new DataGridViewCellEventHandler(dtgvServiceInfoList_CellClick);
            dtgvServiceDetailsInfoList.CellClick += new DataGridViewCellEventHandler(dtgvServiceDetailsInfoList_CellClick);

            btnInsertServiceDetail.Click += new EventHandler(btnInsertServiceDetail_Click);
            btnUpdateServiceDetail.Click += new EventHandler(btnUpdateServiceDetail_Click);
            btnDeleteServiceDetail.Click += new EventHandler(btnDeleteServiceDetail_Click);

            LoadCustomer();
            LoadService();

            txtServiceTransID.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([ServiceTransID]),0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransaction]"));
            txtAdditionalPrice.Text = "0";
            dtpkCreatedDate.Value = DateTime.Now;
            dtpkDeliveredDate.Value = DateTime.Now;

            LoadServiceInvoice();
        }

        #region Service Invoice  

        private void LoadServiceInvoice()
        {
            List<ServiceInvoice_DTO> listInvoice = ServiceInvoice_BUS.ServiceInvoiceLoad(Convert.ToInt32(txtServiceTransID.Text));
            dtgvServiceInfoList.DataSource = listInvoice;
        }

        private void LoadCustomer()
        {
            List<Customer_DTO> loadCustomer = Customer_BUS.LoadCustomerList();
            cmbCustomerName.DataSource = loadCustomer;
            cmbCustomerName.ValueMember = "CustomerID";
            cmbCustomerName.DisplayMember = "CustomerName";
            txtCustomerID.Text = cmbCustomerName.SelectedValue.ToString();
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = cmbCustomerName.SelectedValue.ToString();
        }

        private void dtgvServiceInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                txtServiceTransID.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["ServiceTransID"].Value);
                txtCustomerID.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["CustomerID"].Value);
                cmbCustomerName.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["CustomerName"].Value);
                dtpkCreatedDate.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["CreateDate"].Value);
                txtTotal.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["Total"].Value);
                txtPrepaid.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["Prepaid"].Value);
                txtRemain.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["Remain"].Value);
                txtStatus.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["Status"].Value);

                txtServiceTransIDD.Text = txtServiceTransID.Text;
                LoadServiceInvoiceDetails();
            }
        }

        private void btnInsertService_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceInvoice_DTO serviceInvoice = new ServiceInvoice_DTO();
                serviceInvoice.Createdate = Convert.ToDateTime(dtpkCreatedDate.Text.ToString());
                serviceInvoice.CustomerId = Convert.ToInt32(txtCustomerID.Text.ToString());
                

                if (ServiceInvoice_BUS.InsertServiceInvoice(serviceInvoice))
                {
                    XtraMessageBox.Show("Insert Service Invoice Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtServiceTransIDD.Text = txtServiceTransID.Text;
                    LoadServiceInvoice();
                    ClearDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Insert Service Invoice Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceInvoice_DTO serviceInvoice = new ServiceInvoice_DTO();
                serviceInvoice.ServiceTransId = Convert.ToInt32(txtServiceTransID.Text.ToString());
                serviceInvoice.Createdate = Convert.ToDateTime(dtpkCreatedDate.Text.ToString());
                serviceInvoice.CustomerId = Convert.ToInt32(txtCustomerID.Text.ToString());

                if (ServiceInvoice_BUS.UpdateServiceInvoice(serviceInvoice))
                {
                    LoadServiceInvoice();
                    XtraMessageBox.Show("Update Service Invoice Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Update Service Invoice Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceInvoice_DTO serviceInvoice = new ServiceInvoice_DTO();
                serviceInvoice.ServiceTransId = Convert.ToInt32(txtServiceTransID.Text.ToString());


                if (ServiceInvoice_BUS.DeleteServiceInvoice(serviceInvoice))
                {
                    LoadServiceInvoice();
                    XtraMessageBox.Show("Delete Service Invoice Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearDisplay()
        {
            txtServiceTransID.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([ServiceTransID]),0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[ServiceTransaction]"));
        }

        private void lkbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay();
        }

        #endregion

        #region Service Invoice Details

        private void LoadService()
        {
            List<Service_DTO> loadService = Service_BUS.LoadService();
            cmbServiceName.DataSource = loadService;
            cmbServiceName.ValueMember = "ServiceID";
            cmbServiceName.DisplayMember = "ServiceName";
            txtServiceID.Text = cmbServiceName.SelectedValue.ToString();
            txtServicePrice.DataBindings.Add("Text", loadService, "ServicePrice");
        }

        private void cmbServiceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServiceID.Text = cmbServiceName.SelectedValue.ToString();
        }

        private void dtgvServiceDetailsInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                txtServiceTransDetailsID.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["ServiceTransDetailsID"].Value);
                txtServiceTransIDD.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["ServiceTransIDD"].Value);
                txtServiceID.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["ServiceID"].Value);
                cmbServiceName.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["ServiceName"].Value);
                txtServicePrice.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["ServicePrice"].Value);
                txtAdditionalPrice.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["AdditionalPrice"].Value);
                txtTransPrice.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["TransPrice"].Value);
                txtQuantity.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["TransQuantity"].Value);
                txtTransTotal.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["TransTotal"].Value);
                txtTransPrepaid.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["TransPrepaid"].Value);
                txtTransRemain.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["TransRemain"].Value);
                dtpkDeliveredDate.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["DeliveredDate"].Value);
                txtTransStatus.Text = Convert.ToString(dtgvServiceDetailsInfoList.CurrentRow.Cells["TransStatus"].Value);
            }
        }

        private void LoadServiceInvoiceDetails()
        {
            List<ServiceInvoiceDetails_DTO> listServiceInvoice = ServiceInvoiceDetails_BUS.LoadServiceInvoiceDetails(Convert.ToInt32(txtServiceTransIDD.Text));
            dtgvServiceDetailsInfoList.DataSource = listServiceInvoice;
        }

        private void btnInsertServiceDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdditionalPrice.Text == "" || txtQuantity.Text == "" || txtTransPrepaid.Text == "")
                {
                    XtraMessageBox.Show("You have to fullfill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ServiceInvoiceDetails_DTO invoiceDetails = new ServiceInvoiceDetails_DTO();
                invoiceDetails.ServiceTransID = Convert.ToInt32(txtServiceTransIDD.Text);
                invoiceDetails.ServiceID = Convert.ToInt32(txtServiceID.Text);
                invoiceDetails.ServiceName = cmbServiceName.Text;
                invoiceDetails.ServicePrice = float.Parse(txtServicePrice.Text);
                invoiceDetails.AdditionalPrice = Convert.ToInt32(txtAdditionalPrice.Text);
                invoiceDetails.TransPrice = float.Parse(txtTransPrice.Text);
                invoiceDetails.TransQuantity = Convert.ToInt32(txtQuantity.Text);
                invoiceDetails.TransTotal = float.Parse(txtTransTotal.Text);
                invoiceDetails.TransPrepaid = float.Parse(txtTransPrepaid.Text);
                invoiceDetails.TransRemain = float.Parse(txtTransRemain.Text);
                invoiceDetails.DeliveredDate = Convert.ToDateTime(dtpkDeliveredDate.Text.ToString());
                invoiceDetails.TransStatus = txtTransStatus.Text;

                if (ServiceInvoiceDetails_BUS.InsertServiceInvoiceDetails(invoiceDetails))
                {
                    List<ServiceInvoice_DTO> listInvoice = ServiceInvoice_BUS.ServiceInvoiceLoad(Convert.ToInt32(txtServiceTransIDD.Text));
                    dtgvServiceInfoList.DataSource = listInvoice;

                    LoadServiceInvoiceDetails();
                    XtraMessageBox.Show("Insert details sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearDetailsDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Insert details Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateServiceDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdditionalPrice.Text == "" || txtQuantity.Text == "" || txtTransPrepaid.Text == "")
                {
                    XtraMessageBox.Show("You have to fullfill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ServiceInvoiceDetails_DTO invoiceDetails = new ServiceInvoiceDetails_DTO();
                invoiceDetails.ServiceTransDetailsID = Convert.ToInt32(txtServiceTransDetailsID.Text);
                invoiceDetails.ServiceTransID = Convert.ToInt32(txtServiceTransIDD.Text);
                invoiceDetails.ServiceID = Convert.ToInt32(txtServiceID.Text);
                invoiceDetails.ServiceName = cmbServiceName.Text;
                invoiceDetails.ServicePrice = float.Parse(txtServicePrice.Text);
                invoiceDetails.AdditionalPrice = Convert.ToInt32(txtAdditionalPrice.Text);
                invoiceDetails.TransPrice = float.Parse(txtTransPrice.Text);
                invoiceDetails.TransQuantity = Convert.ToInt32(txtQuantity.Text);
                invoiceDetails.TransTotal = float.Parse(txtTransTotal.Text);
                invoiceDetails.TransPrepaid = float.Parse(txtTransPrepaid.Text);
                invoiceDetails.TransRemain = float.Parse(txtTransRemain.Text);
                invoiceDetails.DeliveredDate = Convert.ToDateTime(dtpkDeliveredDate.Text.ToString());
                invoiceDetails.TransStatus = txtTransStatus.Text;


                if (ServiceInvoiceDetails_BUS.UpdateServiceInvoiceDetails(invoiceDetails))
                {
                    List<ServiceInvoice_DTO> listInvoice = ServiceInvoice_BUS.ServiceInvoiceLoad(Convert.ToInt32(txtServiceTransIDD.Text));
                    dtgvServiceInfoList.DataSource = listInvoice;

                    LoadServiceInvoiceDetails();

                    XtraMessageBox.Show("Update details sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearDetailsDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Update details failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnDeleteServiceDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdditionalPrice.Text == "" || txtQuantity.Text == "" || txtTransPrepaid.Text == "")
                {
                    XtraMessageBox.Show("You have to fullfill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ServiceInvoiceDetails_DTO invoiceDetails = new ServiceInvoiceDetails_DTO();
                invoiceDetails.ServiceTransDetailsID = Convert.ToInt32(txtServiceTransDetailsID.Text);
                invoiceDetails.ServiceTransID = Convert.ToInt32(txtServiceTransIDD.Text);


                if (ServiceInvoiceDetails_BUS.DeleteServiceInvoiceDetails(invoiceDetails))
                {
                    List<ServiceInvoice_DTO> listInvoice = ServiceInvoice_BUS.ServiceInvoiceLoad(Convert.ToInt32(txtServiceTransIDD.Text));
                    dtgvServiceInfoList.DataSource = listInvoice;

                    LoadServiceInvoiceDetails();

                    XtraMessageBox.Show("Delete details sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearDetailsDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Delete details failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void clearDetailsDisplay()
        {
            txtAdditionalPrice.Text = "0";
            txtQuantity.Text = "0";
            txtTransPrepaid.Text = "0";
        }

        private void txtAdditionalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTransPrepaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClearDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clearDetailsDisplay();
        }

        private void txtAdditionalPrice_TextChanged(object sender, EventArgs e)
        {
            if (float.Parse(txtAdditionalPrice.Text) < 0)
            {
                XtraMessageBox.Show("Addtional Price can not less than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                float servicePrice = float.Parse(txtServicePrice.Text);
                float addition = float.Parse(txtAdditionalPrice.Text);

                float transPrice = servicePrice + addition;

                txtTransPrice.Text = transPrice.ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtQuantity.Text) < 0)
            {
                XtraMessageBox.Show("Quantity can not less than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float transPrice = float.Parse(txtTransPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            float total = transPrice * quantity;
            txtTransTotal.Text = total.ToString();
        }

        private void txtTransPrepaid_TextChanged(object sender, EventArgs e)
        {
            float prepaid = float.Parse(txtTransPrepaid.Text);

            float total = float.Parse(txtTransTotal.Text);

            if (prepaid < 0 || prepaid > total)
            {
                XtraMessageBox.Show("Quantity can not less than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (prepaid < (total * 0.5))
            {
                XtraMessageBox.Show("Prepaid must greater than or equal to 50% of total", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float remain = total - prepaid;

            if (remain == 0)
            {
                txtTransRemain.Text = remain.ToString();
                txtTransStatus.Text = "Delivered";
            }
            else
            {
                txtTransRemain.Text = remain.ToString();
                txtTransStatus.Text = "Pending";
            }
        }

        #endregion
    }
}
