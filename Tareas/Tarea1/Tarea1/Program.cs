using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ejercicio 1:

            Console.WriteLine("Ingrese la cantidad de semanas: ");
            int semanas = int.Parse(Console.ReadLine());

            int cantDias = semanas * 7;

            Console.WriteLine("La cantidad de dias que hay en " + semanas + " semanas es: " + cantDias + " dias");

            // Ejercicio 2:

            Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            int valorHoraTrabajada = 20;

            int salario = valorHoraTrabajada * horasTrabajadas;

            Console.WriteLine("El salario total por " + horasTrabajadas + " horas trabajadas es de: " + salario + " soles");

            // Ejercicio 3:

            Console.WriteLine("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            decimal igv = precio * 0.18m;
            decimal total = precio + igv;

            Console.WriteLine("IGV: " + igv);
            Console.WriteLine("Total: " + total);

            Console.ReadLine();
        }
    }
}
