using System;
using System.Collections.Generic;
using System.Text;


/*
 * 12. Să se scrie un program care 
 * citește de la tastatură coeficienții a,b și c a unei ecuații 
 * de gradul 2: ax2+bx+c=0 și calculează rădăcinile ecuației, dacă există.
 */
namespace Tema1___MTP
{
    class Exercitiu12
    {

        public void calculateRoot(double d, int a, int b)
        {
            double x1, x2;

            if (d == 0)
            {
                Console.WriteLine("\nd = 0 => radacinile ecuatiei sunt egale");

                x1 = -b / (2.0 * a);
                x2 = x1;

                Console.WriteLine("x1 = {0} si x2 = {1}\n", x1, x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("\nd este pozitiv => radacinile sunt reale si diferite");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("x1 = {0} si x2 = {1}", x1, x2);
            }
            else
                Console.WriteLine("Radacinile nu sunt reale => nu exista solutie.");
        }


        static void Main(string[] args)
        {

            Exercitiu12 exercitiu12 = new Exercitiu12();

            int a, b, c;
            double delta;

            Console.WriteLine("Se vor citi de la tastatura coeficientii unei ecuatii de gradul 2");

            Console.Write("\na = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nb = ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nc = ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - 4 * a * c;

            exercitiu12.calculateRoot(delta, a, b);
        }
    }
}
