using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Imprimir los números del 19 al 37, de 2 en 2. Usar la estructura While

            int numero1 = 19;
            int numero2 = 37;

            while (numero1 <= numero2)
            {
                Console.WriteLine("Mostrando numeros del " + numero1 + " al " + numero2 + ":");
                numero1 += 2;
            }

            // 2. Imprimir la mitad de un numero, hasta que se ingrese un numero negativo. Usar el Do While.

            int numero3 = 0;
            int resDivision = 0;

            do
            {
                Console.WriteLine("Ingrese un numero para calcular su mitad: ");
                numero3 = int.Parse(Console.ReadLine());

                if (numero3 > 0)
                {
                    resDivision = numero3 / 2;
                    Console.WriteLine("La mitad del numero ingresado es: " + resDivision);
                }
                
            } while (numero3 > 0);

            Console.WriteLine("Finalizó la ejecucion debido al ingreso de un numero negativo");

            // 3. Hallar la suma de 5 números (Usando la estructura For)

            int numero4 = 0;
            int resultado = 0;

            for(int i=1; i<=5; i++)
            {
                Console.WriteLine("Ingrese el numero " + i + ":");
                numero4 = int.Parse(Console.ReadLine());

                resultado += numero4; 
            }

            Console.WriteLine("La sumatoria de los 5 numeros es: " + resultado);

            Console.ReadLine();
        }
    }
}
