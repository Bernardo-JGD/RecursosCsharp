using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Comercial oComercial = new Comercial();
            oComercial.nombre = "Miau";
            oComercial.edad = 22;
            oComercial.salario = 4000;
            oComercial.comision = 1000;
            oComercial.plus();

            Console.WriteLine(oComercial.salario);
            oComercial.plus();//si lo llamo de nuevo y se cumple la condicion vuelve a incrementar
            Console.WriteLine(oComercial.salario);

            Console.WriteLine("---------------------");

            Repartidor oRepartidor = new Repartidor();
            oRepartidor.nombre = "Wof";
            oRepartidor.edad = 25;
            oRepartidor.salario = 1000;
            oRepartidor.zona = "Zona 3";
            oRepartidor.plus();
            
            Console.WriteLine(oRepartidor.salario);
            oRepartidor.plus();
            Console.WriteLine(oRepartidor.salario);
            Console.ReadLine();

        }
    }
}
