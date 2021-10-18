using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1___MTP
{
    class Exercitiu3
    {
        static void Main(string[] args)
        {
            string numeCompanie, adresaCompanie, websiteCompanie;
            int faxCompanie;
            string numeManager, prenumeManager;
            int telefonManager;

            Console.WriteLine("Introduceti informatii despre companie : ");

            Console.Write("\nNumele companie : ");
            numeCompanie = Console.ReadLine();

            Console.Write("Adresa companiei : ");
            adresaCompanie = Console.ReadLine();

            Console.Write("Fax-ul companiei : ");
            faxCompanie = Convert.ToInt32(Console.ReadLine());

            Console.Write("Website-ul companiei : ");
            websiteCompanie = Console.ReadLine();

            Console.WriteLine("\nAcum, introduceti informatiile despre managerul acestei companii : ");

            Console.Write("Nume manager : ");
            numeManager = Console.ReadLine();

            Console.Write("Prenume manager : ");
            prenumeManager = Console.ReadLine();

            Console.Write("Numarul de telefon al manager-ului : ");
            telefonManager = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nPe baza informatiilor oferite, compania poate fi descrisa astfel : ");

            Console.WriteLine("   Compania {0}, o companie cu rezultate remarcabile si cu perspective de viitor, este situata la adresa {1} , iar modalitatile de contact sunt prin fax {2} sau pe site-ul {3}.", numeCompanie, adresaCompanie, faxCompanie, websiteCompanie);
            Console.WriteLine("   Pentru mai multe detalii, puteti contacta manager-ul {0} {1} la numarul de telefon 0{2}.", numeManager, prenumeManager, telefonManager);
        }

    }
}
