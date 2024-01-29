using Microsoft.Win32;
using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;
using ProyectoSeminario.Windows.Agregar;
using ProyectoSeminario.Windows.Helpers;
using ProyectoSeminario.Windows.UsersConstrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.Entidades
{
    public partial class FormProfesionales : Form
    {
        private readonly IServicioProfesionales _servicioProfesionales;

        private List<Profesional> profesionalesList;

        string textBusq = null;
        public FormProfesionales()
        {
            InitializeComponent();
            _servicioProfesionales = new ServicioProfesionales();
        }

        private void FormProfesionales_Load(object sender, EventArgs e)
        {
            profesionalesList = _servicioProfesionales.GetProfesionales(textBusq);
            //ShowDataInGrid();
            ShowDataInLayout();
        }

        private void ShowDataInLayout()
        {
            FlowLayoutPanelProfesionales.Controls.Clear();
            foreach (var prof in profesionalesList) 
            { 
                var profesional = SetearUserControl(prof);
                UserControlAdd(profesional);
            }
        }

        private void UserControlAdd(uc_profesionales profesional)
        {
            FlowLayoutPanelProfesionales.Controls.Add(profesional);
        }

        private void ProfesionalEliminated(object sender, EventArgs e)
        {
            FormProfesionales_Load(sender, e);
            //FlowLayoutPanelProfesionales.Controls.Remove(ucProfesionales);
            //ucProfesionales.Dispose();
        }
        private void ProfesionalEdited(object sender, EventArgs e)
        {
            FormProfesionales_Load(sender, e);
        }

        private uc_profesionales SetearUserControl(Profesional prof)
        {
            uc_profesionales ucProfesionales = new uc_profesionales(_servicioProfesionales, prof)
            {
                Nombre = prof.Nombre,
                Apellido = prof.Apellido,
                DNI = prof.DNI,
                Matricula = prof.NroMatricula,
                Firma = prof.Firma,
                Profesion = prof.Profesiones
            };
            ucProfesionales.ProfesionalEliminated += ProfesionalEliminated;
            ucProfesionales.ProfesionalEdited += ProfesionalEdited;

            return ucProfesionales;
        }

        private void txtBuscarProfesional_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProfesional.Text))
            {
                txtBuscarProfesional.Text = "Buscar profesional...";
            }
        }

        private void txtBuscarProfesional_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProfesional.Text == "Buscar profesional...")
            {
                txtBuscarProfesional.Text = "";
            }
        }

        private void AgregarProfesionalButton_Click(object sender, EventArgs e)
        {
            FormProfesionalAE frm = new FormProfesionalAE(_servicioProfesionales);
            DialogResult dr = frm.ShowDialog(this);
            FormProfesionales_Load(sender, e);
        }

        private void txtBuscarProfesional_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProfesional.Text == "Buscar profesional...")
            {
                profesionalesList = _servicioProfesionales.GetProfesionales(textBusq = null);
            }
            else
            {
                textBusq = txtBuscarProfesional.Text;
                profesionalesList = _servicioProfesionales.GetProfesionales(textBusq);
                //ShowDataInGrid();        
            }
            ShowDataInLayout();
        }
    }
}
