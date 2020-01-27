using System;

namespace Practica_uno
{
    class Program
    {

        static string nombre = "Giovanna";
        static void Main(string[] args)
        {
            //Respondemos con el primer argumento y segundo.
            //Condicion se debe cumplir todas las sentencias si utilizamos &&
            //Condicion se debe cumplir todas las sentencias si utilizamos ||
            //Tipos de Comparacion <> == <= >= !=(diferente que)
            if (args[0].Length > 0 || args[0] == nombre) //true or false/booleano
            {
                Console.WriteLine($"Hello {args[0]} {args[1]}");
            }
            else
            {
                Console.WriteLine("User unauthorized");
            }
        }
    }
}
