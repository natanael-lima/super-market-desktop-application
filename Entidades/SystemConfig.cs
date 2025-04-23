using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class SystemConfig
    {
        private int sys_Id;
        private string sys_BusinessName;
        private int sys_CUIT;
        private string sys_Address;
        private int sys_Phone;
        private string sys_TicketFooter;

        public int Sys_Id { get => sys_Id; set => sys_Id = value; }
        public string Sys_BusinessName { get => sys_BusinessName; set => sys_BusinessName = value; }
        public int Sys_CUIT { get => sys_CUIT; set => sys_CUIT = value; }
        public string Sys_Address { get => sys_Address; set => sys_Address = value; }
        public int Sys_Phone { get => sys_Phone; set => sys_Phone = value; }
        public string Sys_TicketFooter { get => sys_TicketFooter; set => sys_TicketFooter = value; }
    }
}