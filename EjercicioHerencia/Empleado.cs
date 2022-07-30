using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public abstract class Empleado
    {
        public readonly double PLUS = 400;
        public string nombre { get; set; }
        public int edad { get; set; }
        public double salario { get; set; } 
        

        public abstract double plus();

    }
}
