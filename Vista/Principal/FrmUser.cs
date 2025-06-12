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
using Logica;
using Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Vista.Properties;
using System.Resources;

namespace Vista.Principal
{
    public partial class FrmUser : Form
    {
        private UserService userService = new UserService();
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUser.Columns.Clear(); // Limpia columnas anteriores para evitar duplicados
            dgvUser.DataSource = userService.GetUsers();
     
            // Botón Editar
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Accion Editar";
            btnEdit.Text = "Editar";
            btnEdit.UseColumnTextForButtonValue = true;

           

            dgvUser.Columns.Add(btnEdit);

            // Botón Eliminar
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Accion Eliminar";
            btnDelete.Text = "Eliminar";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvUser.Columns.Add(btnDelete);

            // Asegura que el evento no se duplique
            dgvUser.CellFormatting -= dgvUser_CellFormatting;
            dgvUser.CellFormatting += dgvUser_CellFormatting;
        }
        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvUser.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(173, 216, 230); // Azul pastel
                    dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
                else if (dgvUser.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(255, 182, 193); // Rojo pastel
                    dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
            }
        }
       

        /*private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtFullname.Text = string.Empty;
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                string rol = dgvUser.CurrentRow.Cells["rol_Id"].Value.ToString();
                if (rol == "Administrador")
                    cmbRole.SelectedValue = 1;
                if (rol == "Cajero")
                    cmbRole.SelectedValue = 2;

                txtFullname.Text = dgvUser.CurrentRow.Cells["user_Fullname"].Value.ToString();
                txtUsername.Text = dgvUser.CurrentRow.Cells["user_Username"].Value.ToString();
                txtPassword.Text = dgvUser.CurrentRow.Cells["user_Password"].Value.ToString();
                txtPhone.Text = dgvUser.CurrentRow.Cells["user_Phone"].Value.ToString();
            }
        }*/

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            /*if (e.RowIndex >= 0)
            {
        

                DataGridViewRow fila = dgvUser.Rows[e.RowIndex];

                string rol = fila.Cells["rol_Id"].Value.ToString();
                if (rol == "Administrador")
                    cmbRole.SelectedValue = 1;
                else if (rol == "Cajero")
                    cmbRole.SelectedValue = 2;

                txtFullname.Text = fila.Cells["user_Fullname"].Value.ToString();
                txtUsername.Text = fila.Cells["user_Username"].Value.ToString();
                txtPassword.Text = fila.Cells["user_Password"].Value.ToString();
                txtPhone.Text = fila.Cells["user_Phone"].Value.ToString();
            }*/

            if (e.RowIndex < 0) return;

            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            int id = Int32.Parse(dgvUser.CurrentRow.Cells["user_Id"].Value.ToString());
            string fullname = dgvUser.Rows[e.RowIndex].Cells["user_Fullname"].Value.ToString();
            string username = dgvUser.Rows[e.RowIndex].Cells["user_Username"].Value.ToString();
            string password = dgvUser.Rows[e.RowIndex].Cells["user_Password"].Value.ToString();
            int phone = Int32.Parse(dgvUser.Rows[e.RowIndex].Cells["user_Phone"].Value.ToString());
            string rol = dgvUser.CurrentRow.Cells["rol_Id"].Value.ToString();
           

            if (colName == "btnEdit")
            {
                
                // Cargar los datos en los campos
                FrmActionUser frm = new FrmActionUser( id,  fullname,  username,  password,  phone, rol);
                frm.ShowDialog();
                LoadUsers();// refrescar después de cerrar
            }
            else if (colName == "btnDelete")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int userId = Int32.Parse(dgvUser.CurrentRow.Cells["user_Id"].Value.ToString());
                    userService.DeleteUser(userId);
                    MessageBox.Show("Categoría eliminada correctamente");
                    LoadUsers();
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searched = (txtSearch.Text);
            DataTable result = userService.SearchUserByNameOrUsername(searched);

            if (result != null && result.Rows.Count > 0)
            {
                dgvUser.DataSource = result;
            }
            else
            {
                MessageBox.Show("User no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dgvProduct.DataSource = null; 
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnOpenAdd_Click(object sender, EventArgs e)
        {

            using (FrmActionUser frm = new FrmActionUser())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers(); // Recarga las categorías
                }
            }
        }
        private void btnOpenUpdate_Click(object sender, EventArgs e)
        {
            FrmActionUser frm = new FrmActionUser();
            frm.ShowDialog();

        }
    }
}
