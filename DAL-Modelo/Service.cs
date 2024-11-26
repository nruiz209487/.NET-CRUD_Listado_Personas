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


        /// <summary>
        /// Listado estatico como base para las funciones de service en privado y solo puede ser editado mediante funciones 
        /// </summary>
        private static List<ClsPersona> listadoPersonas = new List<ClsPersona>
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

        /// <summary>
        /// Devuleve el listado privado de personas 
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }
        /// <summary>
        /// Devyuelve una persona seleccionada 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClsPersona SelecionarPersona(int id)
        {
            ClsPersona obj = listadoPersonas.FirstOrDefault(m => m.id == id);
            return obj;
        }
        /// <summary>
        /// Anyade una nueva persona 
        /// </summary>
        /// <param name="obj">recive un objeto de tipo persona </param>
        public static void AnyadirPersona(ClsPersona obj)
        {
            if (!listadoPersonas.Contains(obj))
                listadoPersonas.Add(obj);
        }


        /// <summary>
        /// Edita una nueva persona (En verdad borra la persona con el mismo id que el obj por parametro y lo vuelve a insertar)
        /// </summary>
        /// <param name="obj">recive un objt tipo persona</param>
        public static void EditarPersona(ClsPersona obj)
        {
            listadoPersonas.Remove(obj);
            listadoPersonas.Add(obj);

        }
        /// <summary>
        /// Elimna una persona del registro 
        /// </summary>
        /// <param name="id">Recive un entero tipo id</param>
        public static void EliminarPersona(int id)
        {
            ClsPersona obj = SelecionarPersona(id);
            listadoPersonas.Remove(obj);

        }
    }

}

