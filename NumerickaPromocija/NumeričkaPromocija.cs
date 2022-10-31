using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // TODO:040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int x = 4;
            int y = 2;
            
            // TODO:041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int max = int.MaxValue;
            long jedan = 1;
            Console.WriteLine(max + jedan);
            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double broj1 = 12.32;
            int broj2 = 12;
            Console.WriteLine(broj1 + broj2);
            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal broj3 = 3.14M;
            double broj4 = 2.16;
            Console.WriteLine(broj3 + (decimal)broj4);
            Console.ReadKey();
        }
    }
}
