namespace ENT_Modelo
{
    public class ClsPersona
    {


        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public DateTime? fechaNac { get; set; }
        public string direccion { get; set; }
        public string img { get; set; }
        public string telefono { get; set; }
        public int dept { get; set; }

        public ClsPersona()
        {
        }

        public ClsPersona(int id, string nombre, string apellidos, DateTime? fechaNac, string direccion, string img, string telefono, int dept)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.direccion = direccion;
            this.img = img;
            this.telefono = telefono;
            this.dept = dept;
        }

        public override bool Equals(object? obj)
        {
            return obj is ClsPersona persona &&
                   id == persona.id;
        }
    }



}
