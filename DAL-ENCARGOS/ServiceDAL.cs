using ENT_Encargos;
using System.Diagnostics;
using System.Linq;

namespace DAL_ENCARGOS
{
    public class ServiceDAL
    {

        #region Listados
        private static List<Mision> listaMisiones = new List<Mision>()
{
    new Mision { Id = 1, Nombre = "Recoger impuestos en el restaurante", Dificultad = 1 },
    new Mision { Id = 2, Nombre = "Hacer una oferta que no puedan rechazar al sindicato de basura", Dificultad = 1 },
    new Mision { Id = 3, Nombre = "Supervisar obras en New Jersey", Dificultad = 2 },
    new Mision { Id = 4, Nombre = "Convencer al Concejal de urbanismo para conseguir favores", Dificultad = 4 },
    new Mision { Id = 5, Nombre = "Encargarse del concejal de urbanismo que no se dejó convencer", Dificultad = 5 },
    new Mision { Id = 6, Nombre = "Llevar la contabilidad del Bada Bing", Dificultad = 3 }
};

        private static List<Candidato> listaCandidatos = new List<Candidato>()
{
    new Candidato { Id = 1, Apellidos = "Gordon", Direccion = "Pizza Street, 1232", Pais = "USA", Telefono = "5456768", FechaNacimiento = new DateTime(1961, 10, 11), Precio = 25000 },
    new Candidato { Id = 2, Apellidos = "Moltisanti", Direccion = "St Monti Ave, 3", Pais = "USA", Telefono = "5687654", FechaNacimiento = new DateTime(2003, 3, 22), Precio = 15005 },
    new Candidato { Id = 3, Apellidos = "Galliani", Direccion = "Brooklyn Ave, 5", Pais = "USA", Telefono = "5679321", FechaNacimiento = new DateTime(1998, 12, 9), Precio = 15005 },
    new Candidato { Id = 4, Apellidos = "Gualtieri", Direccion = "Soprano Street, 16", Pais = "USA", Telefono = "6787654", FechaNacimiento = new DateTime(1963, 6, 30), Precio = 20000 },
    new Candidato { Id = 5, Apellidos = "T'Accordense", Direccion = "Via Donna Musica, 20", Pais = "Italia", Telefono = "5676766", FechaNacimiento = new DateTime(1999, 4, 5), Precio = 16000 },
    new Candidato { Id = 6, Apellidos = "Peperoni", Direccion = "Piazza Roma, 3", Pais = "Italia", Telefono = "5676766", FechaNacimiento = new DateTime(1966, 3, 30), Precio = 15005 },
    new Candidato { Id = 7, Apellidos = "Dante", Direccion = "Town Street, 56", Pais = "USA", Telefono = "6787656", FechaNacimiento = new DateTime(1966, 1, 30), Precio = 20005 }
};

        #endregion


        public static List<Mision> ObtenerListadoDeMisiones()
        {

            return listaMisiones;

        }

        public static List<Candidato> ObtenerListadoDeCandidatosPorMision(int dificultad)
        {

            List<Candidato> listaCandidatosFiltrada = new List<Candidato>();
            switch (dificultad)
            {
                case 1:

                    foreach (Candidato x in listaCandidatos)
                    {
                        if (x.Pais == "USA" && x.Pais != "Italia")
                        {
                            listaCandidatosFiltrada.Add(x);
                        }
                    }
                    break;
                case 2:
                    foreach (Candidato x in listaCandidatos)
                    {
                        if (x.Pais == "USA" && x.Pais != "Italia")
                        {
                            listaCandidatosFiltrada.Add(x);
                        }
                    }
                    break;
                case 3:
                    foreach (Candidato x in listaCandidatos)
                    {
                        if (x.Pais == "USA" && x.Pais != "Italia" && ((uint)x.FechaNacimiento.Year) > 40)
                        {
                            listaCandidatosFiltrada.Add(x);
                        }
                    }
                    break;
                case 4:
                    foreach (Candidato x in listaCandidatos)
                    {
                        if (x.Pais == "Italia" && ((uint)x.FechaNacimiento.Year) < 40)
                        {
                            listaCandidatosFiltrada.Add(x);
                        }
                    }
                    break;
                case 5:
                    foreach (Candidato x in listaCandidatos)
                    {
                        if (x.Pais == "Italia" && ((uint)x.FechaNacimiento.Year) > 45)
                        {
                            listaCandidatosFiltrada.Add(x);
                        }
                    }
                    break;
            }

            return listaCandidatosFiltrada;
        }

        public static List<Mision> ObtenerCandidato(int id)
        {
            Candidato obj = listaCandidatos.FirstOrDefault(m => m.Id == id);
            return listaMisiones;

        }
    }
}
