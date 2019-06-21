using DevExpress.XtraEditors;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_DAL
{
    public class Unit_DAL
    {
        public static List<Unit_DTO> LoadUnit()
        {
            List<Unit_DTO> listUnit = new List<Unit_DTO>();
            SqlConnection con = DataProvider.OpenConnection();

            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getUnitList]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Unit_DTO unit = new Unit_DTO();
                unit.UnitID = dt.Rows[i]["UnitID"].ToString();
                unit.UnitName = dt.Rows[i]["UnitName"].ToString();
                unit.UnitPrice = dt.Rows[i]["UnitPrice"].ToString();

                listUnit.Add(unit);
            }
            DataProvider.CloseConnection(con);

            return listUnit;
        }

        public static bool InsertUnit(Unit_DTO unit)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertUnit]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@UnitName", unit.UnitName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@UnitPrice", unit.UnitPrice);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
                DataProvider.CloseConnection(con);
                return true;
            }
            catch
            {
                DataProvider.CloseConnection(con);
                return false;
            }
        }

        public static bool UpdateUnit(Unit_DTO unit)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateUnit]", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@UnitID", unit.UnitID);
                p = new SqlParameter("@UnitName", unit.UnitName);
                cmd.Parameters.Add(p);
                //p = new SqlParameter("@UnitPrice", unit.UnitPrice);
                //cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
                DataProvider.CloseConnection(con);
                return true;
            }
            catch
            {
                DataProvider.CloseConnection(con);
                return false;
            }
        }

        public static bool DeleteUnit(Unit_DTO unit)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteUnit]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@UnitID", unit.UnitID);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
                DataProvider.CloseConnection(con);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }
    }
}
