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
   public  class ChiTietHoaDonNhap_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;
        public static bool ThemChiTietPHNhapHang(ChiTietHoaDonNhap_DTO phieu)
        {
            SqlConnection con = DataProvider.OpenConnection();
            cmd = new SqlCommand("ThemChiTietPHNhap", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieu.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaSPDL", phieu.MaSPDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuong", phieu.SoLuong);
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

        public static List<ChiTietHoaDonNhap_DTO> LoadChiTietPhieuNhap()
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("DSChiTietPhieuNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();

                da.Fill(dt);

            }
            catch
            {
                return null;
            }

            if (dt.Rows.Count == 0)
                return null;

            List<ChiTietHoaDonNhap_DTO> dsChiTietPhieuNhap = new List<ChiTietHoaDonNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHoaDonNhap_DTO phieuhang = new ChiTietHoaDonNhap_DTO();
                phieuhang.MaHDN = dt.Rows[i]["MaHDN"].ToString();
                phieuhang.MaSPDL = dt.Rows[i]["MaSPDL"].ToString();
                phieuhang.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"].ToString());

                dsChiTietPhieuNhap.Add(phieuhang);
            }
            DataProvider.CloseConnection(con);
            return dsChiTietPhieuNhap;
        }

        public static bool SuaChiTietPhieuHangNhap(ChiTietHoaDonNhap_DTO phieuhang)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("SuaChiTietPHNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieuhang.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaSPDL", phieuhang.MaSPDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuong", phieuhang.SoLuong);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }

        public static bool XoaChiTietPhieuHangNhap(ChiTietHoaDonNhap_DTO phieuhang)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("XoaChiTietPHNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieuhang.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("MaSPDL", phieuhang.MaSPDL);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }
    }
}
