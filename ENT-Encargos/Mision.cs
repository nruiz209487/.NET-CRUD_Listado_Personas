using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Encargos
{
    public class Mision
    {


        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Dificultad { get; set; }
        public Mision(int id, string nombre, int dificultad)
        {
            Id = id;
            Nombre = nombre;
            Dificultad = dificultad;
        }

        public Mision()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is Mision misiones &&
                   Id == misiones.Id;
        }
    }
}
