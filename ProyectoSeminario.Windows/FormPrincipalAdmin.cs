using FontAwesome.Sharp;
using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;
using ProyectoSeminario.Windows.Entidades;
using ProyectoSeminario.Windows.Login;
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

namespace ProyectoSeminario.Windows
{
    public partial class FormPrincipalAdmin : Form
    {
        private IconButton btnActual;
        private Panel bordeIzquierdo;
        private Form formInterno;
        private readonly IServicioUsuarios _servicioUsuario;
        private Usuario currentUser;

        public FormPrincipalAdmin(Usuario user)
        {
            InitializeComponent();
            _servicioUsuario = new ServicioUsuarios();
            currentUser = user;
            //Para el diseño
            bordeIzquierdo = new Panel();
            bordeIzquierdo.Size = new Size(7, 60);
            panelMenu.Controls.Add(bordeIzquierdo);

        }
        private void FormPrincipalAdmin_Load(object sender, EventArgs e)
        {
            bool HabilitarHistoriasClínicas = _servicioUsuario.VerificarPermiso(currentUser, TipoEntidad.HistoriaClinica, Permisos.Leer);
            bool HabilitarProfesionales = _servicioUsuario.VerificarPermiso(currentUser, TipoEntidad.Profesional, Permisos.Leer);
            bool HabilitarPacientes = _servicioUsuario.VerificarPermiso(currentUser, TipoEntidad.Paciente, Permisos.Leer);
            bool HabilitarUsuarios = _servicioUsuario.VerificarPermiso(currentUser, TipoEntidad.Usuario, Permisos.Leer);

            switch (HabilitarHistoriasClínicas)
            {
                case true:
                    HistoriasIconButton.Visible = true;
                    break;

                case false:
                    HistoriasIconButton.Visible = false;
                    break;
            }

            switch (HabilitarProfesionales)
            {
                case true:
                    ProfesionalesIconButton.Visible = true;
                    break;

                case false:
                    ProfesionalesIconButton.Visible = false;
                    break;
            }

            switch (HabilitarPacientes)
            {
                case true:
                    PacientesIconButton.Visible = true;
                    break;

                case false:
                    PacientesIconButton.Visible = false;
                    break;
            }

            switch (HabilitarUsuarios)
            {
                case true:
                    UsuariosIconButton.Visible = true;
                    break;

                case false:
                    UsuariosIconButton.Visible = false;
                    break;
            }
        }

        Color color = Color.FromArgb(23, 88, 115);
        //Color color = Color.FromArgb(11, 171, 203);

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //Button
                btnActual = (IconButton)senderBtn;
                btnActual.BackColor = Color.White;
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;
                //btnActual.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 88, 91,100);

                //borde izquierdo
                bordeIzquierdo.BackColor = color;
                bordeIzquierdo.Location = new Point(0, btnActual.Location.Y);
                bordeIzquierdo.Visible = true;
                bordeIzquierdo.BringToFront();

                //Panel Top
                PanelTopIconPicture.IconChar = btnActual.IconChar;
                PanelTopLabel.Text = btnActual.Text;
            }
        }

        private void DisableButton()
        {
            if (btnActual != null)
            {
                btnActual.BackColor = color;
                //btnActual.FlatAppearance.MouseOverBackColor = SystemColors.ControlLightLight;
                btnActual.ForeColor = Color.White;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.White;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void IconPictureSalir_Click(object sender, EventArgs e)
        {
            IniciarSesionForm frm = new IniciarSesionForm();
            frm.Show();
            Close();

        }

        private void OpenForms(Form form)
        {
            if (formInterno != null)
            {
                formInterno.Close();
            }
            formInterno = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(form);
            PanelPrincipal.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void PacientesIconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenForms(new FormPacientes());

        }

        private void HistoriasIconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenForms(new FormHistoriasClinicas());

        }

        private void ProfesionalesIconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenForms(new FormProfesionales());
        }
    
        private void UsuariosIconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            OpenForms(new FormUsuarios());

        }

        private void CloseIconButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color);
            IniciarSesionForm frm = new IniciarSesionForm();
            frm.Show();
            Close();
        }
    
    }
}
