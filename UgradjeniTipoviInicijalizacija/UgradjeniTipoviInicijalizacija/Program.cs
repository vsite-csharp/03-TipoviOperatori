using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:020 Inicijalizirati varijablu tipa int pozivom podrazumijevanog (praznog)konstruktora te ispisati vrijednost varijable.
            int a = new int();

            // TODO:021 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            int b = new int(4);
            // TODO:022 Inicijalizirati drugu varijablu tipa int pozivom konstruktora koji kao argument prima broj 4. Provjeriti dozvoljava li to prevoditelj.
            int b = 4;

            // TODO:023 Inicijalizirati varijablu tipa string pozivom podrazumijevanog konstruktora.Provjeriti dozvoljava li to prevoditelj.
            //string s=new string()
            // TODO:024 Napisati kod koji inicijalizira novu varijablu tipa string na vrijednost "string 1".
            string s = "pero";
            Console.ReadKey();
        }
    }
}
