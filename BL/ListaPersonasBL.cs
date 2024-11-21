using DAL_Modelo;
using ENT_Modelo;

namespace BL
{
    public class ListaPersonasBL
    {
        public static List<ClsPersona> listadoPersonas = Service.ObtenerListadoPersonas();

        public static List<ClsPersona> ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }
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
            Service.EditarPersona(obj);
        }
        public static ClsPersona SelecionarPersona(int id)
        {
            ClsPersona obj = Service.SelecionarPersona(id);
            return obj;
        }

    }

}
