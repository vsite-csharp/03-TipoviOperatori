using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int var1 = 2;
            int var2 = 6;

            int quotient = var1 / var2;

            Console.WriteLine($"Kvocijent: {quotient}");
            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            int remains = var1 % var2;

            Console.WriteLine($"Ostatak: {remains}");
            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int intmax = int.MaxValue;
            long longvar = 1;

            Console.WriteLine($"{intmax} + {longvar} = {intmax + longvar}");
            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double doublevar = 6;
            int intvar = 8;

            Console.WriteLine($"{doublevar} + {intvar} = {(doublevar + intvar).GetType()}");
            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal decimalvar = 14.2M;
            double doublevar2 = 2.4;
                // ispisat će zbroj samo ako pretvorimo decimal u double ili obrnuto
            Console.WriteLine($"{decimalvar} + {doublevar2} = {((double)decimalvar + doublevar2).GetType()}"); 
            Console.WriteLine($"{decimalvar} + {doublevar2} = {(decimalvar + (decimal)doublevar2).GetType()}");

            Console.ReadKey();
        }
    }
}
