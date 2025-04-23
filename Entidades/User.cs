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
        private string user_Fullname;
        private string user_Username;
        private int rol_Id;
        private string user_Password;

        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string username, string password)
        {
            User_Username = username;
            User_Password = password;
        }

        public int User_Id { get => user_Id; set => user_Id = value; }
        public string User_Fullname { get => user_Fullname; set => user_Fullname = value; }
        public string User_Username { get => user_Username; set => user_Username = value; }
        public int Rol_Id { get => rol_Id; set => rol_Id = value; }
        public string User_Password { get => user_Password; set => user_Password = value; }
    }
}