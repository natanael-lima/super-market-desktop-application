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
        private int prod_Barcode;
        private int cat_Id;
        private string prod_Brand;
        private System.DateTime prod_CreatedAt;

        public Product()
        {
            throw new System.NotImplementedException();
        }

        public int Prod_Barcode
        {
            get => default;
            set
            {
            }
        }

        public string Prod_Description
        {
            get => default;
            set
            {
            }
        }

        public int Prod_Id
        {
            get => default;
            set
            {
            }
        }

        public string Prod_Name
        {
            get => default;
            set
            {
            }
        }

        public decimal Prod_Price
        {
            get => default;
            set
            {
            }
        }

        public int Prod_Stock
        {
            get => default;
            set
            {
            }
        }

        public int Cat_Id
        {
            get => default;
            set
            {
            }
        }

        public string Prod_Brand
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Prod_CreatedAt
        {
            get => default;
            set
            {
            }
        }
    }
}
