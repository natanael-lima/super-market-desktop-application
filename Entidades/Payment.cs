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

        public int Pay_Id { get => pay_Id; set => pay_Id = value; }
        public string Pay_Method { get => pay_Method; set => pay_Method = value; }
        public decimal Pay_Amount { get => pay_Amount; set => pay_Amount = value; }
    }
}