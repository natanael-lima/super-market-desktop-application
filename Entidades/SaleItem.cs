using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class SaleItem
    {
        private int item_Id;
        private int prod_Id;
        private int sale_Id;
        private int item_Quantity;
        private decimal item_UnitPrice;


        public int Item_Id { get => item_Id; set => item_Id = value; }
        public int Prod_Id { get => prod_Id; set => prod_Id = value; }
        public int Sale_id { get => sale_Id; set => sale_Id = value; }
        public int Item_Quantity { get => item_Quantity; set => item_Quantity = value; }
        public decimal Item_UnitPrice { get => item_UnitPrice; set => item_UnitPrice = value; }

        // Subtotal calculado automáticamente
        public decimal Item_SubTotal => item_Quantity * item_UnitPrice;
    }
}