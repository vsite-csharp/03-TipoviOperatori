using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            int b=10;
            Console.WriteLine(a / b);
            double c = 12.4;
            Console.WriteLine(a + c);
            a = (int)(a + c);
            Console.ReadKey();
        }
    }
}
