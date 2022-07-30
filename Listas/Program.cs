using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaracion de objetos para llenar agregar a la lista
            //cargando el constructor
            Estudiante e1 = new Estudiante("Panda", 10, 9);
            Estudiante e2 = new Estudiante("Pato", 8, 7);
            Estudiante e3 = new Estudiante("Gato", 10, 7);

            //Declaracion de la lista
            //Cargando la lista desde el inicio con los objetos de estudiantes
            List<Estudiante> listaEstudiantes = new List<Estudiante>
            {
                e1, e2, e3
            };

            //Cargar constructor directamente en la declaracion de la lista
            List<Estudiante> listaEstudiantes2 = new List<Estudiante> 
            { 
                new Estudiante("Rojo", 100, 150),
                new Estudiante("Verde", 50, 10),
                new Estudiante("Azul", 20, 180)
            };

            //Accediendo a los atributos de los objetos almacenados en la lista 1
            //Sacando promedio de las 2 notas del primer objeto de la lista 1
            int promedio = (listaEstudiantes[0].nota1 + listaEstudiantes[0].nota2) / 2;
            Console.WriteLine("Promedio " + listaEstudiantes[0].nombre + ": " + promedio);
            

            //Cuantos elementos tiene la listaEstudiantes
            int numeroElementosLista1 = listaEstudiantes.Count;
            Console.WriteLine("Cantidad elementos lista 1: " + numeroElementosLista1);

            //Puedo insertar un elemento en la posicion que quiera
            listaEstudiantes.Insert(3, new Estudiante("Poyo", 15, 12));

            //Puedo insertar varios elementos en el rango de posicion que yo quiera
            Estudiante es1 = new Estudiante("Castor", 13, 12);
            Estudiante es2 = new Estudiante("Naranja", 80, 14);

            List<Estudiante> agregarLista = new List<Estudiante>() { es1, es2 };
            //los elementos que estaban en esa posicion se van a terminar
            //recorriendo
            listaEstudiantes.InsertRange(0, agregarLista);

            //Puedo añadir una lista a otra lista
            listaEstudiantes.AddRange(listaEstudiantes2);
            Console.WriteLine("Cantidad de elementos lista 1 añadiendo lista 2: " + listaEstudiantes.Count);
            Console.WriteLine("AddRange-----------------------------------");
            //Iterando lista de objetos
            foreach (Estudiante le in listaEstudiantes)
            {
                Console.WriteLine(le.nombre);
            }

            //Puedo buscar un elemento de acuerdo a una condicion
            Estudiante estu = listaEstudiantes.Find(p => p.nombre.Equals("Rojo"));

            if (estu != null)
            {
                Console.WriteLine("Nombre: " + estu.nombre);
            }
            else
            {
                Console.WriteLine("No cotiene el nombre Rojo");
            }

            //Puedo buscar varios elementos de acuerdo a una condicion
            List<Estudiante> estudiantesConP = listaEstudiantes.FindAll(p => p.nombre.StartsWith("P"));
            Console.WriteLine("Estudiantes que empiezan con P");
            foreach (Estudiante e in estudiantesConP)
            {
                Console.WriteLine(e.nombre);
            }
            Console.WriteLine("Remove All -----------------------------------");
            //RemoveAll elimina todos los elementos que cumplen cierta condicion
            //En este caso eliminar todos los objetos cuyo nombre termine con "o"
            listaEstudiantes.RemoveAll(p => p.nombre.EndsWith("o"));
            foreach (Estudiante le in listaEstudiantes)
            {
                Console.WriteLine(le.nombre);
            }

            //Para remover un elemento puedo hacer lo siguiente
            //Identifico el objeto con el método find.
            //Solo eliminará el primero que encuentre
            listaEstudiantes.Remove(listaEstudiantes.Find(p => p.nombre.EndsWith("a")));
            Console.WriteLine("Remove -----------------------------------");
            foreach (Estudiante le in listaEstudiantes)
            {
                Console.WriteLine(le.nombre);
            }

            //Puedo eliminar de acuerdo a la posicion indicada
            listaEstudiantes.RemoveAt(2);
            Console.WriteLine("RemoveAt -----------------------------------");
            foreach (Estudiante le in listaEstudiantes)
            {
                Console.WriteLine(le.nombre);
            }

            //Limpiando la lista de estudiantes 1
            listaEstudiantes.Clear();
            Console.WriteLine("Cantidad de estudiantes lista 1: " + listaEstudiantes.Count);

            //Lista de strings
            List<string> listaNombres = new List<string>();

            //Agregando elementos a la lista con el método Add
            listaNombres.Add("Luis");
            listaNombres.Add("Juan");
            listaNombres.Add("Pedro");

            //Iterando una lista con foreach
            foreach (string n in listaNombres)
            {
                Console.WriteLine(n);
            }

            //-----------------------------------------------------
            Console.ReadLine();
        }
    }
}
