using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = 5;int y = 10;
            Console.WriteLine(x / y);
            
            double d = 3.14;
            Console.WriteLine(x + d);
            x = (int)(x + d);
            Console.ReadKey();
        }
    }
}
