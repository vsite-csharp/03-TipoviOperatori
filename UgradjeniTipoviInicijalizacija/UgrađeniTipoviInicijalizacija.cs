using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 010 Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int br = new int();
            Console.WriteLine(br);
            // 011 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int br1 = new int(4);
            //Console.WriteLine(br1);
            // 012 Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //String str = new String();

            // 013 Provjeriti koji su mogući konstruktori za string.
            string s = new string('c',5);
            // 014 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            String newStr = "string 1";
            Console.ReadKey();
        }
    }
}
