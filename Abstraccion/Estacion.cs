using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    //La clase abstracta solo es un molde.
    //Debe ser pública.
    //Va a heredar a otras clases
    public abstract class Estacion
    {
        //Los métodos abstractos solo se declaran, no se desarrollan
        public abstract void sensacion();

    }
}
