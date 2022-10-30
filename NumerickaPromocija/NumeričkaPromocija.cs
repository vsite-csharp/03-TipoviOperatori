using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // TODO:040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int y = 3;
            int z = 5;

            // TODO:041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int n = int.MaxValue;
            long l = 1;
            Console.WriteLine(n);
            Console.WriteLine(l);
            Console.WriteLine(n+l);

            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double dub = 5.6;
            int inte = 1;
            Console.WriteLine(dub + inte);

            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal decimalnibroj = 2.1m;
            double dupli = 3.14;
            //Console.WriteLine(decimalnibroj + dupli);
            Console.ReadKey();
        }
    }
}
