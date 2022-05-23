using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    public class Empleado:Persona
    {
        // Atributos

        public double sueldo { get; set; }
        public DateTime fechaContrato { get; set; }

        // Constructores

        public Empleado()
        {

        }

        public Empleado(double sueldo, DateTime fechaContrato)
        {
            this.sueldo = sueldo;
            this.fechaContrato = fechaContrato;
        }

        // Getters y setters

        public double getSueldo()
        {
            return sueldo;
        }

        public void setSueldo(double sueldo)
        {
            if (sueldo >= 0)
            {
                this.sueldo = sueldo;
            }
            else
            {
                this.sueldo = 0;
            }

        }

        public DateTime getFechaContrato()
        {
            return fechaContrato;
        }

        public void setFechaContrato(DateTime fechaContrato)
        {
            this.fechaContrato = fechaContrato;
        }

        // Metodos

        public double calcularSueldoAnual()
        {
            return sueldo * 12;
        }
    }
}
