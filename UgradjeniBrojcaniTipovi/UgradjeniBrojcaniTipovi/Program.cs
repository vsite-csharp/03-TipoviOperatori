using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            int a = int.Parse("12");

            int veliki = int.MaxValue;
            Console.WriteLine(++veliki);
            int mali = int.MinValue;
            Console.WriteLine(--mali);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            double b = 3.0;
            Console.WriteLine(b / 0);
            b = 0.0;
            Console.WriteLine(b / 0);
            double c = 5.0;
            int d = (int)c;
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            double j = (double)decimal.MaxValue;

            float f1 = 1.123456789e23F;
            float f2 = 1.123456788e23F;
            Console.WriteLine(f1 - f2);
            Console.ReadKey();
        }
    }
}
