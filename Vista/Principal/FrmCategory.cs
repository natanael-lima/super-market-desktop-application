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
    public partial class FrmCategory : Form
    {
        private CategoryService categoryService = new CategoryService();
        public FrmCategory()
        {
            InitializeComponent();
        }
        private void LoadCategories()
        {
            dgvCategory.DataSource = categoryService.GetCategories();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Category catNew = new Category
            {
                Cat_Name = txtName.Text
            };
            categoryService.CreateCategory(catNew);
            MessageBox.Show("Categoria agregado correctamente");
            LoadCategories();
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
                txtName.Clear();
            }
            else
            {
                // Acción si NO confirma: no se hace nada
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtID.Clear();
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
            Category updateCat = new Category
            {
                Cat_Id = Int32.Parse(dgvCategory.CurrentRow.Cells["cat_Id"].Value.ToString()),
                Cat_Name = txtName.Text
            };

            categoryService.UpdateCategory(updateCat);
            MessageBox.Show("Categoria modificado correctamente");
            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvCategory.CurrentRow.Cells["cat_Id"].Value.ToString());
            categoryService.DeleteCategory(id);
            LoadCategories();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
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

                DataGridViewRow fila = dgvCategory.Rows[e.RowIndex];

                txtName.Text = fila.Cells["cat_Name"].Value.ToString();
                txtID.Text = fila.Cells["cat_Id"].Value.ToString();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searched = (txtSearch.Text);
            DataTable result = categoryService.SearchCategoryByName(searched);

            if (result != null && result.Rows.Count > 0)
            {
                dgvCategory.DataSource = result;
            }
            else
            {
                MessageBox.Show("Categoria no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dgvProduct.DataSource = null; 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
