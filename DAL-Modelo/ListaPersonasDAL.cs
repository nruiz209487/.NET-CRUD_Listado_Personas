using ENT_Modelo;

namespace DAL_Modelo
{
    using global::EjemploConexionBD.DAL;
    using Microsoft.Data.SqlClient;
    using System;
    using System.Collections.Generic;

    namespace EjemploConexionBD.DAL
    {
        public class ListaPersonasDAL
        {

            public static List<ClsPersona> ObtenerPersonas()
            {
                List<ClsPersona> listadoPersonas = new List<ClsPersona>();

                using (SqlConnection miConexion = ClsConexion.getConnection())
                {
                    try
                    {
                        using (SqlCommand miComando = new SqlCommand("SELECT * FROM personas", miConexion))
                        {
                            using (SqlDataReader miLector = miComando.ExecuteReader())
                            {
                                while (miLector.Read())
                                {
                                    ClsPersona oPersona = new ClsPersona
                                    {
                                        id = (int)miLector["iD"],
                                        nombre = (string)miLector["nombre"],
                                        apellidos = (string)miLector["apellidos"],
                                        direccion = (string)miLector["direccion"],
                                        telefono = (string)miLector["telefono"],
                                        fechaNac = miLector["fechaNac"] == DBNull.Value ? null : (DateTime?)miLector["fechaNac"]
                                    };

                                    listadoPersonas.Add(oPersona);
                                }
                            }
                        }
                    }
                    catch (SqlException exSql)
                    {
                        throw new Exception("Error ejecutando la consulta SQL", exSql);
                    }
                }

                return listadoPersonas;
            }
        }
    }
}

