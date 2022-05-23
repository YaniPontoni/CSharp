using System;
using System.Linq;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dado el siguiente arreglo, filtrar aquellos numeros que son mayores a 12 pero menores a 17
            
            int[] numeros = { 11, 15, 17, 19, 14, 18 };

            Console.WriteLine("Mostrando el contenido del arreglo:");
            Console.WriteLine("");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            var consulta = from numero in numeros
                           where numero > 12 && numero < 17
                           select numero;

            Console.WriteLine("");
            Console.WriteLine("Mostrando numeros mayores a 12 y menores que 17:");
            Console.WriteLine("");

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
