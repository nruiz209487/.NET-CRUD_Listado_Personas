using DAL_Modelo;
using ENT_Modelo;

namespace BL
{
    public class ListaPersonasBL
    {
        public static List<ClsPersona> listadoPersonas = Service.ObtenerListadoDePersonas();
        public static void EliminarPersona(int id)
        {
            Service.EliminarPersona(id);

        }
        public static void AnyadirPersona(ClsPersona obj)
        {
            Service.AnyadirPersona(obj);
        }

        public static void ModificarPersona(ClsPersona obj)
        {

            Service.ModificarPersona(obj);
        }
    }

}
