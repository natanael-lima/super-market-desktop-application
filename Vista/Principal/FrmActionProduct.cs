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
using System.Xml.Linq;

namespace Vista.Principal
{
    public partial class FrmActionProduct : Form
    {
        private ProductService productService = new ProductService();
        private CategoryService categoryService = new CategoryService();
        private int? productId = null; // null = nuevo, distinto de null = editar
        public FrmActionProduct()
        {
            InitializeComponent();
            btnUpdate.Visible = false; // por defecto solo se ve Save
        }
        public FrmActionProduct(int id, long barcode, string brand, string description, decimal price, int stock, int categoryId) : this()
        {
            productId = id;
            // 1. Cargar primero las categorías
            LoadComboCategory();
           
            // 2. Cargar el resto de los datos del producto
            txtBarcode.Text = barcode.ToString();
            txtBrand.Text = brand;
            richTxtDescription.Text = description;
            txtPrice.Text = price.ToString();
            txtStock.Text = stock.ToString();
            // 3. Establecer la categoría seleccionada correctamente
            cmbCategory.SelectedValue = categoryId;

            btnSave.Visible = false;
            btnUpdate.Visible = true;

        }
 
        private void LoadComboCategory()
        {
            cmbCategory.DisplayMember = "cat_name";
            cmbCategory.ValueMember = "cat_id";
            cmbCategory.DataSource = categoryService.GetCategories();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (productId != 0)
            {
                Product upProduct = new Product
                {
                    Prod_Id = productId.Value,// <-- Asegúrate de asignar el ID para que se actualice correctamente
                    Prod_Barcode = Convert.ToInt64(txtBarcode.Text.Trim()),
                    Prod_CreatedAt = DateTime.Now,
                    Prod_Brand = txtBrand.Text,
                    Prod_Description = richTxtDescription.Text,
                    Prod_Price = Convert.ToDecimal(txtPrice.Text),
                    Prod_Stock = Convert.ToInt32(txtStock.Text),
                    Cat_Id = Convert.ToInt32(cmbCategory.SelectedValue),
                };
                productService.UpdateProduct(upProduct);
                MessageBox.Show("Producto actualizado correctamente");
                this.DialogResult = DialogResult.OK; // Opcional: para saber en el formulario padre que se actualizó
                this.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            Product newProduct = new Product
            {
                Prod_Barcode = Convert.ToInt64(txtBarcode.Text.Trim()),
                Prod_CreatedAt = DateTime.Now,
                Prod_Brand = txtBrand.Text,
                Prod_Description = richTxtDescription.Text,
                Prod_Price = Convert.ToDecimal(txtPrice.Text),
                Prod_Stock = Convert.ToInt32(txtStock.Text),
                Cat_Id = Convert.ToInt32(cmbCategory.SelectedValue),
            };

            productService.CreateProduct(newProduct);
            MessageBox.Show("Product agregado correctamente");
            this.DialogResult = DialogResult.OK; // <- importante
            this.Close();
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
                txtPrice.Clear();
                txtStock.Clear();
                this.Close();
            }
            else
            {
                // Acción si NO confirma: no se hace nada
            }
        }
    }
}
