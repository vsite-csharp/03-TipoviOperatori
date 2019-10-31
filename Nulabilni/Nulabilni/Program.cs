using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            //običniDuplić = null; -> CANTTTTT
            // TODO:052 Definirati nulabilnu varijablu korištenjem generičkog tipa Nullable<T>, postaviti vrijednost na nul-referencu i ispisati sadržaj.
            Nullable<int> nulabilniIntInt = null;
            Console.WriteLine(nulabilniIntInt);
            // TODO:053 Postaviti vrijednost gornje varijable na konačnu vrijednost te ispisati sadržaj.
            nulabilniIntInt = 314;
            Console.WriteLine(nulabilniIntInt);

            Console.ReadKey();
        }
    }
}
