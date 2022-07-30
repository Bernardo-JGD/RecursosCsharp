using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {

        static Ticket ticket;

        static void Main(string[] args)
        {
            int salir = 0;
            int opcion1 = 0;
            do
            {

                menu();
                opcion1 = Convert.ToInt32(Console.ReadLine());
                opcionesMenu(opcion1);


                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1 --> Regresar");
                Console.WriteLine("2 --> Salir");
                salir = Convert.ToInt32(Console.ReadLine());
            } while (salir != 2);

        }

        static void menu()
        {
            Console.WriteLine("1 --> Registrar compra");
            Console.WriteLine("2 --> Consultar compra");
            Console.WriteLine("3 --> Modificar compra");
        }

        static void opcionesMenu(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    registrar();
                    Console.WriteLine("\n");
                    break;

                case 2:
                    ticket.mostrar();
                    Console.WriteLine("\n");
                    break;

                case 3:
                    menuModificar();
                    Console.WriteLine("\n");
                    break;

                default:
                    Console.WriteLine("Error, opcion no valida");
                    break;
            }
        }
        static void registrar()
        {
            Console.WriteLine("Ingrese el tipo:");
            Console.WriteLine("1 --> $5.00");
            Console.WriteLine("2 --> $8.00");
            Console.WriteLine("3 --> $10.00");
            int tipo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el color");
            string color = Console.ReadLine();

            Console.WriteLine("Ingrese el tamaño");
            string tama = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            ticket = new Ticket(tipo, color, tama, cantidad);
            ticket.mostrar();
            Console.WriteLine("\n");
        }

        static void menuModificar()
        {
            Console.WriteLine("1 --> Modificar todo");
            Console.WriteLine("2 --> Modificar tipo");
            Console.WriteLine("3 --> Modificar color");
            Console.WriteLine("4 --> Modificar cantidad");
            Console.WriteLine("5 --> Modificar tamaño");
            int opcion = Convert.ToInt32(Console.ReadLine());
            menuModificarOpciones(opcion);
            Console.WriteLine("\n");
        }

        static void menuModificarOpciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    registrar();
                    Console.WriteLine("\n");
                    break;

                case 2:
                    modificarTipo();
                    Console.WriteLine("\n");
                    break;

                case 3:
                    modificarColor();
                    Console.WriteLine("\n");
                    break;

                case 4:
                    modificarCantidad();
                    Console.WriteLine("\n");
                    break;

                case 5:
                    modificarTamano();
                    Console.WriteLine("\n");
                    break;

                default:
                    Console.WriteLine("Error, opcion no valida");
                    Console.WriteLine("\n");
                    break;
            }
        }

        static void modificarTipo()
        {
            Console.WriteLine("Ingrese el tipo:");
            Console.WriteLine("1 --> $5.00");
            Console.WriteLine("2 --> $8.00");
            Console.WriteLine("3 --> $10.00");
            int tipo = Convert.ToInt32(Console.ReadLine());
            ticket.setTipo(tipo);
        }

        static void modificarColor()
        {
            Console.WriteLine("Ingrese el color");
            string color = Console.ReadLine();
            ticket.setColor(color);
        }

        static void modificarCantidad()
        {
            Console.WriteLine("Ingrese la cantidad");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            ticket.setCantidad(cantidad);
        }

        static void modificarTamano()
        {
            Console.WriteLine("Ingrese el tamano");
            string tamano = Console.ReadLine();
            ticket.setTamano(tamano);
        }
    }
}
