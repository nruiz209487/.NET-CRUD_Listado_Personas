using ENT_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.VM
{/// <summary>
/// hereda de la clase perosna
/// </summary>
    public class clsPersonaConNombreDept : ClsPersona
    {

        /// <summary>
        /// Nueva Popiedad
        /// </summary>
        public string nombreDept { get; set; }



        /// <summary>
        /// Constructor de la clase derivada que llama al constructor de la clase base para no tener 
        /// que modificar el constructor con una propiedad mas inicializo la propiedad en este
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="fechaNac"></param>
        /// <param name="direccion"></param>
        /// <param name="img"></param>
        /// <param name="telefono"></param>
        /// <param name="dept"></param>
        public clsPersonaConNombreDept(int id, string nombre, string apellidos, DateTime? fechaNac, string direccion, string img, string telefono, int dept)
            : base(id, nombre, apellidos, fechaNac, direccion, img, telefono, dept) // Llamada al constructor de la clase base
        {
            if (dept == 1)
            {
                this.nombreDept = "finazas";
            }
            else if (dept == 2)
            {
                this.nombreDept = "rh";
            }
            else if (dept == 3)
            {
                this.nombreDept = "contabilidad";
            }
        }
    }
}
