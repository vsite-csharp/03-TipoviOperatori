using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.

            int first = 5;
            int second = 2;
            Console.WriteLine(first / second); // 2 

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            int first2 = 6;
            int second2 = 5;
            Console.WriteLine(first2 / second2); // 1 

            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.

            int maxInt = int.MaxValue;
            long one = 1;
            Console.WriteLine(maxInt + " " + one + " " + maxInt + one); // 2147483647 1 21474836471


            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.

            double val = 1.2;
            int secVal = 5;
            var variableSum = val + secVal;
            Console.WriteLine(val + secVal + " " + variableSum.GetType());  // 6,2 System.Double


            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            
            decimal d = 125M;
            double e = 35;
            //var sumDecimalDouble = e + d; // it is not possible to calculate


            Console.ReadKey();
        }
    }
}
