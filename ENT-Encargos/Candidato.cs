namespace ENT_Encargos
{
    public class Candidato
    {


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Precio { get; set; }
        public Candidato()
        {
        }

        public Candidato(int id, string nombre, string apellidos, string direccion, string pais, string telefono, DateTime fechaNacimiento, int precio)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Direccion = direccion;
            Pais = pais;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Precio = precio;
        }

        public override bool Equals(object? obj)
        {
            return obj is Candidato candidato &&
                   Id == candidato.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
