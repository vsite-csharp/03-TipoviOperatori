using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // ++TODO:040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 10;
            int b = 3;
            Console.WriteLine(a / b);
            // ++TODO:041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine((double)a / b);
            // ++TODO:042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int najveci = int.MaxValue;
            long dugi = 1;
            Console.WriteLine(najveci);
            Console.WriteLine(dugi);
            Console.WriteLine(najveci+dugi); // zbroj je long
            // ++TODO:043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double c = 3;
            int d = 4;
            Console.WriteLine(a + d);
            Console.WriteLine(a / d);
            // ++TODO:044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec = 3.14M; //deciMal
            Console.WriteLine(dec + (decimal)c);
            Console.ReadKey();
        }
    }
}
