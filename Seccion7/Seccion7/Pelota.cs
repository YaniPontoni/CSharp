using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    public class Pelota
    {
        // Atributos

        private string color;
        private double tamanio;
        private int tipo;
        private int cantidadAComprar;

        // Constructores

        public Pelota()
        {

        }

        public Pelota(string color, double tamanio, int tipo, int cantidadAComprar)
        {
            this.color = color;
            this.tamanio = tamanio;
            this.tipo = tipo;
            this.cantidadAComprar = cantidadAComprar;
        }

        // Getters y setters

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public double getTamanio()
        {
            return tamanio;
        }

        public void setTamanio(double tamanio)
        {
            this.tamanio = tamanio;
        }

        public int getTipo()
        {
            return tipo;
        }

        public void setTipo(int tipo)
        {

            if (tipo > 0 && tipo < 4)
            {
                this.tipo = tipo;
            }
            else
            {
                this.tipo = 1;
            }
        }

        public int getCantidadAComprar()
        {
            return cantidadAComprar;
        }

        public void setCantidadAComprar(int cantidadAComprar)
        {
            if (cantidadAComprar > 0)
            {
                this.cantidadAComprar = cantidadAComprar;
            }
            else
            {
                this.cantidadAComprar = 1;
            }
        }

        // Metodos

        public double totalAPagar(int tipo, int cantidadAComprar)
        {
            double total = 0;

            if (tipo == 1)
            {
                total = cantidadAComprar * 5.00;
            }

            if (tipo == 2)
            {
                total = cantidadAComprar * 8.00;
            }

            if (tipo == 3)
            {
                total = cantidadAComprar * 10.00;
            }

            return total;
        }


    }
}
