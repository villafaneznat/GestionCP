using ProyectoSeminario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServicioProfesionales
    {
        void Borrar(Profesional profesional);
        bool Existe(Profesional profesional);
        List<Profesional> GetProfesionales(string textBusq);
        void Guardar(Profesional profesional);
    }
}
