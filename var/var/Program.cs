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
        static void Main(string[] args)
        {
            var i0 = 22;
            var d0 = 5.55;

            //i0 = d0;

            int i1 = 22;
            double d1 = 22.2;

            var s = new S();
            s.a = 2;
            s.b = .2;

            Console.ReadKey();
        }
    }
}
