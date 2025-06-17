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
            LoadComboCategory();
        }
        private void LoadComboCategory()
        {
            DataTable categories = categoryService.GetCategories();

            // Agregar opción por defecto
            DataRow row = categories.NewRow();
            row["cat_id"] = -1;
            row["cat_name"] = "Todos";
            categories.Rows.InsertAt(row, 0);
            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "cat_name";
            cmbCategories.ValueMember = "cat_id";

            dgvProduct.Columns.Clear(); // Limpia columnas anteriores para evitar duplicados
            dgvProduct.DataSource = productService.GetProducts();
            // Botón Editar
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Editar";
            btnEdit.Text = "Editar";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvProduct.Columns.Add(btnEdit);

            // Botón Eliminar
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Eliminar";
            btnDelete.Text = "Eliminar";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvProduct.Columns.Add(btnDelete);

            // Asegura que el evento no se duplique
            dgvProduct.CellFormatting -= dgvCategory_CellFormatting;
            dgvProduct.CellFormatting += dgvCategory_CellFormatting;
        }
        private void dgvCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvProduct.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(173, 216, 230); // Azul pastel
                    dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(255, 182, 193); // Rojo pastel
                    dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
            }
        }

        private void btnOpenAdd_Click(object sender, EventArgs e)
        {
            using (FrmActionProduct frm = new FrmActionProduct())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts(); // Recarga
                }
            }
        }
        private void btnOpenUpdate_Click(object sender, EventArgs e)
        {
            FrmActionProduct frm = new FrmActionProduct();
            frm.ShowDialog();

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no se haya hecho clic en el encabezado
            if (e.RowIndex < 0) return;
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            int id = Int32.Parse(dgvProduct.CurrentRow.Cells["prod_Id"].Value.ToString());
            long barcode = Int64.Parse(dgvProduct.Rows[e.RowIndex].Cells["prod_Barcode"].Value.ToString());
            string brand = dgvProduct.Rows[e.RowIndex].Cells["prod_Brand"].Value.ToString();
            string description = dgvProduct.Rows[e.RowIndex].Cells["prod_Description"].Value.ToString();
            decimal price = Decimal.Parse(dgvProduct.Rows[e.RowIndex].Cells["prod_Price"].Value.ToString());
            int stock = Int32.Parse(dgvProduct.Rows[e.RowIndex].Cells["prod_Stock"].Value.ToString());
            int categoryId = Int32.Parse(dgvProduct.CurrentRow.Cells["cat_Id"].Value.ToString());
           
            if (colName == "btnEdit")
            {
                // Cargar los datos en los campos
                FrmActionProduct frm = new FrmActionProduct(id, barcode, brand, description, price, stock, categoryId);
                frm.ShowDialog();
                LoadProducts();// refrescar después de cerrar
            }
            else if (colName == "btnDelete")
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
                    int idProduct = Int32.Parse(dgvProduct.CurrentRow.Cells["prod_Id"].Value.ToString());
                    productService.DeleteProduct(idProduct);
                    MessageBox.Show("Producto eliminada correctamente");
                    LoadProducts();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searched = (txtSearch.Text);
            DataTable result = productService.SearchProductByNameOrBrand(searched);

            if (result != null && result.Rows.Count > 0)
            {
                dgvProduct.DataSource = result;
            }
            else
            {
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dgvProduct.DataSource = null; 
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedValue != null && int.TryParse(cmbCategories.SelectedValue.ToString(), out int categoryId))
            {
                if (categoryId == -1) // Es la opción "Seleccionar categoría"
                {
                    LoadProducts();
                    return;
                }
                //int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
      
                DataTable products = productService.SearchProductByCategory(categoryId);

                if (products.Rows.Count > 0)
                {
                    dgvProduct.DataSource = products;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para esta categoría.");
                    dgvProduct.DataSource = null;
                }
            }
        }

       
    }
}
