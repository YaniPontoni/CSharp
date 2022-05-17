using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de semanas");
            string semanaCadena= Console.ReadLine();
           int numeroSemana=  int.Parse(semanaCadena);
            int totalDias = numeroSemana * 7;

            Console.WriteLine("El numero de dias es " + totalDias);
            Console.ReadLine();

        }
    }
}
