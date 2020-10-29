using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // ++TODO:010 Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog) konstruktora te ispisati vrijednost varijable.
            int a = new int(); // inicijalizira na 0
            Console.WriteLine(a);
            // ++TODO:011 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int b = new int(4); //nedozvoljena inicijalizacija
            int b = 4;
            // ++TODO:012 Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string s = new string(); // nre moze biti prazan
            // ++TODO:013 Provjeriti koji su mogući konstruktori za string.
            string s = new string('c',10);
            Console.WriteLine(s);
            // ++TODO:014 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string s2 = "Pero";
            Console.ReadKey();
        }
    }
}
