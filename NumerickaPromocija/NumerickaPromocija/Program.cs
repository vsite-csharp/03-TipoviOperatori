using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            Console.WriteLine(a / b);
            Console.WriteLine((double)a / b);
            int najveci = int.MaxValue;
            long dugi = 1;
            Console.WriteLine(najveci);
            Console.WriteLine(dugi);
            Console.WriteLine(najveci + dugi);

            double c = 3.14;
            int d = 4;
            Console.WriteLine(c + d);
            decimal dec = 3.14M;
            Console.WriteLine(dec + (decimal)c);
            Console.ReadKey();
        }
    }
}
