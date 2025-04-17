using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class User
    {

        private int user_Id;

        private string user_Nombre;

        private string user_Username;
        private int rol_Id;

        private string user_Password;

        public int Rol_Id
        {
            get => default;
            set
            {
            }
        }

        public string User_Apellido
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

        public string User_Nombre
        {
            get => default;
            set
            {
            }
        }

        public string User_Password
        {
            get { return user_Password; }
            set { user_Password = value; }
        }

        public string User_Username
        {
            get { return user_Username; }
            set { user_Username = value; }
        }
        public User(string username, string password)
        {
            User_Username = username;
            User_Password = password;
        }

    }
}