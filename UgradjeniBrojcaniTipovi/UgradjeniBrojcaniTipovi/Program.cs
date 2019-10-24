using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            int max = int.MaxValue;
            Console.WriteLine(++max);

            int min = int.MinValue;
            Console.WriteLine(--min);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            double a = 2.0;
            Console.WriteLine(a / 0);
            Console.WriteLine((-1*a) / 0);

            a = 0.0;
            Console.WriteLine(a / 0);

            double b = 5.0;

            int x = (int)b, y = (int)b;

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            double d = (double)decimal.MaxValue;

            double f1 = 1.23456789e23;
            double f2 = 1.23456788e23;

            Console.WriteLine(f1 - f2);


            Console.ReadKey();
        }
    }
}
