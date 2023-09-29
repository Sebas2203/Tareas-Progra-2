using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
/*
Un vendedor ofrece su producto de la siguiente manera: Si le compran 10 productos o menos, 
el precio por producto es de $20. Si le compran más de 10 artículos, el precio es de $15 por artículo. 
Realice un algoritmo y diagrama de flujo que con solo proporcionarle la 
cantidad de artículos dé como resultado el precio y el total.
*/
//Estudiante Sebastian Mora Rodríguez
namespace productos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cantidadProductos();
            Console.ReadLine();
        }
        static void cantidadProductos()
        {
            bool play = true;
            while (play)
            {
                try
                {
                    Console.WriteLine("¿Cuántos productos compró?");
                    int productos = int.Parse(Console.ReadLine());
                    if (productos <= 10)
                    {
                        Console.WriteLine("El precio por producto es de $20");
                        int total = productos * 20;
                        Console.WriteLine($"El total a pagar es de {total}");
                    }
                    else
                    {
                        Console.WriteLine("El precio por porducto es de $15");
                        int total = productos * 15;
                        Console.WriteLine($"El total a pagar es de ${total}");
                    }
                    play = false;
                }
                catch
                {
                    Console.WriteLine("Ingrese un valor correcto");
                }
            }
        }
    }
}
