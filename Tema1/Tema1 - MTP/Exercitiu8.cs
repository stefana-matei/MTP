using System;
using System.Collections.Generic;
using System.Text;

/*
 * 8. Să se scrie un program care citește n numere de la tastatură și calculează suma acestora
 */
namespace Tema1___MTP
{
    class Exercitiu8
    {
        static void Main(string[] args)
        {
            Console.Write("Se citeste un numar n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] v = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nScrie un numar : ");
                v[i] = Convert.ToInt32(Console.ReadLine());

                sum += v[i];
            }

            Console.WriteLine("\nSuma numerelor este {0}", sum);
        }
    }
}
