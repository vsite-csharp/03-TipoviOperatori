using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            // Dodati naredbu kojom se vrijednost nulabilnog tipa double postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            // Pridružiti varijabli tipa double nul-referencu. Provjeriti što će se dogoditi.
            //običniDuplić = null;

            // Definirati nulabilnu varijablu korištenjem generičkog tipa Nullable<T>, postaviti vrijednost na nul-referencu i ispisati sadržaj.
            Nullable<int> nulabilniInt = null;
            Console.WriteLine(nulabilniInt);

            // Postaviti vrijednost gornje varijable na konačnu vrijednost te ispisati sadržaj.
            nulabilniInt = 314;
            Console.WriteLine(nulabilniInt);
            Console.ReadKey();
        }
    }
}
