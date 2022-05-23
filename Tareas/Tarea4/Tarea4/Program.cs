using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Se tiene el siguiente array de números. Calcular cuantos elementos son pares y cuantos son impares.
            // int[] valores = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };

            int[] valores = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };

            int contPares = 0;
            int contImpares = 0;

            foreach(int numero in valores)
            {
                if (numero %2 == 0)
                {
                    contPares++;
                } else
                {
                    contImpares++;
                }
            }

            Console.WriteLine("Mostrando arreglo original:");
            Console.WriteLine("");

            foreach(int numero in valores)
            {
                Console.Write("{" + numero + "}");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Cantidad de elementos pares: " + contPares);
            Console.WriteLine("");
            Console.Write("Cantidad de elementos impares: " + contImpares);

            // 2. Se tiene el siguiente array de números indicar cuantos números de tres cifras positivos hay
            // int[] valores = { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15 };

            int[] valores2 = { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15 };
            int cont3Cifras = 0;
            
            foreach(int numero in valores2)
            {
                if (numero > 99 && numero < 1000)
                {
                    cont3Cifras++;
                }
            }

            Console.Write("Cantidad de numeros positivos de 3 cifras: " + cont3Cifras);

            // 3. Se tiene el siguiente array , hallar la suma de los elementos que son mayores a 15
            // int[] números = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };

            int[] números = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };

            int suma = 0;

            foreach(int numero in números)
            {
                if (numero > 15)
                {
                    suma += numero;
                }
            }

            Console.Write("La sumatoria de los numeros mayores a 15 en el arreglo es de: " + suma);

            Console.ReadLine();

        }
    }
}
