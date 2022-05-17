using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de horas");
            string numeroCadena=  Console.ReadLine();
            int numeroHoras=  int.Parse(numeroCadena);
            int total = numeroHoras * 20;
            Console.WriteLine("El total a pagar es " + total);
            Console.ReadLine();
        }
    }
}
