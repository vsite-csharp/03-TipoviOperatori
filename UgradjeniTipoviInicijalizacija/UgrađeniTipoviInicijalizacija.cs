using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // TODO:010 Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            var i = new int();
            Console.WriteLine(i);
            // TODO:011 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //var j = new int(4);
            // TODO:012 Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //var s = new string();
            // TODO:013 Provjeriti koji su mogući konstruktori za string.
            var s1 = new string("hello");
            var s2 = new string('a', 10);
            // TODO:014 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            Console.ReadKey();
        }
    }
}
