using System;

namespace MiConsole
{
    class Program
    {
          static void Main(string[] datosPersona)
        {
            Console.WriteLine("Escriba su nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine("Escriba su apellido: ");
            var apellido = Console.ReadLine();

            Console.WriteLine("Escriba su peso: ");
            var peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba su estatura: ");
            var estatura = int.Parse(Console.ReadLine());
       
            Console.WriteLine("Escriba su edad: ");
            var edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba su nota: ");
            var nota = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Su estado civil?:");
            var EstadoCivil = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Escriba su direccion: ");
            var direccion = Console.ReadLine();

            Console.WriteLine("Miembros de su familia:");
            var MiembrosFamilia = Convert.ToByte(Console.ReadLine());

            DateTime fecha = new DateTime(2021, 06, 17);
            var Fecha = Console.ReadLine();

            var amigo = new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                Peso = peso,
                Estatura = estatura,
                Edad = edad,
                Nota = nota,
                EstadoCivil = EstadoCivil,
                direccion = direccion,
                MiembrosFamilia = MiembrosFamilia,
                Fecha = Fecha 
                
            };

            
            Console.WriteLine($"Hola {amigo.Nombre}" );
            Console.WriteLine($"Tu apellido es: {amigo.Apellido}");
            Console.WriteLine($"Tu edad es: {amigo.Edad}");
            Console.WriteLine($"Tu peso es: {amigo.Peso}");
            Console.WriteLine($"Tu estatura es: {amigo.estatura}");
            Console.WriteLine($"Tu nota es: {amigo.Nota}");
            Console.WriteLine($"Tu estado civil es: {amigo.EstadoCivil}");
            Console.WriteLine($"Tu direccion es: {amigo.Direccion}");
            Console.WriteLine($"Miembros de su familia son: {amigo.MiembrosFamilia}");
            Console.WriteLine($"La Fecha es: {amigo.Fecha}");

            Persona vecina = new("Carla", "Gomez");
            Console.WriteLine($"Mi vecina se llama {vecina.NombreCompleto}");

            Console.WriteLine("Escribe cualquier letra para terminar");

            Console.Read();

        }
    }
}