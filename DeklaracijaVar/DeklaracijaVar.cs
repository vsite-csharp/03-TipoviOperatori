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
            var i0 = 13;
            
            var d0 = 3.14;

            //i0 = d0;

            int i1 = i0;

            var s=new S();
            //s.a = d0;
            s.a = i0;


            Console.ReadKey();
        }
    }
}
