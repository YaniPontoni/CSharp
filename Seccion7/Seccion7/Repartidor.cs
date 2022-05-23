using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    public class Repartidor:EmpleadoEjercicio
    {

        public string zona { get; set; }

        public Repartidor(string nombre, int edad, double salario, string zona)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
            this.zona = zona;
        }

        public override double plus()
        {
            if (edad < 35 && zona.Equals("zona 3"))
            {
                salario = salario + PLUS;
            }
            return salario;
        }
    }
}
