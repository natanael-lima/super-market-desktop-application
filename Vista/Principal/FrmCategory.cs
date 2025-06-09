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
            dgvCategory.Columns.Clear(); // Limpia columnas anteriores para evitar duplicados
            dgvCategory.DataSource = categoryService.GetCategories();
            // Botón Editar
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "-";
            btnEdit.Text = "Editar";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvCategory.Columns.Add(btnEdit);

            // Botón Eliminar
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "-";
            btnDelete.Text = "Eliminar";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvCategory.Columns.Add(btnDelete);
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        
        private void btnOpenUpdate_Click(object sender, EventArgs e)
        {
            FrmActionCategory frm = new FrmActionCategory();
            frm.ShowDialog();

        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            int id = Int32.Parse(dgvCategory.CurrentRow.Cells["cat_Id"].Value.ToString());
            //int id = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells["cat_Id"].Value);
            string name = dgvCategory.Rows[e.RowIndex].Cells["cat_Name"].Value.ToString();

            if (colName == "btnEdit")
            {
                // Cargar los datos en los campos
                FrmActionCategory frm = new FrmActionCategory(id, name);
                frm.ShowDialog();
                LoadCategories(); // refrescar después de cerrar
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

        private void btnOpenAdd_Click(object sender, EventArgs e)
        {
            FrmActionCategory frm = new FrmActionCategory();
            frm.ShowDialog();
        }
    }
}
