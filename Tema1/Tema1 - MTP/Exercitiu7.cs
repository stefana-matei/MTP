using System;
using System.Collections.Generic;
using System.Text;

/*
 * 7. Se dau 5 numere de la tastatură, să se afișeze numărul cel mai mare.
 */
namespace Tema1___MTP
{
    class Exercitiu7
    {

        static void Main(string[] args)
        {
            
            int[] v = new int[5];

            for(int i = 0;i < v.Length; i++)
            {
                Console.Write("Scrie un numar : ");
                v[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = v[0];

            for(int i = 1;i < v.Length; i++)
            {
                if (v[i] > max)
                    max = v[i];
            }

            Console.WriteLine("\nCel mai mare numar este : {0}", max);
        }
    }
}
