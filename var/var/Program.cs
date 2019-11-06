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
            var i0 = 12;
            var d0 = 3.14;
            
            //i0 = d0;

            int i1 = 12;
            double d1 = 3.14;

            var s = new S();

            s.a = 10;
            s.b = 3.14;


            Console.ReadKey();
        }
    }
}
