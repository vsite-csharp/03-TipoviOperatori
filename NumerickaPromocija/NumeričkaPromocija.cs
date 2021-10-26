using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int m = 7, n = 3;
            var z = m / n;
            Console.WriteLine(z is int);
            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int yeah = int.MaxValue;
            long yo = 1;
            Console.WriteLine(String.Format("prvi= {0}\ndrugi= {1}\nzbroj= {2}\nint= {3}", yeah, yo, yeah + yo,yeah+yo is int));
            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double ja = 67.77;
            int ti = 55;
            Console.WriteLine(ja + ti is int);
            // Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal hej = 27.77M;
            double you = 13.333D;
            var the = hej + (decimal)you;
            Console.WriteLine(the is double);

            Console.ReadKey();
        }
    }
}
