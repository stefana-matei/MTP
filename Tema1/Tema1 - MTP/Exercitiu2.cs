using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1___MTP
{
    class Exercitiu2
    {
        public const double PI = 3.1415926535897931;

        static void Main(string[] args)
        {
            double r;

            do
            {
                Console.Write("Se va citi raza a unui cerc : ");
                r = Convert.ToDouble(Console.ReadLine());
            } while (r <= 0);
            Console.WriteLine("\nRaza cercului este : {0} \nPerimetrul cercului : {1} \nAria cercului : {2}", r, 2 * PI * r, PI * r * r);
        }
    }
}
