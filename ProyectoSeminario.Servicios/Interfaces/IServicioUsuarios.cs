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
        bool Exist(Usuario user);
        List<Usuario> GetUsuarios();
        void Guardar(Usuario user);
        bool VerificarPermiso(Usuario user, TipoEntidad entidad, Permisos permiso);
    }
}
