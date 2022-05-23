using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Elaborar un programa que indique si un numero es múltiplo de 5.

            Console.WriteLine("Ingrese un numero para verificar si es multiplo de 5: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 5 == 0)
            {
                Console.WriteLine("El numero " + numero + " si es multiplo de 5");
            } else
            {
                Console.WriteLine("El numero " + numero + " no es multiplo de 5");
            }

            // 2. Un empleado gana al mes de acuerdo a las horas que trabaja, si trabaja menos de 30 horas gana por hora 10 soles.
            // En caso que trabaje de 30 horas a mas gana 20 soles por hora.

            Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            int totalAPagar;

            if (horasTrabajadas < 30)
            {
                totalAPagar = horasTrabajadas * 10;
            } else
            {
                totalAPagar = horasTrabajadas * 20;
            }

            Console.WriteLine("El trabajador ha trabajado " + horasTrabajadas + " horas, por lo tanto le corresponden " + totalAPagar + " soles");

            // 3. Elaborar una calculadora, se ingresara 2 números, en el caso que se ingrese el carácter “+” se sumara.
            // Si se ingresa el “-” se restara, si se ingresar “*” se multiplicara, y si ingresa “/” se dividirá.

            Console.WriteLine("Ingrese el primer numero para hacer el calculo: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero para hacer el calculo: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese que operacion desea realizar: (+: suma | -: resta | *: multiplicacion | /: division)");
            string operacion = Console.ReadLine(); 

            decimal resultado = 0;


            switch(operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    } else
                    {
                        Console.WriteLine("No se permite las divisiones entre 0");
                    }
                    break;

                default:
                    Console.WriteLine("Usted ha ingresado una opcion no valida");
                    break;
            }

            Console.WriteLine("El resultado de su operacion es: " + resultado);

            Console.ReadLine();
        }
    }
}
