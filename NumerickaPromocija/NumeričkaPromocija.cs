using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int varijabla1 = 5;
            int varijabla2 = 4;
            Console.WriteLine(varijabla1 / varijabla2);
            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine(varijabla1 / (varijabla1/varijabla2));
            // TODO:042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int varijabla3 = int.MaxValue;
            long varijabla4 = 1;
            Console.WriteLine(varijabla3);
            Console.WriteLine(varijabla4);
            Console.WriteLine(varijabla4 + varijabla3);
            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double varijabla5 = 234;
            Console.WriteLine(varijabla1 + varijabla5);
            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal varijabla6 = 122.331;
            Console.WriteLine(varijabla6 + varijabla5);

            Console.ReadKey();
        }
    }
}
