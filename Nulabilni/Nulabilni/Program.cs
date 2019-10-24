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


            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            // TODO:051 Pridružiti varijabli tipa double nul-referencu. Provjeriti što će se dogoditi.

            // TODO:052 Definirati nulabilnu varijablu korištenjem generičkog tipa Nullable<T>, postaviti vrijednost na nul-referencu i ispisati sadržaj.

            // TODO:053 Postaviti vrijednost gornje varijable na konačnu vrijednost te ispisati sadržaj.


            Console.ReadKey();
        }
    }
}
