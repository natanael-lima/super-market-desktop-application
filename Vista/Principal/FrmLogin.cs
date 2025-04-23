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

namespace Vista.Principal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean bUserFoud = false;
            User User1 = new User("admin", "admin");
            User User2 = new User("nata", "nata");
            Main formMain = new Main();

            if (User1.User_Username == txtUsername.Text && User1.User_Password == txtPassword.Text)
            {
                bUserFoud = true;
            }
            else if (User2.User_Username == txtUsername.Text && User2.User_Password == txtPassword.Text)
            {
                bUserFoud = true;
            }

            if (bUserFoud)
            {
                MessageBox.Show("Bienvenido/a: " + txtUsername.Text, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos de Acceso Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
