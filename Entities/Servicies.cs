using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_23AM.Etities
{
    public class Servicies
    {
        float P1, P2, P3, P4, P5, total;
        public void Caja()
        {



            /*for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Ingrese  el precio {i} producto");
                P1 = float.Parse(Console.ReadLine());
                total = total + P1;
            }*/
            //Console.WriteLine("el total de la compra es "+total);
            Console.WriteLine("Ingrese el precio del producto 1: ");
            P1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto 2: ");
            P2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto 3: ");
            P3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto 4: ");
            P4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto 5: ");
            P5 = int.Parse(Console.ReadLine());

            Console.Clear();

            float Total = P1 + P2 + P3 + P4 + P5;
            float Mpagar;
            int Opcion;
            //ouble Desc = Total * .10;
            //Desc = int.Parse(Console.ReadLine());


            Console.WriteLine("El valor total de su compra es: $" + Total);

            if (Total >= 5000 && Total < 8000)
            {
                Console.WriteLine("POR SU COMPRA HA OBTENIDO UN DESCUENTO DE 10%");
                double Desc = Total * .10;
                Mpagar = (float)(Total - Desc);
                Console.WriteLine("USTED PAGARÁ: $" + Mpagar);

            }
            if (Total >= 8000 && Total < 10000)
            {
                Console.WriteLine("POR SU COMPRA HA OBTENIDO 3 MSI");
                Mpagar = Total / 3;
                Console.WriteLine("USTED PAGARÁ MENSUALMENTE: $" + Mpagar);
            }
            if (Total >= 10000)
            {
                Console.WriteLine("POR SU COMPRA HA OBTENIDO 6 0 12 MSI");
                Console.WriteLine("¿DESEA 6 O 12 MSI?");
                Console.WriteLine("6 MSI = 1          12 MSI = 2");
                Opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Opcion == 1)
                {
                    Console.WriteLine("HA ELEGIDO 6 MSI");
                    Mpagar = Total / 6;
                    Console.WriteLine("USTED PAGARÁ MENSUALMENTE POR MEDIO AÑO: $" + Mpagar);
                }
                if (Opcion == 2)
                {
                    Console.WriteLine("HA ELEGIDO 12 MSI");
                    Mpagar = Total / 12;
                    Console.WriteLine("USTED PAGARÁ MENSUALMENTE POR UN AÑO: $" + Mpagar);
                }
            }
            if (Total < 5000)
            {
                Console.WriteLine("SU COMPRA NO ALCANZA LA CANTIDAD REQUERIDA PARA RECIBIR BENEFICIOS EXTRA");

            }
        }
    }
}