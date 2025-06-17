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
    public partial class FrmActionUser : Form
    {
        private UserService userService = new UserService();
        private int? userId = null; // null = nuevo, distinto de null = editar
        public FrmActionUser()
        {
            InitializeComponent();
            btnUpdate.Visible = false; // por defecto solo se ve Save
        }
        public FrmActionUser(int id, string fullname, string username, string password, int phone, string rol) : this()
        {
            userId = id;

            // Cargar primero las categorías
            LoadComboRoles();

            txtFullname.Text = fullname;
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtPhone.Text = phone.ToString();

            // Establecer la categoría seleccionada correctamente
            cmbRole.SelectedValue = rol;

            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        private void LoadComboRoles()
        {
            cmbRole.DisplayMember = "rol_description";
            cmbRole.ValueMember = "rol_id";
            cmbRole.DataSource = userService.GetRoles();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userId != null)
            {
                User updateUser = new User
                {
                    User_Id = userId.Value,
                    User_Fullname = txtFullname.Text,
                    User_Username = txtUsername.Text,
                    User_Password = txtPassword.Text,
                    User_Phone = Convert.ToInt32(txtPhone.Text),
                    Rol_Id = (int)cmbRole.SelectedValue
                };

                userService.UpdateUser(updateUser);
                MessageBox.Show("Usuario modificado correctamente");
                this.Close();
            }   
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullname.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

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
                txtFullname.Clear();
                this.Close();
            }
            else
            {
                // Acción si NO confirma: no se hace nada
            }
        }

       
    }
}
