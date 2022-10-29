using System; 

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 10;
            int b = 3;
            var c = a / b;
            Console.WriteLine(c.GetType());

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int d = int.MaxValue;
            long l = 1;
            Console.WriteLine(d);
            Console.WriteLine(l);
            Console.WriteLine(d + l);

            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double x = 1.0;
            int y = 1;
            var z = x + y;
            Console.WriteLine(z.GetType());

            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal d1 = 3.14M;
            double d2 = 1.0;
            //Console.WriteLine(d1 + d2);

            Console.ReadKey();
        }
    }
}
