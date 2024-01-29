using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.UsersConstrols
{
    public partial class uc_usuarios : UserControl
    { 
        private readonly IServicioUsuarios _servicioUsuarios;

        Usuario usuario;
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

        // VISUALIZAR LA CONTRASEÑA
        private void VerPassButton_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTxt.PasswordChar = '\0';
        }

        private void VerPassButton_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordTxt.PasswordChar = '•';
        }
    }
}
