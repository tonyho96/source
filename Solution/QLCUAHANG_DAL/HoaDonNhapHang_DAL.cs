﻿using QLCUAHANG_DTO;
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
   public class HoaDonNhapHang_DAL
    {

        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;
        public static bool ThemPHNhapHang(HoaDonNhapHang_DTO phieu)
        {
            SqlConnection con = DataProvider.OpenConnection();
            cmd = new SqlCommand("ThemPHNhap", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieu.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenDL", phieu.TenDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaDL", phieu.MaDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgayNhap", phieu.NgayNhap);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TongTien", phieu.TongTien);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TongNo", phieu.TongNo);
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

        public static List<HoaDonNhapHang_DTO> LoadPhieuNhap()
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("DSPhieuNhap", con);
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

            List<HoaDonNhapHang_DTO> dsPhieuNhap = new List<HoaDonNhapHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonNhapHang_DTO phieuhang = new HoaDonNhapHang_DTO();
                phieuhang.MaHDN = dt.Rows[i]["MaHDN"].ToString();
                phieuhang.MaDL = dt.Rows[i]["MaDL"].ToString();

                phieuhang.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayNhap"].ToString());
                phieuhang.TongNo = Convert.ToDouble(dt.Rows[i]["TongNo"].ToString());
                phieuhang.TongTien = Double.Parse(dt.Rows[i]["TongTien"].ToString());

                phieuhang.TenDL = dt.Rows[i]["TenDL"].ToString();

                dsPhieuNhap.Add(phieuhang);
            }
            DataProvider.CloseConnection(con);
            return dsPhieuNhap;
        }

        public static bool SuaPhieuHangNhap(HoaDonNhapHang_DTO phieuhang)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("SuaPHNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieuhang.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaDL", phieuhang.MaDL);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@NgayNhap", phieuhang.NgayNhap);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@TongTien", phieuhang.TongTien);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TongNo", phieuhang.TongNo);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenDL", phieuhang.TenDL);
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

        public static bool XoaPhieuHangNhap(HoaDonNhapHang_DTO phieuhang)
        {
            SqlConnection con = DataProvider.OpenConnection();
            try
            {
                cmd = new SqlCommand("XoaPHNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieuhang.MaHDN);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(con);
                return true;
            }
            catch(Exception ex)
            {
                DataProvider.CloseConnection(con);
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static List<HoaDonNhapHang_DTO>DSNoTienDaiLi()
        {

            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                cmd = new SqlCommand("DS_TIENNODL", con);
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

            List<HoaDonNhapHang_DTO> dsPhieuNhap = new List<HoaDonNhapHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonNhapHang_DTO phieuhang = new HoaDonNhapHang_DTO();

                phieuhang.MaDL = dt.Rows[i]["MaDL"].ToString();
                phieuhang.TenDL = dt.Rows[i]["TenDL"].ToString();


                dsPhieuNhap.Add(phieuhang);
            }
            DataProvider.CloseConnection(con);
            return dsPhieuNhap;
        }

        public static string TongNoDaiLi(string s)
        {

            SqlConnection con = DataProvider.OpenConnection();

            try
            {

                string query = string.Format("EXEC TONGNO_DAILI @MaDL = N'" + s + "'");
                dt = DataProvider.GetDataTable(query, con);
            }
            catch
            {
                return null;
            }

            if (dt.Rows.Count == 0)
                return null;

  
            string d2;
            d2 = dt.Rows[0]["TongNo"].ToString();

            DataProvider.CloseConnection(con);
            return d2;
        }

         public static List<string>LoadDS_MaHDNhap(string s)
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {

                string query = string.Format("EXEC dbo.DS_MaHDNhap @MaDL = N'" + s + "'");
                dt = DataProvider.GetDataTable(query, con);
            }
            catch
            {
                return null;
            }

            if (dt.Rows.Count == 0)
                return null;

            List<string> listDS = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string phieuhang;
                phieuhang = dt.Rows[i]["MaHDN"].ToString();


                listDS.Add(phieuhang);
            }
            DataProvider.CloseConnection(con);
            return listDS;
        }
        #region newcode
        // This is mine

        public static List<PostInvoice_DTO> GetPostInvoice_DTO()
        {
            SqlConnection con = DataProvider.OpenConnection();

            try
            {
                con.ChangeDatabase("JEWELRYSTOREMGMT");
                cmd = new SqlCommand("dbo.usp_getPostInvoice", con);
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

            List<PostInvoice_DTO> PostInvoiceList = new List<PostInvoice_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PostInvoice_DTO postInvoice = new PostInvoice_DTO();
                postInvoice.TransID = Convert.ToInt32(dt.Rows[i]["TransID"].ToString());
                postInvoice.VendorID = Convert.ToInt32(dt.Rows[i]["VendorID"].ToString());
                postInvoice.VendorName = dt.Rows[i]["VendorName"].ToString();
                postInvoice.Address = dt.Rows[i]["Address"].ToString();
                postInvoice.PhoneNo = dt.Rows[i]["PhoneNo"].ToString();
                postInvoice.CreateDate = Convert.ToDateTime(dt.Rows[i]["TransDate"].ToString());
                postInvoice.TotalPrice = Convert.ToDouble(dt.Rows[i]["TotalPrice"].ToString());
                PostInvoiceList.Add(postInvoice);
            }
            DataProvider.CloseConnection(con);
            return PostInvoiceList;
        }

        public static bool InsertPostInvoice(PostInvoice_DTO postInvoice)
        {
            SqlConnection con = DataProvider.OpenConnection();
            con.ChangeDatabase("JEWELRYSTOREMGMT");
            cmd = new SqlCommand("[dbo].[usp_InsertPostInvoice]", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@VendorID", postInvoice.VendorID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@CreateDate", postInvoice.CreateDate);
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
        #endregion
    }
}
