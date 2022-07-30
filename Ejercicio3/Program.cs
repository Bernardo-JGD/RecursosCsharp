using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static List<Alumno> listaAlumnos = new List<Alumno>();
        Alumno a = new Alumno();
        static int id = 0;
        static void Main(string[] args)
        {
            int opcionSalir = 0;
            int opcionMenu = 0;
            do
            {
                menu();
                opcionMenu = Convert.ToInt32(Console.ReadLine());
                opcionesMenu(opcionMenu);
                if (opcionMenu != 6)
                {
                    menuSalirContinuar();
                    opcionSalir = Convert.ToInt32(Console.ReadLine());
                }
                
            } while (opcionSalir != 2 && opcionMenu != 6);

        }

        static void menuSalirContinuar()
        {
            Console.WriteLine("Seleccione el número de la opción que desee");
            Console.WriteLine("1 ---> Regresar al menú principal");
            Console.WriteLine("2 ---> Salir");
            Console.WriteLine("");
        }

        static void menu()
        {
            Console.WriteLine("Seleccione el número de la opción que desee");
            Console.WriteLine("");
            Console.WriteLine("1 ---> Registrar alumno");
            Console.WriteLine("2 ---> Consultar promedios");
            Console.WriteLine("3 ---> Cambiar nombre");
            Console.WriteLine("4 ---> Cambiar todas las notas");
            Console.WriteLine("5 ---> Cambiar una nota");
            Console.WriteLine("6 ---> Salir");
            Console.WriteLine("");
        }

        static void opcionesMenu(int opcion)
        {
            switch (opcion)
            {
                case 1: registrarAlumno(); break;
                case 2: consultarPromedios(); break;
                case 3: cambiarNombre(); break;
                case 4: cambiarTodasLasNotas(); break;
                case 5: cambiarUnaNota(); break;
                case 6: 
                    Console.WriteLine("Hasta pronto :D!");
                    Console.ReadLine();
                    break;


                default:
                    Console.WriteLine("Opción no valida");
                    break;

            }
        }

        static void registrarAlumno()
        {
            Alumno a = new Alumno();
            Console.WriteLine("Ingrese el nombre del alumno");
            a.setNombre(Console.ReadLine());
            for (int i = 0; i<a.getNotas().Count(); i++)
            {
                Console.WriteLine("Ingrese el valor de la nota " + (i+1));
                a.ingresarUnaNota(float.Parse(Console.ReadLine()), i);
            }
            listaAlumnos.Add(a);
        }

        static void consultarPromedios()
        {
            Console.WriteLine("Seleccione el id del alumno para consultar sus promedios");
            mostrarListaAlumnos();
            id = Convert.ToInt32(Console.ReadLine());
            listaAlumnos[id].mostrarPromedios();
            Console.WriteLine("");
        }

        static void mostrarListaAlumnos()
        {
            for (int i = 0; i<listaAlumnos.Count; i++)
            {
                Console.WriteLine("id: " + i);
                Console.WriteLine("Nombre: " + listaAlumnos[i].getNombre());
                Console.WriteLine("");
            }
        }

        static void cambiarNombre()
        {
            Console.WriteLine("Seleccione el id del alumno para corregir su nombre");
            mostrarListaAlumnos();
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingres el nombre");
            listaAlumnos[id].setNombre(Console.ReadLine());
            Console.WriteLine("Nombre corregido");
            Console.WriteLine("");
        }

        static void cambiarTodasLasNotas()
        {
            Console.WriteLine("Seleccione el id del alumno para corregir su nombre");
            mostrarListaAlumnos();
            id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el valor de la nota " + (i + 1));
                listaAlumnos[id].ingresarUnaNota(float.Parse(Console.ReadLine()), i);
            }
        }

        static void cambiarUnaNota()
        {
            Console.WriteLine("Seleccione el id del alumno para corregir su nombre");
            mostrarListaAlumnos();
            id = Convert.ToInt32(Console.ReadLine());
            mostrarNotas();
            Console.WriteLine("Ingrese el número de unidad");
            int unidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la nota");
            float nota = float.Parse(Console.ReadLine());
            listaAlumnos[id].ingresarUnaNota(nota, unidad-1);
        }

        static void mostrarNotas()
        {
            for (int i = 0; i<4; i++)
            {
                Console.WriteLine("Unidad" + (i+1) +  " ---> " + listaAlumnos[id].getNotas()[i]);
            }
            Console.WriteLine("");
        }
        
    }
}
