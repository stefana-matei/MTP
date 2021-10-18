using System;
using System.Collections.Generic;
using System.Text;

/*
 * 13. Scrieți un program care în funcție de alegerea utilizatorului acesta poate să citească o
variabilă de tip întreg, una de tip double sau un șir de caractere. Dacă variabila este int sau double,
programul o va incrementa cu 1 și o va afișa, dacă variabila este string, programul va afișa șirul
citit urmat de caracterul *. 
 */

namespace Tema1___MTP
{
    class Exercitiu13
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            string str, optiune;

            do
            {

                Console.WriteLine("---------------Meniu--------------");
                Console.WriteLine("1. Citire variabila de tip intreg.");
                Console.WriteLine("2. Citire variabila de tip double.");
                Console.WriteLine("3. Citire variabila de tip string.");
                Console.WriteLine("exit => Iesire program.");
                Console.WriteLine("----------------------------------");
                Console.Write("\nOptiunea dvs. : ");
                optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":

                        Console.Write("Ati ales sa cititi o valoare de tip intreg : ");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Variabila citita si incrementata : {0}\n", a += 1);
                        
                        break;

                    case "2":

                        Console.Write("Ati ales sa cititi o valoare de tip double : ");

                        b = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Variabila citita si incrementata : {0}\n", b += 1);

                        break;

                    case "3":

                        Console.Write("Ati ales sa cititi o valoare de tip string : ");

                        str = Console.ReadLine();

                        Console.WriteLine("Variabila citita : {0}*\n", str);

                        break;

                    case "exit":

                        Console.WriteLine("Ati iesit din program!");

                        break;

                    default:
                        Console.WriteLine("Varianta aleasa nu exista, mai incercati!\n");
                        break;
                }
            } while (optiune != "exit");
        }
    }
}
