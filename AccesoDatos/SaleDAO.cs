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
    public class SaleDAO
    {
        public void RegisterSale(Sale sale)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insert Sale (encabezado)
                    string saleQuery = @"
                                        INSERT INTO [Sale] (sale_date, pay_id, user_id,sale_total)
                                        OUTPUT INSERTED.sale_id
                                        VALUES (@SaleDate, @PayId, @UserId,@SaleTotal)";

                    SqlCommand saleCmd = new SqlCommand(saleQuery, conn, transaction);
                    //saleCmd.Parameters.AddWithValue("@CusId", sale.Cus_Id != null ? (object)sale.Cus_Id : DBNull.Value);
                    saleCmd.Parameters.AddWithValue("@SaleDate", sale.Sale_Date);
                    saleCmd.Parameters.AddWithValue("@PayId", sale.Pay_Id);
                    saleCmd.Parameters.AddWithValue("@UserId", sale.User_Id);
                    saleCmd.Parameters.AddWithValue("@SaleTotal", sale.Sale_Total);

                    int saleId = (int)saleCmd.ExecuteScalar();
                    sale.Sale_Id = saleId;

                    // 2. Insert SaleItems (detalle)
                    foreach (SaleItem item in sale.Sale_Items)
                    {
                        string itemQuery = @"
                            INSERT INTO [SaleItem] (sale_id, prod_id, item_quantity, item_unitprice)
                            VALUES (@SaleId, @ProdID, @Quantity, @UnitPrice)";

                        SqlCommand itemCmd = new SqlCommand(itemQuery, conn, transaction);
                        itemCmd.Parameters.AddWithValue("@SaleId", saleId);
                        itemCmd.Parameters.AddWithValue("@ProdID", item.Prod_Id);
                        itemCmd.Parameters.AddWithValue("@Quantity", item.Item_Quantity);
                        itemCmd.Parameters.AddWithValue("@UnitPrice", item.Item_UnitPrice);

                        itemCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al registrar la venta: " + ex.Message);
                }
            }
        }

        public DataTable GetAllSales()
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = "SELECT * FROM [Sale]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetSaleDetails(int saleId)
        {
            using (SqlConnection conn = ConnectionDB.GetConnection())
            {
                string query = @"
                    SELECT si.*, p.prod_name 
                    FROM [SaleItem] si
                    INNER JOIN [Product] p ON si.prod_id = p.prod_id
                    WHERE si.sale_id = @SaleId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SaleId", saleId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
