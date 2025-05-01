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
        private CategoryService categoryService = new CategoryService();
        private SaleService saleService = new SaleService();

        private DataTable dgvSaleDetails = new DataTable(); // Variable de clase

        public FrmSale()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
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

        private void FrmSale_Load(object sender, EventArgs e)
        {
            LoadProducts();
            StartSale();
            btnPay.Enabled = false;
        }
        private void LoadProducts()
        {
            dgvProduct.DataSource = productService.GetProducts();
            LoadComboCategory();
            // Ocultar todas las columnas primero
            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                column.Visible = false;
            }

            // Mostrar solo las columnas que quieres
            dgvProduct.Columns["prod_name"].Visible = true;
            dgvProduct.Columns["prod_stock"].Visible = true;
            dgvProduct.Columns["prod_price"].Visible = true;

            // Opcional: Configurar el ancho y el nombre de las columnas
            dgvProduct.Columns["prod_name"].HeaderText = "Nombre";
            dgvProduct.Columns["prod_stock"].HeaderText = "Stock";
            dgvProduct.Columns["prod_price"].HeaderText = "Precio";
            
        }
        private void LoadComboCategory()
        {
            cmbCategory.DisplayMember = "cat_name";
            cmbCategory.ValueMember = "cat_id";
            cmbCategory.DataSource = categoryService.GetCategories();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no se haya hecho clic en el encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProduct.Rows[e.RowIndex];

                txtCodigo.Text = fila.Cells["prod_Barcode"].Value.ToString();
                txtName.Text = fila.Cells["prod_Name"].Value.ToString();
                txtUnitPrice.Text = fila.Cells["prod_Price"].Value.ToString();
            }
        }

        private void StartSale()
        {
            dgvSaleDetails.Clear();
            if (dgvSaleDetails.Columns.Count == 0) // Evitar recrear columnas
            {
                dgvSaleDetails.Columns.Add("#", typeof(int));
                dgvSaleDetails.Columns.Add("Codigo", typeof(string));
                dgvSaleDetails.Columns.Add("Descripcion", typeof(string)); // Cambiado a string (error en tu código original)
                dgvSaleDetails.Columns.Add("Cantidad", typeof(decimal));
                dgvSaleDetails.Columns.Add("Unitario", typeof(decimal));
                dgvSaleDetails.Columns.Add("Subtotal", typeof(decimal));
            }
            dgvSale.DataSource = dgvSaleDetails;
        }

        private void AddProductTable(string code, string description, decimal price, decimal quantity)
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
            string code = txtCodigo.Text; // O desde un DataGridView de productos
            string description = txtName.Text;
            decimal price = Convert.ToDecimal(txtUnitPrice.Text);
            decimal quantity = Convert.ToDecimal(txtQuantity.Text);

            AddProductTable(code, description, price, quantity);
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            btnPay.Enabled = false;
            lblSubtotal.Text = "$ 0.00";
            lblTotal.Text = "$ 0.00";
            StartSale();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            long codigoBarra = Convert.ToInt64(txtSearchArt.Text); // Obtener el código de barras de la caja de texto
            Product producto = productService.SearchProductByBarcode(codigoBarra); // Buscar el producto usando el código de barras

            if (producto != null) // Si se encuentra el producto
            {
                // Asignar los valores del producto a los cuadros de texto
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
    }
}
