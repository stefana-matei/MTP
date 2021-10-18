using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1___MTP
{
    class Exercitiu4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se vor citi doua numere intregi a si b");

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            for (int i = a;i <= b; i++){

                if (i % 10 == 5 || i % 10 == 0)
                    counter++;
            }

            if(counter > 1)
                Console.WriteLine("\nIn intervalul [{0},{1}] sunt {2} numere divizibile cu 5.", a, b, counter);
            else if(counter == 1)
                Console.WriteLine("\nIn intervalul [{0},{1}] este doar {2} numar divizibil cu 5.", a, b, counter);
        }

    }
}
