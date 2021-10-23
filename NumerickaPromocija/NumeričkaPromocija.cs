using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 5;
            int b = 2;
            Console.WriteLine($"Type of a/b: {(a/b).GetType()}");
            // 041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine($"Type of a/b: {((double)a/b).GetType()}");
            // 042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int c = int.MaxValue;
            long d = 1;
            Console.WriteLine($"int c = {c}");
            Console.WriteLine($"long d = {d}");
            Console.WriteLine($"c + d = {c + d}, result of type {(c + d).GetType()}");
            // 043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double e = 5.5;
            int f = 2;
            Console.WriteLine($"e + f = {e + f}, result of type {(e + f).GetType()}");
            // 044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal g = 5.5M;
            double h = 2.5;
            //Console.WriteLine($"g + h = {g + h}, result of type {(g + h).GetType()}");
            Console.ReadKey();
        }
    }
}
