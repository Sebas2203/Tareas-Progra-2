using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
Desarrolle un algoritmo que calcule el promedio final para un estudiante del curso de Programación 
1. Deberá leer los siguientes datos para cada estudiante: carnet, nombre, quiz 1, quiz 2, quiz 3, tarea 1, tarea 2, tarea 3, 
examen 1, examen 2 y examen 3. El programa deberá calcular el porcentaje de quices (25%), porcentaje de tareas (30%), y el 
porcentaje de exámenes (45%). El algoritmo tiene que calcular el promedio final y reportar el carnet, nombre, porcentaje de 
quices, porcentaje de tareas, porcentaje de exámenes, promedio final y condición del estudiante. La condición del estudiante 
esta con base a: Si el promedio final es mayor o igual a 70 “Aprobado”. Si el promedio final es mayor o igual a 50 y menor que 
70 “Aplazado” y si el promedio final es menor que 50 “Reprobado”. 9. 
*/

//Estudiante: Sebastian Mora Rodríguez
namespace promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            promedio();
            Console.ReadLine();
        }
        static void promedio()
        {
            bool enter = true;

            while (enter)
            {
                try
                {
                    Console.WriteLine("\n---Promedios Estudiantes---\n");

                    Console.Write("Cédula");
                    int cedula = int.Parse(Console.ReadLine());
                    Console.Write("Nombre");
                    string nombre = Console.ReadLine();

                    Console.Write("Quiz 1");
                    float quiz1 = float.Parse(Console.ReadLine());
                    Console.Write("Quiz 2");
                    float quiz2 = float.Parse(Console.ReadLine());
                    Console.Write("Quiz 3");
                    float quiz3 = float.Parse(Console.ReadLine());

                    Console.Write("Tarea 1");
                    float tarea1 = float.Parse(Console.ReadLine());
                    Console.Write("Tarea 2");
                    float tarea2 = float.Parse(Console.ReadLine());
                    Console.Write("Tarea 3");
                    float tarea3 = float.Parse(Console.ReadLine());

                    Console.Write("Examen 1");
                    float examen1 = float.Parse(Console.ReadLine());
                    Console.Write("Examen 2");
                    float examen2 = float.Parse(Console.ReadLine());
                    Console.Write("Examen 3");
                    float examen3 = float.Parse(Console.ReadLine());

                }
                catch 
                {
                    Console.WriteLine("Error, Intenta de nuevo ");
                }
            }
            

        }
    }
}
