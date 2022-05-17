using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            int a = 40;
            int b = 30;

            if (a.Equals(b))
            {
                Console.WriteLine("Son iguales");
            } else
            {
                Console.WriteLine("Son distintos");
            }

            if (a > b)
            {
                Console.WriteLine("A es mayor que B");
            } else
            {
                Console.WriteLine("B es mayor que A");
            }

            */

            /*

            // Comprobar si el usuario es mayor de edad

            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad <= 0)
            {
                Console.WriteLine("La edad ingresada no es valida");
            } else if (edad >= 18)
            {
                Console.WriteLine("La persona es mayor de edad!");
            }
            else
            {
                Console.WriteLine("La persona es menor de edad!");
            }

            */

            /*

            // Elaborar un programa que me permita ingresar el total de una venta, en el caso de que el total de la venta sea mayor a 500
            // ofrecer un descuento del 20%, en caso contrario ofrecer un descuento del 10%

            Console.WriteLine("Ingrese el total de la venta: ");
            decimal venta = decimal.Parse(Console.ReadLine());
            decimal descuento;

            if (venta > 500)
            {
                descuento = venta * 0.20m;
            } else
            {
                descuento = venta * 0.10m;
            }

            decimal totalAPagar = venta - descuento;

            Console.WriteLine("El total a pagar en esta venta es de: " + totalAPagar);

            */

            /*

            // Elaborar un sistema que me permita ingresar un numero, y me permita identificar si es par o impar.

            Console.WriteLine("Ingrese un numero para comprobar si es par o impar: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero %2 == 0)
            {
                Console.WriteLine("El numero " + numero + " es par");
            } else
            {
                Console.WriteLine("El numero " + numero + " es impar");
            }

            */

            /*

            // Elaborar un programa que permita ingresar una nota a un usuario, y que imprima "El usuario aprobo" en el caso que se
            // ingrese una A, "El usuario necesita refuerzo" en el caso que se ingrese una B, "El usuario desaprobo" si se ingresa una C
            // y "Error" en el caso de que se ingrese cualquier otra letra.

            Console.WriteLine("Ingrese una letra (A - B - C): ");
            string letra = Console.ReadLine();

            if (letra.Equals("A"))
            {
                Console.WriteLine("El usuario aprobo");
            } else if (letra.Equals("B")) {
                Console.WriteLine("El usuario necesita refuerzo");
            } else if (letra.Equals("C"))
            {
                Console.WriteLine("El usuario desaprobo");
            } else
            {
                Console.WriteLine("Error");
            }

            */

            /*

            // Sentencia switch

            Console.WriteLine("Ingrese una letra (A - B - C): ");
            string letra = Console.ReadLine();

            switch(letra)
            {
                case "A":
                    Console.WriteLine("El usuario aprobo");
                    break;
                case "B":
                    Console.WriteLine("El usuario necesita refuerzo");
                    break;
                case "C":
                    Console.WriteLine("El usuario desaprobo");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            */

            /*

            // Elaborar un programa que nos permita ingresar un numero del 1 al 7. Si se ingresa 1, escribir Lunes, si se ingresa 2, escribir
            // Martes y asi hasta escribir 7 que corresponde a Domingo. En caso de que se ingrese un numero distinto al del rango, escribir
            // numero incorrecto.

            Console.WriteLine("Ingrese un numero del 1 al 7: ");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Numero incorrcto");
                    break;
            }

            */

            /*

            // Elaborar un programa que permita ingresar un sueldo y una categoria. Si si categoria es "A", el aumento es de 500.
            // Si su categoria es "B", el aumento es de 300. Si es "C", el aumento es de 100. Si es otra categoria diferente
            // a las mencionadas anteriormente, el aumento es de 10.

            Console.WriteLine("Ingrese el sueldo de la persona: ");
            decimal sueldo = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la categoria de la persona: ");
            string categoria = Console.ReadLine();

            decimal salarioTotal;
            
            switch(categoria)
            {
                case "A":
                    salarioTotal = sueldo + 500;
                    break;
                case "B":
                    salarioTotal = sueldo + 300;
                    break;
                case "C":
                    salarioTotal = sueldo + 100;
                    break;
                default:
                    salarioTotal = sueldo + 10;
                    break;
            }

            Console.WriteLine("El salario total de la persona es " + salarioTotal + " pesos");

            Console.ReadLine();

            */
        }
    }
}
