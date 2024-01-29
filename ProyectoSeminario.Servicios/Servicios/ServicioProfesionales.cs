using ProyectoSeminario.Datos;
using ProyectoSeminario.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminatio.DatosComun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServicioProfesionales : IServicioProfesionales
    {
        private readonly IRepositorioProfesionales _repoProfesionales;

        public ServicioProfesionales()
        {
            _repoProfesionales = new RepositorioProfesionales();
        }

        public void Borrar(Profesional profesional)
        {
            try
            {
                _repoProfesionales.Borrar(profesional);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Profesional profesional)
        {
            return _repoProfesionales.Existe(profesional);
        }

        public List<Profesional> GetProfesionales(string textBusq = null)
        {
            return _repoProfesionales.GetProfesionales(textBusq);
        }

        public void Guardar(Profesional profesional)
        {
            if (profesional.IdProfesional == 0)
            {

                _repoProfesionales.Agregar(profesional);

            }
            else
            {
                _repoProfesionales.Editar(profesional);
            }
        }
    }
}
