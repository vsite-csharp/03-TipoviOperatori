using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 34;
            int b = 899;
            int k = b % a;
            Console.WriteLine(k);

            double d = 234.6;
            var result = d + k;

            Console.ReadKey();
        }
    }
}
