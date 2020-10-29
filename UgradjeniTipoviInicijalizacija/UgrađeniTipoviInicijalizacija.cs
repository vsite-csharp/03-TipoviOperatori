using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            int a = new int();
            Console.WriteLine(a);
            //int b = new int(4);
            //string s = new string();
            string s = new string('c', 10);
            Console.WriteLine(s);
            string s2 = s;
            Console.ReadKey();
        }
    }
}
