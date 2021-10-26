using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // :040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 15;
            int b = 2;
            var c = a / b;

            // :041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            // :042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int imax = int.MaxValue;
            long l = 1;
            Console.WriteLine(imax + l);

            // :043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d = 2;
            int i = 3;
            var di = i + d;

            // :044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dc = 1.56M;
            //Console.WriteLine(dc + d);

            Console.ReadKey();
        }
    }
}
