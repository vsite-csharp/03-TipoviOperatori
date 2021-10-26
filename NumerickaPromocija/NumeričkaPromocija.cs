using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            //  Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int dva = 2;
            int pet = 5;
            Console.WriteLine((dva/pet).GetType().FullName);
            //  Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            //  Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int max = int.MaxValue;
            long jed = 1;
            Console.WriteLine(max);
            Console.WriteLine(jed);
            Console.WriteLine(max + jed);
            //  Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d = 25;
            Console.WriteLine(pet + d);
            Console.WriteLine((pet + d).GetType().FullName);
            //  Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec = 25;
            //Console.WriteLine(d + dec);
            //Console.WriteLine((dec + d).GetType().FullName);
            Console.ReadKey();
        }
    }
}
