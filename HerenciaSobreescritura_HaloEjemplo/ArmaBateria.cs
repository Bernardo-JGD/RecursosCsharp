using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSobreescritura_HaloEjemplo
{
    internal class ArmaBateria: Arma
    {
        private string razaOrigen;
        //cantidad de disparos necesarios para bajar 1% de bateria
        private int descuentoMunicion;
        private bool descontarUno = false;

        public ArmaBateria(string nombre, string velocidadDisparo, int damage, string razaOrigen, int descuentoMunicion)
        {
            this.nombre = nombre;
            this.municion = 100;
            this.velocidadDisparo = velocidadDisparo;
            this.damage = damage;
            this.razaOrigen = razaOrigen;
            this.descuentoMunicion = descuentoMunicion;
        }

        public void disparar()
        {
            Console.WriteLine("Ingrese la cantidad de disparos");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (calcularDisparos(cantidad)>municion)
            {
                Console.WriteLine("No hay suficiente bateria");
                Console.WriteLine("¿Desea cambiar arma?");
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
                municion = municion - calcularDisparos(cantidad);
                Console.WriteLine("Bateria actual: " + municion);
            }
            
        }

        private int calcularDisparos(int cantidad)
        {
            return (cantidad / 2);
        }

        public override void recargar()
        {
            Console.WriteLine("Ingrese el nombre del arma");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nivel de bateria");
            municion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad de disparo");
            velocidadDisparo = Console.ReadLine();
            Console.WriteLine("Ingrese el daño que provoca el arma");
            damage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la raza de origen");
            razaOrigen = Console.ReadLine();
            Console.WriteLine("Ingres el descuento de disparos requerido");
            descuentoMunicion = Convert.ToInt32(Console.ReadLine());

        }

        /*
         Para descontar la bateria debo recibir la cantida de disparos
         luego puedo iterar, y cada vez que sume la cantidad requerida 
         para el descuento, restar 1 de bateria, y reiniciar contador. 
         Si sobra una fraccion de disparos, guardar y comenzar a iterar a partir 
         de ahí para la proxima ronda de disparos
         */

    }
}
