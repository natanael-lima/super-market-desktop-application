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
            //dgvCategory.DataSource = categoryService.GetCategories();
            //btnUpdate.Visible = false;
            //btnDelete.Visible = false;

            dgvCategory.Columns.Clear(); // Limpia columnas anteriores para evitar duplicados
            dgvCategory.DataSource = categoryService.GetCategories();
            // Botón Editar
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Editar";
            btnEdit.Text = "Editar";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvCategory.Columns.Add(btnEdit);

            // Botón Eliminar
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Eliminar";
            btnDelete.Text = "Eliminar";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvCategory.Columns.Add(btnDelete);
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

            if (e.RowIndex < 0) return;

            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            int id = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells["cat_Id"].Value);
            string name = dgvCategory.Rows[e.RowIndex].Cells["cat_Name"].Value.ToString();

            if (colName == "btnEdit")
            {
                // Cargar los datos en los campos
                txtID.Text = id.ToString();
                txtName.Text = name;

                btnUpdate.Visible = true;
                btnDelete.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = true;
            }
            else if (colName == "btnDelete")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    categoryService.DeleteCategory(id);
                    LoadCategories();
                    MessageBox.Show("Categoría eliminada correctamente");
                }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddCategory frm = new FrmAddCategory();
            frm.Show();
        }
    }
}
