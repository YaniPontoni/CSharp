using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ManejoDeArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manejo de archivos

            // Las rutas se especifican por medio de strings, se coloca un @ al inicio para que no generen error las barras invertidas

            // string ruta = @"C:\Users\Yani\Desktop\ClaseArchivo\Estudiantes";
            string ruta2 = @"C:\Users\Yani\Desktop\ClaseArchivo\Profesores";
            string ruta3 = @"C:\Users\Yani\Desktop\ClaseArchivo\Materias";
            string ruta4 = @"C:\Users\Yani\Desktop\ClaseArchivo\CSharp.txt";
            string ruta5 = @"C:\Users\Yani\Desktop\ClaseArchivo";

            // Con CreateDirectory(path) creo una carpeta en el directorio elegido

            // Directory.CreateDirectory(ruta);

            // Con Delete(path) elimino una carpeta en el directorio elegido, si la carpeta contiene archivos saldra una excepcion
            // que no me permitira eliminarla. Para eliminar una carpeta con contenido, tengo que agregar un segundo parametro en true

            // Directory.Delete(ruta);

            // Para enumerar los subdirectorios de una carpeta se usa Directory.EnumerateDirectories(path), se lo debo asignar a una variable
            // de tipo List (tengo que agregar los using de System.Collections.Generic para la List y System.Linq para para poder usar el 
            // metodo ToList). Agregando un segundo parametro de tipo string puedo filtrar subdirectorios usando comodines para simplificar
            // la busqueda.

            List<string> lista = Directory.EnumerateDirectories(ruta2, "C*").ToList();

            foreach (string elemento in lista)
            {
                Console.WriteLine(elemento);
            }

            if (lista.Contains("C*") == false)
            {
                Console.WriteLine("No hay directorios con ese criterio");
            }

            // Para enumerar los archivos de un directorio se usa Directory.EnumerateFiles(path), tambien lo debo asignar a una variable
            // de tipo List. Cuando quiero hacer un filtrado usando el segundo parametro tengo que tener en cuenta que la extension del
            // archivo tambien cuenta como parte del string.

            Directory.CreateDirectory(ruta3);

            List<string> lista2 = Directory.EnumerateFiles(ruta3).ToList();

            foreach (string elemento in lista2)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("Cantidad de archivos filtrados: " + lista2.Count());

            // Con la clase DirectoryInfo puedo recuperar informacion de un directorio.

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Yani\Desktop\ClaseArchivo");
            DirectoryInfo dir2 = new DirectoryInfo(@"C:\Users\Yani\Desktop\ClaseArchivo\Notas");

            // Con el metodo Exists puedo comprobar si un directorio existe o no.

            if (dir.Exists)
            {
                Console.WriteLine("El directorio existe");
            }
            else
            {
                Console.WriteLine("El directorio no existe");
            }

            // Con el metodo Parent puedo saber cual es el directorio padre del string que le pasamos por parametro

            Console.WriteLine("Directorio padre de: " + dir + " es: " + dir.Parent);

            // Con el metodo Root puedo saber en que unidad del sistema se encuentra el directorio.

            Console.WriteLine("Unidad en la que se encuentra el directorio: " + dir.Root);

            // Con el metodo Create puedo crear un directorio

            dir2.Create();

            // Con el metodo Delete puedo borrar un directorio que este vacio (en el caso que contenga archivos, necesito poner true
            // como parametro del metodo).

            dir2.Delete(true);

            // Uso de la clase File

            // Para crear un archivo usamos el metodo Create de la clase File pasandole como parametro la ruta que es un string

            // File.Create(ruta4);

            // Puedo agregar lineas de texto al archivo con el metodo AppendAllLines, que tengo que pasarle la ruta del archivo y para
            // el segundo parametro le tengo que pasar un enumurable como una lista.

            List<string> nombres = new List<string>();

            nombres.Add("Yani");
            nombres.Add("Gisela");
            nombres.Add("Samira");

            File.AppendAllLines(ruta4, nombres);

            // Puedo usar el metodo AppendAllText para agregar un string con texto

            string texto = "\n\nHola, esto es un texto que voy a agregar al archivo CSharp.txt.";

            File.AppendAllText(ruta4, texto);

            // Para listar tanto directorios como archivos al mismo tiempo se usa el metodo EnumerateFileSystemEntries

            List<string> lista3 = Directory.EnumerateFileSystemEntries(ruta5).ToList();

            foreach (string elemento in lista3)
            {
                Console.WriteLine(elemento);
            }

            // Para obtener el directorio actual se usa GetCurrentDirectory y lo tengo que guardar en una variable de tipo string

            string directorio = Directory.GetCurrentDirectory();

            Console.WriteLine("Directorio actual: " + directorio);

            // Tambien podemos obtener la unidad desde donde se esta ejecutando el directorio anterior

            string unidad = Directory.GetDirectoryRoot(directorio);

            Console.WriteLine("Unidad en la que se encuentra el directorio: " + unidad);

            // Puedo mover un directorio de una ubicacion a otra con Move especificando la ruta donde estan los archivos a mover y 
            // la ruta de destino

            /*string rutaInicio = @"C:\Users\Yani\Desktop\ClaseArchivo";
            string rutaFinal = @"C:\Users\Yani\Desktop\ClaseArchivo2";

            Directory.Move(rutaInicio, rutaFinal);*/

            // Puedo copiar archivos de un directorio a otro con el metodo Copy de la clase File.

            /*string rutaOrigen = @"C:\Users\Yani\Desktop\ClaseArchivo2\CSharp2.txt";
            string rutaDestino = @"C:\Users\Yani\Desktop\ClaseArchivo\CSharp2.txt";

            File.Copy(rutaOrigen, rutaDestino);*/

            // Con File.CreateText puedo crear un archivo y guardandolo en una variable de tipo StreamWriter puedo escribir texto en
            // el archivo mediante el metodo Write (cada vez que se ejecute el archivo es creado nuevamente para agregar el texto
            // que se le asigna)

            string ruta6 = @"C:\Users\Yani\Desktop\ClaseArchivo\Prueba.txt";
            string ruta7 = @"C:\Users\Yani\Desktop\ClaseArchivo2\Prueba.txt";

            using (StreamWriter sw = File.CreateText(ruta6))
            {
                sw.Write("Hola");
                sw.Write(", esto es otra agregacion de texto al archivo de texto.");
            }

            // Con File.Delete puedo borrar un archivo de un directorio especificando la ruta como parametro

            // File.Delete(ruta6);

            // Con File.Encrypt puedo encriptar un archivo para que solo el usuario que lo encriptó pueda visualizar el contenido

            // File.Encrypt(ruta6);

            // Con File.Move puedo mover un archivo desde el origen hasta el destino especificando las rutas como parametros

            // File.Move(ruta6, ruta7);

            // Con File.ReadAllBytes(path) puedo leer la cantidad de bytes de un archivo y almacenarlo en una variable

            string rutaImagen = @"C:\Users\Yani\Desktop\ClaseArchivo\Imagenes\PicrossNP4Proof.jpg";
            string rutaImagenDestino = @"C:\Users\Yani\Desktop\ClaseArchivo2\Img\PicrossNP4Proof.jpg";

            byte[] archivo = File.ReadAllBytes(rutaImagen);

            // Con File.WriteAllBytes(rutaDestino, bytes) puedo escribir esos bytes en otra ubicacion (que seria como copiar el archivo)

            // File.WriteAllBytes(rutaImagenDestino, archivo);

            // Con File.WriteAllText(ruta, contenido) puedo escribir texto en un archivo guardado en una ruta de tipo string y como
            // segundo parametro indicar el contenido que va a ser agregado almacenado en un string.

            string rutaTexto = @"C:\Users\Yani\Desktop\ClaseArchivo\AgregarTexto.txt";
            string rutaTextoDestino = @"C:\Users\Yani\Desktop\ClaseArchivo\contenido.txt";
            string contenido = "Hola, esto es un texto para agregar en el archivo AgregarTexto.txt";

            // File.WriteAllText(rutaTexto, contenido);

            // Con File.ReadAllText puedo leer el contenido de un archivo para guardarlo en una variable de tipo string
            // Puedo combinar estas clases para copiar texto de un archivo a otro

            string contenidoArchivo = File.ReadAllText(rutaTexto);

            // File.WriteAllText(rutaTextoDestino, contenidoArchivo);

            // Con File.ReadAllLines(path) puedo leer todas las lineas de un archivo de texto las cuales tengo que guardarlas
            // en un arreglo de strings

            string[] lineasArchivo = File.ReadAllLines(rutaTextoDestino);

            foreach (string linea in lineasArchivo)
            {
                Console.WriteLine(linea);
            }

            // Con la clase FileInfo puedo determinar toda clase de informacion de los archivos.

            FileInfo file = new FileInfo(rutaTextoDestino);

            Console.WriteLine("Existe el archivo?: " + file.Exists);
            Console.WriteLine("Tamaño del archivo: " + file.Length);
            Console.WriteLine("Directorio padre del archivo: " + file.Directory);
            Console.WriteLine("Nombre del archivo: " + file.Name);
            Console.WriteLine("Ruta completa del directorio del archivo: " + file.DirectoryName);

            Console.ReadLine();


        }
    }
}
