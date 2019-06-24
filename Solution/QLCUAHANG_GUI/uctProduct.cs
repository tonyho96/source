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
using System.IO;
using QLCUAHANG_DAL;
using System.Data.SqlClient;
using QLCUAHANG_GUI.Properties;
using System.Web;
using System.Drawing.Imaging;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctProduct : UserControl
    {
        public uctProduct()
        {
            InitializeComponent();
        }

        public static uctProduct uctSPCH = new uctProduct();

        private void uctProduct_Load(object sender, EventArgs e)
        {
            LoadDataStore();
        }

        private void LoadDataStore()
        {
            LoadVendor();
            LoadProductCategory();
            LoadUnit();

            LoadProductList();

            dtgvProductListOfStore.CellClick += new DataGridViewCellEventHandler(dtgvProductListOfStore_CellClick);

            //btnUpdateProductStore.Click += new EventHandler(btnUpdateProductStore_Click);
            //btnDeleteProductStore.Click += new EventHandler(btnDeleteProductStore_Click);

            txtQuantity.KeyPress += new KeyPressEventHandler(txtQuantity_KeyPress);
            txtImportPrice.KeyPress += new KeyPressEventHandler(txtImportPrice_KeyPress);
            txtWeight.KeyPress += new KeyPressEventHandler(txtWeight_KeyPress);
        }

        public void LoadProductList()
        {
            List<Product_DTO> productList = Product_BUS.LoadProduct();
            dtgvProductListOfStore.DataSource = productList;
        }

        private void LoadVendor()
        {
            List<Vendor_DTO> loadVendor = Vendor_BUS.LoadVendor();
            cmbVendor.DataSource = loadVendor;
            cmbVendor.ValueMember = "VendorID";
            cmbVendor.DisplayMember = "VendorName";
        }

        private void LoadProductCategory()
        {
            List<ProductCategory_DTO> loadCategory = ProductCategory_BUS.LoadProductCategory();
            cmbCategory.DataSource = loadCategory;
            cmbCategory.ValueMember = "ProductCategoryID";
            cmbCategory.DisplayMember = "ProductCategoryName";
        }

        private void LoadUnit()
        {
            List<Unit_DTO> loadUnit = Unit_BUS.LoadUnit();
            cmbUnit.DataSource = loadUnit;
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DisplayMember = "UnitName";
        }

        private void ClearDisplay()
        {
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtWeight.Text = "";
            txtImportPrice.Text = "";
        }

        private void dtgvProductListOfStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtProductID.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["ProductID"].Value);
                txtProductName.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["ProductName"].Value);
                cmbVendor.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["VendorName"].Value);
                cmbCategory.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["ProductCategoryName"].Value);
                cmbUnit.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["UnitName"].Value);
                txtQuantity.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["Quantity"].Value);
                txtWeight.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["Weight"].Value);
                txtImportPrice.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["ImportPrice"].Value);
            }
        }
       
        /*private void btnUpdateProductStore_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtNameProductCH.Text == "" || cmbUnit.Text == "" || txtImportPrice.Text == "" || txtQuantity.Text == "")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }
            try
            {

                Product_DTO product = new Product_DTO();
                product.ProductID = txtProductID.Text;
                product.ProductName = txtNameProductCH.Text;

                product.VendorID = cmbUnit.Text;
                product.ProductCategoryID = txtImportPrice.Text.ToString();
                product.ImportPrice = float.Parse(txtQuantity.Text.ToString());

                if (Product_BUS.SuaSPCH(product))
                {
                    XtraMessageBox.Show("Sửa thông tin Sản phẩm trong Cửa hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSanPhamCH1();
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

        public void btnDeleteProductStore_Click(object sender, EventArgs e)
        {

            if (txtProductID.Text == "" || txtNameProductCH.Text == "" || cmbUnit.Text == "" || txtImportPrice.Text == "" || txtQuantity.Text == "")
            {
                XtraMessageBox.Show("Bạn phải chọn Sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }
            try
            {
                Product_DTO product = new Product_DTO();
                product.ProductID = txtProductID.Text;
                if (Product_BUS.XoaSPCH(product))
                {
                    LoadSanPhamCH1();
                    XtraMessageBox.Show("Xóa Sản phẩm trong Cửa hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }*/

        private void txtAmountOfProductCH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtImportPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}