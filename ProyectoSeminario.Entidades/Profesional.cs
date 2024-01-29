using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Entidades
{
    public class Profesional
    {
        public int IdProfesional { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int NroMatricula { get; set; }
        public byte[] Firma { get; set; }
        public List<Profesion> Profesiones { get; set; }
    }
}
