using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Principal
{
    public partial class Dashboard : Form
    {
        private ProductService productService = new ProductService();
        private CategoryService categoryService = new CategoryService();
        private UserService userService = new UserService();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            int userCount = userService.CountAllUsers();
            int categoryCount = categoryService.CountAllCategories();
            int productCount = productService.CountAllProducts();

            lblCat.Text=categoryCount.ToString();
            lblProd.Text=productCount.ToString();
            lblUse.Text= userCount.ToString();
        }
    }
}
