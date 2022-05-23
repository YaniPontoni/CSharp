using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            
            // Manejo de array de strings

            string[] nombres = { "Pedro", "Luis", "Samira", "Gisela", "Yani" };

            // Recorriendo el array con for

            for(int i=0; i<nombres.Length; i++)
            {
                Console.WriteLine("Nombre " + i + ": " + nombres[i]);
            }

            // Recorriendo el array con foreach

            foreach(string n in nombres)
            {
                Console.WriteLine("Nombre: " + n);
            }

            // Otra forma de declarar un array es instanciandolo

            // int[] notas = {15, 10, 12, 13, 17};
            
            int[] notas = new int[5];

            notas[0] = 15;
            notas[1] = 10;
            notas[2] = 12;
            notas[3] = 13;
            notas[4] = 17;

            foreach(int numero in notas)
            {
                Console.WriteLine("Nota: " + numero);
            }

            // Definiendo una matriz de strings

            string[,] nombresCompleto =
            {
                {"Ricardo", "Roberto", "Rojas"},
                {"Tony", "Carlos", "Tramontana"},
                {"La", "Vacuna", "China"},
            };

            // Para acceder a los valores de la matriz se hace por su posicion

            Console.WriteLine(nombresCompleto[2, 0]);
            Console.WriteLine(nombresCompleto[2, 1]);
            Console.WriteLine(nombresCompleto[2, 2]);

            // Llenar una array dinamicamente

            int[] numeritos = new int[4];
            string numeroCadena;
            int numero2;

            for(int i=0; i<4; i++)
            {
                Console.WriteLine("Ingrese numero " + (i + 1));
                numeroCadena = Console.ReadLine();
                numeritos[i] = int.Parse(numeroCadena);

            }

            int suma = numeritos[0] + numeritos[3];

            Console.WriteLine("La suma del primer numero y el ultimo numero es: " + suma);

            */

            /*
            
            // Ejercicio con arrays

            // Se tiene el siguiente array de numeros: int[] numeros = {31, 27, 34, 46, 20, 42}, mostrar solo aquellos
            // numeros que son mayores a 18 pero menores a 35.

            int[] numeros = {31, 27, 34, 46, 20, 42};

            Console.WriteLine("Recorriendo array con for:");

            for (int i=0; i<numeros.Length; i++)
            {
                if (numeros[i] > 18 && numeros[i] < 35)
                {
                    Console.WriteLine("18 > x < 35: " + numeros[i]);
                }
            }

            // Resolucion con foreach

            Console.WriteLine("Recorriendo array con foreach:");

            foreach (int numeroArray in numeros)
            {
                if (numeroArray > 18 && numeroArray < 35)
                { 
                    Console.WriteLine("18 > x < 35: " + numeroArray);
                }
            }

            */

            /*

            // Se tiene un array de numeros, indicar cuantos son positivos (igual o mayor a 0)

            int[] otrosNumeros = { -100, 56, -20, 15, -12, -20 };
            int contPos = 0;

            foreach(int num in otrosNumeros)
            {
                if (num > 0)
                {
                    contPos++;
                }
            }

            Console.WriteLine("La cantidad de numeros positivos dentro del arreglo es de: " + contPos);

            Console.WriteLine("Mostrando el array analizado: ");

            foreach(int num in otrosNumeros)
            {
                Console.Write("{" + num + "} ");
            }

            */

            /*

            // Se tiene un array de numeros, hallar la suma de los numeros pares

            int[] numerongos = { 1, 3, 2, 4, 11, 19 };
            int suma = 0;

            foreach(int numeros in numerongos)
            {
                if (numeros % 2 == 0)
                {
                    suma += numeros;
                }
            }

            Console.Write("La suma de los numeros pares del arreglo es: " + suma);

            */

            /*

            // Calcular cuantos numeros positivos y negativos hay en el array

            int[] arreglo = { 4, 5, -4, 7, 8, -2, 12, 176, -6 };

            int contPositivos = 0;
            int contNegativos = 0;

            foreach(int numero in arreglo)
            {
                if(numero > 0)
                {
                    contPositivos++;
                } else
                {
                    contNegativos++;
                }
            }

            Console.Write("Cantidad de numeros positivos: " + contPositivos);
            Console.WriteLine("");
            Console.Write("Cantidad de numeros negativos: " + contNegativos);

            */

            // Indicar cuantos numeros de 1 cifra y 2 cifras positivos hay en el arreglo

            int[] numeros = { 10, 4, 6, 11, 145, 3453, 22, 44, 1, -6, -8 };
            int cont1Cifra = 0;
            int cont2Cifras = 0;

            foreach(int numero in numeros)
            {
                if (numero >= 0 && numero <= 9)
                {
                    cont1Cifra++;
                } else if(numero >= 10 && numero <= 99)
                {
                    cont2Cifras++;
                }
            }

            Console.WriteLine("Mostrando arreglo original:");
            Console.WriteLine("");

            foreach (int numero in numeros)
            {
                Console.Write("{" + numero + "} ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Cantidad de numeros positivos de 1 cifra: " + cont1Cifra);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Cantidad de numeros positivos de 2 cifras: " + cont2Cifras);

            Console.ReadLine();
        }
    }
}
