using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.

            double a = 2; int b = 4;
            double c = a / b;
            Console.WriteLine(c);

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            

            Console.WriteLine(c);


            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.

            int d = int.MaxValue;
            Console.WriteLine(d);
            long e = 1;
            Console.WriteLine(e);
            Console.WriteLine(d+e);


            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            var f = a + b;
            Console.WriteLine(f.GetType());

            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.

            decimal y = 0.55M;
            var x = (decimal)a + y;
            Console.WriteLine(x.GetType());


            Console.ReadKey();
        }
    }
}
