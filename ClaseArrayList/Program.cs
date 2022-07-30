using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList cursos = new ArrayList();
            //Agregar elementos a un arraylist
            cursos.Add("Inglés");
            cursos.Add("Matemáticas");
            cursos.Add("Historia");
            cursos.Add(200);
            cursos.Add(true);
            cursos.Add(-25.4);

            //Posicion de un arraylist
            Console.WriteLine("Primer curso: " + cursos[0]);

            //Cantidad de elementos
            Console.WriteLine("Numero de cursos: " + cursos.Count);

            //inserta un nuevo elemento en la posicion indicada
            cursos.Insert(0, "Miautematicas");

            //iterar un arraylist
            //var porque puede tener diferentes tipos de datos almacenados
            foreach (var curso in cursos)
            {
                Console.WriteLine(curso);
            }
            Console.ReadLine();

        }
    }
}
