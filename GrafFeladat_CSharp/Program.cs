﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);

            Console.WriteLine("Szélességi Bejárás: ");
            graf.SzelessegiBejaras(2);
            Console.WriteLine("Mélységi Bejárás: ");
            graf.MelysegiBejaras(3);
            Console.WriteLine("Összefüggő: ");
            graf.Osszefuggo(4); 
            Console.WriteLine("Feszítőfa: ");
            graf.FeszitoFa(5);
            Console.WriteLine();
            Console.WriteLine(graf);
            Console.ReadLine();
        }
    }
}
