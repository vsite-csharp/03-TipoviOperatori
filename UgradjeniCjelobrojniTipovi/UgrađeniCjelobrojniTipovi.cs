using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("int.MaxValue : {0}", int.MaxValue);
            Console.WriteLine("long.MaxValue : {0}", long.MaxValue);

            Console.WriteLine("int.MinValue : {0}", int.MinValue);
            Console.WriteLine("long.MinValue : {0}", long.MinValue);
            int a = 1;
            long dugi = a;
            short kratki = (short)a;
            int b = int.MaxValue;
            Console.WriteLine("b : {0}", b + 1);
            int c = int.MinValue;
            Console.WriteLine("c : {0}", c - 1);

            Console.WriteLine(a / 0);
            Console.ReadKey();
        }
    }
}
