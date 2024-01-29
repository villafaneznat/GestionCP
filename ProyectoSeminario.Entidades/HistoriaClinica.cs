using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Entidades
{
    public class HistoriaClinica
    {
        public int IdHC { get; set; }
        public int NumeroHC { get; set; }
        public int IdPaciente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime HoraCreacion { get; set; }
        public string Ruta { get; set; }

    }
}
