using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 90;
            int b = 10;
            Console.WriteLine($"Kvocijent dijeljenja dviju int varijabli je tipa: {(a / b).GetType()}");
            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            a = 99;
            Console.WriteLine($"Kvocijent dijeljenja dviju int varijabli s ostatkom je tipa: {(a / b).GetType()}");
            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int maxInt = int.MaxValue;
            long c = 1;
            Console.WriteLine($"int maxInt: {maxInt}");
            Console.WriteLine($"long c: {c}");
            Console.WriteLine($"maxInt + c: {maxInt + c}");
            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double d = 4.4;
            Console.WriteLine($"Zbrajanje int i double variabli je tipa {(maxInt + d).GetType()}");
            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal e = 1.1M;
            // Sljedeca linija javlja grešku: Operator '+' cannot be applied to operands of type 'double' and 'decimal', potreban je cast
            //Console.WriteLine($"Zbroj decimal i double varijabli: {d + e} tipa {(d + e)}");
            Console.WriteLine($"Zbroj decimal i double varijabli nakon castanja: {(decimal) d + e} tipa {((decimal)d + e).GetType()}");
            Console.ReadKey();
        }
    }
}
