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
    public class UserDAO
    {
        public DataTable GetUsers()
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = "SELECT * FROM [User] as U LEFT JOIN Rol as R ON (R.rol_id=U.rol_id)";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
        public DataTable GetRoles()
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = "SELECT * FROM [Rol]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
        public void RegisterUser(User user)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                
                string query = "INSERT INTO [User] (user_fullname, user_username, user_password, rol_id, user_phone) VALUES (@Fullname, @Username, @Password, @RolId, @Phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Fullname", user.User_Fullname);
                cmd.Parameters.AddWithValue("@Username", user.User_Username);
                cmd.Parameters.AddWithValue("@Password", user.User_Password);
                cmd.Parameters.AddWithValue("@RolId", user.Rol_Id);
                cmd.Parameters.AddWithValue("@Phone", user.User_Phone);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();  
            }
        }

        public void UpdateUser(User user)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                conn.Open();
                string query = "UPDATE [User] SET user_fullname = @Fullname, user_username = @Username, user_password = @Password, rol_id = @RolId, user_Phone = @Phone WHERE user_id = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fullname", user.User_Fullname);
                cmd.Parameters.AddWithValue("@Username", user.User_Username);
                cmd.Parameters.AddWithValue("@Password", user.User_Password);
                cmd.Parameters.AddWithValue("@RolId", user.Rol_Id);
                cmd.Parameters.AddWithValue("@UserId", user.User_Id);
                cmd.Parameters.AddWithValue("@Phone", user.User_Phone);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM [User] WHERE user_id = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SearchUserByNameOrUsername(string Search)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SearchUserByNameOrUsername", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Search", Search ?? (object)DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable SearchUserLogin(string search)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SearchUserLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@search", search ?? (object)DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public int CountAllUsers()
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("CountAllUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                // Ejecuta el SP y obtiene un único valor (la cuenta)
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
    }
}
