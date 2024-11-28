using ENT_Encargos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UIEncargos.VM
{
    public class CandidatoConEdad : Candidato
    {


        public int edad { get; set; }
        public CandidatoConEdad(int id, string nombre, string apellidos, string direccion, string pais, string telefono, DateTime fechaNacimiento, int precio) : base(id, nombre, apellidos, direccion, pais, telefono, fechaNacimiento, precio)
        {
            edad =  DateTime.Now.Year - fechaNacimiento.Year;
        }

    }
}
