namespace ConsoleA
{ class Persona
    {
        string nombre;
        string apellido;
        int edad;
        int peso;
        int estatura;
        float nota;
        bool EstadoCivil;
        string Direccion;
        byte MiembrosFamilia;
        Fecha = Fecha

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public int Peso { get { return peso; } set { peso = value; } }
        public int Estatura { get { return estatura; } set { estatura = value; } }
        public float Nota { get { return nota; } set { nota = value; } }
        public bool EstadoCivil { get { return EstadoCivil; } set { EstadoCivil = value; } }
        public float Direccion { get { return Direccion; } set { Direccion = value; } }
        public byte MiembrosFamilia { get { return MiembrosFamilia; } set { MiembrosFamilia = value; } }
        public float Fecha { get { return Fecha; } set { Fecha = value; } }

        public string NombreCompleto
        {
            get { return $"{this.Nombre} {this.Apellido}"; } //interpolacion
        }
        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }        

        public string Saludar()
        {
            return $"Hola... ¿como estas?, mi nombre es {this.Nombre}";
        }
       
    }
}

            //ToDo:Jeniffer, debo leer 10 datos de una persona utilizando todos estos tipos 
            //float
            //double
            //DateTime // System.DateTime
            //bool


       
