using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Product
    {
        private int prod_Id;
        private string prod_Name;
        private int prod_Stock;
        private string prod_Description;
        private decimal prod_Price;
        private long prod_Barcode;
        private int cat_Id;
        private string prod_Brand;
        private DateTime prod_CreatedAt;

        public Product()
        {
           
        }

        public int Prod_Id { get => prod_Id; set => prod_Id = value; }
        public string Prod_Name { get => prod_Name; set => prod_Name = value; }
        public int Prod_Stock { get => prod_Stock; set => prod_Stock = value; }
        public string Prod_Description { get => prod_Description; set => prod_Description = value; }
        public decimal Prod_Price { get => prod_Price; set => prod_Price = value; }
        public long Prod_Barcode { get => prod_Barcode; set => prod_Barcode = value; }
        public int Cat_Id { get => cat_Id; set => cat_Id = value; }
        public string Prod_Brand { get => prod_Brand; set => prod_Brand = value; }
        public DateTime Prod_CreatedAt { get => prod_CreatedAt; set => prod_CreatedAt = value; }
    }
}
