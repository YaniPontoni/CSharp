using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    class Cuenta
    {
        // Atributos
        private string titular { get; set; }
        private double cantidad { get; set; }

        // Constructores
        public Cuenta()
        {

        }

        // Getters y setters

        public string getTitular()
        {
            return titular;
        }

        public void setTitular(string titular)
        {
            this.titular = titular;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad = cantidad;
            }
            else
            {
                this.cantidad = 0;
            }
        }

        // Metodos

        public void retirarDinero (double cantidad)
        {
            this.cantidad = this.cantidad - cantidad;
        }

        public void ingresarDinero (double cantidad)
        {
            this.cantidad = this.cantidad + cantidad;
        }

    }
}
