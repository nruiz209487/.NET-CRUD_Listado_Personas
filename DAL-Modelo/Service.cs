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
       private static  List<ClsPersona> listadoPersonas = new List<ClsPersona>
        {
            new ClsPersona
            {
                id = 1,
                nombre = "Juan",
                apellidos = "Pérez López",
                fechaNac = new DateTime(1990, 5, 24),
                direccion = "Calle Falsa 123",
                telefono = "555-1234"
            },
            new ClsPersona
            {
                id = 2,
                nombre = "María",
                apellidos = "García Fernández",
                fechaNac = new DateTime(1985, 8, 15),
                direccion = "Avenida Principal 456",
                telefono = "555-5678"
            },
            new ClsPersona
            {
                id = 3,
                nombre = "Luis",
                apellidos = "Rodríguez Gómez",
                fechaNac = new DateTime(2000, 11, 30),
                direccion = "Calle Secundaria 789",
                telefono = "555-9012"
            }
        };
        public static List<ClsPersona> ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }
        public static ClsPersona SelecionarPersona(int id)
        {
            ClsPersona obj = new ClsPersona();
            obj = listadoPersonas.FirstOrDefault(m => m.id == id);

            return obj;
        }

        public static void AnyadirPersona(ClsPersona obj)
        {
            if (!listadoPersonas.Contains(obj))
                listadoPersonas.Add(obj);

        }

        public static void EditarPersona(ClsPersona obj)
        {
            listadoPersonas.Remove(obj);
            listadoPersonas.Add(obj);

        }

        public static void EliminarPersona(int id)
        {
            ClsPersona obj = SelecionarPersona(id);
            listadoPersonas.Remove(obj);

        }
    }

}

