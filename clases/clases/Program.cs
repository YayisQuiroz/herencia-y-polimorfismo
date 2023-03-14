using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public abstract class EntidadContacto : Persona
    {
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public EntidadContacto(string nombre, string direccion, string telefono, string email)
            : base(nombre)
        {
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
        }

        public abstract void MostrarInformacion();
    }

    public class Contacto : EntidadContacto
    {
        public Contacto(string nombre, string direccion, string telefono, string email)
            : base(nombre, direccion, telefono, email)
        {
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto = new Contacto("Juan Pérez", "Av. Siempre Viva 123", "555-1234", "juanperez@example.com");
            Contacto contacto2 = new Contacto("Diana Quiroz", "calle josevasconcelos", "555-2004", "mariana24@example.com");

            contacto.MostrarInformacion();
            Console.WriteLine("--------------------------------------------------------------------------");
            contacto2.MostrarInformacion();
            Console.ReadKey();
        }
    }

    
}
