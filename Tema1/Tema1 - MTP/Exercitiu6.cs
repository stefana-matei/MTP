using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1___MTP
{
    /*6. Să se scrie un program care citește 5 numere și calculează suma acestora. Dacă unul din
numere este invalid, atunci utilizatorul va trebui să introducă alt număr.
     */
    class Exercitiu6
    {
        static void Main(string[] args)
        {
            int i;
            int[] v = new int[5];
            int sum = 0;
            string str;
            Console.WriteLine("Se vor citi 5 numere de la tastatura :  ");

            for(i = 0;i < v.Length; i++)
            {
                Console.WriteLine("\nScrieti numarul {0} : ", i);
                str = Console.ReadLine();

                bool parseSuccess = Int32.TryParse(str, out v[i]);


                if (!parseSuccess)
                {
                    Console.WriteLine("\nNumar invalid");
                    i--;
                    continue;
                }
                sum += v[i];
            }

            Console.WriteLine("Suma numerelor este : {0}", sum);
            
        }

    }
}
