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
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            FrmPayment frm = new FrmPayment();
            //frmSelling.Show();
            frm.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Main frm = new Main();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
