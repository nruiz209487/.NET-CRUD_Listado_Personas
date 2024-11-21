using BL;
using ENT_Modelo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD_Personas.VM
{
    public class ClsPersonaVM
    {
        private static List<ClsPersona> listadoDePersonas = ListaPersonasBL.ObtenerListadoPersonas();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? fechaNac { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public void EliminarPersona(int id)
        {
            ListaPersonasBL.EliminarPersona(id);
        }
        public static List<ClsPersona> ObtenerListadoPersonas()
        {
            return listadoDePersonas;
        }
        public ClsPersona SelecionarPersona(int id)
        {
            ClsPersona obj = new ClsPersona();
            obj = ListaPersonasBL.SelecionarPersona(id);
            return obj;
        }
        public void AnyadirPersona(int id, string nombre, string apellidos, DateTime? fechaNac, string direccion, string telefono)
        {
            ClsPersona obj = new ClsPersona(id, nombre, apellidos, fechaNac, direccion, telefono);
            ListaPersonasBL.AnyadirPersona(obj);
        }
        public void EditarPersona(int id, string nombre, string apellidos, DateTime? fechaNac, string direccion, string telefono)
        {
            ClsPersona obj = new(id, nombre, apellidos, fechaNac, direccion, telefono);
            ListaPersonasBL.ModificarPersona(obj);
        }
    }
}
