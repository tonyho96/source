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
    public partial class uctProductCategory : UserControl
    {
        public uctProductCategory()
        {
            InitializeComponent();
        }
        public static uctProductCategory uctProductCategoryInfo = new uctProductCategory();
        

        private void uctProductCategory_Load(object sender, EventArgs e)
        {
            CategoryData();
        }

        #region Category
        private void CategoryData()
        {
            LoadCategoryList();
            dtgvCategoryInfoList.CellClick += new DataGridViewCellEventHandler(dtgvCategoryInfoList_CellClick);
            btnInsertCategory.Click += new EventHandler(btnInsertCategory_Click);
            btnUpdateCategory.Click += new EventHandler(btnUpdateCategory_Click);
            btnDeleteCategory.Click += new EventHandler(btnDeleteCategory_Click);
            txtCategoryID.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([ProductCategoryID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[ProductCategory]"));
        }

        private void dtgvCategoryInfoList_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvCategoryInfoList.SelectedRows[0];
            txtCategoryID.Text = Convert.ToString(dr.Cells["ProductCategoryID"].Value);
            txtCategoryName.Text = Convert.ToString(dr.Cells["ProductCategoryName"].Value);
            txtPercentRevenue.Text = Convert.ToString(dr.Cells["PercentRevenue"].Value);
        }

        private void dtgvCategoryInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtCategoryID.Text = Convert.ToString(dtgvCategoryInfoList.CurrentRow.Cells["ProductCategoryID"].Value);
                txtCategoryName.Text = Convert.ToString(dtgvCategoryInfoList.CurrentRow.Cells["ProductCategoryName"].Value);
                txtPercentRevenue.Text = Convert.ToString(dtgvCategoryInfoList.CurrentRow.Cells["PercentRevenue"].Value);
            }
        }

        public void LoadCategoryList()
        {
            List<ProductCategory_DTO> category = ProductCategory_BUS.LoadProductCategory();
            dtgvCategoryInfoList.DataSource = category;
        }

        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            try
            {
                ProductCategory_DTO category = new ProductCategory_DTO();
                category.ProductCategoryID = txtCategoryID.Text;
                category.ProductCategoryName = txtCategoryName.Text;
                category.PercentRevenue = float.Parse(txtPercentRevenue.Text);

                if (txtCategoryID.Text == "" || txtCategoryName.Text == "" || txtPercentRevenue.Text == "")
                {
                    XtraMessageBox.Show("You have to fullfill category information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (ProductCategory_BUS.InsertProductCategory(category))
                {
                    XtraMessageBox.Show("Category Info has been inserted sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoryList();
                    ClearDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Insert Info Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {

                ProductCategory_DTO category = new ProductCategory_DTO();
                category.ProductCategoryID = dtgvCategoryInfoList.CurrentRow.Cells["ProductCategoryID"].Value.ToString();
                category.ProductCategoryName = txtCategoryName.Text;
                category.PercentRevenue = float.Parse(txtPercentRevenue.Text);

                if (txtCategoryID.Text == "" || txtCategoryName.Text == "" || txtPercentRevenue.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one category to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (ProductCategory_BUS.UpdateProductCategory(category))
                {
                    XtraMessageBox.Show("Category Info has been updated sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoryList();
                    ClearDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Update Info Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                ProductCategory_DTO category = new ProductCategory_DTO();
                category.ProductCategoryID = dtgvCategoryInfoList.CurrentRow.Cells["ProductCategoryID"].Value.ToString();
                category.ProductCategoryName = txtCategoryName.Text;

                if (txtCategoryID.Text == "" || txtCategoryName.Text == "" || txtPercentRevenue.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one category to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (ProductCategory_BUS.DeleteProductCategory(category))
                {
                    LoadCategoryList();
                    XtraMessageBox.Show("Category Info has been deleted sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Delete Info Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearDisplay()
        {
            txtCategoryID.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([ProductCategoryID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[ProductCategory]"));
            txtCategoryName.Text = "";
            txtPercentRevenue.Text = "";
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void txtPercentRevenue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}