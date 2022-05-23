using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos enteros para positivos o negativos

            /*short a = -20;
            int b = -40000;
            long c = -1000000000000000; */

            // Tipos de datos para enteros y decimales positivos o negativos

            /*float d = 30.6f;            
            double e = 3530147898.6758585858;
            decimal f = 123156465215645123.50m; */

            // Tipos de datos para manejo de caracteres

            /*char letra = 'a';
            string nombre = "Yani"; */

            // Tipos de datos para validaciones (verdadero o falso)

            bool exito = false;

            //Console.WriteLine(nombre);
            //Console.ReadLine();

            int a = 50;
            int b = 40;
            double c = 20.5;

            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            double division = (a * 1.0) / b;
            int residuo = a % b;
            double e = b + c;


            /*
            string cad1 = "ABC";
            string cad2 = "DEF";
            int numero = 20;

            string sumaCadena = cad1 + cad2; // Resultado: ABCDEF
            string sumaNumeroACadena = cad1 + numero; // Resultado: ABC20
            // string restaCadena = cad1 + cad2; // Esta operacion no esta permitida para cadenas
            // string multiplicacionCadena = cad1 * cad2; // Esta operacion no esta permitida para cadenas
            // string divisionCadena = cad1 / cad2; // Esta operacion no esta permitida para cadenas
            */

            /*
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicacion: " + multiplicacion);
            Console.WriteLine("Division: " + division);
            Console.WriteLine("Residuo: " + residuo);
            Console.WriteLine("Suma Double: " + e);
            Console.WriteLine("Concatenacion de strings: " + sumaCadena);
            Console.WriteLine("Concatenacion de un string con un entero: " + sumaNumeroACadena);

            */

            // Conversion de string a otro tipo de dato

            /*

            string numero = "20";
            int stringConvertido = int.Parse(numero);

            int resultado = stringConvertido + 10;

            // Conversion de entero a cadena

            int k = 30;
            string cadena = k.ToString();

            */

            /*

            // Ejercicio 1: Ingrese 2 numeros y calcule su suma (los datos deben ser ingresados por el usuario).

            Console.WriteLine("Ingrese el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int sumatoria = numero1 + numero2;

            Console.WriteLine("El resultado de la suma es: " + sumatoria);

            */

            /*

            // Ejercicio 2: Calcular el area de un triangulo

            Console.WriteLine("Ingrese la base del triangulo: ");
            float baseT = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            float alturaT = float.Parse(Console.ReadLine());

            float area = (baseT * alturaT) / 2;

            Console.WriteLine("El area del triangulo es: " + area);

            */

            // Ejercicio 3: Una tienda vende sus productos a un determinado precio, pero esta ofreciendo sus productos a un 20% de descuento.
            // Elaborar un sistema que permita ingresar el precio e imprimir el descuento y el total a pagar.

            Console.WriteLine("Ingrese el precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            decimal descuento = precio * 0.20m;
            decimal total = precio - descuento;

            Console.WriteLine("El descuento es de: " + descuento);
            Console.WriteLine("El precio total es: " + total);
            
            Console.ReadLine();


        }
    }
}
