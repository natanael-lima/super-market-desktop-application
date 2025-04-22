using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Payment
    {
        private int pay_Id;
        private string pay_Method;
        private decimal pay_Amount;

        public Payment()
        {
            throw new System.NotImplementedException();
        }

        public decimal Pay_Amount
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

        public string Pay_Method
        {
            get => default;
            set
            {
            }
        }
    }
}