using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Alumno
    {

        private string nombre;
        private float[] notas = new float[4];

        public Alumno()
        {

        }

        public Alumno(string nombre, float[] notas)
        {
            this.nombre = nombre;
            this.notas = notas;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public float[] getNotas()
        {
            return notas;
        }

        public void setNotas(float[] notas)
        {
            this.notas = notas;
        }

        public void ingresarUnaNota(float nota, int unidad)
        {
            notas[unidad] = nota;
        }

        public void mostrarPromedios()
        {
            float promedio1 = (notas[0] + notas[1]) / 2;
            float promedio2 = (notas[2] + notas[3]) / 2;
            float promedio3 = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;
            Console.WriteLine("Promedio 1: " + promedio1);
            Console.WriteLine("Promedio 2: " + promedio2);
            Console.WriteLine("Promedio 3: " + promedio3);
        }

    }
}
