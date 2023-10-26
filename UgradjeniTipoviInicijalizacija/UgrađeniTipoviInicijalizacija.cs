using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // :010 Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int someInt = new int();
            Console.WriteLine(someInt);
            // :011 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int someInt2 = new int(4);
            // :012 Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string tekst = new string();
            string tekst = new string(string.Empty);
            // :013 Provjeriti koji su mogući konstruktori za string.
            string konstruktor = new string('x', 5);
            // :014 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string noviString = new string("string 1");

            Console.ReadKey();
        }
    }
}
