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
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctPostInvoice : UserControl
    {
        public uctPostInvoice()
        {
            InitializeComponent();
        }

        public static uctPostInvoice uctPostInvoiceInfo = new uctPostInvoice();

        private void uctPostInvoice_Load(object sender, EventArgs e)
        {
            LoadDataBillImport();
        }

        #region Post Invoice
        private void LoadDataBillImport()
        {
            btnAddImportBill.Click += new EventHandler(btnAddImportBill_Click);
            dtgvInfoListOfBillImport.CellClick += new DataGridViewCellEventHandler(dtgvInfoListOfBillImport_CellClick);
            dtgvListOfDetailProductImport.CellClick += new DataGridViewCellEventHandler(dtgvListOfDetailProductImport_CellClick);
            btnUpdateBillImport.Click += new EventHandler(btnUpdateBillImport_Click);
            btnDeleteBillImport.Click += new EventHandler(btnDeleteBillImport_Click);
            btnAddProductImportDetail.Click += new EventHandler(btnAddProductImportDetail_Click);
            btnUpdateProductImportDetail.Click += new EventHandler(btnUpdateProductImportDetail_Click);
            btnDeleteProductImportDetail.Click += new EventHandler(btnDeleteProductImportDetail_Click);
            LoadVendor();
            LoadProductCategory();
            LoadUnit();

            LoadPostInvoice();
            txtIDBillImport.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([TransID]),0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Transaction]"));
            dtpkDateTimeImport.Value = DateTime.Now;
        }

        private void LoadPostInvoice()
        {
            List<PostInvoice_DTO> listInvoice = PostInvoice_BUS.PostInvoiceLoad();
            dtgvInfoListOfBillImport.DataSource = listInvoice;
        }

        private void LoadVendor()
        {
            List<Vendor_DTO> loadVendor = Vendor_BUS.LoadVendor();
            cmbIDAgency.DataSource = loadVendor;
            cmbIDAgency.ValueMember = "VendorID";
            cmbIDAgency.DisplayMember = "VendorName";
            txtVendorId.Text = cmbIDAgency.SelectedValue.ToString();
        }

        private void LoadProductCategory()
        {
            List<ProductCategory_DTO> loadCategory = ProductCategory_BUS.LoadProductCategory();
            cmbProductCategory.DataSource = loadCategory;
            cmbProductCategory.ValueMember = "ProductCategoryID";
            cmbProductCategory.DisplayMember = "ProductCategoryName";
        }

        private void LoadUnit()
        {
            List<Unit_DTO> loadUnit = Unit_BUS.LoadUnit();
            cmbUnit.DataSource = loadUnit;
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DisplayMember = "UnitName";
        }

        private void dtgvInfoListOfBillImport_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                txtIDBillImport.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TransID"].Value);
                txtVendorId.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["VendorID"].Value);
                cmbIDAgency.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["VendorName"].Value);
                dtpkDateTimeImport.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["CreateDate"].Value);
                cmbIDBillImportDetail.Text = txtIDBillImport.Text;
                txtTotal.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TotalPrice"].Value);

                List<PostInvoiceDetails_DTO> listInvoice = PostInvoiceDetails_BUS.LoadPostInvoiceDetails(Convert.ToInt32(txtIDBillImport.Text));
                dtgvListOfDetailProductImport.DataSource = listInvoice;

                if (dtgvListOfDetailProductImport.Rows.Count > 1)
                {
                    dtgvListOfDetailProductImport.Columns["TransID"].Visible = false;
                }
            }
        }

        private void btnAddImportBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillImport.Text == "" || txtVendorId.Text == "" || cmbIDAgency.Text == "")
                {
                    XtraMessageBox.Show("Missing Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PostInvoice_DTO postInvoice = new PostInvoice_DTO();
                postInvoice.TransID = Convert.ToInt32(txtIDBillImport.Text);
                postInvoice.VendorID = Convert.ToInt32(txtVendorId.Text.ToString());
                postInvoice.CreateDate = Convert.ToDateTime(dtpkDateTimeImport.Text.ToString());
                postInvoice.VendorName = cmbIDAgency.Text.ToString();
                postInvoice.TotalPrice = 0;

                if (PostInvoice_BUS.InsertPostInvoice(postInvoice))
                {
                    XtraMessageBox.Show("Insert Post Invoice Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbIDBillImportDetail.Text = txtIDBillImport.Text;
                    ClearDisplay();

                    uctVendor.uctVendorInfo.LoadVendorList();
                    LoadPostInvoice();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Insert Post Invoice Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateBillImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillImport.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one invoice to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PostInvoice_DTO invoice = new PostInvoice_DTO();
                invoice.TransID = Convert.ToInt32(dtgvInfoListOfBillImport.CurrentRow.Cells["TransID"].Value);
                invoice.VendorID = Convert.ToInt32(txtVendorId.Text);
                invoice.CreateDate = Convert.ToDateTime(dtpkDateTimeImport.Text.ToString());

                if (PostInvoice_BUS.UpdatePostInvoice(invoice))
                {
                    LoadPostInvoice();
                    uctVendor.uctVendorInfo.LoadVendorList();
                    XtraMessageBox.Show("Update Post Invoice Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Update Post Invoice Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeleteBillImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillImport.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one invoice to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PostInvoice_DTO invoice = new PostInvoice_DTO();
                invoice.TransID = Convert.ToInt32(dtgvInfoListOfBillImport.CurrentRow.Cells["TransID"].Value);

            
                if (PostInvoice_BUS.DeletePostInvoice(invoice))
                {
                    LoadPostInvoice();
                    uctVendor.uctVendorInfo.LoadVendorList();
                    XtraMessageBox.Show("Delete Post Invoice Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtIDBillImport.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([TransID]),0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Transaction]"));
            txtVendorId.Text = "";
            txtVendorId.Text = "";
            cmbIDAgency.Text = "";
        }

        private void txtTotalPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Post Invoice Details

        private void dtgvListOfDetailProductImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                cmbIDProductDetailStore.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["ProductName"].Value);
                cmbProductCategory.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["ProductCategoryName"].Value);
                cmbUnit.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["UnitName"].Value);
                txtQuantity.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["TransQuantity"].Value);
                txtWeight.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["Weight"].Value);
                txtTransPrice.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["TransPrice"].Value);
                txtProductID.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["ProductID"].Value);
                txtTransDetailsID.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["TransDetailsID"].Value);
            }
        }

        private void LoadPostInvoiceDetails()
        {
            List<PostInvoiceDetails_DTO> listInvoice = PostInvoiceDetails_BUS.LoadPostInvoiceDetails(Convert.ToInt32(txtIDBillImport.Text));
            dtgvListOfDetailProductImport.DataSource = listInvoice;
            txtTotal.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TotalPrice"].Value);

            if (dtgvListOfDetailProductImport.Rows.Count != 1)
            {
                dtgvListOfDetailProductImport.Columns["TransID"].Visible = false;
            }

        }

        private void btnAddProductImportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDProductDetailStore.Text == "" || txtQuantity.Text == "" || txtWeight.Text == "" || txtTransPrice.Text == "")
                {
                    XtraMessageBox.Show("You have to fullfill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PostInvoiceDetails_DTO invoiceDetails = new PostInvoiceDetails_DTO();
                invoiceDetails.TransID = cmbIDBillImportDetail.Text;
                invoiceDetails.ProductName = cmbIDProductDetailStore.Text;
                invoiceDetails.ProductCategoryName = cmbProductCategory.Text;
                invoiceDetails.UnitName = cmbUnit.Text;
                invoiceDetails.TransQuantity = Convert.ToInt32(txtQuantity.Text.ToString());
                invoiceDetails.Weight = txtWeight.Text;
                invoiceDetails.TransPrice = txtTransPrice.Text;

                if (PostInvoiceDetails_BUS.InsertPostInvoiceDetails(invoiceDetails))
                {
                    LoadPostInvoice();
                    LoadPostInvoiceDetails();
                    XtraMessageBox.Show("Insert details sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //uctSanPhamCH.uctSPCH.LoadSanPhamCH1();
                    ClearDisplay1();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Sản phẩm đã tồn tại trong Hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateProductImportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDProductDetailStore.Text == "" || txtQuantity.Text == "" || txtWeight.Text == "" || txtTransPrice.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least 1 field to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PostInvoiceDetails_DTO invoiceDetails = new PostInvoiceDetails_DTO();
                invoiceDetails.TransID = cmbIDBillImportDetail.Text;
                invoiceDetails.TransDetailsID = txtTransDetailsID.Text;
                invoiceDetails.ProductID = txtProductID.Text;
                invoiceDetails.ProductName = cmbIDProductDetailStore.Text;
                invoiceDetails.ProductCategoryName = cmbProductCategory.Text;
                invoiceDetails.UnitName = cmbUnit.Text;
                invoiceDetails.TransQuantity = Convert.ToInt32(txtQuantity.Text.ToString());
                invoiceDetails.Weight = txtWeight.Text;
                invoiceDetails.TransPrice = txtTransPrice.Text;


                if (PostInvoiceDetails_BUS.UpdatePostInvoiceDetails(invoiceDetails))
                {
                    LoadPostInvoice();
                    LoadPostInvoiceDetails();

                    XtraMessageBox.Show("Update details sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay1();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Chi tiết phiếu nhập hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnDeleteProductImportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDProductDetailStore.Text == "" || txtQuantity.Text == "" || txtWeight.Text == "" || txtTransPrice.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least 1 field to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PostInvoiceDetails_DTO invoiceDetails = new PostInvoiceDetails_DTO();
                invoiceDetails.TransDetailsID = txtTransDetailsID.Text;
                invoiceDetails.ProductID = txtProductID.Text;


                if (PostInvoiceDetails_BUS.DeletePostInvoiceDetails(invoiceDetails))
                {
                    LoadPostInvoice();
                    LoadPostInvoiceDetails();
                    XtraMessageBox.Show("Delete details sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay1();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Xóa chi tiết hóa đơn thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearDisplay1()
        {
            cmbIDProductDetailStore.Text = "";
            txtQuantity.Text = "";
            txtWeight.Text = "";
            txtTransPrice.Text = "";
        }

        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void lbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay1();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTransPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAmountOfProductImportDetail_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
        }

        private void CmbIDAgency_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVendorId.Text = cmbIDAgency.SelectedValue.ToString();
        }
    }
}