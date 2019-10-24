using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int i = int.MaxValue;
            Console.WriteLine(++i);
            int j = int.MinValue;
            Console.WriteLine(--j);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            
            Console.WriteLine(3.0 / 0);
            Console.WriteLine(-3.0 / 0);
            Console.WriteLine(0.0 / 0);
            double b = 5.0;
            int c = (int)b;
            decimal d1 = decimal.MaxValue;
            Console.WriteLine(d1);
            decimal d2 = decimal.MinValue;
            Console.WriteLine(d2);

            double dd1 = (double)decimal.MaxValue;

            double f1 = 1.23456789e23;
            double f2 = 1.23456788e23;

            Console.WriteLine(f1-f2);


            Console.ReadKey();
        }
    }
}
