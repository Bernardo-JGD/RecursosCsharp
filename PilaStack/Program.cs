using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaStack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declara pila
            Stack pila = new Stack();

            //Agregamos los dias de la semana con nombre y número
            //La pila puede almacenar diferentes tipos de datos
            pila.Push("Lunes");
            pila.Push(2);
            pila.Push("Miercoles");
            pila.Push(4);
            pila.Push("Viernes");
            pila.Push("Sábado");
            pila.Push("Domingo");

            //Numero de elementos de la pila
            Console.WriteLine("Cantidad de elementos de la pila: " + pila.Count);

            //Iterando una pila
            foreach (var elemento in pila)
            {
                Console.WriteLine(elemento);
            }

            /*Imprime en el siguiente orden porque el último que ingresa
             *es el primero que sale.
                Domingo
                Sábado
                Viernes
                4
                Miercoles
                2
                Lunes
             */

            //Eliminar el último elemento agregado
            pila.Pop();
            pila.Pop();
            foreach (var elemento in pila)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine("Cantidad de elementos de la pila: " + pila.Count);

            //Limpiar toda la pila
            pila.Clear();
            Console.WriteLine("Cantidad de elementos de la pila: " + pila.Count);

            //Puedo especificar que tipo de dato quiero que almacene solamente
            Stack<string> pila2 = new Stack<string>();

            pila2.Push("Primavera");
            pila2.Push("Verano");
            pila2.Push("Otoño");
            pila2.Push("Invierno");

            //Puedo copiar los elementos de una pila en un arreglo
            string[] estaciones = new string[7];
            //pila2.CopyTo(pila, indiceApartirParaCopiar);
            pila2.CopyTo(estaciones, 0);//Tiene que coincidir los espacios

            //Iteramos el arreglo recien llenado
            foreach (string estacion in estaciones)
            {
                Console.WriteLine(estacion);
            }//Solo puedo copiar a un array



            Console.ReadLine();

        }
    }
}
