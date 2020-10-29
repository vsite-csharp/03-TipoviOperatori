using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 3;
            Console.WriteLine(a / b);

            Console.WriteLine((double)a / b);

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int najveci = int.MaxValue;
            long dugi = 1;
            Console.WriteLine(najveci);
            Console.WriteLine(dugi);
            Console.WriteLine(najveci + dugi);

            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double a1 = 3.14;
            int b1 = 4;
            Console.WriteLine(a1 + b1);
            Console.WriteLine(a1 / b1);


            //  Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.

            decimal dec = 3.14M;
            Console.WriteLine(dec + (decimal)a1);


            Console.ReadKey();
        }
    }
}
