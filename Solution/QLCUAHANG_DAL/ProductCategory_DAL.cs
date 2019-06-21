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
using System.Windows.Forms;

namespace QLCUAHANG_DAL
{
    public class ProductCategory_DAL
    {
        public static List<ProductCategory_DTO> LoadProductCategory()
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_getProductCategory]", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
                return null;

            List<ProductCategory_DTO> listCategory = new List<ProductCategory_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ProductCategory_DTO category = new ProductCategory_DTO();
                category.ProductCategoryID = dt.Rows[i]["ProductCategoryID"].ToString();
                category.ProductCategoryName = dt.Rows[i]["ProductCategoryName"].ToString();
                category.PercentRevenue = float.Parse(dt.Rows[i]["PercentRevenue"].ToString());

                listCategory.Add(category);
            }

            DataProvider.CloseConnection(con);
            return listCategory;
        }

        public static bool InsertProductCategory(ProductCategory_DTO category)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_insertProductCategory]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@ProductCategoryName", category.ProductCategoryName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@PercentRevenue", category.PercentRevenue);
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

        public static bool UpdateProductCategory(ProductCategory_DTO category)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_updateProductCategory]", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ProductCategoryID", category.ProductCategoryID);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ProductCategoryName", category.ProductCategoryName);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@PercentRevenue", category.PercentRevenue);
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

        public static bool DeleteProductCategory(ProductCategory_DTO category)
        {
            SqlConnection con = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand("[JEWELRYSTOREMGMT].[dbo].[usp_deleteProductCategory]", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@ProductCategoryID", category.ProductCategoryID);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
                DataProvider.CloseConnection(con);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.CloseConnection(con);
                return false;
            }
        }
    }
}
