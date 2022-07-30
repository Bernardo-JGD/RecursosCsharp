using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cliente:Persona
    {

        private string codigo;
        private double saldo;

        public Cliente(string nombre, string paterno, string materno, string codigo, double saldo)
        {
            this.nombre = nombre;
            this.paterno = paterno;
            this.materno = materno;
            this.codigo = codigo;
            this.saldo = saldo;
        }

    }
}
