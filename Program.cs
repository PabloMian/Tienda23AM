using Tienda_23AM;
using System;
using Tienda_23AM.Etities;
using Tienda_23AM.Entities;

namespace Tienda_23AM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.PedirDatos();
        }
    }
}
