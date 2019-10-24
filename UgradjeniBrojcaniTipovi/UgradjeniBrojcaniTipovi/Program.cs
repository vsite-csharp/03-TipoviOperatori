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
            Console.WriteLine(double.MinValue + " " + double.MaxValue);
            Console.WriteLine(2.0 / 0);
            Console.WriteLine(-2.0 / 0);
            Console.WriteLine(0.0 / 0);
            double val= 5.0;
            int a, b; a = (int)val; b = (int)val;
            Console.WriteLine(decimal.MinValue + " " + decimal.MinValue);
            double dbr = (double)decimal.MaxValue;

            float f1 = 1.23456789e23F;
            float f2 = 1.23456788e23F;
            Console.WriteLine(f1 - f2);

            double d1 = 1.23456789e23;
            double d2 = 1.23456788e23;
            Console.WriteLine(d1 - d2);

            Console.ReadKey();
        }
    }
}
