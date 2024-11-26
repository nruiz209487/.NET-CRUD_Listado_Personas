using DAL_Modelo;
using ENT_Modelo;

namespace BL
{
    public class ListaPersonasBL
    {
        /// <summary>
        /// Lista estatica que llama a la funcion  ObtenerListadoPersonas que obtiene el listado original esta en privado en caso de que haga falta hacer alguna modificacion 
        /// de regla de empresa no se toque el lisrtado dal
        /// </summary>
        public static List<ClsPersona> listadoPersonas = Service.ObtenerListadoPersonas();


        /// <summary>
        /// devuelve un listado de personas (el de la propia clase )
        /// </summary>
        /// <returns>devuelve el listado completo </returns>
        public static List<ClsPersona> ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }

        /// <summary>
        /// elimina a una persona del listado de personas llama a la capa dal
        /// </summary>
        /// <param name="id">recive como parametro el id de una perosna</param>
        public static void EliminarPersona(int id)
        {
            Service.EliminarPersona(id);

        }
        /// <summary>
        /// anyade una persona al listado llaama a la funcion en la dal 
        /// </summary>
        /// <param name="obj">ovjeto ClsPersona </param>
        public static void AnyadirPersona(ClsPersona obj)
        {
            Service.AnyadirPersona(obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public static void ModificarPersona(ClsPersona obj)
        {
            Service.EditarPersona(obj);
        }

        /// <summary>
        /// Seleciona el u8na  de una persona por id
        /// </summary>
        /// <param name="id">entero id del objeto a buscar</param>
        /// <returns>devulve un obj del listado</returns>
        public static ClsPersona SelecionarPersona(int id)
        {
            ClsPersona obj = Service.SelecionarPersona(id);
            return obj;
        }

    }

}
