﻿using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int b = new int();
            // Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int a = new int(4);
            // Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string s = new string();
            // Provjeriti koji su mogući konstruktori za string.
            string s = new string('c', 5);
            // Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string s1 = "string2";
            Console.ReadKey();
        }
    }
}
