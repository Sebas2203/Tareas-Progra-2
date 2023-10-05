using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
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
        //variables 
        static float[] tarea = new float[3];
        static float[] quiz = new float[3];
        static float[] examen = new float[3];
        static float[] nota = new float[3];
        static float promedio = 0;
        static string carnet = "";
        static string estudiante = "";
        static bool ingresar = true;

        static void Main(string[] args)
        {
            menu();
            Console.ReadLine();
        }

        //menu
        static void menu()
        {

            while (ingresar)
            {
                try
                {
                    Console.WriteLine("\n---Promedio---\n");

                    //datos del estudiante
                    Console.Write("Carnet: ");
                    carnet = Console.ReadLine().ToUpper();
                    Console.Write("Estudiante: ");
                    estudiante = Console.ReadLine();

                    //ingreso de las notas
                    notasTareas();
                    notasQuices();
                    notasExamenes();

                    //funciones para calcular el porcentaje
                    porcentajeTarea();
                    porcentajeQuiz();
                    porcentajeExamen();

                    //promedio del estudiante
                    promedioFinal();
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }

        //resultado de promedio final 
        static void promedioFinal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nEl estudiante -{estudiante}- con el carnet -{carnet}- tiene un promedio de {nota}\n");
            Console.ForegroundColor = ConsoleColor.White;

            //ingresar de nuevo o salir del programa 
            Console.WriteLine("1. Ingresar\n2. Salir");
            int opcion = int.Parse( Console.ReadLine());

            if ( opcion == 1 ) 
            {
                Console.WriteLine("");
            }
            else if ( opcion == 2 )
            {
                ingresar = false;
                Console.WriteLine("Hasta la próxima");
            }
        }

        //funciones para ingresar notas
        static void notasTareas()
        {
            Console.Write("\n---Ingrese la nota de las Tareas---\n");
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Tarea {i + 1}:");
                tarea[i] = int.Parse(Console.ReadLine());

            }
        }

        static void notasQuices()
        {
            Console.Write("\n---Ingrese la nota de los quices---\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Quiz {i + 1}:");
                quiz[i] = int.Parse(Console.ReadLine());
            }
        }

        static void notasExamenes()
        {
            Console.Write("\n---Ingrese la nota de los Examenes---\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Examen {i + 1}:");
                examen[i] = int.Parse(Console.ReadLine());
            }
        }

        //funciones para sacar los porcentajes 
        static void porcentajeTarea()
        {
            promedio = 0;
            for (int i = 0; i < 3; i++)
            {
                promedio += tarea[i];
            }
            promedio /=3;
            nota[0] = promedio *= 0.30f;
        }

        static void porcentajeQuiz()
        {
            promedio = 0;
            for (int i = 0; i < 3; i++)
            {
                promedio += quiz[i];
            }
            promedio /= 3;
            nota[0] = promedio *= 0.25f;
        }

        static void porcentajeExamen()
        {
            promedio = 0;
            for (int i = 0; i < 3; i++)
            {
                promedio += examen[i];
            }
            promedio /= 3;
            nota[0] = promedio *= 0.45f;

        }
    }
}
