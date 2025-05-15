using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UserService
    {
        private UserDAO userDAO = new UserDAO();

        public DataTable GetUsers()
        {
            return userDAO.GetUsers();
        }

        public DataTable GetRoles()
        {
            return userDAO.GetRoles();
        }
        public void CreateUser(User user)
        {
            userDAO.RegisterUser(user);
        }

        public void UpdateUser(User user)
        {
            userDAO.UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            userDAO.DeleteUser(userId);
        }

        public DataTable SearchUserByNameOrUsername(string search)
        {
            return userDAO.SearchUserByNameOrUsername(search);
        }
        public DataTable SearchUserLogin(string search)
        {
            return userDAO.SearchUserLogin(search);
        }
        public int CountAllUsers()
        {
            return userDAO.CountAllUsers();
        }
    }
}
