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
    public partial class uctService : UserControl
    {
        public uctService()
        {
            InitializeComponent();
        }

        public static uctService uctServiceInfo = new uctService();


        private void uctService_Load(object sender, EventArgs e)
        {
            ServiceData();
        }

        #region Service
        private void ServiceData()
        {
            LoadServiceList();
            dtgvServiceInfoList.CellClick += new DataGridViewCellEventHandler(dtgvUnitInfoList_CellClick);

            btnAddService.Click += new EventHandler(btnAddService_Click);
            btnUpdateService.Click += new EventHandler(btnUpdateService_Click);
            btnDeleteService.Click += new EventHandler(btnDeleteService_Click);

            txtServiceID.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([ServiceID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Service]"));
        }

        private void dtgvUnitInfoList_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvServiceInfoList.SelectedRows[0];
            txtServiceID.Text = Convert.ToString(dr.Cells["ServiceID"].Value);
            txtServiceName.Text = Convert.ToString(dr.Cells["ServiceName"].Value);
            txtServicePrice.Text = Convert.ToString(dr.Cells["ServicePrice"].Value);
        }

        private void dtgvUnitInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtServiceID.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["ServiceID"].Value);
                txtServiceName.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["ServiceName"].Value);
                txtServicePrice.Text = Convert.ToString(dtgvServiceInfoList.CurrentRow.Cells["ServicePrice"].Value);
            }
        }

        public void LoadServiceList()
        {
            List<Service_DTO> service = Service_BUS.LoadService();
            dtgvServiceInfoList.DataSource = service;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Service_DTO service = new Service_DTO();
                service.ServiceID = txtServiceID.Text;
                service.ServiceName = txtServiceName.Text;
                service.ServicePrice = float.Parse(txtServicePrice.Text);

                if (txtServiceID.Text == "" || txtServiceName.Text == "" || txtServicePrice.Text == "")
                {
                    XtraMessageBox.Show("You have to fullfill service information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Service_BUS.InsertService(service))
                {
                    XtraMessageBox.Show("Service Info has been inserted sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServiceList();
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

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            try
            {

                Service_DTO service = new Service_DTO();
                service.ServiceID = dtgvServiceInfoList.CurrentRow.Cells["ServiceID"].Value.ToString();
                service.ServiceName = txtServiceName.Text;
                service.ServicePrice = float.Parse(txtServicePrice.Text);

                if (txtServiceID.Text == "" || txtServiceName.Text == "" || txtServicePrice.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one service to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Service_BUS.UpdateService(service))
                {
                    XtraMessageBox.Show("Service Info has been updated sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServiceList();
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

        public void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                Service_DTO service = new Service_DTO();
                service.ServiceID = dtgvServiceInfoList.CurrentRow.Cells["ServiceID"].Value.ToString();
                service.ServiceName = txtServiceName.Text;

                if (txtServiceID.Text == "" || txtServiceName.Text == "" || txtServicePrice.Text == "")
                {
                    XtraMessageBox.Show("You have to choose at least one service to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (Service_BUS.DeleteService(service))
                {
                    LoadServiceList();
                    XtraMessageBox.Show("Service Info has been deleted sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Delete Info Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearDisplay()
        {
            txtServiceID.Text = DataProvider.ExcuteScalar(string.Format("SELECT ISNULL(MAX([ServiceID]), 0)+1 FROM [JEWELRYSTOREMGMT].[dbo].[Service]"));
            txtServiceName.Text = "";
            txtServicePrice.Text = "";

        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void txtServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
