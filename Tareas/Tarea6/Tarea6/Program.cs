using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Elaborar un método que me permita ingresar dos números e imprimir los números pares que hay entre esos 2 valores.

            imprimirRangoNumerosPares(2, 27);

            //Console.ReadLine();

            // 2. Elaborar una función, que me permita ingresar un precio (tipo de dato decimal) y devolver cuanto se pagaría finalmente
            // si se realizo un descuento del 20%

            decimal resultado = precioFinal20Descuento(120);

            Console.WriteLine("El precio final con el 20% de descuento es: " + resultado);

            //Console.ReadLine();

            // 3. Elaborar una función, que permita recibir como parámetro un sueldo y una categoría, en el caso que la categoría sea A, se
            // realiza un aumento de 400. Si es B se realiza un aumento de 200 soles, si es C se realiza un aumento de 100 soles, y si es una
            // categoría distinta a las mencionadas se realiza un aumento de 50 soles

            float sueldoFinalA = sueldoPorCategoria(15000, 'A');
            float sueldoFinalB = sueldoPorCategoria(20000, 'B');
            float sueldoFinalC = sueldoPorCategoria(12000, 'C');
            float sueldoFinalOtraCategoria = sueldoPorCategoria(16000, 'Z');

            Console.WriteLine("El sueldo del trabajador categoria A es: " + sueldoFinalA);
            Console.WriteLine("El sueldo del trabajador categoria B es: " + sueldoFinalB);
            Console.WriteLine("El sueldo del trabajador categoria C es: " + sueldoFinalC);
            Console.WriteLine("El sueldo del trabajador categoria Z es: " + sueldoFinalOtraCategoria);

            Console.ReadLine();

        }

        static void imprimirRangoNumerosPares(int rangoA, int rangoB)
        {
            for(int i=rangoA; i<=rangoB; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static decimal precioFinal20Descuento (decimal precio)
        {
            decimal descuento = precio * 0.20m;

            return precio - descuento;
        }

        static float sueldoPorCategoria (float sueldo, char categoria)
        {
            float sueldoFinal = 0;

            switch (categoria)
            {
                case 'A':
                    sueldoFinal = sueldo + 400;
                    break;

                case 'B':
                    sueldoFinal = sueldo + 200;
                    break;

                case 'C':
                    sueldoFinal = sueldo + 100;
                    break;

                default:
                    sueldoFinal = sueldo + 50;
                    break;
            }

            return sueldoFinal;
        }
    }
}
