using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion8
{
    class Cliente
    {
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }

        public Cliente(string nombre, string apellidoPaterno, string apellidoMaterno, int edad, string direccion)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.edad = edad;
            this.direccion = direccion;
        }


    }
}