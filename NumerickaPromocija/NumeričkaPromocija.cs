using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 1;
            int b = 3;
            
            Console.WriteLine((a/b) is int);

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine((1.0 / b) is int);

            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int i = int.MaxValue;
            long l = 1;
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(i+l);

            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d2 = 45;
            Console.WriteLine((d2 + i) is double);
            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec = 23;
            //var zu = dec + d2;
            //Console.WriteLine((dec + d2) is double);
            Console.ReadKey();
        }
    }
}
