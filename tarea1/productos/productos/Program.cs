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
        static int cantidadProductos = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                articulos();
                Console.ReadLine();
                
            }
        }

        //reiniciar o finalizar programa
        
        static void articulos()
        {
            try
            {
                Console.WriteLine("¿Cuántos productos compró?");
                cantidadProductos = int.Parse(Console.ReadLine());
                descuento();
            }
            catch 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error al ingresar debe pone un número");
                Console.ForegroundColor= ConsoleColor.White;
            }
        }

        static void descuento()
        {
            if (cantidadProductos <= 10)
            {
                cantidadProductos *= 20;
                Console.WriteLine($"Los productos salen para ${cantidadProductos}");
            }
            else if (cantidadProductos > 10)
            {
                cantidadProductos *= 15;
                Console.WriteLine($"Los productos salen para ${cantidadProductos}");
            }
        }
    }
}
