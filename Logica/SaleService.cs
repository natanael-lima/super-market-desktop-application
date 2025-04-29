using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class SaleService
    {
        private SaleDAO saleDAO = new SaleDAO();
        public void RegisterSale(Sale sale)
        {
            saleDAO.RegisterSale(sale);
        }

        public DataTable GetAllSales()
        {
            return saleDAO.GetAllSales();
        }

        public DataTable GetSaleDetails(int saleId)
        {
            return saleDAO.GetSaleDetails(saleId);
        }

    }
}
