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
    public partial class Main : Form
    {
        Form product;
        private UserService userService = new UserService();
        public Main()
        {
            InitializeComponent();
        }
        private void OpenForm(Form childForm)
        {
            product = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new Dashboard());
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmProduct());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmUser());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCategory());
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            FrmSale frm = new FrmSale();
            frm.FormClosed += (s, args) => this.Show(); // se cierre, este se vuelve a mostrar
            frm.Show();
        }

        private void btnPays_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHistorySale());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSetting());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere Cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide(); // Oculta el formulario actual
                FrmLogin frm = new FrmLogin();
                frm.FormClosed += (s, args) => this.Show(); // se cierre, este se vuelve a mostrar
                frm.Show();
            }


            
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            //OpenForm(new Dashboard());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenForm(new Dashboard());  // Se carga solo al inicio.
        }

        private void panelBar_Paint(object sender, PaintEventArgs e)
        {
            if (Program.UserRolGlobal == "Administrador")
            {
                btnSetting.Enabled = false;
                btnSetting.Enabled = false;

                // Muestra los datos del usuario logueado
                lblUsername.Text = Program.CurrentUsername;
                lblRol.Text = Program.UserRolGlobal;
            }
            else
            {
                if (Program.UserRolGlobal == "Cajero")
                {
                    btnSetting.Enabled = false;

                    btnPays.Enabled = false;
                    lblRol.Text = Program.UserRolGlobal;
                    lblUsername.Text = Program.CurrentUsername;
                }
                else
                {
                    lblRol.Text = Program.UserRolGlobal;
                    lblUsername.Text = Program.CurrentUsername;
                }
            }
        }
    }
}
