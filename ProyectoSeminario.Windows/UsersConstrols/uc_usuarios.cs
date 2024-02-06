using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;
using ProyectoSeminario.Windows.Agregar;
using ProyectoSeminario.Windows.AgregarEditar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.UsersConstrols
{
    public partial class uc_usuarios : UserControl
    { 
        private readonly IServicioUsuarios _servicioUsuarios;

        Usuario usuario;

        Usuario usuarioActivo = FormPrincipalAdmin.GetUsuarioActual();

        public string NombreUsuario { get => NombreUsuario; set => LblUserName.Text = value; }

        public string Password { get => Password; set => PasswordTxt.Text = value; }

        public Rol rol { get => rol; set => LblRol.Text = value.ToString(); }

        public event EventHandler UserEliminated;

        public event EventHandler UserEdited;

        public uc_usuarios()
        {
            InitializeComponent();
        }

        public uc_usuarios(IServicioUsuarios servicio, Usuario user)
        {
            InitializeComponent();
            _servicioUsuarios = servicio;
            usuario = user;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (usuario.IdUser == usuarioActivo.IdUser)
            {
                DeleteUserBtn.Enabled = false;
            }
        }

        // VISUALIZAR LA CONTRASEÑA
        private void VerPassButton_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTxt.PasswordChar = '\0';
        }

        private void VerPassButton_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordTxt.PasswordChar = '•';
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Se debe controlar que no este relacionado
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No) { return; }

                _servicioUsuarios.Borrar(usuario);
                UserEliminated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            FormUsuarioAE frm = new FormUsuarioAE(_servicioUsuarios, usuario, true);
            DialogResult dr = frm.ShowDialog(this);
            UserEdited?.Invoke(this, EventArgs.Empty);

        }
    }
}
