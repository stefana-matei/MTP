using System;
using System.Collections.Generic;
using System.Text;

/*
 * 9. Să se scrie un program care citește un număr întreg n și afișează toate numerele între 0
și n pe linii diferite.
 */
namespace Tema1___MTP
{
    class Exercitiu9
    {
        static void Main(string[] args)
        {
            Console.Write("Se citeste un numar n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
