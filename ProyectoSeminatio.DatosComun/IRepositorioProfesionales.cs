using ProyectoSeminario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminatio.DatosComun
{
    public interface IRepositorioProfesionales
    {
        void Agregar(Profesional profesional);
        void Borrar(Profesional profesional);
        void Editar(Profesional profesional);
        bool Existe(Profesional profesional);
        List<Profesional> GetProfesionales(string textBusq);
    }
}
