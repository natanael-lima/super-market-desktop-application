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
    public partial class FrmProduct : Form
    {
        private ProductService productService = new ProductService();
        private CategoryService categoryService = new CategoryService();
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProduct.DataSource = productService.GetProducts();
            LoadComboCategory();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        private void LoadComboCategory()
        {
            cmbCategories.DisplayMember = "cat_name";
            cmbCategories.ValueMember = "cat_id";
            cmbCategories.DataSource = categoryService.GetCategories();
            cmbCategory.DisplayMember = "cat_name";
            cmbCategory.ValueMember = "cat_id";
            cmbCategory.DataSource = categoryService.GetCategories();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtBrand.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            richTxtDescription.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product productUpdate = new Product
            {
                Prod_Id = Int32.Parse(dgvProduct.CurrentRow.Cells["prod_Id"].Value.ToString()),
                Prod_Barcode = Convert.ToInt64(txtBarcode.Text.Trim()),
                Prod_Brand = txtBrand.Text,
                Prod_Description = richTxtDescription.Text,
                Prod_Name = txtName.Text,
                Prod_Price = Convert.ToDecimal(txtPrice.Text),
                Prod_Stock = Convert.ToInt32(txtStock.Text),
                Cat_Id = Convert.ToInt32(cmbCategory.SelectedValue),

            };
            productService.UpdateProduct(productUpdate);
            MessageBox.Show("Producto modificado correctamente");
            LoadProducts();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Si el usuario elige "Yes", proceder con la eliminación
            if (result == DialogResult.Yes)
            {
                int id = Int32.Parse(dgvProduct.CurrentRow.Cells["prod_Id"].Value.ToString());
                productService.DeleteProduct(id);
                LoadProducts();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                Prod_Barcode = Convert.ToInt64(txtBarcode.Text.Trim()),
                Prod_CreatedAt = DateTime.Now,
                Prod_Brand = txtBrand.Text,
                Prod_Description = richTxtDescription.Text,
                Prod_Name = txtName.Text,
                Prod_Price= Convert.ToDecimal(txtPrice.Text),
                Prod_Stock= Convert.ToInt32(txtStock.Text),
                Cat_Id = Convert.ToInt32(cmbCategory.SelectedValue),
            };
            productService.CreateProduct(newProduct);
            MessageBox.Show("Producto agregado correctamente");
            LoadProducts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "¿Estás seguro que deseas cancelar?",
            "Confirmación de Cancelación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                txtBarcode.Clear();
                txtBrand.Clear();
                txtName.Clear();
                txtPrice.Clear();
                txtStock.Clear();
            }
            else
            {
                // Acción si NO confirma: no se hace nada
            }

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no se haya hecho clic en el encabezado
            if (e.RowIndex >= 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnSave.Enabled = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;

                DataGridViewRow fila = dgvProduct.Rows[e.RowIndex];

      
                txtName.Text = fila.Cells["prod_Name"].Value.ToString();
                txtBarcode.Text = fila.Cells["prod_Barcode"].Value.ToString();
                txtBrand.Text= fila.Cells["prod_Brand"].Value.ToString();
                txtPrice.Text= fila.Cells["prod_Price"].Value.ToString();
                txtStock.Text = fila.Cells["prod_Stock"].Value.ToString();
                richTxtDescription.Text= fila.Cells["prod_Description"].Value.ToString();

            }
        }
    }
}
