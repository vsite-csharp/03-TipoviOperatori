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
        
        void ispis(dynamic x)
        {
            Console.WriteLine(x);
        }
    }

    class Program
    {
        static void Main()
        {
            dynamic s=new S();

            s.a = 5;
            s.b = 10.43534;
            s.ispis(s.a);
            s.ispis(s.b);
            s.c = 3;

            Console.ReadKey();
        }
    }
}
