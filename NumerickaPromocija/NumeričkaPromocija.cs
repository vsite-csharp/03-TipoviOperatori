using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 31;
            int b = 2;

            Console.WriteLine("{0} / {1} = {2} to je tip {3}", a, b, (a / b), (a/b).GetType()); // 15, System.Int32

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine("\n");
            Console.WriteLine("{0} / {1} = {2}", a, b, ((double)a / b)); // 15.5

            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            Console.WriteLine("\n");
            int intMax = int.MaxValue;
            long varLong = 1;

            Console.WriteLine("intMax = {0} \nvarLong = {1} \nrezultat zborja = {2} ", intMax, varLong,
                intMax + varLong); // intMax = 2147483647, varLong = 1, zbroj = 2147483648

            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            Console.WriteLine("\n");
            double dValue = 32.4;
            int iValue = 4;

            Console.WriteLine("dValue = {0} \niValue = {1} \nrezultat zborja = {2} \n{3}", dValue, iValue,
                dValue + iValue, (dValue + iValue).GetType()); // zbroj = 26.4, System.Double

            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            Console.WriteLine("\n");
            decimal decVal = 32.4M;

            //Console.WriteLine("decVal = {0} \ndValue = {1} \nrezultat zborja = {2} \n{3}", decVal, dValue, decVal + dValue, (decVal + dValue).GetType()); // ne mogu se zbrojiti

            Console.ReadKey();
        }
    }
}
