using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = 1, n2 = 0;

            try
            {
                int resultado = n1 / n2;
            }catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------");

            string convertirFallo = "123a";
            try
            {
                int conversion = Convert.ToInt32(convertirFallo); 
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            int[] desborde = new int[2];
            try
            {
                desborde[0] = 0;
                desborde[1] = 1;
                desborde[2] = 2;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int i = 0;
                Console.WriteLine((1 / i));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

            Console.WriteLine("Continua el programa");

            Console.ReadLine();

        }
    }
}
