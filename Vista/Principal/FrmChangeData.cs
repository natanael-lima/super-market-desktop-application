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
    public partial class FrmChangeData : Form
    {
        public decimal Nueva { get; private set; }

        public FrmChangeData(decimal valorActual)
        {
            InitializeComponent();
            txtNewData.Text = valorActual.ToString(); // Prellenar con el valor actual
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNewData.Text, out decimal nuevoValor) && nuevoValor > 0)
            {
                Nueva = nuevoValor;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
        }
    }
}
