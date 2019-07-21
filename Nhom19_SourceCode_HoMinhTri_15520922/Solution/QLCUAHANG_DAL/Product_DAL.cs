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
        public static List<Product_DTO> LoadProduct()
        {
            SqlConnection con = DataProvider.OpenConnection();

            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getProductList]", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
                return null;

            List<Product_DTO> listProduct = new List<Product_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Product_DTO product = new Product_DTO();
                product.ProductID = dt.Rows[i]["ProductID"].ToString();
                product.ProductName = dt.Rows[i]["ProductName"].ToString();
                product.VendorID = dt.Rows[i]["VendorID"].ToString();
                product.VendorName = dt.Rows[i]["VendorName"].ToString();
                product.ProductCategoryID = dt.Rows[i]["ProductCategoryID"].ToString();
                product.ProductCategoryName = dt.Rows[i]["ProductCategoryName"].ToString();
                product.PercentRevenue = float.Parse(dt.Rows[i]["PercentRevenue"].ToString());
                product.UnitID = dt.Rows[i]["UnitID"].ToString();
                product.UnitName = dt.Rows[i]["UnitName"].ToString();
                product.ImportPrice = float.Parse(dt.Rows[i]["ImportPrice"].ToString());
                product.Weight= dt.Rows[i]["Weight"].ToString();
                product.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());

                listProduct.Add(product);
            }

            DataProvider.CloseConnection(con);
            return listProduct;
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
