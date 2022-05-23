using System;
using System.Linq;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 9, 11, 4, 7, 12, 16, 15 };

            var consulta = from numero in numeros
                           orderby numero descending
                           select numero;

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
