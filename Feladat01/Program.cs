﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat01
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Feladat

            var szamok = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Adj meg egy szamot");
                string userSzam = Console.ReadLine();

                szamok[i] = int.Parse(userSzam);
            }

            int max = szamok[0];

            foreach (var e in szamok)
            {
                if(e > max)
                {
                    max = e;
                }
            }

            Console.WriteLine("A legnagyobb szám amit megadtál: " + max);

            Console.WriteLine("Kérem adja meg, hogy hány számot szeretne megadni: ");
            String n = Console.ReadLine();

            int darab = int.Parse(n);

            int[] tomb = new int[darab];

            for(int i = 0; i < darab; i++)
            {
                Console.WriteLine("Adj meg egy szamot: ");
                string userSzam = Console.ReadLine();

                tomb[i] = int.Parse(userSzam);
            }

            int max2 = tomb[0];
            int min = tomb[0];

            foreach (var e in tomb)
            {
                if (e > max2)
                {
                    max2 = e;
                }

                if (min > e)
                {
                    min = e;
                }
            }

            Console.WriteLine("A legnagyobb szám amit megadtál: " + max2);

            Console.WriteLine("A legkisebb szám amit megadtál: " + min);

        }
    }
}
