using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1___MTP
{
    class Exercitiu15
    {
        static void Main(string[] args)
        {
            int[] cazuri = new int[15];

            cazuri[0] = 0;
            cazuri[1] = 1;
            cazuri[2] = 5;
            cazuri[3] = 10;
            cazuri[4] = 12;
            cazuri[5] = 19;
            cazuri[6] = 50;
            cazuri[7] = 98;
            cazuri[8] = 100;
            cazuri[9] = 123;
            cazuri[10] = 277;
            cazuri[11] = 400;
            cazuri[12] = 456;
            cazuri[13] = 780;
            cazuri[14] = 999;

            // cazuri de test
            Console.WriteLine("----Cazuri de test----");
            foreach (int caz in cazuri)
            {
                convertire(caz);
            }


            // functionalitate propriu-zisa
            do
            {
                Console.Write("\n\nScrie un numar intre [0,999] : ");
                convertire(Convert.ToInt32(Console.ReadLine()));

            } while (true);
        }


        static void convertire(int nr)
        {
            if (nr < 0 || nr > 999)
            {
                Console.WriteLine("Numarul nu este cuprins in intervalul de referinta!");
                return;
            }

            int nrOriginal, index = 0;
            int[] valori = new int[3];
            bool areSute, areZeci, areUnitati, suteSingular, zeciSingular;

            string[] dictionary = new string[10];
            string[] dictionaryF = new string[10];

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

            dictionaryF[0] = dictionary[0];
            dictionaryF[1] = "o";
            dictionaryF[2] = "doua";
            dictionaryF[3] = dictionary[3];
            dictionaryF[4] = dictionary[4];
            dictionaryF[5] = dictionary[5];
            dictionaryF[6] = dictionary[6];
            dictionaryF[7] = dictionary[7];
            dictionaryF[8] = dictionary[8];
            dictionaryF[9] = dictionary[9];

            //Console.Write("Scrie un numar : ");
            //nr = Convert.ToInt32(Console.ReadLine());
            nrOriginal = nr;

            while (nr != 0)
            {
                valori[index] = nr % 10;
                nr = nr / 10;
                index++;

            }

            areSute = valori[2] != 0;
            areZeci = valori[1] != 0;
            areUnitati = valori[0] != 0;
            suteSingular = valori[2] == 1;
            zeciSingular = valori[1] == 1;


            Console.Write("{0}: ", nrOriginal);

            // sute
            if (areSute)
            {
                if (suteSingular)
                {
                    Console.Write("{0} suta ", dictionaryF[valori[2]]);
                }
                else
                {
                    Console.Write("{0} sute ", dictionaryF[valori[2]]);
                }

            }

            // zeci
            if (zeciSingular)
            {
                if (areUnitati)
                {
                    Console.Write("{0}sprezece ", dictionary[valori[0]]);
                }
                else
                {
                    Console.Write("zece");
                }
            }
            else
            {

                if (areZeci)
                {
                    Console.Write("{0} zeci ", dictionaryF[valori[1]]);

                    if (areUnitati)
                    {
                        Console.Write("si ");
                    }
                }


                // unitati
                if (areUnitati || (!areSute && !areZeci))
                {
                    Console.Write("{0}", dictionary[valori[0]]);
                }
            }

            Console.WriteLine("");

        }

    }
}
