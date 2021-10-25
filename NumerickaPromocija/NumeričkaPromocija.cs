using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            //040 Definirati dvije varijable tipa int i provjeriti kojeg tipa je njihov kvocijent.
            int a = 5;
            int b = 10;
            Console.WriteLine("{0}", (a / b).GetType());//Int

            //041 Dijeljitelj i/ili dijeljenik u gornjem izrazu modificirati tako da dijeljenje bude s ostatkom.
            Console.WriteLine("{0}", (float)a / b);//0.5

            //042 Definirati varijablu tipa int s vrijednošću int.MaxValue i jednu varijablu tipa long s vrijednošću 1. Ispisati vrijednosti tih varijabli i njihov zbroj.
            int c = int.MaxValue;
            long d = 1;
            Console.WriteLine("c = {0}", c);// 2147483647
            Console.WriteLine("d = {0}", d);//1
            Console.WriteLine("c + d = {0}", c+d);// 2147483648

            //043 Definirati jednu varijablu tipa double, zbrojiti ju s varijablom tipa int i provjeriti kakvog tipa je taj zbroj.
            double e = 5.5;
            int f = 5;
            Console.WriteLine("e+f = {0}", (e+f).GetType());//System.Double

            //044 Definirati varijablu tipa decimal i ispisati zbroj s varijablom tipa double te provjeriti kakvog tipa je taj zbroj.
            decimal g = 10.00M;
            double h = 5.0;
            //Console.WriteLine("g+h = {0}", (g+h).GetType());//it is not possible

            Console.ReadKey();
        }
    }
}
