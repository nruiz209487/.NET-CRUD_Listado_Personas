using BL;
using ENT_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.VM
{/// <summary>
/// Nuevo clase para el listado con el nuevo tipo de persona
/// </summary>
    public class ClsListadoDePersonas
    {
        /// <summary>
        /// Funcion estatica que tiene una lista de clsPersonaConNombreDept
        /// </summary>

        private static List<clsPersonaConNombreDept> lista = new List<clsPersonaConNombreDept>();


        /// <summary>
        /// Funcion que rellena llama a la capa bl que tiene  un listado de ClsPersona crea una funcion que lo recorre y crea una persona derivada
        /// con las propiedades y lo anyade a la lisatakkkkkkk
        /// </summary>
        /// <returns></returns>
        public static List<clsPersonaConNombreDept> ObtenerListado()
        {

            clsPersonaConNombreDept personaDerivada;
            foreach (ClsPersona x in ListaPersonasBL.ObtenerListadoPersonas())
            {
                personaDerivada = new clsPersonaConNombreDept(x.id, x.nombre, x.apellidos, x.fechaNac, x.direccion, x.img, x.telefono, x.dept);
                lista.Add(personaDerivada);
            }

            return lista;
        }


    }
}
