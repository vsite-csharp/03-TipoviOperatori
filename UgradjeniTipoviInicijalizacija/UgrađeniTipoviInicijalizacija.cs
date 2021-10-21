using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int a = new int();
            // Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int b = new int(4);
            // Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string tekst = new string("NESTO");
            // Provjeriti koji su mogući konstruktori za string.
            string tekst = new string('s', 8);
            // Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string tekst2 = "string 1";
            Console.ReadKey();
        }
    }
}
