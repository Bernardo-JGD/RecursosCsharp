using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSobreescritura_HaloEjemplo
{
    class Arma
    {
        public string nombre;
        public int municion;
        //baja - media - alta
        public string velocidadDisparo;
        public int damage;

        public virtual void recargar()
        {
            Console.WriteLine("Recargando");
        }

        public virtual void disparar()
        {
            Console.WriteLine("Piu piu");
        }

        /*
            Ambas armas pueden disparar hasta agotar la municion
            Las de cartucho pueden recargar
            Las de bateria tienen que cambiar el arma
            Sobre escribir el método de recargar
         */
    }
}
