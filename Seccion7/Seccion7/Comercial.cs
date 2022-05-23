using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    public class Comercial:EmpleadoEjercicio
    {

        public double comision { get; set; }

        public Comercial(string nombre, int edad, double salario, double comision)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
            this.comision = comision;
        }

        public override double plus()
        {
            if (edad > 20 && comision > 300)
            {
                salario = salario + PLUS;
            }
            return salario;
        }

    }
}
