using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
hacer un algoritmo de una tienda que vende camisas, si la persona se lleva una camisa se lo 
lleva a precio de costo, 
si la persona se lleva entre 2 y 5 camisas se le hace un descuento del 15%
si la persona se lleva más de 5 el descuento es de 20%
El sistema debe solicitar la cantidad de camisas y el precio de las camisas
*/

//Estudiante: Sebastian Mora Rodríguez

namespace tienda
{
    internal class Program
    {
        //global variables
        static bool sharon = true;
        static int camisas = 0;
        static float total = 0f;
        static void Main(string[] args)
        {
            tienda();
            Console.Read();
        }
        static void tienda()
        {

            while (sharon)
            {
                try 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n---Tienda de Camisas---\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("1. Ingresar\n2. Salir\n");
                    Console.Write("Opcion: ");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1 || opcion == 2)
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("¿Cuántas camisas ingresa?");
                                int cantidad = int.Parse(Console.ReadLine());
                                camisas = cantidad;
                                if (cantidad == 1)
                                {
                                    Console.Write($"Precio Camisa: ");
                                    float precio = float.Parse(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Total al pagar: {precio}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (cantidad >= 2 && cantidad <= 5)
                                {
                                    //descuento 15%
                                    for (int i = 0; i < camisas; i++)
                                    {
                                        Console.Write($"Precio Camisa {i + 1}: ");
                                        float precio = float.Parse(Console.ReadLine());
                                        total += precio;
                                        Console.WriteLine($"Total: {total}\n");
                                    }

                                    float descuento = total - (total * 0.15f);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Descuento de un 15% Incluido");
                                    Console.WriteLine($"Total al pagar: {descuento}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (cantidad > 5)
                                {
                                    //descuento 20%
                                    for (int i = 0; i < camisas; i++)
                                    {
                                        Console.Write($"Precio Camisa {i + 1}: ");
                                        float precio = float.Parse(Console.ReadLine());
                                        total += precio;    
                                        Console.WriteLine($"Total: {total}\n");
                                    }

                                    float descuento = total - (total * 0.20f);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Descuento de un 20% Incluido");
                                    Console.WriteLine($"Total al pagar: {descuento}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;

                            case 2:
                                Console.Clear();
                                sharon = false;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n¡Gracias por su compra!\n");
                                break;
                        }
                    }
                    else 
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nIngrese una opcion correcta\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }         
                catch 
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nIngrese un valor correcto\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
