﻿using System;
using System.Xml.Linq;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 010 Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int a = new int();
            Console.WriteLine(a);

            // 011 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int b = new int(4);

            // 012 Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            // string s = new string();

            // 013 Provjeriti koji su mogući konstruktori za string.
            string s = new string('a', 10);
            Console.WriteLine(s);
            // 014 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".

            string s1 = "string 1";
            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }
}
