using System;
using System.ComponentModel.Design.Serialization;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            //Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int i1 = 11;
            int i3 = 5;
            var kvocijent = i1 / i3;
            Console.WriteLine(kvocijent);

            // Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            var kvocijent2 = ((double)i1) / i3;
            Console.WriteLine(kvocijent2);
            // Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int i4 = int.MaxValue;
            long l1 = 1;
            Console.WriteLine(i4);
            Console.WriteLine(l1);
            Console.WriteLine(l1 + i4);
            // Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d4 = 3.3d;
            int i5 = 7;
            var d6 = d4 + i5;
            //Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal dec5 = 3.3m;
            double d8 = 7;
            //var d99 = dec5 + d8;
            //Console.WriteLine(dec5 + d8);
            Console.ReadKey();
        }
    }
}
