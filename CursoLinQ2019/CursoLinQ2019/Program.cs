using System;
using System.Linq;

namespace CursoLinQ2019
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Fuente de datos

            int[] numeros = { 99, 56, 75, 45, 12 };

            // 2. Definir la consulta

            var consulta = from numero in numeros
                           where numero > 70
                           select numero;

            // 3. Ejecucion de la consulta

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
