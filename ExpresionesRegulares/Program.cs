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
            encontrarJ();

            Console.ReadLine();
        }

        static void encontrarJ()
        {
            string frase = "Mi nombre es Juan y mi n° de tfno es (+34)123-45-67 y mi código postal es 29679";

            string patronJ = "[J]";//Todas las concidencias con J
            string patronNumero = @"\d";//Todas las coincidencias con un número
            string patronNumeros = @"\d{3}";//Todas las coincidencias con un tres números
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
        }
    }
}
