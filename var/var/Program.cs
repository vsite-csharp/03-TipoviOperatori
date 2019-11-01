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
            //kod naredbi za inicijalizacije varijabli i0 i d0 uz pomoc var je potpuno identican kao i int i1 i double d1

            var s = new S();

            s.a = 12;
            s.b = 3.14;

            Console.ReadKey();
        }
    }
}
