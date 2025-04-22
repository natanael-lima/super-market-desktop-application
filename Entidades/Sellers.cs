using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Sale
    {
        private int sale_Id;
        private int cus_Id;
        private System.DateTime sale_Date;
        private int pay_Id;
        private int sale_Total;
        private int item_Id;
        private int user_Id;

        public Sale()
        {
            throw new System.NotImplementedException();
        }

        public int Cus_Id
        {
            get => default;
            set
            {
            }
        }

        public int Item_Id
        {
            get => default;
            set
            {
            }
        }

        public int Pay_Id
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Sale_Date
        {
            get => default;
            set
            {
            }
        }

        public int User_Id
        {
            get => default;
            set
            {
            }
        }

        public int Sale_Id
        {
            get => default;
            set
            {
            }
        }

        public int Sale_Total
        {
            get => default;
            set
            {
            }
        }
    }
}