using BL;
using ENT_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI__ModeloMaui.VM
{
    public class ClsListadoDePersonas
    {

        private static List<clsPersonaConNombreDept> lista = new List<clsPersonaConNombreDept>();

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
