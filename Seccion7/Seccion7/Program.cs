using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            Persona per1 = new Persona("Malco", "Yani", "Pontoni", "Castro", 37, 50000);

            Console.WriteLine("Nombre completo: " + per1.nombreCompleto());
            Console.WriteLine("Sueldo anual: " + per1.calcularSueldoAnual());

            string saludo = Persona.saludo("Yani");

            Console.WriteLine(saludo);

            Persona per2 = new Persona();

            per2.setNombre("Samira");
            per2.setApellidoPat("Pontoni");
            per2.setApellidoMat("Rotatori");
            per2.setEdad(0);

            Console.WriteLine(per2.getApellidoPat());

            */

            /*

            Usuario user = new Usuario();

            user.nombreUsuario = "YPontoni";
            user.password = "12345678";

            Console.WriteLine("El nombre de usuario es " + user.nombreUsuario + " y su contraseña es " + user.password);

            */

            /*

            // Ejercicio 1 POO

            Cuenta cuenta1 = new Cuenta();

            cuenta1.setTitular("Alberto Fernandez");
            cuenta1.setCantidad(50000);

            cuenta1.retirarDinero(25000);
            cuenta1.ingresarDinero(2500);

            Console.WriteLine("Ejercicio 1 POO:");
            Console.WriteLine("");
            Console.WriteLine("La cuenta de " + cuenta1.getTitular() + " tiene " + cuenta1.getCantidad() + " pesos");
            Console.WriteLine("");

            // Ejercicio 2 POO

            Pelota pelota1 = new Pelota();

            pelota1.setColor("Verde");
            pelota1.setTamanio(2);
            pelota1.setTipo(2);
            pelota1.setCantidadAComprar(3);

            double total = pelota1.totalAPagar(pelota1.getTipo(), pelota1.getCantidadAComprar());

            Console.WriteLine("Ejercicio 2 POO:");
            Console.WriteLine("");
            Console.WriteLine("El total a pagar por " + pelota1.getCantidadAComprar() + " pelotas de tipo " + pelota1.getTipo() + " es " + total);
            Console.WriteLine("");

            // Ejercicio 3 POO

            Alumno alumno1 = new Alumno("Yani", 8, 6.50f, 9, 10);

            float promedio1 = alumno1.calcularPrimerasDosNotas(alumno1.getNota1(), alumno1.getNota2());

            float promedio2 = alumno1.calcularUltimasDosNotas(alumno1.getNota3(), alumno1.getNota4());

            float promedio3 = alumno1.calcularTodasLasNotas(alumno1.getNota1(), alumno1.getNota2(), alumno1.getNota3(), alumno1.getNota4());

            Console.WriteLine("Ejercicio 3 POO:");
            Console.WriteLine("");
            Console.WriteLine("El promedio de las primeras dos notas es: " + promedio1);
            Console.WriteLine("");
            Console.WriteLine("El promedio de las ultimas dos notas es: " + promedio2);
            Console.WriteLine("");
            Console.WriteLine("El promedio de todas las notas es: " + promedio3);
            Console.WriteLine("");

            */

            /*

            Empleado empleado1 = new Empleado();

            empleado1.setNombre("Carlos");
            empleado1.setSegundoNombre("Saul");
            empleado1.setApellidoPat("Menem");
            empleado1.setApellidoMat("Fernandez");
            empleado1.setSueldo(3000);
            empleado1.setFechaContrato(DateTime.Now);

            string nombreCompletoEmpleado1 = empleado1.nombreCompleto();

            Console.WriteLine(nombreCompletoEmpleado1);
            Console.WriteLine("Fecha de contrato: " + empleado1.getFechaContrato() + ". Sueldo: " + empleado1.getSueldo());

            Cliente cliente1 = new Cliente();

            cliente1.setNombre("Charmander");
            cliente1.setSegundoNombre("Charmeleon");
            cliente1.setApellidoMat("Charizard");
            cliente1.setApellidoPat("Megacharizard");
            cliente1.setEdad(30);
            cliente1.setDireccion("ABC");
            cliente1.setFechaNacimiento(DateTime.Now);

            string nombreCompletoCliente1 = cliente1.nombreCompleto();

            Console.WriteLine(nombreCompletoCliente1);
            Console.WriteLine("Edad: " + cliente1.getEdad() + ". Direccion: " + cliente1.getDireccion() + ". Fecha de nacimiento: " + cliente1.getFechaNacimiento());

            */

            /*

            Frutilla frutilla1 = new Frutilla();
            Pera pera1 = new Pera();

            frutilla1.color();
            pera1.color();

            */

            Comercial comercial1 = new Comercial("Felipe", 18, 4000, 1000);

            comercial1.plus();

            Console.WriteLine("El salario total de comercial1 es: " + comercial1.salario);

            Repartidor repartidor1 = new Repartidor("Marcos", 25, 6000, "zona 3");

            repartidor1.plus();

            Console.WriteLine("El salario total de repartidor1 es: " + repartidor1.salario);

            Console.ReadLine();
        }
    }
}
