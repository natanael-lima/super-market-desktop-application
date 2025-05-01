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
    public class ProductService
    {
        private ProductDAO productDAO = new ProductDAO();

        public DataTable GetProducts()
        {
            return productDAO.GetProducts();
        }

        public void CreateProduct(Product product)
        {
            productDAO.RegisterProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            productDAO.UpdateProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            productDAO.DeleteProduct(productId);
        }

        public Product SearchProductByBarcode(long barcode)
        {
            return productDAO.SearchProductByBarcode(barcode);
        }


    }
}
