using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class HistoryPay
    {
        private int his_Id;
        private int sale_Id;
        private string his_Method;
        private decimal his_Amount;
        private System.DateTime his_RegisteredAt;

        public int His_Id { get => his_Id; set => his_Id = value; }
        public int Sale_Id { get => sale_Id; set => sale_Id = value; }
        public string His_Method { get => his_Method; set => his_Method = value; }
        public decimal His_Amount { get => his_Amount; set => his_Amount = value; }
        public DateTime His_RegisteredAt { get => his_RegisteredAt; set => his_RegisteredAt = value; }
    }
}