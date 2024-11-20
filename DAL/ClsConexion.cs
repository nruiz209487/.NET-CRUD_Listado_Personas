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
                objConexion.ConnectionString = "";

                objConexion.Open();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

                objConexion.Close();

            }

            return objConexion;
        }


    }
}
