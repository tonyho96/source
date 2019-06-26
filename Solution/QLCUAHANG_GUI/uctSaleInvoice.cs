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
    public partial class uctSaleInvoice : UserControl
    {
        public uctSaleInvoice()
        {
            InitializeComponent();
        }

        public static uctSaleInvoice uctPHDB = new uctSaleInvoice();

        private void uctSaleInvoice_Load(object sender, EventArgs e)
        {
            DataSaleInvoice();
            //DataChiTietHoaDonBan();
        }

        #region Sale Invoice

        private void DataSaleInvoice()
        {
            dtgvInfoListOfBillExport.CellClick += new DataGridViewCellEventHandler(dtgvInfoListOfBillExport_CellClick);
            dtgvDetailBillSale.CellClick += new DataGridViewCellEventHandler(dtgvDetailBillSale_CellClick);

            btnAddBillExport.Click += new EventHandler(btnAddBillExport_Click);
            btnUpdateBillExport.Click += new EventHandler(btnUpdateBillExport_Click);
            btnDeleteBillExport.Click += new EventHandler(btnDeleteBillExport_Click);

            btnAddProductExportDetail.Click += new EventHandler(btnAddProductExportDetail_Click);
            btnUpdateProductExportDetail.Click += new EventHandler(btnUpdateProductExportDetail_Click);
            btnDeleteProductExportDetail.Click += new EventHandler(btnDeleteProductExportDetail_Click);

            LoadCustomer();
            LoadProduct();
            LoadSaleInvoice();
            txtIDBillExport.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([TransID]),0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Transaction]"));
            dtpkDateTimeExport.Value = DateTime.Now;
        }

        private void LoadSaleInvoice()
        {
            List<SaleInvoice_DTO> saleInvoiceList = SaleInvoice_BUS.LoadSaleInvoice();
            dtgvInfoListOfBillExport.DataSource = saleInvoiceList;
        }

        private void LoadCustomer()
        {
            List<Customer_DTO> loadCustomer = Customer_BUS.LoadCustomerList();
            cmbIDCustomer.DataSource = loadCustomer;
            cmbIDCustomer.ValueMember = "CustomerId";
            cmbIDCustomer.DisplayMember = "CustomerName";
            txtIDCustomer.Text = cmbIDCustomer.SelectedValue.ToString();
        }

        private void LoadProduct()
        {
            List<Product_DTO> loadProduct = Product_BUS.LoadProduct();
            cmbProductName.DataSource = loadProduct;
            cmbProductName.ValueMember = "ProductID";
            cmbProductName.DisplayMember = "ProductName";
            cmbIDProductDetailStore.Text = cmbProductName.SelectedValue.ToString();

            cmbUnit.DataSource = loadProduct;
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.Text = cmbProductName.SelectedValue.ToString();

            cmbProductCategory.DataSource = loadProduct;
            cmbProductCategory.ValueMember = "ProductCategoryID";
            cmbProductCategory.DisplayMember = "ProductCategoryName";

            cmbPQuatity.DataSource = loadProduct;
            cmbPQuatity.ValueMember = "Quantity";
            cmbPQuatity.DisplayMember = "Quantity";

            cmbPercent.DataSource = loadProduct;
            cmbPercent.ValueMember = "PercentRevenue";
            cmbPercent.DisplayMember = "PercentRevenue";

            cmbImportPrice.DataSource = loadProduct;
            cmbImportPrice.ValueMember = "ImportPrice";
            cmbImportPrice.DisplayMember = "ImportPrice";
        }

        private void dtgvInfoListOfBillExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    txtIDBillExport.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["TransID"].Value);
                    txtIDCustomer.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["CustomerID"].Value);
                    cmbIDCustomer.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["CustomerName"].Value);
                    dtpkDateTimeExport.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["CreateDate"].Value);
                    cmbIDBillExportDetail.Text = txtIDBillExport.Text;
                    txtTotal.Text = "";
                    LoadSaleInvoiceDetails();
                }
                else
                    return;
            }
            catch
            {
                return;
            }
        }

        private void btnAddBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillExport.Text == "" || txtIDCustomer.Text == "" || cmbIDCustomer.Text == "")
                {
                    XtraMessageBox.Show("Missing Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaleInvoice_DTO invoice = new SaleInvoice_DTO();
                invoice.TransID = Convert.ToInt32(txtIDBillExport.Text);
                invoice.CustomerId = Convert.ToInt32(txtIDCustomer.Text.ToString());
                invoice.CreateDate = Convert.ToDateTime(dtpkDateTimeExport.Text.ToString());
                invoice.CustomerName = cmbIDCustomer.Text.ToString();
                invoice.TotalPrice = 0;

                if (SaleInvoice_BUS.InsertSaleInvoice(invoice))
                {
                    LoadSaleInvoice();
                    cmbIDBillExportDetail.Text = txtIDBillExport.Text;
                    ClearDisplay();
                    uctCustomer.uctCustomerInfo.LoadCustomer();
                    XtraMessageBox.Show("Insert Sale Invoice Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Insert Post Invoice Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillExport.Text == "" || txtIDCustomer.Text == "" || cmbIDCustomer.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one invoice to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                SaleInvoice_DTO invoice = new SaleInvoice_DTO();
                invoice.TransID = Convert.ToInt32(dtgvInfoListOfBillExport.CurrentRow.Cells["TransID"].Value);
                invoice.CustomerId = Convert.ToInt32(txtIDCustomer.Text);
                invoice.CreateDate = Convert.ToDateTime(dtpkDateTimeExport.Text.ToString());

                if (SaleInvoice_BUS.UpdateSaleInvoice(invoice))
                {
                    LoadSaleInvoice();
                    uctCustomer.uctCustomerInfo.LoadCustomer();
                    XtraMessageBox.Show("Update Post Invoice Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            } catch
            {
                XtraMessageBox.Show("Update Post Invoice Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeleteBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillExport.Text == "" || txtIDCustomer.Text == "" || cmbIDCustomer.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one invoice to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                SaleInvoice_DTO invoice = new SaleInvoice_DTO();
                invoice.TransID = Convert.ToInt32(dtgvInfoListOfBillExport.CurrentRow.Cells["TransID"].Value);


                if (SaleInvoice_BUS.DeleteSaleInvoice(invoice))
                {
                    LoadSaleInvoice();
                    uctCustomer.uctCustomerInfo.LoadCustomer();
                    ClearDisplay();
                    XtraMessageBox.Show("Delete Post Invoice Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
        #endregion

        #region Sale Invoice Details

        private void txtTransQuantity_TextChanged(object sender, EventArgs e)
        {
            /*int num;
            if (txtTransQuantity.Text == "")
                num = 0;
            else
                num = Convert.ToInt32(txtTransQuantity.Text.ToString());

            int num1 = Convert.ToInt32(cmbPQuatity.Text.ToString());

            if (num < 0)
            {
                XtraMessageBox.Show("Quantity must be greater than 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTransQuantity.Text = "";
                return;
            }

            if (num > num1)
            {
                XtraMessageBox.Show("Not enough products in store!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTransQuantity.Text = "";
                return;
            }*/
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float transPrice, total;
            transPrice = float.Parse(cmbImportPrice.Text.ToString()) + (float.Parse(cmbImportPrice.Text.ToString()) * float.Parse(cmbPercent.Text.ToString()));
            total = transPrice * float.Parse(txtTransQuantity.Text.ToString());
            txtTransPrice.Text = transPrice.ToString();
            txtTotal.Text = total.ToString();
        }

        private void LoadSaleInvoiceDetails()
        {
            List<SaleInvoiceDetails_DTO> listInvoice = SaleInvoiceDetails_BUS.LoadSaleInvoiceDetails(Convert.ToInt32(cmbIDBillExportDetail.Text));
            dtgvDetailBillSale.DataSource = listInvoice;
        }

        private void dtgvDetailBillSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    cmbIDProductDetailStore.Text = dtgvDetailBillSale.CurrentRow.Cells["ProductID"].Value.ToString();
                    cmbProductName.Text = dtgvDetailBillSale.CurrentRow.Cells["ProductName"].Value.ToString();
                    cmbProductCategory.Text = dtgvDetailBillSale.CurrentRow.Cells["ProductCategoryName"].Value.ToString();
                    cmbUnit.Text = dtgvDetailBillSale.CurrentRow.Cells["UnitName"].Value.ToString();
                    txtTransQuantity.Text = dtgvDetailBillSale.CurrentRow.Cells["TransQuantity"].Value.ToString();
                    txtTransPrice.Text = dtgvDetailBillSale.CurrentRow.Cells["TransPrice"].Value.ToString();
                    txtTotal.Text = dtgvDetailBillSale.CurrentRow.Cells["Total"].Value.ToString();
                    txtTransDetailsID.Text = dtgvDetailBillSale.CurrentRow.Cells["TransDetailsID"].Value.ToString();
                }
                else
                    return;
            }
            catch
            {
                return;
            }
        }

        private void btnAddProductExportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTransQuantity.Text == "")
                {
                    XtraMessageBox.Show("You have to input quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int num;
                if (txtTransQuantity.Text == "")
                    num = 0;
                else
                    num = Convert.ToInt32(txtTransQuantity.Text.ToString());

                int num1 = Convert.ToInt32(cmbPQuatity.Text.ToString());


                if (num > num1)
                {
                    XtraMessageBox.Show("Not enough products in store!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTransQuantity.Text = "";
                    return;
                }
                else
                {
                    SaleInvoiceDetails_DTO invoice = new SaleInvoiceDetails_DTO();
                    invoice.TransID = cmbIDBillExportDetail.Text;
                    invoice.ProductID = cmbIDProductDetailStore.Text;
                    invoice.TransQuantity = Convert.ToInt32(txtTransQuantity.Text);
                    invoice.TransPrice = txtTransPrice.Text;
                    invoice.Total = txtTotal.Text;

                    if (SaleInvoiceDetails_BUS.InsertSaleInvoiceDetails(invoice))
                    {
                        LoadSaleInvoice();
                        LoadSaleInvoiceDetails();
                        LoadProduct();
                        uctProduct.uctSPCH.LoadProductList();
                        XtraMessageBox.Show("Insert detail sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearDisplay1();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateProductExportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTransQuantity.Text == "")
                {
                    XtraMessageBox.Show("You have to input quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int originQuantity = Convert.ToInt32(dtgvDetailBillSale.CurrentRow.Cells["TransQuantity"].Value.ToString());
                int newQuantity = Convert.ToInt32(txtTransQuantity.Text.ToString());
                int change = newQuantity - originQuantity;

                int prodQuantity = Convert.ToInt32(cmbPQuatity.Text.ToString());

                if (change > prodQuantity)
                {
                    XtraMessageBox.Show("Not enough products in store!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTransQuantity.Text = "";
                    return;
                }

                SaleInvoiceDetails_DTO invoice = new SaleInvoiceDetails_DTO();
                invoice.TransID = cmbIDBillExportDetail.Text;
                invoice.TransDetailsID = txtTransDetailsID.Text;
                invoice.ProductID = cmbIDProductDetailStore.Text;
                invoice.TransQuantity = Convert.ToInt32(txtTransQuantity.Text);
                invoice.TransChange = change;
                invoice.TransPrice = txtTransPrice.Text;
                invoice.Total = txtTotal.Text;

                if (SaleInvoiceDetails_BUS.UpdateSaleInvoiceDetails(invoice))
                {
                    LoadSaleInvoice();
                    LoadSaleInvoiceDetails();
                    LoadProduct();
                    uctProduct.uctSPCH.LoadProductList();
                    XtraMessageBox.Show("Update detail sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearDisplay1();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Update detail failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeleteProductExportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTransQuantity.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least 1 record to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SaleInvoiceDetails_DTO invoice = new SaleInvoiceDetails_DTO();
                invoice.TransDetailsID = txtTransDetailsID.Text;
                invoice.TransChange = Convert.ToInt32(dtgvDetailBillSale.CurrentRow.Cells["TransQuantity"].Value.ToString());
                invoice.ProductID = cmbIDProductDetailStore.Text;

                if (SaleInvoiceDetails_BUS.DeleteSaleInvoiceDetails(invoice))
                {
                    LoadSaleInvoice();
                    LoadSaleInvoiceDetails();
                    LoadProduct();
                    uctProduct.uctSPCH.LoadProductList();
                    XtraMessageBox.Show("Delete detail sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearDisplay1();
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Delete detail failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
       
        #endregion

        private void ClearDisplay1()
        {
            txtTransQuantity.Text = "";
            LoadProduct();
        }

        private void ClearDisplay()
        {
            //txtIDBillExport.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaHDB=dbo.fcGetMaHDB()"));
            //txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
        }


        private void txtTotalPayExport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotalDebtExport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lkbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay();
        }

        private void lkbClear1_Click(object sender, EventArgs e)
        {
            ClearDisplay1();
        }

        private void txtTotalPayExport_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAmountOfProductExportDetail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbIDCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDCustomer.Text = cmbIDCustomer.SelectedValue.ToString();
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIDProductDetailStore.Text = cmbProductName.SelectedValue.ToString();
            cmbUnit.Text = cmbProductName.SelectedValue.ToString();
            cmbProductCategory.Text = cmbProductName.SelectedValue.ToString();
            cmbPQuatity.Text = cmbProductName.SelectedValue.ToString();
            cmbPercent.Text = cmbProductName.SelectedValue.ToString();
            cmbImportPrice.Text = cmbProductName.SelectedValue.ToString();
        }     
    }
}
