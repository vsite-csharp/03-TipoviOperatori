using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            int max_br = int.MaxValue;
            Console.WriteLine(++max_br);
            int min_br = int.MinValue;
            Console.WriteLine(--min_br);

           
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            double x = 0.0;
            Console.WriteLine(x / 0);

            double y = 5;

            int t_one = (int)y;
            Console.WriteLine(t_one);

            decimal dec1 = decimal.MaxValue;
            decimal dec2 = decimal.MinValue;
            Console.WriteLine(dec1);
            Console.WriteLine(dec2);

            double d = (double)decimal.MaxValue;

            double f1 = 1.23456789e23;
            double f2 = 1.23456788e23;

            Console.WriteLine(f1 - f2);

            Console.ReadKey();
        }
    }
}
