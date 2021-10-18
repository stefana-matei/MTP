using System;
using System.Collections.Generic;
using System.Text;

/*
 * 10. Să se scrie un program care afișează în consolă primele 100 de numere din șirul lui
Fibonacci.
 */

namespace Tema1___MTP
{
    class Exercitiu10
    {
        static void Main(string[] args)
        {
            decimal[] v = new decimal[100];

            v[0] = 0;
            v[1] = 1;
            for (int i = 2; i < 100; i++)
            {
                v[i] = v[i - 1] + v[i - 2];
            }

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(" {1} : {0}", v[i], i);
            }
        }
    }
}