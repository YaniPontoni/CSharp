using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    public class Cliente:Persona
    {
        // Atributos

        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }

        // Constructores

        public Cliente()
        {

        }

        public Cliente(string direccion, DateTime fechaNacimiento)
        {
            this.direccion = direccion;
            this.fechaNacimiento = fechaNacimiento;
        }

        // Getters y setters

        public string getDireccion()
        {
            return direccion;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public DateTime getFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void setFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

    }
}
