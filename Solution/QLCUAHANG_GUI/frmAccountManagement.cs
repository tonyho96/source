using DevExpress.XtraEditors;
using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_GUI
{
    public partial class frmAccountManagement : Form
    {
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                SqlConnection con = DataProvider.OpenConnection();

                DataTable dt = DataProvider.GetDataTable("[JEWELRYSTOREMGMT].[dbo].[usp_getUserList]", con);

                List<User_DTO> dsUser = new List<User_DTO>();

                if (dt.Rows.Count == 0)
                {
                    return;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    User_DTO us = new User_DTO();
                    us.UserID = Convert.ToInt32(dt.Rows[i]["UserID"].ToString());
                    us.UserName = dt.Rows[i]["UserName"].ToString();
                    us.Role = dt.Rows[i]["Role"].ToString();
                    us.PhoneNo = dt.Rows[i]["PhoneNo"].ToString();
                    us.Address = dt.Rows[i]["Address"].ToString();

                    dsUser.Add(us);
                }
                DataProvider.CloseConnection(con);
                dtgvListUser.DataSource = dsUser;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay();
        }

        private void ClearDisplay()
        {
            txtUser.Text = "";
            txtPosition.Text = "";
            txtAddress.Text = "";
            txtNumberPhone.Text = "";
        }

        private void dtgvListUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtUser.Text = Convert.ToString(dtgvListUser.CurrentRow.Cells["UserName"].Value);
                txtPosition.Text = Convert.ToString(dtgvListUser.CurrentRow.Cells["Role"].Value);
                txtAddress.Text = Convert.ToString(dtgvListUser.CurrentRow.Cells["Address"].Value);
                txtNumberPhone.Text = Convert.ToString(dtgvListUser.CurrentRow.Cells["PhoneNo"].Value);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                XtraMessageBox.Show("You have to choose at least one account to update?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateUser]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@UserName", txtUser.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Role", txtPosition.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Address", txtAddress.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@PhoneNo", txtNumberPhone.Text);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                XtraMessageBox.Show("Update account sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearDisplay();
                return;
            }
            catch(Exception ex)
            {
                DataProvider.CloseConnection(con);
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                XtraMessageBox.Show("You have to choose at least one account to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteUser]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@UserName", txtUser.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CurrentUserName", frmLogin.UserName);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                XtraMessageBox.Show("Delete Account Sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearDisplay();
                return;
            }
            catch(Exception ex)
            {
                DataProvider.CloseConnection(con);
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
