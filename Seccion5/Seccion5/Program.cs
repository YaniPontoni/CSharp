using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 39. Propiedad Lenght, metodo Trim, TrimStart y TrimEnd (string)

            // Lenght

            string nombre = "Jorge";
            string nombre2 = "Pedro";

            Console.Write("La cadena contiene " + nombre.Length + " caracteres");
            Console.WriteLine("");

            // Equals

            if(nombre.Equals(nombre2))
            {
                Console.Write("Las cadenas son iguales");
            } 
            else
            {
                Console.Write("Las cadenas son diferentes");
            }

            // Trim (Elimina los espacios al inicio y al final de la cadena. No tiene en cuenta los espacios en medio de la cadena)

            string apellido = " Gonzalez ";

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sin trim:");
            Console.WriteLine("");
            Console.Write("La cadena contiene " + apellido.Length + " caracteres");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Con trim:");
            Console.WriteLine("");
            Console.Write("La cadena contiene " + apellido.Trim().Length + " caracteres");

            // Trim.Start() elimina los espacios en blanco solo al principio.

            string objeto = " Mesa ";

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Cantidad de caracteres de la cadena: " + objeto.TrimStart().Length);

            // Trim.End() elimina los espacios en blanco solo al final

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Cantidad de caracteres de la cadena: " + objeto.TrimEnd().Length);

            // 40. Propiedad ToLower y ToUpper (string)

            string nombre3 = "Carlos";

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("cadena Carlos pasada a minusculas: " + nombre3.ToLower());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("cadena Carlos pasada a mayusculas: " + nombre3.ToUpper());

            // 41. ToCharArray, ToSubstring, Remove y StartsWith (string)

            // ToCharArray convierte un string en un array de chars

            string frase = "Samira tiene 2 letras A pero este array tiene 5";
            char[] arreglo = frase.ToCharArray();
            int contLetras = 0;

            foreach(char letra in arreglo)
            {
                if (letra.Equals('a'))
                {
                    contLetras++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Cantidad de veces que aparece la letra a en el arreglo: " + contLetras);

            // Substring toma una cantidad determinada de caracteres del string (posicion inicial, cantidad de caracteres a tomar)

            string codigo = "123456";
            string usuario = "carancho";

            string codigoSub = codigo.Substring(1, 3);
            string usuarioSub = usuario.Substring(1, 3);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("La contraseña resultante es: " + codigoSub + usuarioSub);

            // Remove() elimina una cadena completa o parte de ella

            string codigoUsuario = "A2395OLM23";

            string nuevoCodigo = codigoUsuario.Remove(1, 3);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Codigo original: " + codigoUsuario);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Codigo nuevo: " + nuevoCodigo);

            // StartsWith() sirve para saber si un string comienza con un determinado char o cadena (mayormente util en array de strings)

            string[] aves = {"Gallina", "Pato", "Urraca", "Gaviota", "Hornero", "Buitre", "Condor", "Cuervo", "Chorlito", "Tero", "Paloma", "Gorrion" };
            int contAves = 0;

            Console.WriteLine("");
            Console.WriteLine("");

            foreach(string ave in aves)
            {
                if (ave.StartsWith("C"))
                {
                    contAves++;
                }
            }

            Console.Write("La cantidad de aves que comienzan con C dentro del arreglo es de: " + contAves);

            // 42. EndsWith(), Contains() y Split()

            // EndsWith() sirve para saber si un string finaliza con un determinado char o cadena (mayormente util en array de strings)

            string[] felinos = { "Gato", "Tigre", "Pantera", "Leon", "Lince", "Leopardo", "Puma", "Cheeta", "Guepardo" };
            int contFelinos = 0;

            Console.WriteLine("");
            Console.WriteLine("");

            foreach(string felino in felinos)
            {
                if(felino.EndsWith("e"))
                {
                    contFelinos++;
                }
            }

            Console.Write("La cantidad de felinos que terminan con E dentro del arreglo es de: " + contFelinos);

            string apellido2 = "Roman";

            Console.WriteLine("");
            Console.WriteLine("");

            if (apellido2.EndsWith("m"))
            {
                Console.Write("La cadena termina con m");
            } else
            {
                string ultimaLetra = apellido2.Substring(apellido2.Length - 1, 1);
                Console.Write("La cadena no termina con m, termina con " + ultimaLetra);
            }

            // Contains() verifica dentro de la cadena si se encuentra determinado caracter o texto, no importando su ubicacion dentro de la cadena

            string mensaje = "Hola, esto es un mensaje!";

            Console.WriteLine("");
            Console.WriteLine("");

            if (mensaje.Contains("mensaje"))
            {
                Console.Write("La palabra se encuentra dentro de la cadena");
            } else
            {
                Console.Write("La palabra no se encuentra dentro de la cadena");
            }

            // Split() sirve para separar una cadena en varias secciones usando un caracter o texto como delimitador, el resultado se guarda en un
            // array de strings

            string palabra = "Mondongos";

            string[] arreglito = palabra.Split('o');

            Console.WriteLine("");
            Console.WriteLine("");

            foreach (string item in arreglito)
            {
                Console.WriteLine(item);
            }

            // 43. Propiedades de los numeros (short (Int16), int (Int32) y long (Int64))

            // TryParse() sirve para convertir un string a un tipo de dato numerico

            string otroNumero = "15";
            int resultado;

            bool exito = Int32.TryParse(otroNumero, out resultado);

            Console.WriteLine("");

            if (exito == true)
            {
                Console.Write("Es un numero");
            } 
            else
            {
                Console.Write("No es un numero");
            }

            // Equals() sirve para hacer comparaciones entre numeros

            int y = 60;
            int z = 60;

            Console.WriteLine("");
            Console.WriteLine("");

            if (y.Equals(z))
            {
                Console.Write("Son iguales");
            }
            else
            {
                Console.Write("Son diferentes");
            }

            // ToString() convierte un tipo de dato en string

            short a = 10;
            int b = 20;
            long c = 30;

            string cadena1 = a.ToString();
            string cadena2 = b.ToString();
            string cadena3 = c.ToString();

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(cadena1);
            Console.WriteLine(cadena2);
            Console.WriteLine(cadena3);

            // 44. Clase Math

            double precio = 20.6;
            double precio2 = 20.2;
            int v = 2;
            int k = 5;
            int j = 37;
            int abs = -57;

            Console.WriteLine("");

            Console.Write("Math.Floor(20.6): " + Math.Floor(precio));
            Console.WriteLine("");
            Console.Write("Math.Ceiling(20.6): " + Math.Ceiling(precio));
            Console.WriteLine("");
            Console.Write("Math.Round(20.2): " + Math.Round(precio2));
            Console.WriteLine("");
            Console.Write("Math.Round(20.6): " + Math.Round(precio));
            Console.WriteLine("");
            Console.Write("Math.Round(20.6): " + Math.Round(precio));
            Console.WriteLine("");
            Console.Write("Math.Pow(2, 5): " + Math.Pow(v, k));
            Console.WriteLine("");
            Console.Write("Math.Sqrt(37): " + Math.Sqrt(j));
            Console.WriteLine("");
            Console.Write("El numero mayor entre 2 y 5 es: " + Math.Max(v, k));
            Console.WriteLine("");
            Console.Write("El numero menor entre 2 y 5 es: " + Math.Min(v, k));
            Console.WriteLine("");
            Console.Write("El valor absoluto de -57 es: " + Math.Abs(abs));

            // Length, IndexOf, Find y FindAll (array)

            // Length

            Console.WriteLine("");

            int[] numeros = { 4, 8, 178, 19, 56, 7 };
            string[] nombres = { "Mario", "Luigi", "Peach", "Daisy" };

            int cantNumeros = numeros.Length;
            int cantNombres = nombres.Length;

            Console.Write("El arreglo contiene " + cantNumeros + " elementos");
            Console.WriteLine("");
            Console.Write("El arreglo contiene " + cantNombres + " elementos");
            Console.WriteLine("");

            // Find sirve para encontrar el primer valor que cumpla cierta condicion y sea devuelto.

            // Con este metodo busco dentro del array de enteros y me va a devolver el primer elemento que sea mayor a 15

            int mayorA15 = Array.Find(numeros, p => p > 15);
            int[] mayoresA15 = Array.FindAll(numeros, p => p > 15);
            string encuentraNombre = Array.Find(nombres, p => p.Equals("Bowser"));

            if (encuentraNombre == "Bowser")
            {
                Console.WriteLine("El nombre se encuentra dentro del arreglo");
            }
            else
            {
                Console.WriteLine("El nombre no se encuentra dentro del arreglo");
            }

            Console.Write("El primer elemento mayor a 15 dentro del arreglo de enteros es: " + mayorA15);
            Console.WriteLine("");
            
            foreach(int mayor in mayoresA15)
            {
                Console.WriteLine("Mayores a 15: " + mayor);
            }

            int indice = Array.IndexOf(numeros, 178);

            if (indice == -1)
            {
                Console.WriteLine("El elemento no se encuentra dentro del arreglo");
            }
            else
            {
                Console.WriteLine("El elemento se encuentra en la posicion " + indice);
            }

            // FindIndex y FindLast

            // FindLast encuentra el primer elemento de derecha a izquierda que coincida con la condicion de busqueda

            int ultimoMayorA30 = Array.FindLast(numeros, p => p > 30);

            Console.WriteLine("El ultimo elemento mayor a 30 es: " + ultimoMayorA30);

            int indice2 = Array.FindIndex(numeros, p => p > 10);
            int indice3 = Array.FindLastIndex(numeros, p => p > 10);

            Console.WriteLine("El primer valor mayor a 10 dentro del arreglo esta en la posicion " + indice2 + " y su valor es " + numeros[indice2]);
            Console.WriteLine("El ultimo valor mayor a 10 dentro del arreglo esta en la posicion " + indice3 + " y su valor es " + numeros[indice3]);

            // 47. TimeSpan y propiedades

            // TimeSpan sirve para definir un formato horario

            TimeSpan objeto1 = new TimeSpan(4, 10, 29);
            TimeSpan objeto2 = new TimeSpan(5, 15, 10);

            TimeSpan objeto3 = objeto1 + objeto2;
            TimeSpan objeto4 = objeto2 - objeto1;

            TimeSpan objeto5 = new TimeSpan(12, 10, 15, 12, 18);

            TimeSpan objeto6 = objeto2.Add(objeto1);



            Console.WriteLine("");
            Console.WriteLine("Suma de objeto1 y objeto2: " + objeto3);
            Console.WriteLine("Resta de objeto2 y objeto1: " + objeto4);
            Console.WriteLine("Dias del objeto5: " + objeto5.Days);
            Console.WriteLine("Horas del objeto5: " + objeto5.Hours);
            Console.WriteLine("Minutos del objeto5: " + objeto5.Minutes);
            Console.WriteLine("Segundos del objeto5: " + objeto5.Seconds);
            Console.WriteLine("Milisegundos del objeto5: " + objeto5.Milliseconds);
            Console.WriteLine("");
            Console.WriteLine("Dias totales del objeto3: " + objeto3.TotalDays);
            Console.WriteLine("Horas totales del objeto3: " + objeto3.TotalHours);
            Console.WriteLine("Minutos totales del objeto3: " + objeto3.TotalMinutes);
            Console.WriteLine("Segundos totales del objeto3: " + objeto3.TotalSeconds);
            Console.WriteLine("Milisegundos totales del objeto3: " + objeto3.TotalMilliseconds);
            Console.WriteLine("");
            Console.WriteLine("Objeto6: " + objeto6);

            if (objeto4.CompareTo(objeto5) == -1)
            {
                Console.WriteLine("La hora es menor");
            }
            else
            {
                Console.WriteLine("La hora es mayor");
            }

            // Podemos definir dias, horas, minutos, segundos y milisegundos especificos.

            Console.WriteLine("");
            Console.WriteLine(TimeSpan.FromDays(1));
            Console.WriteLine(TimeSpan.FromHours(2));
            Console.WriteLine(TimeSpan.FromMinutes(30));
            Console.WriteLine(TimeSpan.FromSeconds(15));
            Console.WriteLine(TimeSpan.FromMilliseconds(7));

            string horario = "17:30";

            Console.WriteLine(TimeSpan.ParseExact(horario, @"h\:mm", null));

            Console.ReadLine();
        }
    }
}
