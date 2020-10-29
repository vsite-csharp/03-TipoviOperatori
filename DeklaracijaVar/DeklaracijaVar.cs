using System;

namespace Vsite.CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
    }

    class Program
    {
        static void Main()
        {
            var i0 = 5;
            var d0 = 3.14;
            i0 = (int)d0;
            int i1 = i0;
            double d1 = d0;

            var s = new S();
            s.a = 10;
            s.b = 3.14;
            //s.c = 5;
            Console.ReadKey();
        }
    }
}
