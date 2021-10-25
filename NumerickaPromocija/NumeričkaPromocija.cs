using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int i = 10;
            int j = 2;
            Console.WriteLine("Kvocijent dvije varijable tipa int: " + i / j);

            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            int i1 = 11;
            Console.WriteLine(i1/j);

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int x = int.MaxValue;
            long l = 1;
            Console.WriteLine("vrijednost varijable x: " + x);
            Console.WriteLine("vrijednost varijable l: " + l);
            Console.WriteLine("zbroj varijabla x + l: "+ (x + l));


            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d = 2.4;
            int c = 2;
            Console.WriteLine("zbroj varijabla d + c: " + (d + c));

            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec = 23.4M;
            double dub = 22.1;
            //Console.WriteLine("zbroj varijabla dec i dub: " + (dec + dub));

            Console.ReadKey();
        }
    }
}
