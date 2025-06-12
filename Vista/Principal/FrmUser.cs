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
            dgvUser.DataSource = userService.GetUsers();
            LoadComboRoles();
            btnUpdate.Visible = false;
            btnDelete.Visible = false; 
        }
        private void LoadComboRoles()
        {
            cmbRole.DisplayMember = "rol_description";
            cmbRole.ValueMember = "rol_id";
            cmbRole.DataSource = userService.GetRoles();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                User_Fullname = txtFullname.Text,
                User_Username = txtUsername.Text,
                User_Password = txtPassword.Text,
                Rol_Id = Convert.ToInt32(cmbRole.SelectedValue),
                User_Phone = Convert.ToInt32(txtPhone.Text) // Convierte el texto a int
            };
            userService.CreateUser(newUser);
            MessageBox.Show("Usuario agregado correctamente");
            LoadUsers();
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
                        txtFullname.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtPhone.Clear();
                    }
                    else
                    {
                        // Acción si NO confirma: no se hace nada
                    }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User updateUser = new User
            {
                User_Id = Int32.Parse(dgvUser.CurrentRow.Cells["user_Id"].Value.ToString()),
                User_Fullname = txtFullname.Text,
                User_Username = txtUsername.Text,
                User_Password = txtPassword.Text,
                User_Phone = Convert.ToInt32(txtPhone.Text),
                Rol_Id = (int)cmbRole.SelectedValue
            };

            userService.UpdateUser(updateUser);
            MessageBox.Show("Usuario modificado correctamente");
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(dgvUser.CurrentRow.Cells["user_Id"].Value.ToString());
            userService.DeleteUser(userId);
            LoadUsers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFullname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                txtFullname.Text = string.Empty;
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
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
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
