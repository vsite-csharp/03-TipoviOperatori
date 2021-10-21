using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int myInt = new int();
            Console.WriteLine(">>>>>" + myInt);

            // Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int myInt2 = new int(4.);

            //Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string myString = new string();

            // Provjeriti koji su mogući konstruktori za string.
            string myString2 = new string('s', 5);
            // Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string myString3 = "string 1";

            Console.ReadKey();
        }
    }
}
