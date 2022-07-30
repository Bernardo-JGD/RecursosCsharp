using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Verano v = new Verano();
            Invierno i = new Invierno();
            v.sensacion();
            i.sensacion();
            Console.ReadLine();

        }
    }
}
