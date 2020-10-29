using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 5;
            int b = 6;
            Console.WriteLine(a / b);

            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine((double)a / b);

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int najv = int.MaxValue;
            long l = 1;
            Console.WriteLine(najv);
            Console.WriteLine(l);
            Console.WriteLine(najv + l);

            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d = 2.54;
            Console.WriteLine(d + a);

            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal de = 2.94M;
            Console.WriteLine(de + (decimal)d);

            Console.ReadKey();
        }
    }
}
