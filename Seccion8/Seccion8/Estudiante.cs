using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion8
{
    public class Estudiante
    {

        public string nombre { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(string nombre, int nota1, int nota2)
        {
            this.nombre = nombre;

            if (nota1 > 0 && nota1 <= 10)
            {
                this.nota1 = nota1;
            }
            else
            {
                this.nota1 = 1;
            }

            if (nota2 > 0 && nota2 <= 10)
            {
                this.nota2 = nota2;
            }
            else
            {
                this.nota2 = 1;
            }
        }


    }
}