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
            // TODO:032 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int mali = int.MinValue;
            Console.WriteLine(++mali);

            // TODO:033 Ispisati granične vrijednosti za tip double.
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MaxValue);

            //Console.WriteLine(mali / 0);
            double a = 3.0;
            Console.WriteLine(a / 0);


            a = 0.0;
            Console.WriteLine(a / 0);
            double b = 5.0;
            int c = (int)b;

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            double d =(double) decimal.MaxValue;
            double f1 = 1.23456789e23F;
            double f2 = 1.23456788e23F;
            Console.WriteLine(f1 - f2);
            Console.ReadKey();
        }
    }
}
