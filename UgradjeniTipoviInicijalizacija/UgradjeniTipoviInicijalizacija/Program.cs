using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog)konstruktora te ispisati vrijednost varijable.
            int a = new int();
            // Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            //int b = new int(4);
            int b = 4;
            // Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string s = new string();
            // Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string s = "pero";
            Console.ReadKey();
        }
    }
}
