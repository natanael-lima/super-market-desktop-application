using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace Entidades
{
    public class Sale
    {
        private int sale_Id;
        private int? cus_Id;
        private DateTime sale_Date;
        private int pay_Id;
        private int user_Id;
        private List<SaleItem> sale_Items = new List<SaleItem>(); // Siempre inicializar la lista

        public Sale()
        {
            
        }
 
        public int Sale_Id { get => sale_Id; set => sale_Id = value; }
        public int? Cus_Id { get => cus_Id; set => cus_Id = value; }
        public DateTime Sale_Date { get => sale_Date; set => sale_Date = value; }
        public int Pay_Id { get => pay_Id; set => pay_Id = value; }
        public int User_Id { get => user_Id; set => user_Id = value; }
        public List<SaleItem> Sale_Items { get => sale_Items; set => sale_Items = value; }

        // Total calculado automáticamente
        public decimal Sale_Total => Sale_Items.Sum(i => i.Item_SubTotal);
       
    }
}