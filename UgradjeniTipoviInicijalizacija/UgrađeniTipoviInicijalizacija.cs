using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // OK-TODO:010 Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int a = new int();

            // OK-TODO:011 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int b = new int(4);

            // OK-TODO:012 Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string s = new string();

            // OK-TODO:013 Provjeriti koji su mogući konstruktori za string.
            string s = new string('s', 5); // 5 s-ova

            // OK- TODO:014 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string s1 = "string 1";

            Console.ReadKey();
        }
    }
}
