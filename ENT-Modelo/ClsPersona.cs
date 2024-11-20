namespace ENT_Modelo
{
    public class ClsPersona
    {


        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public DateTime? fechaNac { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public ClsPersona()
        {
        }
        public ClsPersona(int id, string nombre, string apellidos, DateTime? fechaNac, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.direccion = direccion;
            this.telefono = telefono;
        }


    }



}
