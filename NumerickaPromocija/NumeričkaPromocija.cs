using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int var1=4;
            int var2=7;
            int div = var1 / var2;


            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            int mod = var1%var2;
            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int var3 = int.MaxValue;
            long var4 = 1;
            Console.WriteLine(var3);
            Console.WriteLine(var4);
            Console.WriteLine(var3+var4);
            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double var5 = 16546;
            Console.WriteLine(var3+var5);
            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal var6 = 445545464M;
            //Console.WriteLine(var5+var6);
            Console.ReadKey();
        }
    }
}
