using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Estudiante
    {

        public string nombre { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(string nombre, int nota1, int nota2)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

    }
}
