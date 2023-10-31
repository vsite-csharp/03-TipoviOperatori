using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 010 Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.

            int a;
            //Console.Write(a);
            // :011 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            int b = 4;
            Console.Write(b);
            // :012 Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.

            string ab;
            //Console.Write(ab);
            // :013 Provjeriti koji su mogući konstruktori za string.

            // :014 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string abdc = "string 1";
            Console.ReadKey();
        }
    }
}
