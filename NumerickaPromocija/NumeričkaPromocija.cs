using System;
using System.CodeDom;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {

            int a = 10;
            int b = 3;

            Console.WriteLine(a / b);
            Console.WriteLine((double)a / b);


            int max = int.MaxValue;
            long l = 1;

            Console.WriteLine(max );
            Console.WriteLine(l );
            Console.WriteLine(max + l );


            double a1 = 3.14;
            int b1 = 24;
            Console.WriteLine(a1 + b1);

            decimal d = 3.14M;
            Console.WriteLine(d + (decimal)a1);


            Console.ReadKey();
        }
    }
}
