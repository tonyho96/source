using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace QLCUAHANG_DAL
{
   public class Product_DAL
    {
        public static List<Product_DTO> LoadSanPhamCH()
        {
            SqlConnection con = DataProvider.OpenConnection();

            SqlCommand cmd = new SqlCommand("DSSanPhamCH", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
                return null;

            List<Product_DTO> listSP = new List<Product_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Product_DTO product = new Product_DTO();
                product.ProductID = dt.Rows[i]["MaSPCH"].ToString();
                product.ProductName = dt.Rows[i]["TenSP"].ToString();
                product.VendorID = dt.Rows[i]["Gia"].ToString();
                product.ProductCategoryID = dt.Rows[i]["DonVi"].ToString();
                product.ImportPrice = float.Parse(dt.Rows[i]["SoLuong"].ToString());
                product.ImageUrl = dt.Rows[i]["HinhAnh"].ToString();
                product.Weight= dt.Rows[i]["ThongSo"].ToString();
                product.Quantity = Convert.ToInt32(dt.Rows[i]["BanLe"].ToString());
                //sanpham.SoLuongLe= Convert.ToInt32(dt.Rows[i]["SoLuongLe"].ToString());

                listSP.Add(product);
            }

            DataProvider.CloseConnection(con);
            return listSP;
        }

        public static Product_DTO TimKiemTenSP(string t)
        {
            
            SqlConnection con = DataProvider.OpenConnection();
            string query = string.Format("EXEC dbo.TimKiemTHSP @TenSP = N'" + t + "'");
            DataTable dt = DataProvider.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
                return null;

            if (dt.Rows.Count == 0)
                return null;

            Product_DTO product = new Product_DTO();
            product.ProductID = dt.Rows[0]["MaSPCH"].ToString();
            product.ProductName = dt.Rows[0]["TenSP"].ToString();
            product.VendorID = dt.Rows[0]["Gia"].ToString();
            product.ProductCategoryID = dt.Rows[0]["DonVi"].ToString();
            product.ImportPrice = float.Parse(dt.Rows[0]["SoLuong"].ToString());
            product.ImageUrl = dt.Rows[0]["HinhAnh"].ToString();
            product.Weight = dt.Rows[0]["ThongSo"].ToString();
            product.Quantity = Convert.ToInt32(dt.Rows[0]["BanLe"].ToString());
            //sanpham.SoLuongLe = Convert.ToInt32(dt.Rows[0]["SoLuongLe"].ToString());

            DataProvider.CloseConnection(con);
            return product;
        }

        public static bool SuaSanPhamCH(Product_DTO product)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("SuaSPCH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaSPCH", product.ProductID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenSP", product.ProductName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DonVi", product.VendorID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Gia", product.ProductCategoryID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuong", product.ImportPrice);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@HinhAnh", product.ImageUrl);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ThongSo", product.Weight);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@BanLe", product.Quantity);
                cmd.Parameters.Add(p);
                //p = new SqlParameter("@SoLuongLe", product.SoLuongLe);
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
        public static bool XoaSPCH(Product_DTO product)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("XoaSPCH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaSPCH", product.ProductID);
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
    }
}
