using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            int veliki = int.MaxValue;
            Console.WriteLine(++veliki);

            int mali = int.MinValue;
            Console.WriteLine(--mali);



            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);


            double a = 3.0;
            Console.WriteLine(a / 0);

            double b = 0.0;
            Console.WriteLine(b / 0);

            double c = 5.8;
            c += 5;

            int asef=1;
            double asef2 = double.MaxValue;

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            a += double.MaxValue;


            float f1 = 1.23456789e23F;
            float f2 = 1.23456789e23F;
            Console.WriteLine(f1 - f2);

            Console.ReadKey();
        }
    }
}
