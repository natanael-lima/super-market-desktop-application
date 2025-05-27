using Connection;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PaymentDAO
    {
        public int RegisterPayment(Payment payment)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = @"
                    INSERT INTO [Payment] (pay_method)
                    VALUES (@Method);
                    SELECT SCOPE_IDENTITY();"; // devuelve el ID generado

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Method", payment.Pay_Method);

                conn.Open();
                int paymentId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return paymentId; // se retorna para asociarlo con la venta (sale)
            }
        }

        public DataTable GetAllPayments()
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = "SELECT * FROM [Payment]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
