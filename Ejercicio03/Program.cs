using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese precio");
            string precioCadena=  Console.ReadLine();
            decimal precio = decimal.Parse(precioCadena);
            decimal igv = precio * 0.18m;
            decimal total = precio + igv;

            Console.WriteLine("Precio " + precio);
            Console.WriteLine("El igv es " + igv);
            Console.WriteLine("El total es " + total);

            Console.ReadLine();
        }
    }
}
