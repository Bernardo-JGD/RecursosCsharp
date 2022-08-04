using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*Doucmentacion
 * https://docs.microsoft.com/es-mx/dotnet/standard/base-types/regular-expression-language-quick-reference
 * https://docs.microsoft.com/es-mx/dotnet/api/system.text.regularexpressions.regex?view=net-6.0
 */

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //encontrarJ();
            practicaNombres();
            practicaNumeroTelefono();
            practicaNumeroEntero();
            practicaDireccion();
            Console.ReadLine();
        }

        static void encontrarJ()
        {
            string frase = "Mi nombre es Juan y mi n° de tfno es (+52)123-45-67 y mi código postal es 29679";
            string fraseWeb = "";
            string patronJ = "[J]";//Todas las concidencias con J
            string patronNumero = @"\d";//Todas las coincidencias con un número
            string patronNumeros = @"\d{3}";//Todas las coincidencias con un tres números
            string patronO = @"\+34|\+52";//Coincide con una opción o con la otra

            Regex miRegex = new Regex(patronJ);
            MatchCollection coincidencia = miRegex.Matches(frase);
            if (coincidencia.Count>0)
            {
                Console.WriteLine("Se encontró una J");
            }
            else
            {
                Console.WriteLine("No hay J");
            }

            miRegex = new Regex(patronNumero);
            coincidencia = miRegex.Matches(frase);
            if (coincidencia.Count > 0)
            {
                Console.WriteLine("Encontró un número");
            }
            else
            {
                Console.WriteLine("No encontró un número");
            }

            miRegex = new Regex(patronNumeros);
            coincidencia = miRegex.Matches(frase);
            if (coincidencia.Count > 0)
            {
                Console.WriteLine("Encontró un grupo de 3 números");
            }
            else
            {
                Console.WriteLine("No encontró un grupo de 3 números");
            }

            miRegex = new Regex(patronO);
            coincidencia = miRegex.Matches(frase);
            if (coincidencia.Count > 0)
            {
                Console.WriteLine("Hay números de Méxivo");
            }
            else
            {
                Console.WriteLine("No hay números de México");
            }
        }
        
        static void practicaNombres()
        {
            string nombre = "Ana Ma. Elizabeth";
            //Por ahora si permite nombres con puntos pero que no comiencen con puntos
            //Ana Ma. Elizabeth Diaz Baltazar
            Regex expresion = new Regex(@"(^[a-zA-Z]+)([a-zA-Z]+)([^0-9]+)$");//creo que ya jaló así
            if (expresion.IsMatch(nombre))
            {
                MatchCollection matches = Regex.Matches(nombre, @"(^[a-zA-Z]+)([a-zA-Z]+)([^0-9]+)$");
                Console.WriteLine("Si es un nombre");
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Value);
                }
            }
            else
            {
                Console.WriteLine("No es un nombre");
            }
            
        }

        static void practicaNumeroTelefono()
        {
            string nombre = "831-898-2339";
            //Solo permite esta estructura: 831-898-2339
            Regex expresion = new Regex(@"(^[0-9]{3})-([0-9]{3})-([0-9]{4}$)");
            if (expresion.IsMatch(nombre))
            {
                Console.WriteLine("Si es un telefono");
            }
            else
            {
                Console.WriteLine("No es un telefono");
            }

        }

        static void practicaNumeroEntero()
        {
            string nombre = "56";
            //Solo permite numeros de 2 a 4 cifras
            Regex expresion = new Regex(@"[0-9]{2}|[0-9]{3}|[0-9]{4}");
            if (expresion.IsMatch(nombre))
            {
                Console.WriteLine("Si es un numero");
            }
            else
            {
                Console.WriteLine("No es un numero");
            }

        }

        static void practicaDireccion()
        {
            string nombre = "Emiliano Zapata # _304";
            //Hasta ahora permite esto: Emiliano Zapata # _304
            Regex expresion = new Regex(@"[a-zA-Z0-9]+");
            if (expresion.IsMatch(nombre))
            {
                Console.WriteLine("Si es un direccion");
            }
            else
            {
                Console.WriteLine("No es un direccion");
            }

        }

    }
}
