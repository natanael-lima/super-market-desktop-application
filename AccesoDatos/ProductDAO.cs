using Connection;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductDAO
    {
        public DataTable GetProducts()
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = "SELECT * FROM [Product]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void RegisterProduct(Product product)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = "INSERT INTO [Product] (prod_name, prod_description, prod_price, prod_stock, prod_barcode, prod_brand, prod_createdAt, cat_id) VALUES (@Name, @Description, @Price, @Stock, @Barcode, @Brand, @CreateAt, @CategoryId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Name", product.Prod_Name);
                cmd.Parameters.AddWithValue("@Description", product.Prod_Description);
                cmd.Parameters.AddWithValue("@Price", product.Prod_Price);
                cmd.Parameters.AddWithValue("@Stock", product.Prod_Stock);
                cmd.Parameters.AddWithValue("@Barcode", product.Prod_Barcode);
                cmd.Parameters.AddWithValue("@Brand", product.Prod_Brand);
                cmd.Parameters.AddWithValue("@CategoryId", product.Cat_Id);
                cmd.Parameters.AddWithValue("@CreateAt", product.Prod_CreatedAt);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = @"
            UPDATE [Product] SET 
                prod_name = @Name, 
                prod_description = @Description, 
                prod_price = @Price, 
                prod_stock = @Stock,
                prod_barcode = @Barcode,
                prod_brand = @Brand,
                cat_id = @CategoryId
            WHERE 
                prod_id = @ProductId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", product.Prod_Name);
                cmd.Parameters.AddWithValue("@Description", product.Prod_Description);
                cmd.Parameters.AddWithValue("@Price", product.Prod_Price);
                cmd.Parameters.AddWithValue("@Stock", product.Prod_Stock);
                cmd.Parameters.AddWithValue("@Barcode", product.Prod_Barcode);
                cmd.Parameters.AddWithValue("@Brand", product.Prod_Brand);
                cmd.Parameters.AddWithValue("@CategoryId", product.Cat_Id);
                cmd.Parameters.AddWithValue("@ProductId", product.Prod_Id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteProduct(int productId)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM [Product] WHERE prod_id = @ProductId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                cmd.ExecuteNonQuery();
            }
        }

        public Product SearchProductByBarcode(long codigoBarra)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SearchProductByBarcode", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoBarra", codigoBarra);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Product product = new Product
                    {
                        Prod_Id = Convert.ToInt32(reader["prod_Id"]),
                        Prod_Name = reader["prod_Name"].ToString(),
                        Prod_Stock = Convert.ToInt32(reader["prod_Stock"]),
                        Prod_Description = reader["prod_Description"].ToString(),
                        Prod_Price = Convert.ToDecimal(reader["prod_Price"]),
                        Prod_Barcode = Convert.ToInt64(reader["prod_Barcode"]),
                        Cat_Id = Convert.ToInt32(reader["cat_Id"]),
                        Prod_Brand = reader["prod_Brand"].ToString(),
                        Prod_CreatedAt = Convert.ToDateTime(reader["prod_CreatedAt"])
                    };
                    return product;
                }

                return null; // No se encontró ningún producto
            }
        }

    }
}
