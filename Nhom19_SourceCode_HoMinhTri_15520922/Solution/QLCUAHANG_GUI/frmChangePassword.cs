using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLCUAHANG_DAL;

namespace QLCUAHANG_GUI
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        static public string NameLog = Properties.Settings.Default.NameLog;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == string.Empty || txtOldPass.Text == string.Empty || txtRegisPass.Text == string.Empty)
                XtraMessageBox.Show("Please fullfill your information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (txtOldPass.Text != Properties.Settings.Default.PassLog) lbOld.Text = "Old password is not correct!";
            else
                if (txtNewPass.Text != txtRegisPass.Text) return;
            else
                if (txtOldPass.Text == txtNewPass.Text) return;
            else
            {
                try
                {
                    SqlConnection cnn = DataProvider.OpenConnection();
                    SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateUserPassword]", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = NameLog;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtNewPass.Text;
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    XtraMessageBox.Show("Change password failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRegisPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtRegisPass.Text)
            {
                lbNew.ForeColor = Color.Red;
                lbNew.Text = "Not match!";
            }
            else if (txtNewPass.Text == txtRegisPass.Text)
            {
                lbNew.Text = "Match";
                lbNew.ForeColor = Color.Green;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtOldPass.Text) lbCheck.Text = "New password must be different from the old one.";
            else
                lbCheck.Text = "";
            if (txtNewPass.Text != txtRegisPass.Text) lbNew.Text = "";
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}