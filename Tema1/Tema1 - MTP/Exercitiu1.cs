using System;

namespace Tema1___MTP
{
    class Exercitiu1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Citire a trei numere de la tastatura : \n");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("\nb = ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("\nc = ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma celor trei numere anterior citite : {0}", a + b + c);
        }
    }
}