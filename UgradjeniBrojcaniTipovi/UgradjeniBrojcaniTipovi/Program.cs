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
            Console.WriteLine(++a);
            
            int b = int.MinValue;
            Console.WriteLine(--b);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            double number = 3.0;
            Console.WriteLine(a / 0);


            double numberTwo = 0;
            Console.WriteLine(a / 0);

            double n = 5.0;
            int c = (int)n;

            decimal i = decimal.MaxValue;
            Console.WriteLine(i);

            decimal j = decimal.MinValue;
            Console.WriteLine(j);

            n = (double)i;

            double f1 = 1.123456789e23;
            double f2 = 1.123456788e23;
            Console.WriteLine(f1 - f2);
            Console.ReadKey();
        }
    }
}
;