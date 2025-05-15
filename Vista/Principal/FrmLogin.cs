using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Vista.Principal
{
    public partial class FrmLogin : Form
    {
        private UserService userService = new UserService();
        public FrmLogin()
        {
            InitializeComponent();
            //this.AcceptButton = btnIngresar;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main oFormMain = new Main();
            DataTable user = userService.SearchUserLogin(txtUsername.Text);

            if (user.Rows.Count > 0)
            {
                if (user.Rows[0].Field<string>("user_username") == txtUsername.Text && user.Rows[0].Field<string>("user_password") == txtPassword.Text)
                { 
                    // Aquí guardas los datos globales ANTES de abrir el formulario principal
                    Program.UserRolGlobal = user.Rows[0].Field<string>("rol_description");
                    Program.CurrentUsername = user.Rows[0].Field<string>("user_fullname"); // <- Guarda el username
                    MessageBox.Show("Bienvenido/a: " + txtUsername.Text, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oFormMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos de acceso erróneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Datos de Acceso Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
