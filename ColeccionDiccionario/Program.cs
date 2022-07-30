using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionDiccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de un diccionario
            Dictionary<int, string> diccionario = new Dictionary<int, string>();

            //agregamos elementos al diccionario
            diccionario.Add(1, "Lunes");
            diccionario.Add(2, "Martes");
            diccionario.Add(3, "Miercoles");
            diccionario.Add(4, "Jueves");
            diccionario.Add(5, "Viernes");
            //Podemos agregar también de esta forma
            diccionario[6] = "Sabado";
            diccionario[7] = "Domingo";

            Console.WriteLine("Cantidad de elementos del diccionario: " + diccionario.Count);

            //Iterar un diccionario
            //el primer valor funciona como indice
            foreach (string val in diccionario.Values)
            {
                Console.WriteLine(val);
            }

            //Podemos preguntar si hay una llave en el diccionario
            if (diccionario.ContainsKey(8))
            {
                Console.WriteLine("Si tiene la llave 8");
            }
            else
            {
                Console.WriteLine("No contiene la llave 8");
            }

            //Podemos preguntar si hay un valor en el diccionario
            if (diccionario.ContainsValue("Viernes"))
            {
                Console.WriteLine("Si contiene el día viernes");
            }
            else
            {
                Console.WriteLine("No contiene el día viernes");
            }

            //Agregamos un valor pero lo quitaremos con remove
            diccionario.Add(8, "Enero");
            //indicamos la llave del elemento que queremos remover
            diccionario.Remove(8);
            Console.WriteLine("Cantidad de elementos del diccionario: " + diccionario.Count);

            //Podemos recorrer las llaves del diccionario
            foreach (int llave in diccionario.Keys)
            {
                Console.WriteLine(llave);
            }

            //Podemos limpiar el diccionario
            diccionario.Clear();
            Console.WriteLine("Cantidad de elementos del diccionario: " + diccionario.Count);

            Console.ReadLine();

        }
    }
}
