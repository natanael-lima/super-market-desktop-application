using Connection;
using Entidades;
using System;
using System.Collections.Generic;
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
                    INSERT INTO [Payment] (pay_method, pay_amount)
                    VALUES (@Method, @Amount);
                    SELECT SCOPE_IDENTITY();"; // devuelve el ID generado

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Method", payment.Pay_Method);
                cmd.Parameters.AddWithValue("@Amount", payment.Pay_Amount);

                conn.Open();
                int paymentId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return paymentId; // se retorna para asociarlo con la venta (sale)
            }
        }
    }
}
