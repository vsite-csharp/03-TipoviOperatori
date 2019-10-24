using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int a = int.MaxValue;
            a++;
            int b = int.MinValue;
            b--;
            Console.WriteLine(b);
            Console.WriteLine(a);
            double d = double.MinValue;
            Console.WriteLine(d);
            d = double.MaxValue;
            Console.WriteLine(d);
            Console.WriteLine(d / 0);
            d++;
            Console.WriteLine(d / 0);
            d = 0;
            Console.WriteLine(d / 0);
            double c = 5.0;
            a = (int)c;
            c = double.MaxValue;
            a = (int)c;
            Console.WriteLine(a);
            decimal d1 = decimal.MaxValue;
            decimal d2 = decimal.MinValue;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            d =(double) decimal.MaxValue;
            double f1 = 1.23456789e23;
            double f2 = 1.23456788e23;
            Console.WriteLine(f1-f2);

            Console.ReadKey();
        }
    }
}
