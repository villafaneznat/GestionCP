using Microsoft.Win32;
using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;
using ProyectoSeminario.Windows.Agregar;
using ProyectoSeminario.Windows.Entidades;
using ProyectoSeminario.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.UsersConstrols
{
    public partial class uc_profesionales : UserControl
    {
        Color colorBorde = Color.FromArgb(162, 161, 161);

        private readonly IServicioProfesionales _servicioProfesionales;

        Profesional profesional;

        public event EventHandler ProfesionalEliminated;

        public event EventHandler ProfesionalEdited;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            ControlPaint.DrawBorder(e.Graphics, rect, colorBorde, ButtonBorderStyle.Solid);

        }

        public uc_profesionales()
        {

        }

        public uc_profesionales(IServicioProfesionales servicio, Profesional prof)
        {
            InitializeComponent();
            _servicioProfesionales = servicio;
            profesional = prof;
        }

        public string Nombre { get => Nombre; set => LblNombre.Text = value; }

        public string Apellido { get => Apellido; set => LblApellido.Text = value; }

        public int DNI { get => DNI; set => LblNroDocumento.Text = value.ToString("N0"); }

        public int Matricula { get => Matricula; set => LblNroMatricula.Text = value.ToString(); }

        public List<Profesion> Profesion
        {
            get { return Profesion; }
            set
            {
                if (value != null && value.Count > 0)
                {
                    // Concatenar las profesiones en líneas nuevas
                    string profesionesTexto = string.Join("\n", value.Select(p => p.Nombre));

                    LblProfesion.Text = profesionesTexto;
                }
                else
                {
                    LblProfesion.Text = "Sin profesión";
                }

            }
        }

        public byte[] Firma
        {
            get { return Firma; }
            set
            {
                using (MemoryStream ms = new MemoryStream(value))
                {
                    Image firmaImage = Image.FromStream(ms);

                    firmaImage = RedimensionarImagen(firmaImage, PictureBoxFirma.Width, PictureBoxFirma.Height);

                    PictureBoxFirma.Image = firmaImage;
                }

            }
        }

        private Image RedimensionarImagen(Image imagen, int nuevoAncho, int nuevoAlto)
        {
            Bitmap nuevaImagen = new Bitmap(nuevoAncho, nuevoAlto);

            using (Graphics gr = Graphics.FromImage(nuevaImagen))
            {
                gr.DrawImage(imagen, new Rectangle(0, 0, nuevoAncho, nuevoAlto));
            }

            return nuevaImagen;
        }

        private void uc_profesionales_Load(object sender, EventArgs e)
        {

        }

        private void BorrarProfesionalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Se debe controlar que no este relacionado
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No) { return; }

                _servicioProfesionales.Borrar(profesional);
                ProfesionalEliminated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProfesionalesBtn_Click(object sender, EventArgs e)
        {
            FormProfesionalAE frm = new FormProfesionalAE(_servicioProfesionales, profesional, true);
            DialogResult dr = frm.ShowDialog(this);
            ProfesionalEdited?.Invoke(this, EventArgs.Empty);
        }
    }
}
