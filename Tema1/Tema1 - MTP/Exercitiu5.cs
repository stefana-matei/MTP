using System;
using System.Collections.Generic;
using System.Text;


/*5. Să se scrie un program care citește două numere de la tastatură 
 * și afișează numărul mai mare dintre ele. 
 * Pentru rezolvare nu se folosesc bucle for/while sau condiții if.
 */
namespace Tema1___MTP
{
    class Exercitiu5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se vor citi doua numere de la tastatura : ");

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNumarul mai mare dintre {0} si {1} este {2}", a, b, Math.Max(a,b));
        }
    }
}
