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
            dtgvAgencyInfoList.CellClick += new DataGridViewCellEventHandler(dtgvAgencyInfoList_CellClick);
            //dtgvAgencyInfoList.Click += new EventHandler(dtgvAgencyInfoList_Click);
            btnAddAgency.Click += new EventHandler(btnAddAgency_Click);
            btnUpdateUnit.Click += new EventHandler(btnUpdateUnit_Click);
            btnDeleteAgency.Click += new EventHandler(btnDeleteAgency_Click);
            txtIDAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([UnitID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Unit]"));
        }

        private void dtgvAgencyInfoList_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvAgencyInfoList.SelectedRows[0];
            txtIDAgency.Text = Convert.ToString(dr.Cells["UnitID"].Value);
            txtNameAgency.Text = Convert.ToString(dr.Cells["UnitName"].Value);
            txtAddressOfAgency.Text = Convert.ToString(dr.Cells["UnitPrice"].Value);
        }

        private void dtgvAgencyInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtIDAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["UnitID"].Value);
                txtNameAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["UnitName"].Value);
                txtAddressOfAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["UnitPrice"].Value);
            }
        }

        public void LoadUnitList()
        {
            List<Unit_DTO> unit = Unit_BUS.LoadUnit();
            dtgvAgencyInfoList.DataSource = unit;
        }

        private void btnAddAgency_Click(object sender, EventArgs e)
        {
            try
            {
                Unit_DTO unit = new Unit_DTO();
                unit.UnitID = txtIDAgency.Text;
                unit.UnitName = txtNameAgency.Text;
                unit.UnitPrice = txtAddressOfAgency.Text;

                if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "")
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
                unit.UnitID = dtgvAgencyInfoList.CurrentRow.Cells["UnitID"].Value.ToString();
                unit.UnitName = txtNameAgency.Text;
                //unit.UnitPrice = txtAddressOfAgency.Text;

                if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "")
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

        public void btnDeleteAgency_Click(object sender, EventArgs e)
        {
            try
            {
                Unit_DTO unit = new Unit_DTO();
                unit.UnitID = dtgvAgencyInfoList.CurrentRow.Cells["UnitID"].Value.ToString();
                unit.UnitName = txtNameAgency.Text;

                if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "")
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
            txtIDAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([UnitID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Unit]"));
            txtNameAgency.Text = "";
            txtAddressOfAgency.Text = "";

        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void txtAddressOfAgency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
