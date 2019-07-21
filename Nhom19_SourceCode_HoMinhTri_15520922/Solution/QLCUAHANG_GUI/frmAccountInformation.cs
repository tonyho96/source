using DevExpress.XtraEditors;
using QLCUAHANG_DAL;
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
    public partial class frmAccountInformation : Form
    {
        public frmAccountInformation()
        {
            InitializeComponent();
        }

        private void frmAccountInformation_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DataProvider.OpenConnection();
                string query = string.Format("EXEC [JEWELRYSTOREMGMT].[dbo].[usp_loadUserInfo] @UserName = '" + frmLogin.UserName + "'");
                DataTable dt = DataProvider.GetDataTable(query, con);

                if (dt.Rows.Count == 0)
                {
                    return;
                }

                txtUser.Text = dt.Rows[0]["UserName"].ToString();
                txtPosition.Text = dt.Rows[0]["Role"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtNumberPhone.Text = dt.Rows[0]["PhoneNo"].ToString();

                if (dt.Rows[0]["Role"].ToString() != "Admin")
                {
                    txtPosition.Items.Remove("Admin");
                    txtPosition.DropDownStyle = ComboBoxStyle.Simple;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
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
                XtraMessageBox.Show("Update Informaion Sucessfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                DataProvider.CloseConnection(con);
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
