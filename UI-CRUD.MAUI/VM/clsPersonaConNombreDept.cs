using ENT_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI__ModeloMaui.VM
{
    public class clsPersonaConNombreDept : ClsPersona
    {


        public string nombreDept { get; set; }


        // Constructor de la clase derivada que llama al constructor de la clase base
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
