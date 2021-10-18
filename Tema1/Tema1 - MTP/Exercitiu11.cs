using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1___MTP
{
    class Exercitiu11
    {
        static void Main(string[] args)
        {
            string[] dictionary = new string[10];
            int number;

            dictionary[0] = "zero";
            dictionary[1] = "unu";
            dictionary[2] = "doi";
            dictionary[3] = "trei";
            dictionary[4] = "patru";
            dictionary[5] = "cinci";
            dictionary[6] = "sase";
            dictionary[7] = "sapte";
            dictionary[8] = "opt";
            dictionary[9] = "noua";

            do
            {
                number = Convert.ToInt32(Console.ReadLine());

                if(number < 0 || number > 9)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                Console.WriteLine("{0}", dictionary[number]);

            } while (true);
            
        }
    }
}
