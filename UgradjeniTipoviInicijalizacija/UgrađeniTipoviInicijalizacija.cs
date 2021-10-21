using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int a = new int();
            Console.WriteLine(a);

            // Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int b = new int(4);

            // Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string c = new string();

            // Provjeriti koji su mogući konstruktori za string.
            string c = new string('c',5);
            Console.WriteLine(c);

            // Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string d = "string 1";
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
