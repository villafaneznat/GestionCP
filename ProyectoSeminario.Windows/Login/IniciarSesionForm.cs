using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.Login
{
    public partial class IniciarSesionForm : Form
    {
        //usuario rol 1: admin; pass: admin
        //usuario rol 2: Juan Perez; pass: 4321

        private readonly IServicioUsuarios _servicioUsuario;

        private List<Usuario> usuariosList;

        string userName, password;

        Usuario user;

        public IniciarSesionForm()
        {
            InitializeComponent();
            _servicioUsuario = new ServicioUsuarios();
        }

        private void IniciarSesionForm_Load(object sender, EventArgs e)
        {
            usuariosList = _servicioUsuario.GetUsuarios();
        }

        private void IniciarSesionBtn_Click(object sender, EventArgs e)
        {
            if (ValidAccess())
            {
                userName = textBoxNombreUser.Text;
                password = textBoxPassword.Text;
                user = SearchUser(userName);

                if (user != null)
                {
                    if (user.Password == password)
                    {
                        FormPrincipalAdmin frm = new FormPrincipalAdmin(user);
                        frm.Show();
                        this.Hide();
                        //if (user.IdRol == 1)
                        //{
                        //    FormPrincipalAdmin frm = new FormPrincipalAdmin();
                        //    frm.Show();
                        //    this.Hide();
                        //}
                        //else
                        //{
                        //    InvalidAccessMessage();
                        //}
                    }
                    else
                    {
                        InvalidAccessMessage();
                    }

                }
                else
                {
                    InvalidAccessMessage();
                }
            }
        }

        private Usuario SearchUser(string alias)
        {
            Usuario usuarioIngresante = null;
            foreach (var usuario in usuariosList)
            {
                if (usuario.UserName == alias)
                {
                    usuarioIngresante = usuario;
                    break;
                }
            }
            return usuarioIngresante;
        }

        private bool ValidAccess()
        {
            bool validAccess = true;
            if (string.IsNullOrEmpty(textBoxNombreUser.Text) || textBoxNombreUser.Text == "Nombre de usuario")
            {
                InvalidAccessMessage();
                validAccess = false;
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text) || textBoxPassword.Text == "Contraseña")
            {
                InvalidAccessMessage();
                validAccess = false;
            }
            return validAccess;
        }

        private void InvalidAccessMessage()
        {
            MessageBox.Show("Nombre de usuario o contraseña incorrectos, por favor intente nuevamente",
                       "Error de ingreso",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Stop);
            textBoxNombreUser.Focus();
            textBoxNombreUser.SelectAll();
        }

        private void IconPictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // PLACEHOLDER
        private void textBoxNombreUser_Enter(object sender, EventArgs e)
        {
            if (textBoxNombreUser.Text == "Nombre de usuario")
            {
                textBoxNombreUser.Text = "";
            }
        }

        private void textBoxNombreUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreUser.Text))
            {
                textBoxNombreUser.Text = "Nombre de usuario";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Contraseña")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '•';
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Contraseña";
                textBoxPassword.PasswordChar = '\0';
            }
        }

        // VISUALIZAR LA CONTRASEÑA
        private void IconButtonVerPassw_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void IconButtonVerPassw_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '•';
        }

    }
}
