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
    public partial class uctUnit : UserControl
    {
        public uctUnit()
        {
            InitializeComponent();
        }

        public static uctUnit uctUnitInfo = new uctUnit();


        private void uctUnit_Load(object sender, EventArgs e)
        {
            UnitData();
        }

        #region Unit
        private void UnitData()
        {
            LoadUnitList();
            dtgvUnitInfoList.CellClick += new DataGridViewCellEventHandler(dtgvUnitInfoList_CellClick);
            //dtgvAgencyInfoList.Click += new EventHandler(dtgvAgencyInfoList_Click);
            btnAddUnit.Click += new EventHandler(btnAddUnit_Click);
            btnUpdateUnit.Click += new EventHandler(btnUpdateUnit_Click);
            btnDeleteUnit.Click += new EventHandler(btnDeleteUnit_Click);
            txtIDUnit.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([UnitID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Unit]"));
        }

        private void dtgvUnitInfoList_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvUnitInfoList.SelectedRows[0];
            txtIDUnit.Text = Convert.ToString(dr.Cells["UnitID"].Value);
            txtNameUnit.Text = Convert.ToString(dr.Cells["UnitName"].Value);
            txtUnitPrice.Text = Convert.ToString(dr.Cells["UnitPrice"].Value);
        }

        private void dtgvUnitInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtIDUnit.Text = Convert.ToString(dtgvUnitInfoList.CurrentRow.Cells["UnitID"].Value);
                txtNameUnit.Text = Convert.ToString(dtgvUnitInfoList.CurrentRow.Cells["UnitName"].Value);
                txtUnitPrice.Text = Convert.ToString(dtgvUnitInfoList.CurrentRow.Cells["UnitPrice"].Value);
            }
        }

        public void LoadUnitList()
        {
            List<Unit_DTO> unit = Unit_BUS.LoadUnit();
            dtgvUnitInfoList.DataSource = unit;
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            try
            {
                Unit_DTO unit = new Unit_DTO();
                unit.UnitID = txtIDUnit.Text;
                unit.UnitName = txtNameUnit.Text;
                unit.UnitPrice = txtUnitPrice.Text;

                if (txtIDUnit.Text == "" || txtNameUnit.Text == "" || txtUnitPrice.Text == "")
                {
                    XtraMessageBox.Show("You have to fullfill unit information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Unit_BUS.InsertUnit(unit))
                {
                    XtraMessageBox.Show("Unit Info has been inserted sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUnitList();
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

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            try
            {

                Unit_DTO unit = new Unit_DTO();
                unit.UnitID = dtgvUnitInfoList.CurrentRow.Cells["UnitID"].Value.ToString();
                unit.UnitName = txtNameUnit.Text;
                unit.UnitPrice = txtUnitPrice.Text;

                if (txtIDUnit.Text == "" || txtNameUnit.Text == "" || txtUnitPrice.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one unit to update!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Unit_BUS.UpdateUnit(unit))
                {
                    XtraMessageBox.Show("Unit Info has been updated sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUnitList();
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

        public void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            try
            {
                Unit_DTO unit = new Unit_DTO();
                unit.UnitID = dtgvUnitInfoList.CurrentRow.Cells["UnitID"].Value.ToString();
                unit.UnitName = txtNameUnit.Text;

                if (txtIDUnit.Text == "" || txtNameUnit.Text == "" || txtUnitPrice.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one unit to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Unit_BUS.DeleteUnit(unit))
                {
                    LoadUnitList();
                    XtraMessageBox.Show("Unit Info has been deleted sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Delete Info Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearDisplay()
        {
            txtIDUnit.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([UnitID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Unit]"));
            txtNameUnit.Text = "";
            txtUnitPrice.Text = "";

        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
