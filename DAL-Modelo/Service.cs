using DAL_Modelo.EjemploConexionBD.DAL;
using ENT_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Modelo
{
    public class Service
    {
        private static List<ClsPersona> listadoPersonas = ListaPersonasDAL.ObtenerPersonas();
        public static void EliminarPersona(int id)
        {


        }
        public static void AnyadirPersona(ClsPersona obj)
        {


        }

        public static void ModificarPersona(ClsPersona obj)
        {


        }

        public static ClsPersona ObtenerPersona(int id)
        {
            ClsPersona obj;
            obj = listadoPersonas.FirstOrDefault(m => m.id == id);
            return obj;

        }
        public static List<ClsPersona> ObtenerListadoDePersonas()
        {
            return listadoPersonas; 
        }
    }

}