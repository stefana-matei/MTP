using System;
using System.Collections.Generic;
using System.Text;

/*
 * 14. Se citesc de la tastatură 5 numere întregi. Scrieți un program care găsește toate
subseturile de numere din cele 5 care însumate dau 0.
Exemplu: dacă numere citite sunt: 3, -2, 1, 1, 8 suma numerelor -2,1 și 1 este 0; dacă
numere citite sunt: 3, 1, -7, 35, 22, nu exită subset care să dea suma 0.
 */
namespace Tema1___MTP
{
    class Exercitiu14
    {

        private static void findSubset(int[] v, int sum)
        {
            int[] sub = new int[v.Length];
            int vTemp = 0;

            Console.WriteLine("Subsetul de numere a carui suma sa dea 0 este :  ");
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i, col = 0; j < v.Length; j++, col++)
                {
                    vTemp += v[j];
                    sub[col] = v[j];

                    if(vTemp == sum)
                    {
                        int total = 0;

                        for(int k = 0; k < sub.Length; k++)
                        {
                            total += sub[k];
                            Console.Write(sub[k].ToString() + " ");

                            if(total == sum)
                            {
                                Console.Write("\n");
                                break;
                            }
                        }
                    }

                    if(vTemp > sum)
                    {
                        Array.Clear(sub, 0, sub.Length);
                        vTemp = 0;
                        break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int sum = 0;
            int[] v = new int[5];

            Console.WriteLine("Se vor citi 5 numere intregi.");
            for(int i = 0; i < v.Length; i++)
            {
                Console.Write("\nScrie un numar : ");
                v[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n--------Numerele introduse-------- ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("{0}\n", v[i]);
            }


            findSubset(v, sum);
        }
    }
}
