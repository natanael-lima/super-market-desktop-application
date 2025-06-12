using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Principal
{
    public partial class FrmSale : Form
    {
        private ProductService productService = new ProductService();
        private PaymentService payService = new PaymentService();
        private SaleService saleService = new SaleService();

        private DataTable dgvSaleDetails = new DataTable(); // Variable de clase

        public FrmSale()
        {
            InitializeComponent();
        }

  
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Main frm = new Main();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            //LoadProducts();
            StartSale();
            btnPay.Enabled = false;
            btnChangeQuatity.Visible = false;
            btnChangePrice.Visible = false;
            btnDelete.Visible = false;
            LoadComboTypePay();
        }

        private void LoadComboTypePay()
        {
            DataTable pays = payService.GetAllPayments();

            // Agregar opción por defecto
            DataRow row = pays.NewRow();
            row["pay_id"] = -1;
            row["pay_method"] = "Ninguno";
            pays.Rows.InsertAt(row, 0);
            cmbTypePay.DataSource = pays;
            cmbTypePay.DisplayMember = "pay_method";
            cmbTypePay.ValueMember = "pay_id";
        }
     
        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no se haya hecho clic en el encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvSale.Rows[e.RowIndex];

                // Aseguramos que se seleccione visual y lógicamente la fila
                dgvSale.ClearSelection(); // opcional: limpia selecciones previas
                dgvSale.Rows[e.RowIndex].Selected = true;

                txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                txtName.Text = fila.Cells["Descripcion"].Value.ToString();
                txtUnitPrice.Text = fila.Cells["Unitario"].Value.ToString();
                btnChangePrice.Visible = true;
                btnChangeQuatity.Visible = true;
                btnDelete.Visible = true;
                btnAgregar.Visible = true;

            }
        }

        private void StartSale()
        {
            dgvSaleDetails.Clear();
            if (dgvSaleDetails.Columns.Count == 0) // Evitar recrear columnas
            {
                dgvSaleDetails.Columns.Add("#", typeof(int));
                dgvSaleDetails.Columns.Add("ID", typeof(int));
                dgvSaleDetails.Columns.Add("Codigo", typeof(string));
                dgvSaleDetails.Columns.Add("Descripcion", typeof(string)); // Cambiado a string (error en tu código original)
                dgvSaleDetails.Columns.Add("Cantidad", typeof(decimal));
                dgvSaleDetails.Columns.Add("Unitario", typeof(decimal));
                dgvSaleDetails.Columns.Add("Subtotal", typeof(decimal));
            }
            dgvSale.DataSource = dgvSaleDetails;
        }

        private void AddProductTable(int id, string code, string description, decimal price, decimal quantity)
        {

            if (IsInTable(code))
            {
                // Si el producto ya está, aumentar la cantidad
                foreach (DataRow row in dgvSaleDetails.Rows)
                {
                    if (row["Codigo"].ToString() == code)
                    {
                        row["Cantidad"] = Convert.ToDecimal(row["Cantidad"]) + quantity;
                        row["Subtotal"] = Convert.ToDecimal(row["Cantidad"]) * Convert.ToDecimal(row["Unitario"]);
                        break;
                    }
                }
            }
            else
            {
                // Si es nuevo, agregar una fila
                DataRow newRow = dgvSaleDetails.NewRow();
                newRow["#"] = dgvSaleDetails.Rows.Count + 1;
                newRow["ID"] = id;
                newRow["Codigo"] = code;
                newRow["Descripcion"] = description;
                newRow["Cantidad"] = quantity;
                newRow["Unitario"] = price;
                newRow["Subtotal"] = price * quantity;
                dgvSaleDetails.Rows.Add(newRow);
                btnPay.Enabled = true;
            }
            RefreshTable();
        }

        private bool IsInTable(string productCode)
        {
            foreach (DataRow row in dgvSaleDetails.Rows)
            {
                if (row["Codigo"].ToString() == productCode)
                {
                    return true;
                }
            }
            return false;
        }

        private void RefreshTable()
        {
            dgvSale.DataSource = null;
            dgvSale.DataSource = dgvSaleDetails;
            dgvSale.Refresh();

            // Opcional: Calcular total de la venta
            decimal total = 0;
            foreach (DataRow row in dgvSaleDetails.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            lblSubtotal.Text = total.ToString("C2");
            lblTotal.Text = total.ToString("C2");
            lblTotal.TextAlign = ContentAlignment.MiddleRight; // Alinea el texto a la derecha

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener datos del producto seleccionado (ejemplo)
            int id;
            if (txtID.Text.Length <= 0)
            {
                id = 999909;
            }
            else
            {
                id = Convert.ToInt32(txtID.Text);
            }

            string code = txtCodigo.Text; // O desde un DataGridView de productos
            string description = txtName.Text;
            decimal price = Convert.ToDecimal(txtUnitPrice.Text);
            decimal quantity = Convert.ToDecimal(txtQuantity.Text);

            AddProductTable(id,code, description, price, quantity);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            long codigoBarra = Convert.ToInt64(txtSearchArt.Text); // Obtener el código de barras de la caja de texto
            Product producto = productService.SearchProductByBarcode(codigoBarra); // Buscar el producto usando el código de barras

            if (producto != null) // Si se encuentra el producto
            {
                // Asignar los valores del producto a los cuadros de texto
                txtID.Text = producto.Prod_Id.ToString();
                txtCodigo.Text = producto.Prod_Barcode.ToString();
                txtName.Text = producto.Prod_Name;
                txtUnitPrice.Text = producto.Prod_Price.ToString(); // Puedes formatear el precio si es necesario
            }
            else
            {
                // Si no se encuentra el producto, puedes mostrar un mensaje
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = true;
            btnChangePrice.Visible = false;
            btnChangeQuatity.Visible = false;
            btnDelete.Visible = false;
            lblSubtotal.Text = "$ 0.00";
            lblTotal.Text = "$ 0.00";
            txtCodigo.Text = null; 
            txtQuantity.Text = null;
            txtName.Text = null;
            txtUnitPrice.Text = null;
            StartSale();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Confirmar si hay productos en el carrito (opcional)
            if (dgvSaleDetails.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para procesar el pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar mensaje de confirmación
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas confirmar la compra?",
                "Confirmar Compra",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Crear objeto Sale
                Sale sale = new Sale
                {
                    Sale_Date = DateTime.Now
                    // Obtener ID del cliente si aplica
                    //sale.Cus_Id = selectedCustomerId; // o null si no hay cliente asignado
                };

                // Buscar el RadioButton seleccionado dentro del GroupBox
                RadioButton selectedRadio = grpPaymentType.Controls
                    .OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked);

                if (selectedRadio != null)
                {
                    sale.Sale_Payment = selectedRadio.Text; // Guarda el texto del botón como "Efectivo", "Tarjeta", etc.
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // ID del usuario (por ejemplo, el cajero logueado)
                sale.User_Id = 2;

                // Lista de productos vendidos
                sale.Sale_Items = new List<SaleItem>();


                foreach (DataRow row in dgvSaleDetails.Rows)
                {
                    SaleItem item = new SaleItem
                    {
                        Prod_Id = (int) Convert.ToInt32(row["ID"]),
                        Item_Quantity = Convert.ToInt32(row["Cantidad"]),
                        Item_UnitPrice = Convert.ToDecimal(row["Unitario"])
                    };

                    sale.Sale_Items.Add(item);
                }

                // Registrar en base de datos
                saleService.RegisterSale(sale);


                MessageBox.Show("Compra realizada con éxito. ¡Gracias por tu compra!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpieza opcional del formulario
                dgvSaleDetails.Rows.Clear();
                txtCodigo.Clear();
                txtName.Clear();
                txtUnitPrice.Clear();
                txtQuantity.Clear();
                btnPay.Enabled = false;
            }
        }

        private void btnChangeQuatity_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada
            if (dgvSale.SelectedRows.Count > 0)
            {
                // Obtenemos el código del producto seleccionado
                string code = dgvSale.SelectedRows[0].Cells["Codigo"].Value.ToString();

                // Obtenemos la cantidad actual para mostrarla en el formulario
                decimal valorActual = Convert.ToDecimal(dgvSale.SelectedRows[0].Cells["Cantidad"].Value);

                // Abrimos el formulario de cambio de datos con el valor actual precargado
                using (FrmChangeData form = new FrmChangeData(valorActual))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        decimal nuevaCantidad = form.Nueva;

                        // Buscamos el producto en la tabla y actualizamos la cantidad y el subtotal
                        foreach (DataRow row in dgvSaleDetails.Rows)
                        {
                            if (row["Codigo"].ToString() == code)
                            {
                                row["Cantidad"] = nuevaCantidad;
                                row["Subtotal"] = nuevaCantidad * Convert.ToDecimal(row["Unitario"]);
                                break;
                            }
                        }

                        // Refrescamos la tabla para mostrar los cambios
                        RefreshTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto primero.");
            }
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada
            if (dgvSale.SelectedRows.Count > 0)
            {
                // Obtenemos el código del producto seleccionado
                string code = dgvSale.SelectedRows[0].Cells["Codigo"].Value.ToString();

                // Obtenemos la cantidad actual para mostrarla en el formulario
                decimal valorActual = Convert.ToDecimal(dgvSale.SelectedRows[0].Cells["Unitario"].Value);

                // Abrimos el formulario de cambio de datos con el valor actual precargado
                using (FrmChangeData form = new FrmChangeData(valorActual))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        decimal nueva = form.Nueva;

                        // Buscamos el producto en la tabla y actualizamos la cantidad y el subtotal
                        foreach (DataRow row in dgvSaleDetails.Rows)
                        {
                            if (row["Codigo"].ToString() == code)
                            {
                                row["Unitario"] = nueva;
                                row["Subtotal"] = nueva * Convert.ToDecimal(row["Cantidad"]);
                                break;
                            }
                        }

                        // Refrescamos la tabla para mostrar los cambios
                        RefreshTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto primero.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSale.SelectedRows.Count > 0)
            {
                string code = dgvSale.SelectedRows[0].Cells["Codigo"].Value.ToString();

                // Buscar y eliminar la fila correspondiente en el DataTable
                foreach (DataRow row in dgvSaleDetails.Rows)
                {
                    if (row["Codigo"].ToString() == code)
                    {
                        dgvSaleDetails.Rows.Remove(row);
                        break; // Muy importante: romper el ciclo después de eliminar
                    }
                }

                RefreshTable();

                // Si ya no hay productos, deshabilitamos el botón de pago
                if (dgvSaleDetails.Rows.Count == 0)
                {
                    btnPay.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }
    }
}
