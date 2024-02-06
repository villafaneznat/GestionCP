using ProyectoSeminario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServicioUsuarios
    {
        void Borrar(Usuario usuario);
        bool Exist(Usuario user);
        List<Usuario> GetUsuarios(string textBusq);
        void Guardar(Usuario user);
        bool VerificarPermiso(Usuario user, TipoEntidad entidad, Permisos permiso);
    }
}
