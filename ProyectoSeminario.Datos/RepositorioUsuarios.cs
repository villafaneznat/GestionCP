using ProyectoSeminario.Entidades;
using ProyectoSeminatio.DatosComun;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;

namespace ProyectoSeminario.Datos
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private string cadenaConexion;

        public RepositorioUsuarios()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["SqlConnection"].ToString();
        }

        public void Agregar(Usuario user)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string insertQuery = @"INSERT INTO Usuarios(UserName, Password, IdRol) 
                                    VALUES(@UserName, @Password, @IdRol);
                                    SELECT SCOPE_IDENTITY()";
                var parametros = new { UserName = user.UserName, Password = user.Password, IdRol = (int)user.Rol };
                int id = conn.ExecuteScalar<int>(insertQuery, parametros);
                user.IdUser = id;
            }
        }

        public void Borrar(Usuario usuario)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Usuarios WHERE IdUser=@IdUser";
                conn.Execute(deleteQuery, new { usuario.IdUser });
            }
        }

        public void Editar(Usuario user)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Usuarios 
                    SET UserName=@UserName, 
                    Password=@Password, 
					IdRol=@IdRol
                    WHERE IdUser=@IdUser";
                var parametros = new { UserName = user.UserName, Password = user.Password, IdRol = (int)user.Rol, IdUser = user.IdUser };
                conn.Execute(updateQuery, parametros);
            }
        }

        public bool Exist(Usuario user)
        {
            int cantidad = 0;
            using (var con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                string selectQuery = "SELECT COUNT(*) FROM Usuarios WHERE UserName=@UserName AND Password=@Password";
                
                using (var comando = new SqlCommand(selectQuery, con))
                {
                    comando.Parameters.Add("@UserName", SqlDbType.NVarChar);
                    comando.Parameters["@UserName"].Value = user.UserName;
                    
                    comando.Parameters.Add("@Password", SqlDbType.NVarChar);
                    comando.Parameters["@Password"].Value = user.Password;

                    cantidad = Convert.ToInt32(comando.ExecuteScalar());
                }
            }
            return cantidad > 0;
        }

        public List<Usuario> GetUsuarios(string textBusq = null)
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                using (var con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    string selectQuery;
                    if (textBusq != null)
                    {
                        selectQuery = @"SELECT IdUser, UserName, Password, IdRol FROM Usuarios
							WHERE UPPER(UserName) LIKE @textBusq";
                        using (var comando = new SqlCommand(selectQuery, con))
                        {
                            comando.Parameters.Add("@textBusq", SqlDbType.NVarChar);
                            comando.Parameters["@textBusq"].Value = $"%{textBusq}%";
                            using (var reader = comando.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    Usuario usuario = new Usuario()
                                    {
                                        IdUser = reader.GetInt32(0),
                                        UserName = reader.GetString(1),
                                        Password = reader.GetString(2)
                                    };
                                    if (reader.GetInt32(3) == 1)
                                    {
                                        usuario.Rol = Rol.Administrador;
                                    }
                                    else
                                    {
                                        usuario.Rol = Rol.Profesional;

                                    }

                                    lista.Add(usuario);
                                }
                            }
                        }
                    }
                    else
                    {
                        selectQuery = "SELECT IdUser, UserName, Password, IdRol FROM Usuarios";
                        using (var comando = new SqlCommand(selectQuery, con))
                        {
                            using (var reader = comando.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Usuario usuario = new Usuario()
                                    {
                                        IdUser = reader.GetInt32(0),
                                        UserName = reader.GetString(1),
                                        Password = reader.GetString(2)
                                    };
                                    if (reader.GetInt32(3) == 1)
                                    {
                                        usuario.Rol = Rol.Administrador;
                                    }
                                    else
                                    {
                                        usuario.Rol = Rol.Profesional;

                                    }

                                    lista.Add(usuario);
                                }
                            }
                        }
                    }

                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Dictionary<Permisos, bool> ObtenerPermisosDeUsuario(Usuario user, TipoEntidad entidad)
        {
            try
            {
                Dictionary<Permisos, bool> permisos = new Dictionary<Permisos, bool>();
                using (var con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    string query = @"SELECT P.Leer, P.Evolucionar, P.Crear, P.Editar, P.Borrar
                                    FROM Permisos P
                                    INNER JOIN Roles R ON P.IdRol = R.IdRol
                                    INNER JOIN TiposEntidades T ON T.IdTipoEntidad = P.IdTipoEntidad
                                    WHERE P.IdRol = @IdRol AND P.IdTipoEntidad = @IdTipoEntidad";
                    
                    using (var comando = new SqlCommand(query, con))
                    {
                        comando.Parameters.Add("@IdRol", SqlDbType.Int);

                        comando.Parameters["@IdRol"].Value = Convert.ToInt32(user.Rol);

                        comando.Parameters.AddWithValue("@IdTipoEntidad", (int)entidad);

                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                permisos[Permisos.Leer] = reader.GetBoolean(0);
                                permisos[Permisos.Evolucionar] = reader.GetBoolean(1);
                                permisos[Permisos.Crear] = reader.GetBoolean(2);
                                permisos[Permisos.Editar] = reader.GetBoolean(3);
                                permisos[Permisos.Borrar] = reader.GetBoolean(4);
                            }

                        }
                    }
                }
                return permisos;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
