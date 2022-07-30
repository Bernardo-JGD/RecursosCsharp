using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Repartidor:Empleado
    {
        public string zona { get; set; }

        public override double plus()
        {
            if (edad<35 && zona.Equals("Zona 3"))
            {
                salario = salario + PLUS;
            }
            return salario;
        }

    }
}
