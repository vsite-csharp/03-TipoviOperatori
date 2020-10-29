using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            dynamic s = new S();

            s.a = 10;
            s.b = 3.14;

            Console.WriteLine(s.a);
            Console.WriteLine(s.b);
            s.c = 23;
            Console.WriteLine(s.c);
            Console.ReadKey();
        }
    }
}
