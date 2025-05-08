using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connection;
using Entidades;

namespace Data
{
    public class CategoryDAO
    {
        public DataTable GetCategories()
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = "SELECT * FROM [Category]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        public void RegisterCategory(Category category)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {

                string query = "INSERT INTO [Category] (cat_Name) VALUES (@Name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Name", category.Cat_Name);
                //cmd.Parameters.AddWithValue("@Id", category.Cat_Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                conn.Open();
                string query = "UPDATE [Category] SET  cat_name = @Name WHERE cat_id = @CatId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", category.Cat_Name);
                cmd.Parameters.AddWithValue("@CatId", category.Cat_Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCategory(int catId)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM [Category] WHERE cat_id = @CatId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CatId", catId);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SearchCategoryByName(string name)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SearchCategoryByName", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name ?? (object)DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public int CountAllCategories()
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("CountAllCategories", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                // Ejecuta el SP y obtiene un único valor (la cuenta)
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
    }
}

