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


        public clsPersonaConNombreDept(string nombreDept)
        {
            
            this.nombreDept = nombreDept;
        }
    }
}
