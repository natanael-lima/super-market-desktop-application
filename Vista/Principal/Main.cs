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

        private void btnSelling_Click(object sender, EventArgs e)
        {

            this.Hide(); // Oculta el formulario actual
            FrmSelling frm = new FrmSelling();
            frm.FormClosed += (s, args) => this.Show(); // se cierre, este se vuelve a mostrar
            frm.Show();
        }

        private void btnPays_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPay());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSetting());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAbout());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            OpenForm(new Dashboard());
        }
    }
}
