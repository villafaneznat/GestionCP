using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;
using ProyectoSeminario.Windows.Agregar;
using ProyectoSeminario.Windows.AgregarEditar;
using ProyectoSeminario.Windows.UsersConstrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.Entidades
{
    public partial class FormUsuarios : Form
    {
        private readonly IServicioUsuarios _servicioUsuarios;

        private List<Usuario> usersList;

        string textBusq = null;

        public FormUsuarios()
        {
            InitializeComponent();
            _servicioUsuarios = new ServicioUsuarios();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            usersList = _servicioUsuarios.GetUsuarios(null);
            ShowDataInLayout();
        }

        private void ShowDataInLayout()
        {
            FlowLayoutPanelUsuarios.Controls.Clear();
            foreach (var u in usersList)
            {
                var user = SetearUserControl(u);
                UserControlAdd(user);
            }
        }

        private void UserControlAdd(uc_usuarios user)
        {
            FlowLayoutPanelUsuarios.Controls.Add(user);
        }

        private void UserEliminated(object sender, EventArgs e)
        {
            FormUsuarios_Load(sender, e);
        }

        private void UserEdited(object sender, EventArgs e)
        {
            FormUsuarios_Load(sender, e);
        }

        private uc_usuarios SetearUserControl(Usuario user)
        {
            uc_usuarios ucUsuarios = new uc_usuarios(_servicioUsuarios, user)
            {
                NombreUsuario = user.UserName,
                Password = user.Password,
                rol = user.Rol
            };
            ucUsuarios.UserEliminated += UserEliminated;
            ucUsuarios.UserEdited += UserEdited;

            return ucUsuarios;
        }

        private void AgregarUsuarioButton_Click(object sender, EventArgs e)
        {
            FormUsuarioAE frm = new FormUsuarioAE(_servicioUsuarios);
            DialogResult dr = frm.ShowDialog(this);
            FormUsuarios_Load(sender, e);
        }

        private void txtBuscarUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
            {
                txtBuscarUsuario.Text = "Buscar usuario...";
            }
        }

        private void txtBuscarUsuario_Enter(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text == "Buscar usuario...")
            {
                txtBuscarUsuario.Text = "";
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text == "Buscar usuario...")
            {
                usersList = _servicioUsuarios.GetUsuarios(textBusq = null);
            }
            else
            {
                textBusq = txtBuscarUsuario.Text;
                usersList = _servicioUsuarios.GetUsuarios(textBusq);
                //ShowDataInGrid();        
            }
            ShowDataInLayout();
        }
    }
}
