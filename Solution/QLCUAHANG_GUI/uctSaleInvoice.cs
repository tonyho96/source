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
            btnAddBillExport.Click += new EventHandler(btnAddBillExport_Click);
            btnUpdateBillExport.Click += new EventHandler(btnUpdateBillExport_Click);
            btnDeleteBillExport.Click += new EventHandler(btnDeleteBillExport_Click);

            //btnAddProductExportDetail.Click += new EventHandler(btnAddProductExportDetail_Click);
            //btnUpdateProductExportDetail.Click += new EventHandler(btnUpdateProductExportDetail_Click);
            //btnDeleteProductExportDetail.Click += new EventHandler(btnDeleteProductExportDetail_Click);

            LoadCustomer();
            LoadProductCategory();
            LoadUnit();
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
                    txtTotal.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["TotalPrice"].Value);
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


        #region Chi tiết Hóa đơn bán

        private void dtgvDetailBillSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    cmbIDBillExportDetail.Text = (string)dtgvDetailBillSale.CurrentRow.Cells["MaHDB1"].Value;
                    cmbIDProductDetailStore.Text = dtgvDetailBillSale.CurrentRow.Cells["MaSPCH"].Value.ToString();
                    txtAmountOfProductExportDetail.Text = dtgvDetailBillSale.CurrentRow.Cells["SoLuong"].Value.ToString();
                    cmbUnitCalculator.Text = dtgvDetailBillSale.CurrentRow.Cells["DonViTinh"].Value.ToString();
                    if (dtgvDetailBillSale.CurrentRow.Cells["HinhThucBan"].Value.ToString() == "1")
                    {
                        txtRetail.Enabled = true;
                        cbRetail.Checked = true;
                    }
                    else
                    {
                        txtRetail.Text = "0";
                        txtRetail.Enabled = false;
                        cbRetail.Checked = false;

                    }

                    if (cbRetail.Checked == true)
                    {
                        txtRetail.Text = dtgvDetailBillSale.CurrentRow.Cells["SoLuongMuaLe"].Value.ToString();
                    }

                }
                else
                    return;
            }
            catch
            {
                return;
            }
        }

        private void LoadSaleInvoiceDetails()
        {
            List<SaleInvoiceDetails_DTO> listInvoice = SaleInvoiceDetails_BUS.LoadChiTietPhieuBan();
            dtgvDetailBillSale.DataSource = listInvoice;
        }

        private void btnAddProductExportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDBillExportDetail.Text == "" || cmbIDProductDetailStore.Text == "" || txtAmountOfProductExportDetail.Text == "")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaleInvoiceDetails_DTO phieunhap = new SaleInvoiceDetails_DTO();
            phieunhap.MaHDB = cmbIDBillExportDetail.Text;
            phieunhap.MaSPCH = cmbIDProductDetailStore.Text;
            if (txtAmountOfProductExportDetail.Text == "")
                phieunhap.SoLuong = 0;
            else
                phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductExportDetail.Text.ToString());

            phieunhap.DonViTinh = cmbUnitCalculator.Text;
            phieunhap.SoLuongMuaLe = Convert.ToInt32(txtRetail.Text.ToString());
            if (cbRetail.Checked == true)
            {
                phieunhap.HinhThucBan = 1;
            }
            else
                phieunhap.HinhThucBan = 0;

            
                if (SaleInvoiceDetails_BUS.ThemChiTietPHBan(phieunhap))
                {
                   LoadPhieuBanHang();
                   LoadChiTietPhieuBanHang();
                    uctProduct.uctSPCH.LoadSanPhamCH1();
                    XtraMessageBox.Show("Thêm chi tiết hóa đơn bán hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearDisplay1();
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateProductExportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDBillExportDetail.Text == "" || cmbIDProductDetailStore.Text == "" || txtAmountOfProductExportDetail.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn chi tiết phiếu cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbIDBillExportDetail.Text != (string)dtgvDetailBillSale.CurrentRow.Cells["MaHDB1"].Value || cmbIDProductDetailStore.Text != (string)dtgvDetailBillSale.CurrentRow.Cells["MaSPCH"].Value)
                {
                    XtraMessageBox.Show("Chi tiết hóa đơn bán hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaleInvoiceDetails_DTO phieunhap = new SaleInvoiceDetails_DTO();
                phieunhap.MaHDB = (string)dtgvDetailBillSale.CurrentRow.Cells["MaHDB1"].Value;
                phieunhap.MaSPCH = (string)dtgvDetailBillSale.CurrentRow.Cells["MaSPCH"].Value;

                phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductExportDetail.Text.ToString());
                phieunhap.DonViTinh = cmbUnitCalculator.Text;


                if (cbRetail.Checked == true)
                {
                    phieunhap.HinhThucBan = 1;
                    phieunhap.SoLuongMuaLe = Convert.ToInt32(txtRetail.Text.ToString());
                }
                else
                {
                    phieunhap.HinhThucBan = 0;
                    phieunhap.SoLuongMuaLe = 0;
                }

                if (SaleInvoiceDetails_BUS.SuaChiTietPHBan(phieunhap))
                {
                    LoadPhieuBanHang();
                    LoadChiTietPhieuBanHang();
                    uctProduct.uctSPCH.LoadSanPhamCH1();
                    XtraMessageBox.Show("Chi tiết hóa đơn bán hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay1();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Chi tiết hóa đơn bán hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeleteProductExportDetail_Click(object sender, EventArgs e)
        {
            try {
            if (cmbIDBillExportDetail.Text == ""||cmbIDProductDetailStore.Text==""||txtAmountOfProductExportDetail.Text=="")
            {
                XtraMessageBox.Show("Bạn phải chọn chi tiết phiếu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
                SaleInvoiceDetails_DTO phieunhap = new SaleInvoiceDetails_DTO();
                phieunhap.MaHDB = (string)dtgvDetailBillSale.CurrentRow.Cells["MaHDB1"].Value;
                phieunhap.MaSPCH = cmbIDProductDetailStore.Text;

                if (SaleInvoiceDetails_BUS.XoaChiTietPHBan(phieunhap))
                {
                    LoadPhieuBanHang();
                    LoadChiTietPhieuBanHang();
                    uctProduct.uctSPCH.LoadSanPhamCH1();
                    XtraMessageBox.Show("Chi tiết phiếu Bán hàng xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay1();
                    if(dtgvDetailBillSale.Rows.Count==0)
                    {
                        dtgvDetailBillSale.ColumnCount = 6;
                        dtgvDetailBillSale.ColumnHeadersVisible = true;
                        dtgvDetailBillSale.Columns[0].Name = "MaHDB1";
                        dtgvDetailBillSale.Columns[1].Name = "MaSPCH";
                        dtgvDetailBillSale.Columns[2].Name = "SoLuong";
                        dtgvDetailBillSale.Columns[3].Name = "DonViTinh";
                        dtgvDetailBillSale.Columns[4].Name = "HinhThucBan";
                        dtgvDetailBillSale.Columns[5].Name = "SoLuongMuaLe";

                        dtgvDetailBillSale.Columns[0].DataPropertyName = "MaHDB";
                        dtgvDetailBillSale.Columns[1].DataPropertyName = "MaSPCH";
                        dtgvDetailBillSale.Columns[2].DataPropertyName = "SoLuong";
                        dtgvDetailBillSale.Columns[3].DataPropertyName = "DonViTinh";
                        dtgvDetailBillSale.Columns[4].DataPropertyName = "HinhThucBan";
                        dtgvDetailBillSale.Columns[5].DataPropertyName = "SoLuongMuaLe";

                        dtgvDetailBillSale.Columns[0].HeaderText = "Mã HDB";
                        dtgvDetailBillSale.Columns[1].HeaderText = "Mã SPCH";
                        dtgvDetailBillSale.Columns[2].HeaderText = "Số lượng";
                        dtgvDetailBillSale.Columns[3].HeaderText = "Đơn vị tính";
                        dtgvDetailBillSale.Columns[4].HeaderText = "Hình thức bán";
                        dtgvDetailBillSale.Columns[5].HeaderText = "Số lượng mua lẻ";

                        dtgvDetailBillSale.Columns[0].Width =75;
                        dtgvDetailBillSale.Columns[1].Width = 80;
                        dtgvDetailBillSale.Columns[2].Width = 75;
                        dtgvDetailBillSale.Columns[3].Width =85;
                        dtgvDetailBillSale.Columns[4].Width = 100;
                        dtgvDetailBillSale.Columns[5].Width = 120;
                    }
                    return;
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void txtAmountOfProductExportDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void txtAmountOfProductExportDetail_Click(object sender, EventArgs e)
        {
            txtAmountOfProductExportDetail.Text = "";
        }

        private void cmbIDProductDetailStore_TextChanged_1(object sender, EventArgs e)
        {
            cmbUnitCalculator.Text = SaleInvoiceDetails_BUS.TimDonViSanPham(cmbIDProductDetailStore.Text.ToString());

        }

        private void txtAmountOfProductExportDetail_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (txtAmountOfProductExportDetail.Text == "")
                num = 0;
            else
                num = Convert.ToInt32(txtAmountOfProductExportDetail.Text.ToString());
            int num1 = Convert.ToInt32(SaleInvoiceDetails_BUS.SoLuongMax(cmbIDProductDetailStore.Text.ToString()));
            if (num < 0)
                XtraMessageBox.Show("Số lượng sản phẩm nhỏ hơn 0 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (num > num1)
                XtraMessageBox.Show("Sản phẩm trong Cửa hàng không đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        #endregion
        */

        private void ClearDisplay1()
        {
            cmbIDProductDetailStore.Text = "";
            cmbProductName.Text = "";
            txtQuantity.Text = "";
            txtTransPrice.Text = "";
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
    }
}
