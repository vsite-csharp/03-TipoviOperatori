using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int var1 = 2;
            int var2 = 3;
            Console.WriteLine((var1 / var2).GetType());

            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.

            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int var3 = int.MaxValue;
            long var4 = 1;
            Console.WriteLine("int.MaxValue = {0}\nlong 1 = {1}\nint.MaxValue + long 1 = {2}", var3, var4, var3 + var4);

            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double var5 = 4;
            int var6 = 5;
            Console.WriteLine((var5 + var6).GetType());

            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal o = 1;
            //Console.WriteLine((o+f).GetType()); //ne može se zbrojiti

            Console.ReadKey();
        }
    }
}
