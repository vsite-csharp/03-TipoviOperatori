using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int a = new int();
            Console.WriteLine("a = {0}", a);
            Console.WriteLine(a);
            // Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int b = new int(4);
            //Console.WriteLine("b = {0}", b);
            // Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string b = new string();
            //Console.WriteLine(b);
            // TODO:013 Provjeriti koji su mogući konstruktori za string.
            string c = new string('a', 10);
            Console.WriteLine(c);
            // TODO:014 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".

            Console.ReadKey();
        }
    }
}
