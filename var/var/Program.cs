﻿using System;

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
            var i0 = 10;

            var d0 = 3.14;
            i0 = (int)d0;

            int i1 = 10;
            double d1 = 3.14;

            var s = new S();
            s.a = 10;
            s.b = 2.4;
            Console.WriteLine(s.a);
            Console.WriteLine(s.b);

            Console.ReadKey();
        }
    }
}
