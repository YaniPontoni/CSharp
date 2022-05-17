using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            // Contadores

            int c = 21;
            c++;

            Console.WriteLine("Valor: " + c);

            c--;

            Console.WriteLine("Valor: " + c);

            */

            /*
            
            // Estructura repetitiva While

            int i = 1;

            while(i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            */

            /*

            // 1. Permitir escribir 5 numeros y hallar su suma

            int p = 1;
            int suma = 0;
            int resultado = 0;

            while(p <= 5)
            {
                Console.WriteLine("Ingrese el numero " + p + " :");
                p++;

                suma = int.Parse(Console.ReadLine());

                resultado += suma; 
            }

            Console.WriteLine("El resultado de la sumatoria de los 5 numeros es: " + resultado);

            */

            /*

            // 2. Ingresar un numero y calcular su triple hasta que se ingrese el numero 0.

            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            int numeroTriple = numero * 3;

            Console.WriteLine("El triple de " + numero + " es " + numeroTriple);

            while (numero != 0)
            {
                Console.WriteLine("Ingrese otro numero: ");
                numero = int.Parse(Console.ReadLine());
                numeroTriple = numero * 3;

                if (numero != 0)
                {
                    Console.WriteLine("El triple de " + numero + " es " + numeroTriple);
                }
            }

            Console.WriteLine("Finalizo la ejecucion del programa");

            */

            /*

            // 3. Ingresar un numero e indicar si es par o impar hasta que se ingrese un numero negativo

            Console.WriteLine("Ingrese un numero para verificar si es par: ");
            int numero = int.Parse(Console.ReadLine());

            while(numero > 0)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El numero " + numero + " es par");
                } else
                {
                    Console.WriteLine("El numero " + numero + " es impar");
                }

                Console.WriteLine("Ingrese otro numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Finalizo la ejecucion porque se detecto el ingreso de un numero negativo");

            */

            /*

            // Do while

            // Ingresar numeros hasta que se ingrese un numero negativo

            int numerito = 0;
            int i = 1;
            int contadorPositivos = 0;

            do
            {
                Console.WriteLine("Ingrese numero " + i + " :");
                numerito = int.Parse(Console.ReadLine());
                i++;
                contadorPositivos++;
                if (numerito > 0)
                {
                    Console.WriteLine("El numero " + numerito + " es positivo");
                }
            } while (numerito > 0);

            Console.WriteLine("El numero ingresado es negativo");
            Console.WriteLine("La cantidad de numeros positivos ingresados es de: " + (contadorPositivos - 1));
            
            */

            /*

            // Estructura repetitiva for

            // Imprimir el mensaje "hola" 20 veces

            for(int i=1; i<21; i++)
            {
                Console.WriteLine("Hola");
            }

            // Elaborar la tabla de multiplicar del 2

            int valor = 2;

            for(int i=1; i<13; i++)
            {
                int resultado = valor * i;
                Console.WriteLine(valor + "x" + i + ": " + resultado);
            }

            */

            // Elaborar un programa que me permita ingresar 2 numeros, el primero tiene que ser menor al segundo. Y dentro de ese rango
            // mostrar los numeros pares.

            int primero = 0;
            int segundo = 0;

            Console.WriteLine("Ingrese el primer numero: ");
            primero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            segundo = int.Parse(Console.ReadLine());

            while (primero > segundo) 
            {
                Console.WriteLine("El numero ingresado debe ser mayor al primero!");
                Console.WriteLine("Ingrese el segundo numero nuevamente: ");
                segundo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El primer numero elegido es: " + primero);
            Console.WriteLine("El segundo numero elegido es: " + segundo);

            if (primero == segundo)
            {
                Console.WriteLine("Los numeros son iguales, no existen numeros pares entre ellos");
            } else
            {
                Console.WriteLine("Mostrando el rango de numeros pares entre los numeros seleccionados: ");

                for (int i = primero; i <= segundo; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Par: " + i);
                    }
                }
            }

            

            Console.ReadLine();
        }
    }
}
