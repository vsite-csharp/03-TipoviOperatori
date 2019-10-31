using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            // TODO:050  Dodati naredbu kojom se vrijednost nulabilnog tipa double postavlja na null referencu te ispisati nakon toga sadržaj varijable.

            nulabilniDuplić = null;
            double običniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);
            Console.WriteLine(običniDuplić);

            //  običniDuplić = null;
            // TODO:052 Definirati nulabilnu varijablu korištenjem generičkog tipa Nullable<T>, postaviti vrijednost na nul-referencu i ispisati sadržaj.
            Nullable<int> nulabilniInt = null;
            Console.WriteLine(nulabilniInt);
            // TODO:053 Postaviti vrijednost gornje varijable na konačnu vrijednost te ispisati sadržaj.
            nulabilniInt = 314;
            Console.WriteLine(nulabilniInt);

            Console.ReadKey();
        }
    }
}
