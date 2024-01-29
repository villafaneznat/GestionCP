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
    public class ServicioUsuarios : IServicioUsuarios
    {
        private readonly IRepositorioUsuarios _repoUsuarios;
        public ServicioUsuarios()
        {
            _repoUsuarios = new RepositorioUsuarios();
        }
        public bool Exist(Usuario user)
        {
            try
            {
                return _repoUsuarios.Exist(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> GetUsuarios()
        {
            return _repoUsuarios.GetUsuarios();
        }

        public void Guardar(Usuario user)
        {
            if (user.IdUser == 0)
            {

                _repoUsuarios.Agregar(user);

            }
            else
            {
                _repoUsuarios.Editar(user);
            }

        }

        public bool VerificarPermiso(Usuario user, TipoEntidad entidad, Permisos permiso)
        {
            bool concederPermiso = false;
            Dictionary<Permisos, bool> permisosDictionary = _repoUsuarios.ObtenerPermisosDeUsuario(user, entidad);
            
            if (permisosDictionary.TryGetValue(permiso, out bool valor))
            {
                concederPermiso = valor;
            }
            return concederPermiso;
        }
    }
}
