using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona();
            Persona p2 = new Cliente("Poo", "Panda", "Gigante", "1234", 500);
            Persona p3 = new Empleado("Tortuga", "Verde", "Marina", 2000, 5);

        }
    }
}
