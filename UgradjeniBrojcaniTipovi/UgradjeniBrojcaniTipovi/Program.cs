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

            //int a = 0;
            //int b = 1 / a;

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MinValue);

            double poz = 1.1;
            double neg = -1.3;
            double nula = 0;
            
            Console.WriteLine(poz / 0);
            Console.WriteLine(neg / 0);
            Console.WriteLine(nula / 0);

            double pet = 5;
            Console.WriteLine(pet);

            unchecked
            {
                int doubleMax = (int)double.MaxValue;
                Console.WriteLine(doubleMax);
            }

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            double d = double.MaxValue;
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
