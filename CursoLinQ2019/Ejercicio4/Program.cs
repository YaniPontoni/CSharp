using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>
            {
                new Empleado { idEmpleado = 1, nombre = "Vanessa", sueldo = 1000 },
                new Empleado { idEmpleado = 2, nombre = "Jorge", sueldo = 800 },
                new Empleado { idEmpleado = 3, nombre = "Carmen", sueldo = 1500 },
                new Empleado { idEmpleado = 4, nombre = "Aurora", sueldo = 1200}
            };

            var consulta = from empleado in empleados
                           where empleado.sueldo >= 1100
                           select empleado;

            foreach (var item in consulta)
            {
                Console.WriteLine("El empleado con nombre " + item.nombre + " tiene un sueldo de " + item.sueldo);
            }

            Console.ReadLine();
        }
    }
}
