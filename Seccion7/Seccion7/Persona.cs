using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    public class Persona
    {
        // Atributos

        public string nombre { get; set; }
        public string segundoNombre { get; set; }
        public string apellidoPat { get; set; }
        public string apellidoMat { get; set; }
        public int edad { get; set; }
        

        // Constructores

        public Persona()
        {

        }
        public Persona(string nombre, string segundoNombre, string apellidoPat, string apellidoMat, int edad)
        {
            this.nombre = nombre;
            this.segundoNombre = segundoNombre;
            this.apellidoPat = apellidoPat;
            this.apellidoMat = apellidoMat;
            this.edad = edad;
        }

        // Getters y Setters

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getSegundoNombre()
        {
            return segundoNombre;
        }

        public void setSegundoNombre(string segundoNombre)
        {
            this.segundoNombre = segundoNombre;
        }

        public string getApellidoPat()
        {
            return apellidoPat;
        }

        public void setApellidoPat(string apellidoPat)
        {
            this.apellidoPat = apellidoPat;
        }

        public string getApellidoMat()
        {
            return apellidoMat;
        }

        public void setApellidoMat(string apellidoMat)
        {
            this.apellidoMat = apellidoMat;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            if (edad > 0)
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 0;
            }
        }

        // Metodos
        
        public string nombreCompleto()
        {
            return nombre + " " + segundoNombre + " " + apellidoPat + " " + apellidoMat;
        }

        public static string saludo(string nombre)
        {
            return "Hola, como estas, " + nombre + "?";
        }
    }
}
