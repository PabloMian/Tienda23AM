using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_23AM.Entities;
using Tienda_23AM.Etities;

namespace Tienda_23AM.Entities
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public long Telefono { get; set; }
        public string Correo { get; set; }

        public void PedirDatos()
        {
            Console.WriteLine("BIENVENIDO A LA TIENDA DE GINO");
            Console.WriteLine("Ingrese su nombre: ");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su numero telefonico: ");
            this.Telefono = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su correo: ");
            this.Correo = Console.ReadLine();

            Console.Clear();


            Servicies servicies = new Servicies();
            servicies.Caja();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("DATOS CLIENTE");
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Telefono: " + this.Telefono);
            Console.WriteLine("Correo: " + this.Correo);

        }
    }
}
