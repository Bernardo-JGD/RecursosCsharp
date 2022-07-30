using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Empleado:Persona
    {

        private double sueldo;
        private int diasLaborados;

        public Empleado(string nombre, string paterno, string materno, double sueldo, int diasLaborados)
        {
            this.nombre = nombre;
            this.paterno = paterno;
            this.materno = materno;
            this.sueldo = sueldo;
            this.diasLaborados = diasLaborados;
        }

    }
}
