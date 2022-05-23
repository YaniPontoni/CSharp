using System;
using System.Collections;
using System.Collections.Generic;

namespace Seccion8
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaracion de listas, se pueden crear listas de cualquier tipo, inclusive de objetos

            // Lista de enteros

            /*

            List<int> numeros = new List<int> { 19, 24, 76, 32 };

            Console.WriteLine(numeros[0]);

            */

            /*

            // Lista de objetos de tipo Estudiante  

            List<Estudiante> listaEstudiantes = new List<Estudiante> { new Estudiante("Yani", 8, 15), new Estudiante("Gisela", 9, 9) };

            // Agrego a la lista con Add y coloco el objeto como si lo fuera a instanciar de forma normal

            listaEstudiantes.Add(new Estudiante("Samira", 10, 10));

            double promedio1 = (listaEstudiantes[0].nota1 + listaEstudiantes[0].nota2) / 2.0;

            // Console.WriteLine("El promedio de la nota de " + listaEstudiantes[0].nombre + " es: " + promedio1);

            // Para recorrer una lista se utiliza el foreach

            Console.WriteLine("Lista de Estudiantes:");
            Console.WriteLine("");

            foreach (Estudiante estudiante in listaEstudiantes)
            {
                Console.WriteLine(estudiante.nombre);
            }

            Console.WriteLine("");

            // Lista de strings

            List<string> listaNombres = new List<string>();

            listaNombres.Add("Charmander");
            listaNombres.Add("Squirtle");
            listaNombres.Add("Bulbasaur");
            listaNombres.Add("Pikachu");

            Console.WriteLine("Lista de strings:");
            Console.WriteLine("");

            // Recorro la lista de strings

            foreach(string nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }

            // Metodo para contar los elementos de una lista

            int elementosListaString = listaNombres.Count;

            Console.WriteLine("");
            Console.WriteLine("La cantidad de elementos dentro de la lista de strings es: " + elementosListaString);

            // Creo una segunda lista de estudiantes

            List<Estudiante> listaEstudiantes2 = new List<Estudiante> { new Estudiante("Marche", 6, 9), new Estudiante("Mewt", 4, 6) };

            // Con el metodo Addrange puedo agregar una lista con otra

            listaEstudiantes.AddRange(listaEstudiantes2);

            // Compruebo contando la cantidad de elementos de la listaEstudiantes

            int elementosEstudiantes = listaEstudiantes.Count;

            Console.WriteLine("La cantidad de elementos dentro de la lista de estudiantes es: " + elementosEstudiantes);

            */

            /*

            // Propiedades y metodos de las listas

            // Puedo crear objetos

            Cliente cliente1 = new Cliente("Yani", "Pontoni", "Castro", 37, "Tandil 1381");
            Cliente cliente2 = new Cliente("Gisela", "Rotatori", "Galeote", 34, "Tandil 1381");
            Cliente cliente3 = new Cliente("Samira", "Pontoni", "Rotatori", 0, "Tandil 1381");
            Cliente cliente4 = new Cliente("Gladys", "Galeote", "Fernandez", 59, "Tandil 1381");
            Cliente cliente5 = new Cliente("Jorge", "Rotatori", "Ianonne", 60, "Tandil 1382");

            // Y meter esos objetos dentro de listas agregando por el nombre del objeto creado

            List<Cliente> listaClientes = new List<Cliente>
            {
                cliente1, cliente2, cliente3, cliente4, cliente5
            };

            // Con el método Add puedo agregar un objeto instanciandolo directamente (el elemento lo agrega al final de la lista)

            listaClientes.Add(new Cliente("Carlos", "Gomez", "Lopez", 70, "Salsipuedes 720"));

            // Recorro la lista con un foreach y voy imprimiendo los valores de los objetos

            Console.WriteLine("Mostrando la lista listaClientes:");
            Console.WriteLine("");

            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.nombre);
            }

            // Creo una segunda lista con dos objetos

            List<Cliente> listaClientes2 = new List<Cliente>
            {
                new Cliente("Saturnino", "Perez", "Gomara", 55, "Catamarca 1588"),
                new Cliente("Cecilia", "Fernandez", "Morcilla", 27, "Rawson 2680"),
            };

            Console.WriteLine("");
            Console.WriteLine("Mostrando la lista listaClientes2:");
            Console.WriteLine("");

            foreach(var cliente in listaClientes2)
            {
                Console.WriteLine(cliente.nombre);
            }

            // Con el metodo AddRange puedo agregar una lista a otra lista

            listaClientes.AddRange(listaClientes2);

            // Recorro la lista listaClientes para verificar

            Console.WriteLine("");
            Console.WriteLine("Mostrando la lista listaClientes con los elementos agregados de la lista listaClientes2:");
            Console.WriteLine("");

            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.nombre);
            }

            // Con el metodo Find puedo encontrar el primer elemento que haga match con lo buscado

            Cliente clienteBuscado = listaClientes2.Find(p => p.nombre.Equals("Felix"));

            // Si encuentro el match, puedo utilizar sus datos para hacer otras cosas (tengo que hacer la verificacion con un if porque puede venir
            // un resultado null

            Console.WriteLine("");
            Console.WriteLine("Cliente buscado: Felix");
            Console.WriteLine("");

            if (clienteBuscado != null)
            {
                Console.WriteLine(clienteBuscado.apellidoPaterno);
            }
            else
            {
                Console.WriteLine("No existe el objeto dentro del sistema");
            }

            // Si existen elementos repetidos dentro del criterio de busqueda, tengo que usar un FindAll para traer todos los registros
            // Importante: lo que me devuelve el FindAll es una lista, entonces tengo que almacenar el resultado dentro de una variable
            // de tipo lista.

            List<Cliente> lista = listaClientes2.FindAll(p => p.nombre.StartsWith("S"));

            Console.WriteLine("");
            Console.WriteLine("Clientes que su nombre comienza con S dentro de listaClientes2:");
            Console.WriteLine("");

            foreach (var match in lista)
            {
                Console.WriteLine(match.nombre);
            }

            // Si quiero agregar un elemento en una posicion determinada dentro de la lista, tengo que usar el metodo Insert(index, elemento)

            listaClientes2.Insert(0, new Cliente("Fernando", "Fernandez", "Fernandin", 27, "Granola 2748"));

            // Verifico que se haya agregado en el indice 0

            Console.WriteLine("");
            Console.WriteLine("listaClientes2 con un nuevo elemento en el indice 0:");
            Console.WriteLine("");

            foreach (Cliente cliente in listaClientes2)
            {
                Console.WriteLine(cliente.nombre + " " + cliente.apellidoPaterno + " " + cliente.apellidoMaterno);
            }

            // Con el metodo InsertRange puedo agregar una lista completa indicando el indice deseado

            listaClientes.InsertRange(0, listaClientes2);

            // Verifico que los dos elementos de la lista se agregaron al principio de listaClientes

            Console.WriteLine("");
            Console.WriteLine("Inserto los elementos de listaClientes2 en la posicion 0 de listaClientes:");
            Console.WriteLine("");

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine(cliente.nombre);
            }

            // El metodo Remove me elimina un objeto de la lista y para poder eliminarlo primero tengo que encontrarlo

            Cliente clienteDireccion = listaClientes.Find(p => p.direccion.EndsWith("2"));

            listaClientes.Remove(clienteDireccion);

            Console.WriteLine("");
            Console.WriteLine("Remuevo el cliente cuya direccion termina con 2 (Jorge):");
            Console.WriteLine("");

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine(cliente.nombre);
            }

            // Con el metodo RemoveAt puedo eliminar un elemento en la posicion deseada

            listaClientes.RemoveAt(3);

            Console.WriteLine("");
            Console.WriteLine("Remuevo el cliente cuya posicion esta en el indice 3:");
            Console.WriteLine("");

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine(cliente.nombre);
            }

            // Con el metodo RemoveAll, puedo eliminar a todos los objetos que hagan match con el criterio de remocion

            listaClientes.RemoveAll(p => p.nombre.EndsWith("o"));

            Console.WriteLine("");
            Console.WriteLine("Remuevo todos los clientes de listaClientes que terminen en o:");
            Console.WriteLine("");

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine(cliente.nombre);
            }

            // Con Count cuento la cantidad de elementos dentro de la lista

            Console.WriteLine("");
            Console.WriteLine("La cantidad de elementos dentro de la lista antes del Clear es de: " + listaClientes.Count);
            Console.WriteLine("");

            // Con Clear, borro todos los elementos de la lista

            listaClientes.Clear();

            // Verificamos con un Count para comprobar que no hay elementos dentro de la lista

            Console.WriteLine("");
            Console.WriteLine("La cantidad de elementos dentro de la lista despues del Clear es de: " + listaClientes.Count);
            Console.WriteLine("");

            */

            /*

            // ArrayList vs List

            // La principal ventaja de utilizar ArrayLists es que puedo agregar items a la lista de diferentes tipos
            // En cambio las Lists me permiten agregar elementos siempre y cuando sean del mismo tipo que definimos previamente

            ArrayList arrayList = new ArrayList();

            arrayList.Add("Samira");
            arrayList.Add("Gisela");
            arrayList.Add("Yani");
            arrayList.Add(50);

            int numero = 0;

            // Con el método Insert puedo colocar un elemento en la lista o arreglo de listas pasando como primer argumento la posicion
            // del indice y luego el elemento del tipo correspondiente

            arrayList.Insert(0, "Jorge");

            // Para recorrer un arrayList necesito usar la palabra reservada var, ya que como un arrayList puede ser multitipo
            // no tiene sentido poner un tipo de dato en particular. Si necesito hacer una coleccion del mismo tipo siempre  es mejor
            // utilizar Listas.

            foreach(var element in arrayList)
            {
                numero++;
                Console.WriteLine("Elemento numero: " + numero + " Contenido: " + element);
            }

            */

            /*

            // Pilas o Stack

            // Si instancio un objeto de la clase Stack, puedo almacenar elementos de cualquier tipo

            Stack pila = new Stack();

            // Si quiero definir una pila para un solo tipo de datos tengo que instanciar de la siguiente manera:
            // Stack<tipoDato> nombreObjeto = new Stack<tipoDato>();
            // Por ejemplo, una pila de strings seria asi: Stack<string> pila = new Stack<string>();

            pila.Push("Lunes");
            pila.Push("Martes");
            pila.Push("Miercoles");
            pila.Push("Jueves");
            pila.Push("Viernes");
            pila.Push("Sabado");
            pila.Push("Domingo");

            int contador = 0;

            foreach (var item in pila)
            {
                contador++;
                Console.WriteLine("Dia " + contador + " --> " + item);
            }

            // Las pilas utilizan el metodo Count para contar elementos dentro de la misma

            Console.WriteLine("La cantidad de elementos dentro de la pila es de: " + pila.Count);

            // Con el metodo CopyTo(array, indice inicial) puedo pasar los elementos de una pila a una matriz unidimensional (vector)

            string[] diasSemana = new string[7];

            pila.CopyTo(diasSemana, 0);

            // Recorro el arreglo diasSemana con un foreach para verificar que se pasaron los elementos de la pila

            foreach(string dia in diasSemana)
            {
                Console.WriteLine(dia);
            }

            // Con el metodo Pop() quito el primer elemento de la pila que fue el último en entrar a ella.

            pila.Pop(); // Elimino el elemento "Domingo"
            pila.Pop(); // Elimino el elemento "Sabado"

            // Verificamos...

            foreach(var item in pila)
            {
                Console.WriteLine(item);
            }

            // Con el método Clear() borro todos los elementos de la pila.

            pila.Clear();

            Console.WriteLine("La cantidad de elementos dentro de la pila es de: " + pila.Count);

            */

            /*

            // Diccionario: es una estructura de datos que permite establecer una clave y un valor para esa clave
            // Asi puedo crear por ejemplo un Diccionario de nombres y edades y tratarlos como una lista.
            // Para instanciar un diccionario usamos la clase Dictionary<tipo1, tipo2> nombreObjeto = new Dictionary<tipo1, tipo2>;

            Dictionary<string, int> edadPersonas = new Dictionary<string, int>();

            edadPersonas.Add("Gonzalo", 58);
            edadPersonas.Add("Carlos", 27);
            edadPersonas.Add("Helena", 50);
            edadPersonas.Add("Norberto", 21);

            // Como el diccionario me permite agregar pares de clave valor, puedo hacerlo en forma manual con diccionario[key] = value

            edadPersonas["Juan"] = 23;
            edadPersonas["Gabriel"] = 70;

            // Con el metodo Count puedo saber la cantidad de elementos dentro del diccionario

            Console.WriteLine("La cantidad de elementos dentro del diccionario es: " + edadPersonas.Count);

            // Con un foreach recorro el diccionario y puedo mostrar los valores con diccionario.Values
            
            foreach(int valores in edadPersonas.Values)
            {
                Console.WriteLine(valores);
            }

            // Con el metodo ContainsKey puedo averiguar si existe una key dentro del diccionario

            if (edadPersonas.ContainsKey("Norberto"))
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("No existe");
            }

            // Con el metodo ContainsValue puedo averiguar si existe un value dentro del diccionario

            if (edadPersonas.ContainsValue(28))
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("No existe");
            }

            // Con el metodo Remove puedo eliminar un elemento por su key

            edadPersonas.Remove("Norberto");

            // Verificamos si esta dentro del diccionario

            foreach(string nombre in edadPersonas.Keys)
            {
                Console.WriteLine(nombre);
            }

            // Con el metodo Clear elimino todos los elementos del diccionario, la key con su respectivo value

            edadPersonas.Clear();

            // Verifico si hay elementos dentro del diccionario

            Console.WriteLine("La cantidad de elementos dentro del diccionario es: " + edadPersonas.Count);

            */

            /*

            // Manejo de excepciones

            // Las excepciones son errores que detienen la ejecucion de nuestro programa por eso es necesario manipular esos errores
            
            // Uno de los errores fatales mas comunes es intentar dividir un numero por 0, que es una operacion no permitida por el sistema

            int numero1 = 9;
            int numero2 = 0;

            try
            {
                Console.WriteLine(numero1 / numero2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Continua la ejecucion del programa");
            }

            // Otro ejemplo de una excepcion es intentar convertir un string de numeros y letras a un tipo entero

            string numero3 = "123p";

            try
            {
                int numeroConvertido = int.Parse(numero3);
                Console.WriteLine("El string convertido a entero es: " + numeroConvertido);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Continua la ejecucion del programa");
            }

            int[] numeros = new int[4];

            int validos = numeros.Length;

            try
            {
                numeros[7] = 20;
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Continua la ejecucion del programa");
            }

            */

            /*

            // Mas metodos de strings

            // Con el metodo indexOf me devuelve el indice donde se encuentra determinado caracter, buscando de izquierda a derecha
            // en caso de no encontrarse devuelve -1.

            string pais = "Argentina";

            Console.WriteLine("La primera letra n en la palabra " + pais + " se encuentra en el indice: " + pais.IndexOf("n"));

            // Se puede agregar un segundo parametro para indicar desde que posicion queremos buscar, si coloco el indice 5
            // va a recorrer desde esa posicion en adelante tratando de encontrar el primer match

            Console.WriteLine("La segunda letra n en la palabra " + pais + " se encuentra en el indice: " + pais.IndexOf("n", 5));

            // Con el metodo LastIndexOf tiene el mismo efecto que IndexOf pero la busqueda se hace de derecha a izquierda

            Console.WriteLine("La segunda letra n en la palabra " + pais + " buscando de derecha a izquierda se encuentra en el indice: " + pais.LastIndexOf("n"));
            Console.WriteLine("La primera letra n en la palabra " + pais + " buscando de derecha a izquierda se encuentra en el indice: " + pais.LastIndexOf("n", 5));

            */

            Console.ReadLine();
        }
    }
}
