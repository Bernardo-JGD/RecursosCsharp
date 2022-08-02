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
            string nombre = "Jose Bernardo Guzmán Diaz";
            string nombre2 = "";
            Console.WriteLine(nombre2.Length);
        }
    
    }
}
