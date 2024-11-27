using DAL_Modelo.EjemploConexionBD.DAL;
using ENT_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Modelo
{
    public class Service
    {


        /// <summary>
        /// Listado estatico como base para las funciones de service en privado y solo puede ser editado mediante funciones 
        /// </summary>
        private static List<ClsPersona> listadoPersonas = new List<ClsPersona>
        {
new ClsPersona
{
    id = 1,
    nombre = "Juan",
    apellidos = "Pérez López",
    fechaNac = new DateTime(1990, 5, 24),
    direccion = "Calle Falsa 123",
    img = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/15c79321-edea-4862-bfcc-7218bc514a36/dbaazft-fa133204-a65c-4c01-a90f-d9485a8e3471.png/v1/fill/w_1013,h_789,strp/megumin_by_drawingshit_dbaazft-pre.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9Nzk4IiwicGF0aCI6IlwvZlwvMTVjNzkzMjEtZWRlYS00ODYyLWJmY2MtNzIxOGJjNTE0YTM2XC9kYmFhemZ0LWZhMTMzMjA0LWE2NWMtNGMwMS1hOTBmLWQ5NDg1YThlMzQ3MS5wbmciLCJ3aWR0aCI6Ijw9MTAyNCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.f8ItKZKi5K6f99Le5_HVDVSLmwogVspygjr_XNBz70E",  // Enlace de ejemplo
    telefono = "555-1234",
    dept = 1
},
new ClsPersona
{
    id = 2,
    nombre = "María",
    apellidos = "García Fernández",
    fechaNac = new DateTime(1985, 8, 15),
    direccion = "Avenida Principal 456",
    img = "https://images.squarespace-cdn.com/content/v1/51b3dc8ee4b051b96ceb10de/9fcdb2b1-de49-42b9-bbd8-d2b302420c8b/homelander-looses-his-fking-mind-in-full-trailer-for-the-boys-season-3.jpg",  // Enlace de ejemplo
    telefono = "555-5678",
    dept = 3
},
new ClsPersona
{
    id = 3,
    nombre = "Luis",
    apellidos = "Rodríguez Gómez",
    fechaNac = new DateTime(2000, 11, 30),
    direccion = "Calle Secundaria 789",
    img = "https://th.bing.com/th/id/OIP.qbQFzIbL-u49DqM49sgpNwAAAA?rs=1&pid=ImgDetMain",  // Enlace de ejemplo
    telefono = "555-9012",
    dept = 2
},
new ClsPersona
{
    id = 4,
    nombre = "Ana",
    apellidos = "Martínez Fernández",
    fechaNac = new DateTime(1992, 3, 22),
    direccion = "Calle Primavera 101",
    img = "https://somoskudasai.com/wp-content/uploads/2024/02/7-4.jpg",  // Enlace de ejemplo
    telefono = "555-1122",
    dept = 1
},
new ClsPersona
{
    id = 5,
    nombre = "Carlos",
    apellidos = "López Pérez",
    fechaNac = new DateTime(1988, 7, 14),
    direccion = "Calle Sol 202",
    img = "https://i.ytimg.com/vi/aRCqeopqnPQ/maxresdefault.jpg",  // Enlace de ejemplo
    telefono = "555-3344",
    dept = 3
},
new ClsPersona
{
    id = 6,
    nombre = "Lucía",
    apellidos = "Sánchez Díaz",
    fechaNac = new DateTime(1995, 10, 5),
    direccion = "Calle Mar 303",
    img = "https://th.bing.com/th/id/OIP.CPP7T9dnFQczY6CqCF6rzQHaHa?rs=1&pid=ImgDetMain",  // Enlace de ejemplo
    telefono = "555-5566",
    dept = 2
},
new ClsPersona
{
    id = 7,
    nombre = "José",
    apellidos = "Torres Gómez",
    fechaNac = new DateTime(1993, 1, 18),
    direccion = "Calle Montaña 404",
    img = "https://i.redd.it/xb5mn7jb4tjc1.jpeg",  // Enlace de ejemplo
    telefono = "555-7788",
    dept = 1
},
new ClsPersona
{
    id = 8,
    nombre = "Sofía",
    apellidos = "Ramírez Fernández",
    fechaNac = new DateTime(1987, 12, 3),
    direccion = "Calle Río 505",
    img = "https://th.bing.com/th/id/OIP.XuyBO4L0KL8NqxMfun1nRwAAAA?rs=1&pid=ImgDetMain",  // Enlace de ejemplo
    telefono = "555-9900",
    dept = 3
},
new ClsPersona
{
    id = 9,
    nombre = "Pedro",
    apellidos = "González López",
    fechaNac = new DateTime(1982, 9, 11),
    direccion = "Calle Bosque 606",
    img = "https://i.kym-cdn.com/photos/images/facebook/002/296/219/baf.jpg",  // Enlace de ejemplo
    telefono = "555-2233",
    dept = 2
},
new ClsPersona
{
    id = 10,
    nombre = "Elena",
    apellidos = "Vázquez García",
    fechaNac = new DateTime(1997, 6, 25),
    direccion = "Calle Luna 707",
    img = "https://elcomercio.pe/resizer/mGIqOA002rtqZ4PlQScZovI5LG0=/980x528/smart/filters:format(jpeg):quality(75)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/KCCNJFVO7ZBM3BHRWEP2NI5TEM.jpg",  // Enlace de ejemplo
    telefono = "555-4455",
    dept = 1
} };

        /// <summary>
        /// Devuleve el listado privado de personas 
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }

        /// <summary>
        /// Devyuelve una persona seleccionada 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClsPersona SelecionarPersona(int id)
        {
            ClsPersona obj = listadoPersonas.FirstOrDefault(m => m.id == id);
            return obj;
        }

        /// <summary>
        /// Anyade una nueva persona 
        /// </summary>
        /// <param name="obj">recive un objeto de tipo persona </param>
        public static void AnyadirPersona(ClsPersona obj)
        {
        
                listadoPersonas.Add(obj);
        }


        /// <summary>
        /// Edita una nueva persona (En verdad borra la persona con el mismo id que el obj por parametro y lo vuelve a insertar)
        /// </summary>
        /// <param name="obj">recive un objt tipo persona</param>
        public static void EditarPersona(ClsPersona obj)
        {
            listadoPersonas.Remove(obj);
            listadoPersonas.Add(obj);

        }

        /// <summary>
        /// Elimna una persona del registro 
        /// </summary>
        /// <param name="id">Recive un entero tipo id</param>
        public static void EliminarPersona(int id)
        {
            ClsPersona obj = SelecionarPersona(id);
            listadoPersonas.Remove(obj);

        }
    }

}

