using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Rol
    {
        private string rol_Description;
        private int rol_Id;

        public Rol()
        {
            throw new System.NotImplementedException();
        }

        public string Rol_Description { get => rol_Description; set => rol_Description = value; }
        public int Rol_Id { get => rol_Id; set => rol_Id = value; }
    }
}