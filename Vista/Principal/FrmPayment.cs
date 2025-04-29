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

namespace Vista
{
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
            // Inicializar el objeto Sale con los datos del carrito
            //Sale = new Sale
            //{
            //    Sale_Date = DateTime.Now,
            //    Sale_Total = total,
            //    Sale_Items = new List<SaleItem>()
            //};

            // Cargar métodos de pago (ejemplo)
            //LoadPaymentMethods();

            // Opcional: Cargar clientes
            //LoadCustomers();
        }
        private void FrmPayment_Load(object sender, EventArgs e)
        {

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Asignar datos seleccionados al objeto Sale
            //Sale.Pay_Id = Convert.ToInt32(cmbPaymentMethod.SelectedValue);
            //Sale.Cus_Id = cmbCustomer.SelectedValue != null ? Convert.ToInt32(cmbCustomer.SelectedValue) : (int?)null;
            //Sale.User_Id = CurrentUser.Id; // Usuario logueado

            this.DialogResult = DialogResult.OK; // Cierra el formulario con "OK"
            this.Close();
        }


    }
}
