using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funciones

            decimal numero1 = 0;
            decimal numero2 = 0;
            string operacion;

            Console.Write("Ingrese un numero: ");
            numero1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            numero2 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese el tipo de operacion (+ - / *): ");
            operacion = Console.ReadLine();

            decimal resultado = calculadora(numero1, numero2, operacion);

            saltoDeLinea();

            Console.Write("El resultado de su operacion es: " + resultado);

            saltoDeLinea();
            saltoDeLinea();

            Console.Write("Ingrese el monto de la ganancia por dia del trabajador: ");
            decimal sueldoDiario = decimal.Parse(Console.ReadLine());

            decimal gananciaSemanal = sueldoSemanal(sueldoDiario);
            decimal gananciaMensual = sueldoMensual(sueldoDiario);
            decimal gananciaAnual = sueldoAnual(sueldoDiario);

            saltoDeLinea();
            Console.Write("El trabajador gana " + gananciaSemanal + " semanalmente, " + gananciaMensual + " mensualmente y " + gananciaAnual + " anualmente.");

            saltoDeLinea();
            saltoDeLinea();

            string[] nombres = { "Yani", "Gisela", "Samira", "Moncho", "Fernando" };
            string[] apellidos = { "Pontoni", "Rotatori", "Pontoni Rotatori", "Gimenez", "Fernandez" };

            imprimirArrayString(nombres);
            saltoDeLinea();
            imprimirArrayString(apellidos);

            saltoDeLinea();

            Console.Write("Ingrese el numero para el rango A: ");
            int rangoA = int.Parse(Console.ReadLine());

            saltoDeLinea();

            Console.Write("Ingrese el numero para el rango B: ");
            int rangoB = int.Parse(Console.ReadLine());

            imprimirRangoNumeros(rangoA, rangoB);

            lectura();

        }

        static decimal calculadora(decimal a, decimal b, string operacion)
        {
            decimal resultado = 0;

            switch (operacion)
            {
                case "+": resultado = sumatoria(a, b);
                    break;

                case "-": resultado = resta(a, b);
                    break;

                case "/": 
                    if (b == 0)
                    {
                        Console.Write("Operacion no permitida.");
                    }
                    else
                    {
                        resultado = division(a, b);
                    }
                    break;

                case "*": resultado = multiplicacion(a, b);
                    break;

                default: Console.Write("La opcion seleccionada no es valida");
                    break;
            }

            return resultado;
        }

        static decimal sumatoria(decimal a, decimal b)
        {
            return a + b;
        }

        static decimal resta(decimal a, decimal b)
        {
            return a - b;
        }

        static decimal multiplicacion(decimal a, decimal b)
        {
            return a * b;
        }

        static decimal division(decimal a, decimal b)
        {
            return a / b;
        }

        static decimal sueldoSemanal(decimal sueldoDiario)
        {
            return sueldoDiario * 7;
        }

        static decimal sueldoMensual(decimal sueldoDiario)
        {
            return sueldoDiario * 30;
        }

        static decimal sueldoAnual(decimal sueldoDiario)
        {
            return sueldoDiario * 365;
        }

        static void mensaje(string cadena)
        {
            Console.WriteLine(cadena);
        }

        static void saltoDeLinea()
        {
            Console.WriteLine("");
        }

        static void lectura()
        {
            Console.ReadLine();
        }

        static void imprimirArrayString (string[] arreglo)
        {
            foreach(string item in arreglo)
            {
                Console.WriteLine(item);
            }
        }

        static void imprimirArrayEnteros (int[] arreglo)
        {
            foreach(int item in arreglo)
            {
                Console.WriteLine(item);
            }
        }

        static void imprimirRangoNumeros (int rangoA, int rangoB)
        {
            for(int i=rangoA; i<=rangoB; i++)
            {
                mensaje(i.ToString());
            }
        }
    }
}
