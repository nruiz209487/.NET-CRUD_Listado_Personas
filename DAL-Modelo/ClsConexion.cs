using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EjemploConexionBD.DAL
{
    public class ClsConexion
    {
        public static SqlConnection getConnection()
        {
            SqlConnection objConexion = new SqlConnection();
            try
            {
                objConexion.ConnectionString = "server=localhost;database=nruizDB;uid=usu;pwd=LaCampana123;trustServerCertificate=true;";
                objConexion.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos", ex);
            }
            return objConexion;
        }
    }
}

