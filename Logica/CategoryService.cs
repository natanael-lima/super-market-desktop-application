using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidades;

namespace Logica
{
    public class CategoryService
    {
        private CategoryDAO catDAO = new CategoryDAO();

        public DataTable GetCategories()
        {
            return catDAO.GetCategories();
        }

        public void CreateCategory(Category category)
        {
            catDAO.RegisterCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            catDAO.UpdateCategory(category);
        }

        public void DeleteCategory(int catId)
        {
            catDAO.DeleteCategory(catId);
        }
    }
}
