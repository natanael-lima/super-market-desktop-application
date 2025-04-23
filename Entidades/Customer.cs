using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Customer
    {
        private int cus_Id;
        private string cus_Fullname;
        private int cus_Phone;
        private string cus_Location;
        private string cus_Address;

        public Customer()
        {
            throw new System.NotImplementedException();
        }

        public Customer(string cus_Fullname, int cus_Phone, string cus_Location, string cus_Address)
        {
            this.Cus_Fullname = cus_Fullname;
            this.Cus_Phone = cus_Phone;
            this.Cus_Location = cus_Location;
            this.Cus_Address = cus_Address;
        }

        public int Cus_Id { get => cus_Id; set => cus_Id = value; }
        public string Cus_Fullname { get => cus_Fullname; set => cus_Fullname = value; }
        public int Cus_Phone { get => cus_Phone; set => cus_Phone = value; }
        public string Cus_Location { get => cus_Location; set => cus_Location = value; }
        public string Cus_Address { get => cus_Address; set => cus_Address = value; }
    }
}