using System;
using System.Linq;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio de la clausula Where

            int[] numeros = { 21, 56, 18, 24, 12, 258, 12, 999 };

            Console.WriteLine("Numeros dentro del arreglo: ");
            Console.WriteLine("");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("");

            var consulta = from numero in numeros
                            where numero < 90
                            select numero;

            Console.WriteLine("Mostrando numeros menores a 90 en el arreglo:");
            Console.WriteLine("");

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
