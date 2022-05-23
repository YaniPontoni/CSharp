using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    public class Alumno
    {

        // Atributos

        private string nombre;
        private float nota1;
        private float nota2;
        private float nota3;
        private float nota4;

        // Constructores

        public Alumno()
        {

        }

        public Alumno(string nombre, float nota1, float nota2, float nota3, float nota4)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
        }

        // Getters y setters

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public float getNota1()
        {
            return nota1;
        }

        public void setNota1(float nota1)
        {
            if (nota1 > 0 && nota1 <= 10)
            {
                this.nota1 = nota1;
            } 
            else
            {
                this.nota1 = 0;
            }

        }

        public float getNota2()
        {
            return nota2;
        }

        public void setNota2(float nota2)
        {
            if (nota2 > 0 && nota2 <= 10)
            {
                this.nota2 = nota2;
            }
            else
            {
                this.nota2 = 0;
            }
        }

        public float getNota3()
        {
            return nota3;
        }

        public void setNota3(float nota3)
        {
            if (nota3 > 0 && nota3 <= 10)
            {
                this.nota3 = nota3;
            }
            else
            {
                this.nota3 = 0;
            }
        }

        public float getNota4()
        {
            return nota4;
        }

        public void setNota4(float nota4)
        {
            if (nota4 > 0 && nota4 <= 10)
            {
                this.nota4 = nota4;
            }
            else
            {
                this.nota4 = 0;
            }
        }

        // Metodos

        public float calcularPrimerasDosNotas(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }

        public float calcularUltimasDosNotas(float nota3, float nota4)
        {
            return (nota3 + nota4) / 2;
        }

        public float calcularTodasLasNotas(float nota1, float nota2, float nota3, float nota4)
        {
            return (nota1 + nota2 + nota3 + nota4) / 4;
        }
    }
}
