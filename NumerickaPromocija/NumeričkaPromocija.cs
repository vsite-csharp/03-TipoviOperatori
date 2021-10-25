using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 1;
            int b = 2;
            Console.WriteLine((a/b).GetType()); // System.Int32

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int c = int.MaxValue;
            long d = 1;
            Console.WriteLine("int.MaxValue = {0}\nlong 1 = {1}\nint.MaxValue + long 1 = {2}", c, d, c+d);

            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double f = 1;
            int g = 1;
            Console.WriteLine((f+g).GetType()); //System.Double

            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal h = 1;
            //Console.WriteLine((h+f).GetType()); //ne može se zbrojiti

            Console.ReadKey();
        }
    }
}
