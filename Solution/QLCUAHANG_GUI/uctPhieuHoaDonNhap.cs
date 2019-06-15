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
    public partial class uctPhieuHoaDonNhap : UserControl
    {
        public uctPhieuHoaDonNhap()
        {
            InitializeComponent();
        }
        public static uctPhieuHoaDonNhap uctPHN = new uctPhieuHoaDonNhap();
        private void uctPhieuHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadDataBillImport();
            LoadDataBillDetailImport();
        }


        #region Hóa đơn nhập hàng
        private void LoadDataBillImport()
        {
            btnAddImportBill.Click += new EventHandler(btnAddImportBill_Click);
            dtgvInfoListOfBillImport.CellClick += new DataGridViewCellEventHandler(dtgvInfoListOfBillImport_CellClick);
            btnUpdateBillImport.Click += new EventHandler(btnUpdateBillImport_Click);
            btnDeleteBillImport.Click += new EventHandler(btnDeleteBillImport_Click);
            LoadMaDL();

            //LoadPhieuNhapHang();
            GetPostInvoice();
            //txtTotalDebt.KeyPress += new KeyPressEventHandler(txtTotalDebt_KeyPress);
            //txtTotalPay.KeyPress += new KeyPressEventHandler(txtTotalPay_KeyPress);

            txtIDBillImport.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([TransID]),0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Transaction]"));

            //txtTotalDebt.Text = "0";
            //txtTotalPay.Text = "0";
        }
        private void LoadPhieuNhapHang()
        {
            List<HoaDonNhapHang_DTO> listPhieuNhap = HoaDonNhapHang_BUS.LoadPhieuNhap();
            dtgvInfoListOfBillImport.DataSource = listPhieuNhap;
        }
        private void GetPostInvoice()
        {
            txtIDBillImport.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([TransID]),0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Transaction]"));
            List<PostInvoice_DTO> PostInvoiceList = HoaDonNhapHang_BUS.PostInvoiceLoad();
            dtgvInfoListOfBillImport.DataSource = PostInvoiceList;
            dtgvInfoListOfBillImport.Columns["VendorID"].Visible = false;
            dtgvInfoListOfBillImport.Columns["TransID"].HeaderText = "Transaction ID";
            dtgvInfoListOfBillImport.Columns["VendorName"].HeaderText = "Vendor Name";
            dtgvInfoListOfBillImport.Columns["PhoneNo"].HeaderText = "Phone No.";
            dtgvInfoListOfBillImport.Columns["CreateDate"].HeaderText = "Create Date";
            dtgvInfoListOfBillImport.Columns["TotalPrice"].HeaderText = "Total";
        }
        private void LoadMaDL()
        {
            List<Vendor_DTO> LoadVendor = Vendor_BUS.LoadVendor();
            //List<C>
            cmbIDAgency.DataSource = LoadVendor;
            cmbIDAgency.ValueMember = "VendorID";
            cmbIDAgency.DisplayMember = "VendorName";
            txtVendorId.Text = cmbIDAgency.SelectedValue.ToString();
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

                if (HoaDonNhapHang_BUS.InsertPostInvoice(postInvoice))
                {
                    XtraMessageBox.Show("Insert Post Invoice Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbIDBillImportDetail.Text = txtIDBillImport.Text;
                    ClearDisplay();

                    uctVendor.uctVendorInfo.LoadVendorList();
                    uctQuanLiTienNoDaiLi.uctQLTienNoDL.Load_DSNoDaiLi();
                    //LoadPhieuNhapHang();
                    GetPostInvoice();
                    LoadMaHD();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Thêm hóa đơn nhập hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void dtgvInfoListOfBillImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                txtIDBillImport.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TransID"].Value);
                txtVendorId.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["VendorID"].Value);
                cmbIDAgency.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["VendorName"].Value);
                //txtTotalDebt.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TongNo"].Value);
                //txtTotalPay.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TongTien"].Value);
                dtpkDateTimeImport.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["CreateDate"].Value);
                cmbIDBillImportDetail.Text = txtIDBillImport.Text;
            }
        }

        private void btnUpdateBillImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillImport.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn phiếu cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                HoaDonNhapHang_DTO phieunhap = new HoaDonNhapHang_DTO();
                phieunhap.MaHDN = (string)dtgvInfoListOfBillImport.CurrentRow.Cells["MaHDN"].Value;
                phieunhap.MaDL = cmbIDAgency.Text.ToString();
                phieunhap.NgayNhap = Convert.ToDateTime(dtpkDateTimeImport.Text.ToString());
                phieunhap.TenDL = txtVendorId.Text;
                //phieunhap.TongTien = Convert.ToDouble(txtTotalPay.Text.ToString());
                //phieunhap.TongNo = Convert.ToDouble(txtTotalDebt.Text.ToString());

                if (HoaDonNhapHang_BUS.SuaPHNhap(phieunhap))
                {
                    GetPostInvoice();
                    //LoadPhieuNhapHang();
                    LoadMaHD();
                    uctVendor.uctVendorInfo.LoadVendorList();
                    uctQuanLiTienNoDaiLi.uctQLTienNoDL.Load_DSNoDaiLi();
                    XtraMessageBox.Show("Phiếu nhập hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Phiếu nhập hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnDeleteBillImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillImport.Text == "")
            {
                XtraMessageBox.Show("Bạn phải chọn phiếu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HoaDonNhapHang_DTO phieunhap = new HoaDonNhapHang_DTO();
            phieunhap.MaHDN = (string)dtgvInfoListOfBillImport.CurrentRow.Cells["MaHDN"].Value;

            
                if (HoaDonNhapHang_BUS.XoaPHNhap(phieunhap))
                {
                    GetPostInvoice();
                    //LoadPhieuNhapHang();
                    LoadMaHD();
                    uctVendor.uctVendorInfo.LoadVendorList();
                    uctQuanLiTienNoDaiLi.uctQLTienNoDL.Load_DSNoDaiLi();
                    XtraMessageBox.Show("Phiếu nhập hàng xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearDisplay()
        {
            txtIDBillImport.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaHDN=dbo.fcGetMaHDN()"));
            txtVendorId.Text = "";
            //txtTotalPay.Text = "";
            //txtTotalDebt.Text = "";
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

        private void txtTotalDebt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbIDAgency_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DataProvider.OpenConnection();
                string query = string.Format("EXEC dbo.TimTenDL @MaDL = N'" + cmbIDAgency.Text + "'");
                DataTable dt = DataProvider.GetDataTable(query, con);
                if (dt.Rows.Count == 0)
                    txtVendorId.Text = "";
                else
                    txtVendorId.Text = dt.Rows[0]["TenDL"].ToString();
                return;
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Chi tiết hóa đơn nhập
        private void LoadDataBillDetailImport()
        {
            btnAddProductImportDetail.Click += new EventHandler(btnAddProductImportDetail_Click);
            dtgvListOfDetailProductImport.CellClick += new DataGridViewCellEventHandler(dtgvListOfDetailProductImport_CellClick);
            btnUpdateProductImportDetail.Click += new EventHandler(btnUpdateProductImportDetail_Click);
            btnDeleteProductImportDetail.Click += new EventHandler(btnDeleteProductImportDetail_Click);
            txtAmountOfProductImportDetail.KeyPress += new KeyPressEventHandler(txtAmountOfProductImportDetail_KeyPress);

            LoadChiTietPhieuNhapHang();
            LoadMaSP();
            LoadMaHD();
            
        }
        private void LoadChiTietPhieuNhapHang()
        {
            List<ChiTietHoaDonNhap_DTO> listChiTietPhieuNhap = ChiTietHoaDonNhap_BUS.LoadChiTietPhieuNhap();
            dtgvListOfDetailProductImport.DataSource = listChiTietPhieuNhap;
        }
        private void LoadMaHD()
        {
            List<HoaDonNhapHang_DTO> hoadon = HoaDonNhapHang_BUS.LoadPhieuNhap();

            cmbIDBillImportDetail.DataSource = hoadon;
            cmbIDBillImportDetail.ValueMember = "MaHDN";
            cmbIDBillImportDetail.DisplayMember = "MaHDN";

        }
        private void LoadMaSP()
        {
            List<SanPhamDL_DTO> sanpham = SanPhamDL_BUS.LoadSanPhamDL();

            cmbIDProductDetailStore.DataSource = sanpham;
            cmbIDProductDetailStore.ValueMember = "MaSPDL";
            cmbIDProductDetailStore.DisplayMember = "MaSPDL";
        }

        private void btnAddProductImportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDBillImportDetail.Text == "" || cmbIDProductDetailStore.Text == "" || txtAmountOfProductImportDetail.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ChiTietHoaDonNhap_DTO phieunhap = new ChiTietHoaDonNhap_DTO();
                phieunhap.MaHDN = cmbIDBillImportDetail.Text;
                phieunhap.MaSPDL = cmbIDProductDetailStore.Text;
                phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductImportDetail.Text.ToString());

                if (ChiTietHoaDonNhap_BUS.ThemChiTietPHNhap(phieunhap))
                {
                    GetPostInvoice();
                    //LoadPhieuNhapHang();
                    LoadChiTietPhieuNhapHang();
                    XtraMessageBox.Show("Thêm chi tiết phiếu nhập hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    uctSanPhamCH.uctSPCH.LoadSanPhamCH1();
                    ClearDisplay1();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Sản phẩm đã tồn tại trong Hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dtgvListOfDetailProductImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbIDProductDetailStore.Text = "";
                cmbIDProductDetailStore.Text = "";
                if (e.RowIndex >=0 && e.ColumnIndex >= 0)
                {
                    cmbIDBillImportDetail.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["MaHDN1"].Value.ToString());
                    cmbIDProductDetailStore.Text = dtgvListOfDetailProductImport.CurrentRow.Cells["MaSPDL"].Value.ToString();
                    txtAmountOfProductImportDetail.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["SoLuong"].Value);
                }
                else
                    return;
            }
            catch
            {
                return;
            }
        }

        private void btnUpdateProductImportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDBillImportDetail.Text == "" || cmbIDProductDetailStore.Text == "" || txtAmountOfProductImportDetail.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn chi tiết phiếu cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbIDBillImportDetail.Text != (string)dtgvListOfDetailProductImport.CurrentRow.Cells["MaHDN1"].Value || cmbIDProductDetailStore.Text != (string)dtgvListOfDetailProductImport.CurrentRow.Cells["MaSPDL"].Value)
                {
                    XtraMessageBox.Show("Chi tiết phiếu nhập hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ChiTietHoaDonNhap_DTO phieunhap = new ChiTietHoaDonNhap_DTO();
                phieunhap.MaHDN = (string)dtgvListOfDetailProductImport.CurrentRow.Cells["MaHDN1"].Value;
                phieunhap.MaSPDL = cmbIDProductDetailStore.Text;
                phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductImportDetail.Text.ToString());


                if (ChiTietHoaDonNhap_BUS.SuaChiTietPHNhap(phieunhap))
                {
                    GetPostInvoice();
                    //LoadPhieuNhapHang();
                    LoadChiTietPhieuNhapHang();
                    uctSanPhamCH.uctSPCH.LoadSanPhamCH1();

                    XtraMessageBox.Show("Chi tiết phiếu nhập hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (cmbIDBillImportDetail.Text == "" || txtAmountOfProductImportDetail.Text == "" || cmbIDProductDetailStore.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn chi tiết phiếu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ChiTietHoaDonNhap_DTO phieunhap = new ChiTietHoaDonNhap_DTO();
                phieunhap.MaHDN = (string)dtgvListOfDetailProductImport.CurrentRow.Cells["MaHDN1"].Value;
                phieunhap.MaSPDL = cmbIDProductDetailStore.Text;


                if (ChiTietHoaDonNhap_BUS.XoaChiTietPHNhap(phieunhap))
                {
                    GetPostInvoice();
                    //LoadPhieuNhapHang();
                    LoadChiTietPhieuNhapHang();
                    uctSanPhamCH.uctSPCH.LoadSanPhamCH1();
                    XtraMessageBox.Show("Chi tiết hóa đơn xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay1();
                    if (dtgvListOfDetailProductImport.Rows.Count == 0)
                    {
                        dtgvListOfDetailProductImport.ColumnCount = 3;
                        dtgvListOfDetailProductImport.ColumnHeadersVisible = true;
                        dtgvListOfDetailProductImport.Columns[0].Name = "MaHDN1";
                        dtgvListOfDetailProductImport.Columns[1].Name = "MaSPDL";
                        dtgvListOfDetailProductImport.Columns[2].Name = "SoLuong";

                        dtgvListOfDetailProductImport.Columns[0].DataPropertyName = "MaHDN";
                        dtgvListOfDetailProductImport.Columns[1].DataPropertyName = "MaSPDL";
                        dtgvListOfDetailProductImport.Columns[2].DataPropertyName = "SoLuong";

                        dtgvListOfDetailProductImport.Columns[0].HeaderText = "Mã HD nhập";
                        dtgvListOfDetailProductImport.Columns[1].HeaderText = "Mã SP Đại lí";
                        dtgvListOfDetailProductImport.Columns[2].HeaderText = "Số lượng";

                        dtgvListOfDetailProductImport.Columns[0].Width = 140;
                        dtgvListOfDetailProductImport.Columns[1].Width = 140;
                        dtgvListOfDetailProductImport.Columns[2].Width = 125;
                    }
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
            txtAmountOfProductImportDetail.Text = "";
        }

        private void txtAmountOfProductImportDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        //private void txtTotalDebt_Click(object sender, EventArgs e)
        //{
        //    txtTotalDebt.Text = "";
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void lbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay1();
        }

        private void txtTotalPay_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotalDebt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAmountOfProductImportDetail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAmountOfProductImportDetail_Click(object sender, EventArgs e)
        {
            txtAmountOfProductImportDetail.Text = "";
        }

        private void CmbIDAgency_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVendorId.Text = cmbIDAgency.SelectedValue.ToString();
        }
    }
}