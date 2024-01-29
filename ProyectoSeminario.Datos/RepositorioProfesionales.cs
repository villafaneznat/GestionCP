using Dapper;
using ProyectoSeminario.Entidades;
using ProyectoSeminatio.DatosComun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Datos
{
    public class RepositorioProfesionales : IRepositorioProfesionales
    {
        private string cadenaConexion;

        public RepositorioProfesionales()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["SqlConnection"].ToString();
        }
        public void Agregar(Profesional profesional)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string insertQuery = @"INSERT INTO Profesionales(Nombre, Apellido, DNI, NroMatricula, Firma) 
                                VALUES(@Nombre, @Apellido, @DNI, @NroMatricula, @Firma);
                                SELECT SCOPE_IDENTITY()";

                int id = conn.ExecuteScalar<int>(insertQuery, profesional);
                profesional.IdProfesional = id;
                SetProfesiones(profesional);               
            }
        }

        private void SetProfesiones(Profesional profesional)
        {
            using (var con = new SqlConnection(cadenaConexion))
            {
                string insert = @"INSERT INTO ProfesionalesProfesiones (IdProfesion, IdProfesional) 
                                VALUES (@IdProfesion, @IdProfesional)";
                string existeQuery = @"SELECT COUNT(*) FROM ProfesionalesProfesiones 
                                WHERE IdProfesion=@IdProfesion AND IdProfesional=@IdProfesional";

                foreach (var profesion in profesional.Profesiones)
                {
                    var parametros = new { IdProfesion = profesion.IdProfesion, IdProfesional = profesional.IdProfesional };
                    int cantidad = con.ExecuteScalar<int>(existeQuery, parametros);
                    if (cantidad == 0)
                    {
                        con.Execute(insert, parametros);
                    }
                }
            }
        }

        public void Editar(Profesional profesional)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Profesionales SET Nombre=@Nombre, Apellido=@Apellido, 
                    DNI=@DNI, NroMatricula=@NroMatricula, Firma=@Firma
                    WHERE IdProfesional=@IdProfesional";
                conn.Execute(updateQuery, profesional);
                SetProfesiones(profesional);
            }
        }

        public bool Existe(Profesional profesional)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (profesional.IdProfesional == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Profesionales WHERE DNI=@DNI";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, profesional);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Profesionales WHERE DNI=@DNI AND IdProfesional!=@IdProfesional";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, profesional);
                }
            }
            return cantidad > 0;
        }

        public List<Profesional> GetProfesionales(string textBusq = null)
        {
            try
            {
                List<Profesional> lista = new List<Profesional>();
                using (var con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    string selectQuery;
                    if (textBusq != null)
                    {
                        selectQuery = @"SELECT IdProfesional, Nombre, Apellido, DNI, NroMatricula, 
                            Firma FROM Profesionales 
							WHERE UPPER(Nombre) LIKE @textBusq OR UPPER(Apellido) LIKE @textBusq
							ORDER BY Nombre";
                        using (var comando = new SqlCommand(selectQuery, con))
                        {
                            comando.Parameters.Add("@textBusq", SqlDbType.NVarChar);
                            comando.Parameters["@textBusq"].Value = $"%{textBusq}%";
                            //comando.Parameters.Add("@textBusq", SqlDbType.NVarChar);
                            //comando.Parameters["@textBusq"].Value = $"%{textBusq}%";
                            using (var reader = comando.ExecuteReader())
                            {
                                
                                while (reader.Read())
                                {
                                    var profesional = new Profesional()
                                    {
                                        IdProfesional = reader.GetInt32(0),
                                        Nombre = reader.GetString(1),
                                        Apellido = reader.GetString(2),
                                        DNI = reader.GetInt32(3),
                                        NroMatricula = reader.GetInt32(4),
                                        Firma = (byte[])reader[5],
                                        Profesiones = GetProfesiones(reader.GetInt32(0)),

                                    };

                                    lista.Add(profesional);
                                }
                            }
                        }

                    }
                    else
                    {
                        selectQuery = @"SELECT IdProfesional, Nombre, Apellido, DNI, NroMatricula, 
                            Firma FROM Profesionales ORDER BY Nombre";
                        using (var comando = new SqlCommand(selectQuery, con))
                        {
                            using (var reader = comando.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var profesional = new Profesional()
                                    {
                                        IdProfesional = reader.GetInt32(0),
                                        Nombre = reader.GetString(1),
                                        Apellido = reader.GetString(2),
                                        DNI = reader.GetInt32(3),
                                        NroMatricula = reader.GetInt32(4),
                                        Firma = (byte[])reader[5],
                                        Profesiones = GetProfesiones(reader.GetInt32(0)),

                                    };

                                    lista.Add(profesional);
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

        private List<Profesion> GetProfesiones(int idProfesional)
        {
            List<Profesion> lista = new List<Profesion>();

            using (var con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                string selectQuery = @"SELECT pp.IdProfesion, p.Profesion FROM ProfesionalesProfesiones pp
                                        INNER JOIN Profesiones p ON p.IdProfesion = pp.IdProfesion 
                                        WHERE IdProfesional = @IdProfesional";

                using (var comando = new SqlCommand(selectQuery, con))
                {
                    comando.Parameters.Add("@IdProfesional", SqlDbType.Int);
                    comando.Parameters["@IdProfesional"].Value = idProfesional;

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var profesion = new Profesion()
                            {
                                IdProfesion = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                            };

                            lista.Add(profesion);
                        }
                    }
                }
            }
            return lista;

        }

        public void Borrar(Profesional profesional)
        {
            if (DeleteProfesiones(profesional))
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    string deleteQuery = "DELETE FROM Profesionales WHERE IdProfesional=@IdProfesional";
                    conn.Execute(deleteQuery, new { profesional.IdProfesional });
                }
            }
            else
            {
                throw new Exception();
            }
        }

        private bool DeleteProfesiones(Profesional profesional)
        {
            bool profesionesEliminadas = false;

            using (var con = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM ProfesionalesProfesiones WHERE IdProfesional = @IdProfesional";
                con.Execute(deleteQuery, new { profesional.IdProfesional });

                profesionesEliminadas = true;
            }

            return profesionesEliminadas;
        }
    }
}
