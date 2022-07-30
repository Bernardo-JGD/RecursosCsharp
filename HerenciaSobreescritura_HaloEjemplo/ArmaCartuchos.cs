using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSobreescritura_HaloEjemplo
{
    class ArmaCartuchos:Arma
    {
        private string codigoRegistro;
        public ArmaCartuchos(string nombre, int municion, string velocidadDisparo, int damage)
        {
            this.nombre = nombre;
            this.municion = municion;
            this.velocidadDisparo = velocidadDisparo;
            this.damage = damage;
            this.codigoRegistro = crearCodigoRegistro(nombre, municion, velocidadDisparo);
        }

        public string crearCodigoRegistro(string nombre, int municion, string velocidadDisparo)
        {
            string codigo =nombre.Substring(0, 3) + Convert.ToString(municion) + velocidadDisparo.Substring(0, 1);
            return codigo;
        }

        public override void recargar()
        {
            Console.WriteLine("Ingrese la cantida de munición");
            int municion = Convert.ToInt32(Console.ReadLine()) ;
            this.municion = this.municion + municion;
        }

        public override void disparar()
        {
            Console.WriteLine("Ingrese la cantidad de disparos que desea realizar");
            int disparos = Convert.ToInt32(Console.ReadLine());
            if (disparos>municion)
            {
                Console.WriteLine("No hay suficiente munición");
                Console.WriteLine("¿Desea recargar?");
                Console.WriteLine("1 - Si\n2 - No");
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    recargar();
                }
                else
                {
                    Console.WriteLine("Disparo no realizado");
                }
            }
            else
            {
                municion = municion - disparos;
                Console.WriteLine("Munición actual: " + municion);
            }
        }

    }
}
