using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.Agregar
{
    public partial class FormProfesionalAE : Form
    {
        private readonly IServicioProfesionales _servicioProfesionales;

        private Profesional profesional;

        private bool esEdicion = false;

        public FormProfesionalAE(IServicioProfesionales servicio)
        {
            InitializeComponent();
            _servicioProfesionales = servicio;
        }

        public FormProfesionalAE(IServicioProfesionales servicio,Profesional prof, bool edicion) : this (servicio)
        {
            profesional = prof;
            esEdicion = edicion;
        }

        private void AEProfesionalForm_Load(object sender, EventArgs e)
        {
            
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (esEdicion)
            {         
                txtNombreProfesional.Text = profesional.Nombre;
                txtApellidoProfesional.Text = profesional.Apellido;
                txtDNIProfesional.Text = profesional.DNI.ToString();
                txtMatriculaProfesional.Text = profesional.NroMatricula.ToString();
                foreach (var profesion in profesional.Profesiones)
                {
                    CheckBox checkBox = CheckboxTick(profesion);/*Controls.OfType<CheckBox>().FirstOrDefault(cb => cb.Tag is Profesion && ((Profesion)cb.Tag).IdProfesion == profesion.IdProfesion)*/;

                    if (checkBox != null)
                    {
                        checkBox.Checked = true;
                    }
                }
                FirmaPictureBox.Image = MostrarFirma(profesional.Firma);

            }
        }

        private Image MostrarFirma(byte[] firma)
        {
            Image img = null;

            if (firma != null && firma.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(firma))
                    {
                        img = RedimensionarImagen(Image.FromStream(ms), FirmaPictureBox.Width, FirmaPictureBox.Height);                     
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al convertir bytes a imagen: {ex.Message}");
                }
            }

            return img;
        }

        private CheckBox CheckboxTick(Profesion profesion)
        {
            CheckBox check = null;
            switch (profesion.IdProfesion)
            {
                case 1:
                    check = PsicologaCheckBox;
                    break;
                case 2:
                    check = PsicologoCheckBox;
                    break;
                case 3:
                    check = PsiquiatraCheckBox;
                    break;
                case 4:
                    check = TerapistaCheckBox;
                    break;
                case 5:
                    check = NutricionistaCheckBox;
                    break;
                case 6:
                    check = AcTerapeuticoCheckBox;
                    break;
                case 7:
                    check = GinecologaCheckBox;
                    break;
                case 8:
                    check = TrabSocialCheckBox;
                    break;
            }
            return check;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (profesional == null)
                {
                    profesional = new Profesional();
                }
                profesional.Nombre = txtNombreProfesional.Text;
                profesional.Apellido = txtApellidoProfesional.Text;
                profesional.DNI = int.Parse(txtDNIProfesional.Text);
                profesional.NroMatricula = int.Parse(txtMatriculaProfesional.Text);
                profesional.Profesiones = ObtenerProfesiones();
                profesional.Firma = ObtenerFirma();
                try
                {

                    if (!_servicioProfesionales.Existe(profesional))
                    {
                        _servicioProfesionales.Guardar(profesional);

                        if (!esEdicion)
                        {
                            MessageBox.Show("Registro agregado",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult dr = MessageBox.Show("¿Desea agregar otro registro?",
                                "Pregunta",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
                            if (dr == DialogResult.No)
                            {
                                DialogResult = DialogResult.OK;

                            }
                            profesional = null;
                            InicializarControles();

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
                        profesional = null;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(txtNombreProfesional.Text))
            {
                valido = false;
                MessageBox.Show("Debe ingresar un nombre, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txtApellidoProfesional.Text))
            {
                valido = false;
                MessageBox.Show("Debe ingresar un apellido, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!int.TryParse(txtDNIProfesional.Text, out int dni)) 
            {
                valido = false;
                MessageBox.Show("Error al ingresar DNI, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!int.TryParse(txtMatriculaProfesional.Text, out int matricula))
            {
                valido = false;
                MessageBox.Show("Error al ingresar el numero de matricula, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return valido;
        }

        //FALTA ACOMODAR LA ESTETICA DEL FRM AE
        private void InicializarControles()
        {
            txtNombreProfesional.Text = "";
            txtApellidoProfesional.Text = "";
            txtDNIProfesional.Text = "";
            txtMatriculaProfesional.Text = "";
            PsicologaCheckBox.Checked = false;
            PsicologoCheckBox.Checked = false;
            PsiquiatraCheckBox.Checked = false;
            NutricionistaCheckBox.Checked = false;
            GinecologaCheckBox.Checked = false;
            TerapistaCheckBox.Checked = false;
            AcTerapeuticoCheckBox.Checked = false;
            TrabSocialCheckBox.Checked = false;
            FirmaPictureBox.Image = FirmaPictureBox.InitialImage;
        }

        private byte[] ObtenerFirma()
        {
            byte[] firma = null;

            if (FirmaPictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        FirmaPictureBox.Image.Save(ms, ImageFormat.Png);
                        firma = ms.ToArray();
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show($"Error al obtener la firma: {ex.Message}");
                    }
                }
            }

            return firma;
        }
      
        private List<Profesion> ObtenerProfesiones()
        {
            List<Profesion> lista = new List<Profesion>();

            if (PsicologaCheckBox.Checked)
            {
                //lista.Add(new Profesion { Nombre = "Psicóloga" });
                var profesion = new Profesion { IdProfesion = 1 };
                lista.Add(profesion);
                PsicologaCheckBox.Tag = profesion;
            }
            if (PsicologoCheckBox.Checked)
            {
                //lista.Add(new Profesion { Nombre = "Psicólogo" });

                var profesion = new Profesion { IdProfesion = 2 };
                lista.Add(profesion);
                PsicologoCheckBox.Tag = profesion;
            }
            if (PsiquiatraCheckBox.Checked)
            {
                //lista.Add(new Profesion { Nombre = "Psiquiatra" });
                var profesion = new Profesion { IdProfesion = 3 };
                lista.Add(profesion);
                PsiquiatraCheckBox.Tag = profesion;

            }
            if (NutricionistaCheckBox.Checked)
            {
                //lista.Add(new Profesion { Nombre = "Nutricionista" });
                var profesion = new Profesion { IdProfesion = 5 };
                lista.Add(profesion);
                NutricionistaCheckBox.Tag = profesion;
            }
            if (GinecologaCheckBox.Checked)
            {
                //lista.Add(new Profesion { Nombre = "Ginecóloga" });
                var profesion = new Profesion { IdProfesion = 7 };
                lista.Add(profesion);
                GinecologaCheckBox.Tag = profesion;

            }
            if (TerapistaCheckBox.Checked)
            {
                //lista.Add(new Profesion { Nombre = "Terapista Ocupacional" });
                var profesion = new Profesion { IdProfesion = 4 };
                lista.Add(profesion);
                TerapistaCheckBox.Tag = profesion;

            }
            if (AcTerapeuticoCheckBox.Checked)
            {
                //lista.Add(new Profesion { Nombre = "Acompañante Terapeutico" });
                var profesion = new Profesion { IdProfesion = 6 };
                lista.Add(profesion);
                AcTerapeuticoCheckBox.Tag = profesion;
            }
            if (TrabSocialCheckBox.Checked)
            {
                //lista.Add(new Profesion { Nombre = "Trabajadora sSocial" });
                var profesion = new Profesion { IdProfesion = 8 };
                lista.Add(profesion);
                TrabSocialCheckBox.Tag = profesion;
            }
        
            return lista;
        }

        private void CargarFirmaBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Imagen|*.png;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FirmaPictureBox.Image = RedimensionarImagen(
                        Image.FromFile(openFileDialog.FileName),
                        FirmaPictureBox.Width,FirmaPictureBox.Height);
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

        private void BorrarFirmaBtn_Click(object sender, EventArgs e)
        {
            FirmaPictureBox.Image = FirmaPictureBox.InitialImage;
        }

        private void PsicologoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PsicologoCheckBox.Checked)
            {
                PsicologaCheckBox.Checked = false;
                PsicologaCheckBox.Enabled = false;
            }
            else
            {
                PsicologaCheckBox.Enabled = true;
            }
        }

        private void PsicologaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PsicologaCheckBox.Checked)
            {
                PsicologoCheckBox.Checked = false;
                PsicologoCheckBox.Enabled = false;
            }
            else
            {
                PsicologoCheckBox.Enabled = true;
            }
        }

    }
}
