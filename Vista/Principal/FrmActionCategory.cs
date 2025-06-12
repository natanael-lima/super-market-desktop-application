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
    public partial class FrmActionCategory : Form
    {
        private CategoryService categoryService = new CategoryService();
        private int? categoryId = null; // null = nuevo, distinto de null = editar
        public FrmActionCategory()
        {
            InitializeComponent();
            btnUpdate.Visible = false; // por defecto solo se ve Save
        }
        public FrmActionCategory(int id, string name) : this()
        {
            categoryId = id;
            txtID.Text = id.ToString();
            txtName.Text = name;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (categoryId != null)
            {
                Category updateCat = new Category
                {
                    //Cat_Id = Int32.Parse(dgvCategory.CurrentRow.Cells["cat_Id"].Value.ToString()),
                    Cat_Id = categoryId.Value,
                    Cat_Name = txtName.Text
                };

                categoryService.UpdateCategory(updateCat);
                MessageBox.Show("Categoría modificada correctamente");
                this.Close(); // o podés usar DialogResult = OK si querés notificar al padre
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            Category catNew = new Category
            {
                Cat_Name = txtName.Text
            };

            categoryService.CreateCategory(catNew);
            MessageBox.Show("Categoría agregada correctamente");

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
                txtName.Clear();
                this.Close();
            }
            else
            {
                // Acción si NO confirma: no se hace nada
            }
        }

    }
}
