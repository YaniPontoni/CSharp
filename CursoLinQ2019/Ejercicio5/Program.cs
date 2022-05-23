using System;
using System.Linq;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // por defecto ordena ascendentemente, para ordenar descendentemente
            // tengo que agregar descending a la derecha de la variable

            string[] nombres = { "Jorge", "Aldair", "Pedro", "Luis" };

            var consulta = from nombre in nombres
                           where nombre.StartsWith("P")
                           orderby nombre
                           select nombre;

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
