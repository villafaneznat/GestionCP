using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.AgregarEditar
{
    public partial class FormUsuarioAE : Form
    {
        private readonly IServicioUsuarios _servicioUsuarios;

        private Usuario user;

        private bool esEdicion = false;

        public FormUsuarioAE()
        {
            InitializeComponent();
        }

        public FormUsuarioAE(IServicioUsuarios servicio) : this()
        {
            _servicioUsuarios = servicio;
        }

        public FormUsuarioAE(IServicioUsuarios servicio, Usuario u, bool edicion) : this(servicio)
        {
            user = u;
            esEdicion = edicion;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (esEdicion)
            {
                UserNameTXT.Text = user.UserName;
                PassTXT.Text = user.Password;
                MarcarRol();
            }
        }

        private void MarcarRol()
        {
            if ((int)user.Rol == 1)
            {
                AdministradorRadioButton.Checked = true;
            }
            else
            {
                ProfesionalRadioButton.Checked = true;
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (user == null)
                {
                    user = new Usuario();
                }
                user.UserName = UserNameTXT.Text;
                user.Password = PassTXT.Text;
                user.Rol = ObtenerRol();
                try
                {
                    if (!_servicioUsuarios.Exist(user))
                    {
                        _servicioUsuarios.Guardar(user);

                        if (!esEdicion)
                        {
                            MessageBox.Show("Registro agregado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult dr = MessageBox.Show("¿Desea agregar otro registro?", "Pregunta",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                            if (dr == DialogResult.No)
                            {
                                DialogResult = DialogResult.OK;

                            }
                            user = null;
                            //InicializarControles();

                        }
                        else
                        {
                            MessageBox.Show("Registro editado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registro duplicado",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        user = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Rol ObtenerRol()
        {
            Rol rol;
            if (AdministradorRadioButton.Checked)
            {
                rol = Rol.Administrador;
            }
            else 
            { 
                rol = Rol.Profesional; 
            }

            return rol;
        }

        private bool ValidarDatos()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(UserNameTXT.Text))
            {
                valido = false;
                MessageBox.Show("Debe ingresar un nombre de usuario, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (string.IsNullOrEmpty(PassTXT.Text))
            {
                valido = false;
                MessageBox.Show("Debe ingresar una contraseña, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PassTXT.Text.Length < 4)
            {
                valido = false;
                MessageBox.Show("la contraseña debe tener al menos 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (!AdministradorRadioButton.Checked && !ProfesionalRadioButton.Checked)
            {
                valido = false;
                MessageBox.Show("Debe seleccionar un rol, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valido;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
