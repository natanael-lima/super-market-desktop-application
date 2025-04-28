using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Category
    {
        private int cat_Id;
        private string cat_Name;

        public Category()
        {

        }

        public int Cat_Id { get => cat_Id; set => cat_Id = value; }

        public string Cat_Name { get => cat_Name; set => cat_Name = value; }
    }
}