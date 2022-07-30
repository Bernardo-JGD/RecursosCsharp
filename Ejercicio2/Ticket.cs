using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ticket
    {

        private int tipo;
        private string color;
        private string tamano;
        private int cantidad;

        public int getTipo()
        {
            return tipo;
        }

        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getTamano()
        {
            return tamano;
        }

        public void setTamano(string tamano)
        {
            this.tamano = tamano;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public Ticket(int tipo, string color, string tamano, int cantidad)
        {
            this.tipo = tipo;
            this.color = color;
            this.tamano = tamano;
            this.cantidad = cantidad;
        }

        public int precio()
        {
            switch (tipo)
            {
                case 1:
                    return (cantidad * 5);
                    break;

                case 2:
                    return (cantidad*8);
                    break;

                case 3:
                    return (cantidad * 10);
                    break;

                default:
                    Console.WriteLine("Error, tipo inexistente, modificar tipo");
                    return -1;
                    break;
            }
        }

        public void mostrar()
        {
            Console.WriteLine("Tipo ---> " + this.tipo);
            Console.WriteLine("Color ---> " + this.color);
            Console.WriteLine("Tamaño ---> " + this.tamano);
            Console.WriteLine("Cantidad ---> " + this.cantidad);
            Console.WriteLine("Total ---> $ " + precio());
        }

    }
}
