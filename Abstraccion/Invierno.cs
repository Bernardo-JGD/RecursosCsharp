using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Invierno:Estacion
    {
        //Cuando heredo de una clase abstracta, es obligatorio
        //sobreescribir sus métodos
        public override void sensacion()
        {
            Console.WriteLine("Ta haciendo mucho frio :'3");
        }

    }
}
