using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            int a = int.MaxValue;
            a++;
            Console.WriteLine(a);
           int b = int.MinValue;
            b--;


            double c = 2.3;
            Console.WriteLine(c / 0);
            c = - 2.3;
            Console.WriteLine(c / 0);

            c = 0;
            Console.WriteLine(c / 0);

            //double d = 5;
            //d = double.MaxValue;
            //int e = d;
            //Console.WriteLine(e);
            //d = double.MinValue;
            //e = d;
            //Console.WriteLine(e);


            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            double z = double.MaxValue;
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
