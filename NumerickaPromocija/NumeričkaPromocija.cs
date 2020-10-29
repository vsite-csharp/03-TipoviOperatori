using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 3;
            Console.WriteLine(a / b);

            // TODO:041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine((double)a / b);
            // TODO:042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int najveci = int.MaxValue;
            long dugi = 1;
            Console.WriteLine("{0}, {1}, {2}", najveci, dugi, najveci + dugi);
            // TODO:043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double dupli = 3.14;
            int c = 4;
            Console.WriteLine(dupli + c);
            Console.WriteLine(c / dupli);
            // TODO:044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec = 3.14M;
            Console.WriteLine(dec + (decimal)dupli);
            Console.ReadKey();
        }
    }
}
